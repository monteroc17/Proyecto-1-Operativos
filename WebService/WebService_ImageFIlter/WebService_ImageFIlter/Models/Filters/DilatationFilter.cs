using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace WebService_ImageFIlter.Models.Filters
{
    public static class DilatationFilter
    {
        public static Bitmap Dilate(this Bitmap sourceBitmap,
                                                int matrixSize,
                                                bool applyBlue = true,
                                                bool applyGreen = true,
                                                bool applyRed = true)
        {
            BitmapData sourceData =
                       sourceBitmap.LockBits(new Rectangle(0, 0,
                       sourceBitmap.Width, sourceBitmap.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride *
                                          sourceData.Height];

            byte[] resultBuffer = new byte[sourceData.Stride *
                                           sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0,
                                       pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            int filterOffset = (matrixSize - 1) / 2;
            int calcOffset = 0;

            int byteOffset = 0;

            byte blue = 0;
            byte green = 0;
            byte red = 0;

            byte morphResetValue = 0;

            for (int offsetY = filterOffset; offsetY <
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    byteOffset = offsetY *
                                 sourceData.Stride +
                                 offsetX * 4;

                    blue = morphResetValue;
                    green = morphResetValue;
                    red = morphResetValue;


                    for (int filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset +
                                         (filterX * 4) +
                            (filterY * sourceData.Stride);

                            if (pixelBuffer[calcOffset] > blue)
                            {
                                blue = pixelBuffer[calcOffset];
                            }

                            if (pixelBuffer[calcOffset + 1] > green)
                            {
                                green = pixelBuffer[calcOffset + 1];
                            }

                            if (pixelBuffer[calcOffset + 2] > red)
                            {
                                red = pixelBuffer[calcOffset + 2];
                            }
                        }
                    }



                    if (applyBlue == false)
                    {
                        blue = pixelBuffer[byteOffset];
                    }

                    if (applyGreen == false)
                    {
                        green = pixelBuffer[byteOffset + 1];
                    }

                    if (applyRed == false)
                    {
                        red = pixelBuffer[byteOffset + 2];
                    }

                    resultBuffer[byteOffset] = blue;
                    resultBuffer[byteOffset + 1] = green;
                    resultBuffer[byteOffset + 2] = red;
                    resultBuffer[byteOffset + 3] = 255;
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width,
                                             sourceBitmap.Height);

            BitmapData resultData =
                       resultBitmap.LockBits(new Rectangle(0, 0,
                       resultBitmap.Width, resultBitmap.Height),
                       ImageLockMode.WriteOnly,
                       PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0,
                                       resultBuffer.Length);

            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }
    }
}