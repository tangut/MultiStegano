﻿using Accord.Video.FFMPEG;
using FFMpegCore;
using MultiStegano.Entities;
using MultiStegano.Library;
using MultiStegano.Utils;
using NAudio.Lame;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiStegano
{
    public partial class MultiStegoForm : Form
    {

        public MultiStegoForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            GlobalFFOptions.Configure(new FFOptions { BinaryFolder = "./FFMPEG", TemporaryFilesFolder = "./FFMPEG" });
            InitializeComponent();
        }

        #region Image steganography

        private void OpenOriginalImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.PNG)|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                originalPictureBox.ImageLocation = dialog.FileName.ToString();
                origImgPath.Text = dialog.FileName.ToString();
            }
        }

        private void OpenChangedImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.PNG)|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                encodedPictureBox.ImageLocation = dialog.FileName.ToString();
                modImgPath.Text = dialog.FileName.ToString();
            }
        }

        // внедрение цвета сообщения
        private void redColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton redColorRadioButton = (RadioButton)sender;
        }

        private void greenColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton greenColorRadioButton = (RadioButton)sender;
        }

        private void blueColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton blueColorRadioButton = (RadioButton)sender;
        }

        // выбор языка
        private void russianLangRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton russianLangRadioButton = (RadioButton)sender;
        }

        private void engLangRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton engLangRadioButton = (RadioButton)sender;
        }

        // кодирование изображения
        private void EncodeButton_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (origImgPath.Text == "Путь к оригинальному файлу" || origImgPath.Text == "")
                {
                    MessageBox.Show("Сначала нужно выбрать изображение.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                if (imgEncryptTextBox.Text == "")
                {
                    MessageBox.Show("Сначала нужно ввести текст для внедрения.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                if (!(redColorRadioButton.Checked || greenColorRadioButton.Checked || blueColorRadioButton.Checked))
                {
                    MessageBox.Show("Сначала выберите цвет для внедрения.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                if (!(russianLangRadioButton.Checked || engLangRadioButton.Checked))
                {
                    MessageBox.Show("Сначала выберите язык сообщения.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                Colors color = Colors.RED; // цвет в любом случае проинициализируется корректно далее
                if (redColorRadioButton.Checked)
                {
                    color = Colors.RED;
                }
                if (greenColorRadioButton.Checked)
                {
                    color = Colors.GREEN;
                }
                if (blueColorRadioButton.Checked)
                {
                    color = Colors.BLUE;
                }
                if (engLangRadioButton.Checked)
                {
                    Bitmap modImg = ImageUtils.EncodeEnglish(origImgPath.Text, imgEncryptTextBox.Text, color);
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.Filter = "Image files (*.PNG)|*.png";

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        originalPictureBox.ImageLocation = origImgPath.Text;
                        modImgPath.Text = saveFile.FileName.ToString();
                        encodedPictureBox.ImageLocation = modImgPath.Text;

                        modImg.Save(modImgPath.Text);
                    }
                }
                else
                {
                    Bitmap modImg = ImageUtils.EncodeRussian(origImgPath.Text, imgEncryptTextBox.Text, color);
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.Filter = "Image files (*.PNG)|*.png";

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        originalPictureBox.ImageLocation = origImgPath.Text;
                        modImgPath.Text = saveFile.FileName.ToString();
                        encodedPictureBox.ImageLocation = modImgPath.Text;

                        modImg.Save(modImgPath.Text);
                    }
                }
                break;
            }
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (!(redColorRadioButton.Checked || greenColorRadioButton.Checked || blueColorRadioButton.Checked))
                {
                    MessageBox.Show("Сначала выберите предполагаемый цвет для внедрения.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                if (!(russianLangRadioButton.Checked || engLangRadioButton.Checked))
                {
                    MessageBox.Show("Сначала выберите предполагаемый язык сообщения.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                if (modImgPath.Text == "" || modImgPath.Text == "Путь к измененному файлу")
                {
                    MessageBox.Show("Сначала выберите изображение с вшитым сообщением.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                Colors color = Colors.RED; // цвет в любом случае проинициализируется корректно далее
                if (redColorRadioButton.Checked)
                {
                    color = Colors.RED;
                }
                if (greenColorRadioButton.Checked)
                {
                    color = Colors.GREEN;
                }
                if (blueColorRadioButton.Checked)
                {
                    color = Colors.BLUE;
                }
                if (engLangRadioButton.Checked)
                {
                    String ecnodedText = ImageUtils.DecodeEnglish(modImgPath.Text, LenghtTextBox.Text, color);
                    imgEncryptTextBox.Text = "Дешифрованный текст: " + ecnodedText;
                }
                else
                {
                    String encodedText = ImageUtils.DecodeRussian(modImgPath.Text, LenghtTextBox.Text, color);
                    imgEncryptTextBox.Text = "Дешифрованный текст: " + encodedText;
                }
                break;
            }
        }

        private void encryptTextBoxClearButton_Click(object sender, EventArgs e)
        {
            imgEncryptTextBox.Text = "";
        }


        #endregion

        #region Audio steganography
        private static WavFile origWavFile = new WavFile();
        private static WavFile modWavFile = new WavFile();

        private void origAudioFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Wav files (*.WAV)|*.wav";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                origAudioFileTextBox.Text = dialog.FileName.ToString();
                origWavFile = WavUtils.CreateWavFile(origAudioFileTextBox.Text);
                origSampleTextBox.Text = Convert.ToString(origWavFile.dwSamplesPerSec) + " Гц";
                origChannelsTextBox.Text = Convert.ToString(origWavFile.wChannels);
                origBitPerSampleTextBox.Text = Convert.ToString(origWavFile.wBitsPerSample);
                origDChunkSizeTextBox.Text = Convert.ToString(origWavFile.dwDChunkSize) + " Байт";
                origDataStartPosTextBox.Text = Convert.ToString(origWavFile.dataStartPos);
                origFChunkSizeTextBox.Text = Convert.ToString(origWavFile.dwFChunkSize);
                origBlockAllignTextBox.Text = Convert.ToString(origWavFile.wBlockAlign);
                origBytesPerSecondTextBox.Text = Convert.ToString(origWavFile.dwAvgBytesPerSec);
            }
        }


        private void modAudioFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Wav files (*.WAV)|*.wav";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                modAudioFileTextBox.Text = dialog.FileName.ToString();
                modWavFile = WavUtils.CreateWavFile(modAudioFileTextBox.Text);
                modSampleTextBox.Text = Convert.ToString(modWavFile.dwSamplesPerSec) + " Гц";
                modChannelsTextBox.Text = Convert.ToString(modWavFile.wChannels);
                modBitPerSampleTextBox.Text = Convert.ToString(modWavFile.wBitsPerSample);
                modDChunkSizeTextBox.Text = Convert.ToString(modWavFile.dwDChunkSize) + " Байт";
                modDataStartPosTextBox.Text = Convert.ToString(modWavFile.dataStartPos);
                modFChunkSizeTextBox.Text = Convert.ToString(modWavFile.dwFChunkSize);
                modBlockAllignTextBox.Text = Convert.ToString(modWavFile.wBlockAlign);
                modBytesPerSecondTextBox.Text = Convert.ToString(modWavFile.dwAvgBytesPerSec);
            }
        }

        // зашифровка сообщения в аудиофайл
        private void encryptAudioButton_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (origAudioFileTextBox.Text == "")
                {
                    MessageBox.Show("Сначала нужно выбрать оригинальный wav файл.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Wav files (*.WAV)|*.wav";
                UInt32 bytesPerSample = origWavFile.dwAvgBytesPerSec;
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    creationalAudioTextBox.Text = saveFile.FileName.ToString();
                    WavUtils.WriteFile(origWavFile, origAudioFileTextBox.Text, creationalAudioTextBox.Text, encryptAudioTextBox.Text);
                }
                break;
            }
        }

        // дешифровка сообщения из аудиофайла
        private void decryptAudioButton_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (modAudioFileTextBox.Text == "")
                {
                    MessageBox.Show("Сначала нужно выбрать измененный wav файл.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                String decryptedMessage = WavUtils.DecryptFile(modWavFile, modAudioFileTextBox.Text);
                decryptAudioTextBox.Text = decryptedMessage;
                break;
            }
        }

        private void chooseOrigAudioButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Оригинальный wav файл (*.WAV)|*.wav";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                origAudioPathTextBox.Text = dialog.FileName.ToString();
            }
        }

        private void chooseModAudioButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Измененный wav файл (*.WAV)|*.wav";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                modAudioPathTextBox.Text = dialog.FileName.ToString();
            }
        }

        // анализ измененных битов в сообщении
        private void analyzeAudioChangesButton_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (origAudioPathTextBox.Text == "")
                {
                    MessageBox.Show("Сначала нужно выбрать оригинальный wav файл для анализа.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                if (modAudioPathTextBox.Text == "")
                {
                    MessageBox.Show("Сначала нужно выбрать измененный wav файл для анализа.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                origWavFile = WavUtils.CreateWavFile(origAudioPathTextBox.Text);
                modWavFile = WavUtils.CreateWavFile(modAudioPathTextBox.Text);
                changesAudioTextBox.Text = WavUtils.Analyze(origWavFile, modWavFile, origAudioPathTextBox.Text, modAudioPathTextBox.Text);
                break;
            }
        }


        #endregion Audio steganography

        private void disableVideoButtons()
        {
            openModVideoFileButton.Enabled = false;
            openOrigVideoFileButton.Enabled = false;
            encryptTextInVideoButton.Enabled = false;
            clearEncryptVideoTextButton.Enabled = false;
            decryptVideoButton.Enabled = false;
        }

        private void enableVideoButtons()
        {
            openModVideoFileButton.Enabled = true;
            openOrigVideoFileButton.Enabled = true;
            encryptTextInVideoButton.Enabled = true;
            clearEncryptVideoTextButton.Enabled = true;
            decryptVideoButton.Enabled = true;
        }

        private void openOrigVideoFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Video files (*.AVI)|*.avi";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                origVideoPlayer.URL = dialog.FileName.ToString();
                origVideoFileTextBox.Text = dialog.FileName.ToString();
            }
        }

        private void openModVideoFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Video files (*.AVI)|*.avi";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                modVideoPlayer.URL = dialog.FileName.ToString();
                modVideoFileTextBox.Text = dialog.FileName.ToString();
            }
        }

        private void encryptTextInVideoButton_Click(object sender, EventArgs e)
        {
            VideoFileReader reader = new VideoFileReader();
            String origFile = origVideoFileTextBox.Text;
            reader.Open(origFile);
            long framecount = reader.FrameCount;
            double frameRate = reader.FrameRate.Value;
            int bitRate = reader.BitRate;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "AVI files (*.AVI)|*.avi";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String path = saveFileDialog.FileName.ToString();
                disableVideoButtons();
                MessageBox.Show("Подождите, запись видеофайла выполняется!");
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
                WavUtils.WriteFile(wavFile, "audio.wav", "audio1.wav", "привет");
                using (var writer = new VideoFileWriter())
                {
                    Bitmap frame = reader.ReadVideoFrame();
                    writer.Open("temp.avi", frame.Width, frame.Height, (int)frameRate, VideoCodec.Default, Int32.MaxValue);
                    for (int i = 0; i < framecount; i++)
                    {
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
                AviManager aviManager = new AviManager("temp.avi", true);
                aviManager.AddAudioStream("audio1.wav", 0);
                aviManager.Close();
                File.Delete("audio.mp3");
                File.Delete("audio.wav");
                File.Delete("audio1.wav");
                MessageBox.Show("Видеофайл записан!", "ОК", MessageBoxButtons.OK, MessageBoxIcon.Information);
                enableVideoButtons();
            }
        }

        private void decryptVideoButton_Click(object sender, EventArgs e)
        {
            AviManager aviManager = new AviManager("temp.avi", true);
            Library.AudioStream audioStream = aviManager.GetWaveStream();
            audioStream.ExportStream("audio2.wav");
            WavFile wavFile = WavUtils.CreateWavFile("audio2.wav");
            String text = WavUtils.DecryptFromVideoFile(wavFile, "audio2.wav");
            decryptVideoTextBox.Text = text;
            File.Delete("audio2.wav");
        }
    }
}
