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
    }
}
