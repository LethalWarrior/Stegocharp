using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Steganography.Classes
{
    class Helper
    {
        public static List<string> ConvertTextToBytes(string text)
        {
            List<string> bytes = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                bytes.Add(Convert.ToString((int)text[i], 2).PadLeft(8, '0'));
            }
            return bytes;
        }

        public static List<string> ConvertImageToPixelRGBs(Bitmap bitmap)
        {
            List<string> bytes = new List<string>();
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    bytes.Add(Convert.ToString(color.R, 2).PadLeft(8, '0'));
                    bytes.Add(Convert.ToString(color.G, 2).PadLeft(8, '0'));
                    bytes.Add(Convert.ToString(color.B, 2).PadLeft(8, '0'));
                }
            }
            return bytes;
        }
    }
}
