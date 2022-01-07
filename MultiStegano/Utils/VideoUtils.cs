using Accord.Video.FFMPEG;
using FFMpegCore;
using MultiStegano.Entities;
using MultiStegano.Library;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiStegano.Utils
{
    class VideoUtils
    {
        public static void EncryptInAudio(String origFile, String outputFile, String message)
        {
            GlobalFFOptions.Configure(options => options.BinaryFolder = "./");
            VideoFileReader reader = new VideoFileReader();
            reader.Open(origFile);
            long framecount = reader.FrameCount;
            double frameRate = reader.FrameRate.Value;
            int bitRate = reader.BitRate;
            FFMpeg.ExtractAudio(origFile, "audio.mp3");
            FileStream fileStream = new FileStream("audio.mp3", FileMode.Open);
            using (var mp3Reader = new Mp3FileReader(fileStream))
            {
                using (var waveWriter = new WaveFileWriter("audio.wav", mp3Reader.WaveFormat))
                {
                    mp3Reader.CopyTo(waveWriter);
                }
            }
            fileStream.Dispose();
            fileStream.Close();
            WavFile wavFile = WavUtils.CreateWavFile("audio.wav");
            WavUtils.WriteFile(wavFile, "audio.wav", "audio1.wav", message);
            if (File.Exists(outputFile))
            {
                File.Delete(outputFile);
            }
            using (var writer = new VideoFileWriter())
            {
                Bitmap frame = reader.ReadVideoFrame();
                writer.Open(outputFile, frame.Width, frame.Height, (int)frameRate, VideoCodec.Default, bitRate * 10);
                for (int i = 0; i < framecount; i++)
                {
                    if (frame == null)
                    {
                        break;
                    }
                    writer.WriteVideoFrame(frame);
                    frame.Dispose();
                    try
                    {
                        frame = reader.ReadVideoFrame();
                    }
                    catch (System.ArgumentException)
                    {
                        continue;
                    }
                }
                writer.Close();
                reader.Close();
            }
            AviManager aviManager = new AviManager(outputFile, true);
            aviManager.AddAudioStream("audio1.wav", 0);
            aviManager.Close();
            File.Delete("audio.mp3");
            File.Delete("audio.wav");
            File.Delete("audio1.wav");
        }

        public static void EncryptFileInAudio(String origVideoFile, String outputVideoFile, String file)
        {
            byte[] source;
            using (BinaryReader b = new BinaryReader(File.Open(file, FileMode.Open)))
            {
                int length = (int)b.BaseStream.Length;
                source = b.ReadBytes(length);
            }
            GlobalFFOptions.Configure(options => options.BinaryFolder = "./");
            VideoFileReader reader = new VideoFileReader();
            reader.Open(origVideoFile);
            long framecount = reader.FrameCount;
            double frameRate = reader.FrameRate.Value;
            int bitRate = reader.BitRate;
            FFMpeg.ExtractAudio(origVideoFile, "audio.mp3");
            FileStream fileStream = new FileStream("audio.mp3", FileMode.Open);
            using (var mp3Reader = new Mp3FileReader(fileStream))
            {
                using (var waveWriter = new WaveFileWriter("audio.wav", mp3Reader.WaveFormat))
                {
                    mp3Reader.CopyTo(waveWriter);
                }
            }
            fileStream.Dispose();
            fileStream.Close();
            WavFile wavFile = WavUtils.CreateWavFile("audio.wav");
            byte[] wavSource;
            while (true)
            {
                using (BinaryReader b = new BinaryReader(File.Open("audio.wav", FileMode.Open)))
                {
                    int length = (int)b.BaseStream.Length;
                    wavSource = b.ReadBytes(length);
                }
                if (wavSource.Length < source.Length * 4 + 50)
                {
                    MessageBox.Show("Контейнер меньше, чем внедряемый файл.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                WavUtils.WriteBinaryFile(wavFile, "audio.wav", "audio1.wav", source);
                if (File.Exists(outputVideoFile))
                {
                    File.Delete(outputVideoFile);
                }
                using (var writer = new VideoFileWriter())
                {
                    Bitmap frame = reader.ReadVideoFrame();
                    writer.Open(outputVideoFile, frame.Width, frame.Height, (int)frameRate, VideoCodec.Default, bitRate * 10);
                    for (int i = 0; i < framecount; i++)
                    {
                        if (frame == null)
                        {
                            break;
                        }
                        writer.WriteVideoFrame(frame);
                        frame.Dispose();
                        try
                        {
                            frame = reader.ReadVideoFrame();
                        }
                        catch (System.ArgumentException)
                        {
                            continue;
                        }
                    }
                    writer.Close();
                    reader.Close();
                }
                AviManager aviManager = new AviManager(outputVideoFile, true);
                aviManager.AddAudioStream("audio1.wav", 0);
                aviManager.Close();
                File.Delete("audio.mp3");
                File.Delete("audio.wav");
                File.Delete("audio1.wav");
                break;
            }
        }

        public static string DecryptFromAudio(String modFile)
        {
            File.Copy(modFile, "temp.avi");
            AviManager aviManager = new AviManager("temp.avi", true);
            Library.AudioStream audioStream = aviManager.GetWaveStream();
            audioStream.ExportStream("audio2.wav");
            WavFile wavFile = WavUtils.CreateWavFile("audio2.wav");
            String text = WavUtils.DecryptFromVideoFile(wavFile, "audio2.wav");
            aviManager.Close();
            File.Delete("temp.avi");
            File.Delete("audio2.wav");
            return text;
        }

        public static byte[] DecryptFileFromAudio(String modFile)
        {
            File.Copy(modFile, "temp.avi");
            AviManager aviManager = new AviManager("temp.avi", true);
            Library.AudioStream audioStream = aviManager.GetWaveStream();
            audioStream.ExportStream("audio2.wav");
            WavFile wavFile = WavUtils.CreateWavFile("audio2.wav");
            byte[] ret = WavUtils.DecryptFileFromVideoFile(wavFile, "audio2.wav");
            aviManager.Close();
            File.Delete("temp.avi");
            File.Delete("audio2.wav");
            return ret;
        }
    }
}
