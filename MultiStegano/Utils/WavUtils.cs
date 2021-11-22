using MultiStegano.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiStegano.Utils
{
    class WavUtils
    {
        public static WavFile CreateWavFile(String filePath)
        {
            WavFile wavFile = new WavFile();
            FileStream fsr = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fsr);
            wavFile.sGroupID = r.ReadChars(4);
            wavFile.dwFileLength = r.ReadUInt32();
            wavFile.sRiffType = r.ReadChars(4);
            wavFile.sFChunkID = r.ReadChars(4);
            wavFile.dwFChunkSize = r.ReadUInt32();
            wavFile.wFormatTag = r.ReadUInt16();
            wavFile.wChannels = r.ReadUInt16();
            wavFile.dwSamplesPerSec = r.ReadUInt32();
            wavFile.dwAvgBytesPerSec = r.ReadUInt32();
            wavFile.wBlockAlign = r.ReadUInt16();
            wavFile.wBitsPerSample = r.ReadUInt16();
            wavFile.sDChunkID = r.ReadChars(4);
            wavFile.dwDChunkSize = r.ReadUInt32();
            wavFile.dataStartPos = (byte)r.BaseStream.Position;
            r.Close();
            fsr.Close();
            return wavFile;
        }

        // метод записи wav файла(просто копирование)
        public static void WriteWav(string oldpath, string path)
        {
            FileStream fsr = new FileStream(oldpath, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fsr);
            FileStream fsw = null;
            try
            {
                fsw = new FileStream(path, FileMode.CreateNew);
            }
            catch (IOException)
            {
                fsw = new FileStream(path, FileMode.Truncate);
            }
            BinaryWriter w = new BinaryWriter(fsw);
            int pos = 0, len = (int)r.BaseStream.Length; short temp;
            while (pos < len)
            {
                temp = (short)r.ReadInt16();
                w.Write(temp);
                pos += 2;
            }
            r.Close(); w.Close();
            fsr.Close(); fsw.Close();
        }

        // метод записи нового файла из потока, с записью туда сообщения
        public static void WriteFile(WavFile file, string oldpath, string path, string messageStr)
        {
            byte DataPos = file.dataStartPos;
            byte[] source;
            using (BinaryReader b = new BinaryReader(File.Open(oldpath, FileMode.Open)))
            {
                int length = (int)b.BaseStream.Length;
                source = b.ReadBytes(length);
            }
            byte[] bufferMessage = Encoding.UTF8.GetBytes(messageStr);
            int sourceLength = bufferMessage.Length * 4; // длина нашего сообщения
            byte[] sourcelen = BitConverter.GetBytes(sourceLength);
            int offlen = DataPos + 1;
            // шифруем длину нашего сообщения в первые 16 байт дата части wav файла в каждые 2 младших бита
            foreach (byte x in sourcelen)
            {
                int multy = 192;
                for (int i = 6; i >= 0; i = i - 2)
                {
                    int output = (x & multy) >> i;
                    multy = multy / 4;
                    int temp = source[offlen] & 252;
                    source[offlen] = Convert.ToByte(temp | output);
                    offlen++;
                }
            }

            int offset = offlen;
            try
            {
                if (source.Length < bufferMessage.Length * 4 + DataPos + 16)
                { 
                    throw new Exception("Длина сообщения больше длины файла");
                }

                // записываем в 2 младших бита байта источника два бита сообщения
                foreach (byte x in bufferMessage)
                {
                    int multiply = 192;
                    for (int i = 6; i >= 0; i = i - 2)
                    {
                        int output = (x & multiply) >> i;
                        multiply = multiply / 4;
                        int temp = source[offset] & 252;
                        source[offset] = Convert.ToByte(temp | output);
                        offset++;
                    }
                }
                using (BinaryWriter b = new BinaryWriter(File.Open(path, FileMode.Create)))
                {
                    foreach (byte i in source)
                    {
                        b.Write(i);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка: {e.Message}", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // дешифратор сообщения
        public static string DecryptFile(WavFile file, string path)
        {
            byte DataPos = file.dataStartPos;
            byte[] source;
            using (BinaryReader b = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                int length = (int)b.BaseStream.Length;
                source = b.ReadBytes(length);
            }
            byte[] bufferlen = new byte[4];
            int lenstep = 0;
            int offlen = 6;
            // вытаскиваем длинну нашего сообщения
            for (int i = DataPos + 1; i < DataPos + 17; i = i + 4)
            {
                offlen = 6;
                int multy = 192;
                int output = 0;
                for (int k = 0; k < 4; k++)
                {
                    int temp = source[i + k];
                    temp = (temp << offlen) & multy;
                    output = output | temp;
                    multy = multy / 4;
                    offlen = offlen - 2;
                }
                bufferlen[lenstep] = Convert.ToByte(output);
                lenstep++;
            }
            int bufferLength = BitConverter.ToInt32(bufferlen, 0);
            byte[] bufferOutput = new byte[bufferLength / 4];
            //извлекаем сообщение из бинарного потока
            int step = 0;
            int offset;
            for (int i = DataPos + 17; i < DataPos + 17 + bufferLength; i = i + 4)
            {
                offset = 6;
                int multiply = 192;
                int output = 0;
                for (int k = 0; k < 4; k++)
                {
                    int temp = source[i + k];
                    temp = (temp << offset) & multiply;
                    output = output | temp;
                    multiply = multiply / 4;
                    offset = offset - 2;
                }
                bufferOutput[step] = Convert.ToByte(output);
                step++;
            }
            string decodeMessage = Encoding.UTF8.GetString(bufferOutput);
            return decodeMessage;
        }

        public static string Analyze(WavFile file1, WavFile file2, string path1, string path2)
        {
            byte DataPos1 = file1.dataStartPos;
            byte DataPos2 = file2.dataStartPos;
            byte[] source1, source2;
            using (BinaryReader b1 = new BinaryReader(File.Open(path1, FileMode.Open)))
            {
                int length1 = (int)b1.BaseStream.Length;
                source1 = b1.ReadBytes(length1);
            }
            using (BinaryReader b2 = new BinaryReader(File.Open(path2, FileMode.Open)))
            {
                int length2 = (int)b2.BaseStream.Length;
                source2 = b2.ReadBytes(length2);
            }
            int arrlen = source1.Length - (DataPos1 + 1);
            int[] NumberArray = new int[arrlen];
            for (int i = 0; i < arrlen; i++)
            {
                NumberArray[i] = 0;
            }
            string str = "Номера измененных байтов данных в файле:";
            int step = 0;
            for (int i = DataPos2 + 1; i < source2.Length; i++)
            {
                if (source2[i] != source1[i])
                {
                    NumberArray[step] = i;
                    step++;
                }
            }
            for (int i = 0; i < arrlen; i++)
            {
                if (NumberArray[i] != 0)
                {
                    str += "  " + Convert.ToString(NumberArray[i]);
                }
            }
            if (str == "Номера измененных байтов данных в файле:")
                str = "В части аудиоданных файла изменений нет.";
            return str;
        }
    }
}
