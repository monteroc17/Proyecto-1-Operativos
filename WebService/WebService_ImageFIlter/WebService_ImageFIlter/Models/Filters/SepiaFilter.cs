using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace WebService_ImageFIlter.Models.Filters
{
    public static class SepiaFilter
    {
        private static Bitmap GetArgbCopy(Image sourceImage)
        {
            Bitmap bmpNew = new Bitmap(sourceImage.Width, sourceImage.Height, PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(bmpNew))
            {
                graphics.DrawImage(sourceImage, new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), GraphicsUnit.Pixel);
                graphics.Flush();
            }

            return bmpNew;
        }
        public static Bitmap SepiaTone(this Image sourceImage)
        {
            Bitmap bmpNew = GetArgbCopy(sourceImage);
            BitmapData bmpData = bmpNew.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            byte[] byteBuffer = new byte[bmpData.Stride * bmpNew.Height];

            Marshal.Copy(ptr, byteBuffer, 0, byteBuffer.Length);

            byte maxValue = 255;
            float r = 0;
            float g = 0;
            float b = 0;

            for (int k = 0; k < byteBuffer.Length; k += 4)
            {
                r = byteBuffer[k] * 0.189f + byteBuffer[k + 1] * 0.769f + byteBuffer[k + 2] * 0.393f;
                g = byteBuffer[k] * 0.168f + byteBuffer[k + 1] * 0.686f + byteBuffer[k + 2] * 0.349f;
                b = byteBuffer[k] * 0.131f + byteBuffer[k + 1] * 0.534f + byteBuffer[k + 2] * 0.272f;

                byteBuffer[k + 2] = (r > maxValue ? maxValue : (byte)r);
                byteBuffer[k + 1] = (g > maxValue ? maxValue : (byte)g);
                byteBuffer[k] = (b > maxValue ? maxValue : (byte)b);
            }

            Marshal.Copy(byteBuffer, 0, ptr, byteBuffer.Length);

            bmpNew.UnlockBits(bmpData);

            bmpData = null;
            byteBuffer = null;

            return bmpNew;
        }
    }
}