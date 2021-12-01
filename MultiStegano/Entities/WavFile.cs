using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiStegano.Entities
{
    class WavFile
    {
        public string path;
        //-----WaveHeader-----
        public char[] sGroupID; // RIFF
        public uint dwFileLength; // полная длина файла минус 8, которые заняты RIFFом
        public char[] sRiffType;// всегда WAVE

        //-----WaveFormatChunk-----
        public char[] sFChunkID;         // четыре байта: "fmt "
        public uint dwFChunkSize;        // длина заголовка в байтах
        public ushort wFormatTag;       // 1 (MS PCM)
        public ushort wChannels;        // число каналов
        public uint dwSamplesPerSec;    // частота в ГЦ
        public uint dwAvgBytesPerSec;   // распределение ОЗУ, байт в секунду
        public ushort wBlockAlign;      // размер кадра семпла в байтах
        public ushort wBitsPerSample;    // битов в семпле

        //-----WaveDataChunk-----
        public char[] sDChunkID;     // "data"
        public uint dwDChunkSize;    // длина заголовка в байтах
        public byte dataStartPos;  // поизиция начала даты аудио

        // инициализация wav файла
        public WavFile()
        {
            path = Environment.CurrentDirectory;
            //-----WaveHeader-----
            dwFileLength = 0;
            sGroupID = "RIFF".ToCharArray();
            sRiffType = "WAVE".ToCharArray();

            //-----WaveFormatChunk-----
            sFChunkID = "fmt ".ToCharArray();
            dwFChunkSize = 16;
            wFormatTag = 1;
            wChannels = 2;
            dwSamplesPerSec = 44100;
            wBitsPerSample = 16;
            wBlockAlign = (ushort)(wChannels * (wBitsPerSample / 8));
            dwAvgBytesPerSec = dwSamplesPerSec * wBlockAlign;

            //-----WaveDataChunk-----
            dataStartPos = 44;
            dwDChunkSize = 0;
            sDChunkID = "data".ToCharArray();
        }

        public override bool Equals(object obj)
        {
            var file = obj as WavFile;
            return file != null &&
                   EqualityComparer<char[]>.Default.Equals(sGroupID, file.sGroupID) &&
                   dwFileLength == file.dwFileLength &&
                   EqualityComparer<char[]>.Default.Equals(sRiffType, file.sRiffType) &&
                   EqualityComparer<char[]>.Default.Equals(sFChunkID, file.sFChunkID) &&
                   dwFChunkSize == file.dwFChunkSize &&
                   wFormatTag == file.wFormatTag &&
                   wChannels == file.wChannels &&
                   dwSamplesPerSec == file.dwSamplesPerSec &&
                   dwAvgBytesPerSec == file.dwAvgBytesPerSec &&
                   wBlockAlign == file.wBlockAlign &&
                   wBitsPerSample == file.wBitsPerSample &&
                   EqualityComparer<char[]>.Default.Equals(sDChunkID, file.sDChunkID) &&
                   dwDChunkSize == file.dwDChunkSize &&
                   dataStartPos == file.dataStartPos;
        }

        public override int GetHashCode()
        {
            var hashCode = -1043702566;
            hashCode = hashCode * -1521134295 + EqualityComparer<char[]>.Default.GetHashCode(sGroupID);
            hashCode = hashCode * -1521134295 + dwFileLength.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<char[]>.Default.GetHashCode(sRiffType);
            hashCode = hashCode * -1521134295 + EqualityComparer<char[]>.Default.GetHashCode(sFChunkID);
            hashCode = hashCode * -1521134295 + dwFChunkSize.GetHashCode();
            hashCode = hashCode * -1521134295 + wFormatTag.GetHashCode();
            hashCode = hashCode * -1521134295 + wChannels.GetHashCode();
            hashCode = hashCode * -1521134295 + dwSamplesPerSec.GetHashCode();
            hashCode = hashCode * -1521134295 + dwAvgBytesPerSec.GetHashCode();
            hashCode = hashCode * -1521134295 + wBlockAlign.GetHashCode();
            hashCode = hashCode * -1521134295 + wBitsPerSample.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<char[]>.Default.GetHashCode(sDChunkID);
            hashCode = hashCode * -1521134295 + dwDChunkSize.GetHashCode();
            hashCode = hashCode * -1521134295 + dataStartPos.GetHashCode();
            return hashCode;
        }
    }
}
