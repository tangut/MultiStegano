using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiStegano
{
    public static class ImageUtils
    {
        private static String alphRussian = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя 0123456789.,?!;:-/=_+()";

        public static Bitmap EncodeEnglish(String filePath, String decodeText, Colors color)
        {
            Bitmap img = new Bitmap(filePath);
            int len = decodeText.Length;
            if (len != 0 && img != null)
            {
                int n = img.Height;
                int m = img.Width;
                int x = 0;
                int y = n - 1;
                // в самый левый нижний угол картинки внедрим длину сообщения
                for (int j = 0; j < 8; j++)
                {
                    Color p = img.GetPixel(x, y);
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    if (color == Colors.RED)
                    {
                        r = ((r & 254) | ((len & (1 << j)) > 0 ? 1 : 0));
                    }
                    if (color == Colors.GREEN)
                    {
                        g = ((g & 254) | ((len & (1 << j)) > 0 ? 1 : 0));
                    }
                    if (color == Colors.BLUE)
                    {
                        b = ((b & 254) | ((len & (1 << j)) > 0 ? 1 : 0));
                    }
                    p = Color.FromArgb(r, g, b);
                    img.SetPixel(x, y, p);
                    x++;
                }
                // внедряем текст, начиная с левого нижнего угла картинки
                for (int i = 0; i < len; i++)
                {
                    int c = decodeText[i];
                    for (int j = 0; j < 8; j++)
                    {
                        if (x >= m)
                        {
                            y--;
                            x = 0;
                        }
                        Color p = img.GetPixel(x, y);
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;
                        if (color == Colors.RED)
                        {
                            r = ((r & 254) | ((c & (1 << j)) > 0 ? 1 : 0));
                        }
                        if (color == Colors.GREEN)
                        {
                            g = ((g & 254) | ((c & (1 << j)) > 0 ? 1 : 0));
                        }
                        if (color == Colors.BLUE)
                        {
                            b = ((b & 254) | ((c & (1 << j)) > 0 ? 1 : 0));
                        }
                        p = Color.FromArgb(r, g, b);
                        img.SetPixel(x, y, p);
                        x++;
                    }
                }
            }
            return img;
        }

        public static Bitmap EncodeRussian(String filePath, String decodeText, Colors color)
        {
            Bitmap img = new Bitmap(filePath);
            int len = decodeText.Length;
            if (len != 0 && img != null)
            {
                int n = img.Height;
                int m = img.Width;
                int x = 0;
                int y = n - 1;
                int c = 0;
                // в самый левый нижний угол картинки внедрим сообщение
                for (int j = 0; j < 8; j++)
                {
                    Color p = img.GetPixel(x, y);
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    if (color == Colors.RED)
                    {
                        r = ((r & 254) | ((len & (1 << j)) > 0 ? 1 : 0));
                    }
                    if (color == Colors.GREEN)
                    {
                        g = ((g & 254) | ((len & (1 << j)) > 0 ? 1 : 0));
                    }
                    if (color == Colors.BLUE)
                    {
                        b = ((b & 254) | ((len & (1 << j)) > 0 ? 1 : 0));
                    }
                    p = Color.FromArgb(r, g, b);
                    img.SetPixel(x, y, p);
                    x++;
                }
                // внедряем текст, начиная с левого нижнего угла картинки
                for (int i = 0; i < len; i++)
                {
                    for (int z = 0; z < alphRussian.Length; z++)
                    {
                        if (decodeText[i] == alphRussian[z])
                        {
                            c = z;
                        }
                    }
                    for (int j = 0; j < 8; j++)
                    {
                        if (x >= m)
                        {
                            y--;
                            x = 0;
                        }
                        Color p = img.GetPixel(x, y);
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;
                        if (color == Colors.RED)
                        {
                            r = ((r & 254) | ((c & (1 << j)) > 0 ? 1 : 0));
                        }
                        if (color == Colors.GREEN)
                        {
                            g = ((g & 254) | ((c & (1 << j)) > 0 ? 1 : 0));
                        }
                        if (color == Colors.BLUE)
                        {
                            b = ((b & 254) | ((c & (1 << j)) > 0 ? 1 : 0));
                        }
                        p = Color.FromArgb(r, g, b);
                        img.SetPixel(x, y, p);
                        x++;
                    }
                }
            }
            return img;
        }

        public static String DecodeEnglish(String filePath, Colors color)
        {
            String txt = "";
            Bitmap img = new Bitmap(filePath);
            int len;
            int n = img.Height;
            int m = img.Width;
            // аналогично, считываем зашифрованный текст, начиная с левого нижнего угла картинки, начиная с его длины
            int x = 0;
            int y = n - 1;
            int c = 0;
            for (int j = 0; j < 8; j++)
            {
                Color p = img.GetPixel(x, y);
                int r = p.R;
                int g = p.G;
                int b = p.B;
                if (color == Colors.RED)
                {
                    c = c | ((r & 1) << j);
                }
                if (color == Colors.GREEN)
                {
                    c = c | ((g & 1) << j);
                }
                if (color == Colors.BLUE)
                {
                    c = c | ((b & 1) << j);
                }
                x++;
            }
            len = c;
            for (int i = 0; i < len; i++)
            {
                c = 0;

                for (int j = 0; j < 8; j++)
                {
                    if (x >= m)
                    {
                        y--;
                        x = 0;
                    }
                    Color p = img.GetPixel(x, y);
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    if (color == Colors.RED)
                    {
                        c = c | ((r & 1) << j);
                    }
                    if (color == Colors.GREEN)
                    {
                        c = c | ((g & 1) << j);
                    }
                    if (color == Colors.BLUE)
                    {
                        c = c | ((b & 1) << j);
                    }
                    x++;
                }
                txt += (char)(c);
            }

            txt.Reverse();

            return txt;
        }

       
        public static String DecodeRussian(String filePath, Colors color)
        {
            String txt = "";
            Bitmap img = new Bitmap(filePath);
            int len;
            int n = img.Height;
            int m = img.Width;
            // аналогично, считываем зашифрованный текст, начиная с левого нижнего угла картинки, начиная с его длины
            int x = 0;
            int y = n - 1;
            int c = 0;
            for (int j = 0; j < 8; j++)
            {
                Color p = img.GetPixel(x, y);
                int r = p.R;
                int g = p.G;
                int b = p.B;
                if (color == Colors.RED)
                {
                    c = c | ((r & 1) << j);
                }
                if (color == Colors.GREEN)
                {
                    c = c | ((g & 1) << j);
                }
                if (color == Colors.BLUE)
                {
                    c = c | ((b & 1) << j);
                }
                x++;
            }
            len = c;
            for (int i = 0; i < len; i++)
            {
                c = 0;

                for (int j = 0; j < 8; j++)
                {
                    if (x >= m)
                    {
                        y--;
                        x = 0;
                    }
                    Color p = img.GetPixel(x, y);
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    if (color == Colors.RED)
                    {
                        c = c | ((r & 1) << j);
                    }
                    if (color == Colors.GREEN)
                    {
                        c = c | ((g & 1) << j);
                    }
                    if (color == Colors.BLUE)
                    {
                        c = c | ((b & 1) << j);
                    }
                    x++;
                }
                if (c < alphRussian.Length)
                {
                    txt += alphRussian[c];
                }
                else
                {
                    txt += (char)c;
                }
            }

            txt.Reverse();

            return txt;
        }
    }
}
