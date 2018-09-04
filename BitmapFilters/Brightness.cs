using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace BitmapFilters
{
    class Brightness
    {
        public static void ApplyBrightness(ref Bitmap bmp, byte brightnessValue)
        {
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* ptr = (byte*)bmpData.Scan0.ToPointer();
                int stopAddress = (int)ptr + bmpData.Stride * bmpData.Height;

                int val = 0;

                while ((int)ptr != stopAddress)
                {
                    val = ptr[2] + brightnessValue;
                    if (val < 0) val = 0;
                    else if (val > 255) val = 255;
                    ptr[2] = (byte)val;

                    val = ptr[1] + brightnessValue;
                    if (val < 0) val = 0;
                    else if (val > 255) val = 255;
                    ptr[1] = (byte)val;

                    val = ptr[0] + brightnessValue;
                    if (val < 0) val = 0;
                    else if (val > 255) val = 255;
                    ptr[0] = (byte)val;

                    ptr += 3;
                }
            }

            bmp.UnlockBits(bmpData);
        }
    }
}
