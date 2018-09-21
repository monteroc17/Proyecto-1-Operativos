using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BitmapFilters
{
    public static class ParallelFilters
    {
        //clase para implementar Parallel.For en for con incremento no consecutivo
        public static class BetterEnumerable
        {
            public static IEnumerable<int> SteppedRange(int fromInclusive, int toExclusive, int step)
            {
                for (var i = fromInclusive; i < toExclusive; i += step)
                {
                    yield return i;
                }
            }
        }
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
        public static Bitmap Transparency(this Image sourceImage, byte alphaComponent = 100)
        {
            Bitmap bmpNew = GetArgbCopy(sourceImage);
            BitmapData bmpData = bmpNew.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            byte[] byteBuffer = new byte[bmpData.Stride * bmpNew.Height];

            Marshal.Copy(ptr, byteBuffer, 0, byteBuffer.Length);

            Parallel.ForEach(BetterEnumerable.SteppedRange(3,byteBuffer.Length,4), k =>
           {
               byteBuffer[k] = alphaComponent;
           });

            Marshal.Copy(byteBuffer, 0, ptr, byteBuffer.Length);

            bmpNew.UnlockBits(bmpData);

            bmpData = null;
            byteBuffer = null;

            return bmpNew;
        }

        // Negativo
        public static Bitmap Negative(this Image sourceImage)
        {
            Bitmap bmpNew = GetArgbCopy(sourceImage);
            BitmapData bmpData = bmpNew.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            byte[] byteBuffer = new byte[bmpData.Stride * bmpNew.Height];

            Marshal.Copy(ptr, byteBuffer, 0, byteBuffer.Length);
            byte[] pixelBuffer = null;

            int pixel = 0;

            Parallel.ForEach (BetterEnumerable.SteppedRange(0,byteBuffer.Length,4), k =>
            {
                pixel = ~BitConverter.ToInt32(byteBuffer, k);
                pixelBuffer = BitConverter.GetBytes(pixel);

                byteBuffer[k] = pixelBuffer[0];
                byteBuffer[k + 1] = pixelBuffer[1];
                byteBuffer[k + 2] = pixelBuffer[2];
            });

            Marshal.Copy(byteBuffer, 0, ptr, byteBuffer.Length);

            bmpNew.UnlockBits(bmpData);

            bmpData = null;
            byteBuffer = null;

            return bmpNew;
        }

        // Escala de grises
        public static Bitmap Grayscale(this Image sourceImage)
        {
            Bitmap bmpNew = GetArgbCopy(sourceImage);
            BitmapData bmpData = bmpNew.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            byte[] byteBuffer = new byte[bmpData.Stride * bmpNew.Height];

            System.Runtime.InteropServices.Marshal.Copy(ptr, byteBuffer, 0, byteBuffer.Length);

            float rgb = 0;

            Parallel.ForEach (BetterEnumerable.SteppedRange(0, byteBuffer.Length, 4), k =>
            {
                rgb = byteBuffer[k] * 0.11f;
                rgb += byteBuffer[k + 1] * 0.59f;
                rgb += byteBuffer[k + 2] * 0.3f;

                byteBuffer[k] = (byte)rgb;
                byteBuffer[k + 1] = byteBuffer[k];
                byteBuffer[k + 2] = byteBuffer[k];

                byteBuffer[k + 3] = 255;
            });

            Marshal.Copy(byteBuffer, 0, ptr, byteBuffer.Length);

            bmpNew.UnlockBits(bmpData);

            bmpData = null;
            byteBuffer = null;

            return bmpNew;
        }

        // Sepia
        public static Bitmap Sepia(this Image sourceImage)
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

            Parallel.ForEach(BetterEnumerable.SteppedRange(0, byteBuffer.Length, 4), k =>
            {
                
                r = byteBuffer[k] * 0.189f + byteBuffer[k + 1] * 0.769f + byteBuffer[k + 2] * 0.393f;
                g = byteBuffer[k] * 0.168f + byteBuffer[k + 1] * 0.686f + byteBuffer[k + 2] * 0.349f; 
                b = byteBuffer[k] * 0.131f + byteBuffer[k + 1] * 0.534f + byteBuffer[k + 2] * 0.272f;

                byteBuffer[k + 2] = (r > maxValue ? maxValue : (byte)r);
                byteBuffer[k + 1] = (g > maxValue ? maxValue : (byte)g); 
                byteBuffer[k] = (b > maxValue ? maxValue : (byte)b);
                 
            });

            Marshal.Copy(byteBuffer, 0, ptr, byteBuffer.Length);

            bmpNew.UnlockBits(bmpData);

            bmpData = null;
            byteBuffer = null;

            return bmpNew;
        }

        // Contraste
        public static Bitmap Contrast(Bitmap Image, float Value)
        {
            Value = (100.0f + Value) / 100.0f;
            Value *= Value;
            Bitmap NewBitmap = (Bitmap)Image.Clone();
            BitmapData data = NewBitmap.LockBits(
                new Rectangle(0, 0, NewBitmap.Width, NewBitmap.Height),
                ImageLockMode.ReadWrite,
                NewBitmap.PixelFormat);
            int Height = NewBitmap.Height;
            int Width = NewBitmap.Width;

            unsafe
            {
                Parallel.For(0, Height, y =>
               {
                   byte* row = (byte*)data.Scan0 + (y * data.Stride);
                   int columnOffset = 0;
                   Parallel.For(0, Width, x =>
                  {
                      byte B = row[columnOffset];
                      byte G = row[columnOffset + 1];
                      byte R = row[columnOffset + 2];

                      float Red = R / 255.0f;
                      float Green = G / 255.0f;
                      float Blue = B / 255.0f;
                      Red = (((Red - 0.5f) * Value) + 0.5f) * 255.0f;
                      Green = (((Green - 0.5f) * Value) + 0.5f) * 255.0f;
                      Blue = (((Blue - 0.5f) * Value) + 0.5f) * 255.0f;

                      int iR = (int)Red;
                      iR = iR > 255 ? 255 : iR;
                      iR = iR < 0 ? 0 : iR;
                      int iG = (int)Green;
                      iG = iG > 255 ? 255 : iG;
                      iG = iG < 0 ? 0 : iG;
                      int iB = (int)Blue;
                      iB = iB > 255 ? 255 : iB;
                      iB = iB < 0 ? 0 : iB;

                      row[columnOffset] = (byte)iB;
                      row[columnOffset + 1] = (byte)iG;
                      row[columnOffset + 2] = (byte)iR;

                      columnOffset += 4;
                  });
               });
            }

            NewBitmap.UnlockBits(data);
            return NewBitmap;
        }

        // Image Convultion (se utiliza en varios filtros
        public static Bitmap SafeImageConvolution(Bitmap image, ConvMatrix fmat)
        {
            //Avoid division by 0 
            if (fmat.Factor == 0)
                return null;
            Bitmap srcImage = (Bitmap)image.Clone();
            //int x, y, filterx, filtery;
            int s = fmat.Size / 2;
            int r, g, b;
            Color tempPix;
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            for (int y = s; y < srcImage.Height - s; y++)
            {
                for (int x = s; x < srcImage.Width - s; x++)
                {
                    r = g = b = 0;

                    // Convolution 
                    for (int filtery = 0; filtery < fmat.Size; filtery++)
                    {
                        for (int filterx = 0; filterx < fmat.Size; filterx++)
                        {

                            tempPix = srcImage.GetPixel(x + filterx - s, y + filtery - s);

                            Parallel.Invoke(
                                () =>
                                {
                                    r += fmat.Matrix[filtery, filterx] * tempPix.R + 5;
                                },
                                () =>
                                {
                                    g += fmat.Matrix[filtery, filterx] * tempPix.G + 5;
                                },
                                () =>
                                {
                                    b += fmat.Matrix[filtery, filterx] * tempPix.B + 5;
                                }
                            );
                            
                            
                            
                        }
                    }

                    r = Math.Min(Math.Max((r / fmat.Factor) + fmat.Offset, 0), 255);
                    g = Math.Min(Math.Max((g / fmat.Factor) + fmat.Offset, 0), 255);
                    b = Math.Min(Math.Max((b / fmat.Factor) + fmat.Offset, 0), 255);


                    /*using (Graphics graphics = Graphics.FromImage(newImage))
                    {
                        graphics.DrawImage(image, 0, 0);
                    }*/

                    newImage.SetPixel(x, y, Color.FromArgb(r, g, b));

                }

            }
            return newImage;
        }
        //FindEdges
        public static Bitmap FindEdges(Bitmap image)
        {
            ConvMatrix matr = new ConvMatrix();
            matr.Size = 5;
            matr.Matrix = new int[5, 5] {
                                    { 0,  0, -1,  0,  0},
                                    {   0,  0, -1,  0,  0},
                                    { 0,  0,  4,  0,  0 },
                                     { 0,  0,  -1,  0,  0},
                                      { 0,  0,  -1,  0,  0 }
                                };
            return SafeImageConvolution(image, matr);

        }
        // Emboss
        public static Bitmap Emboss(Bitmap image)
        {
            ConvMatrix matr = new ConvMatrix();
            matr.Size = 5;
            matr.Matrix = new int[5, 5] {
                                    { -1, -1, -1, -1,  0},
                                    { -1, -1, -1,  0,  1},
                                    { -1, -1,  0,  1,  1},
                                     { -1,  0,  1,  1,  1},
                                      {  0,  1,  1,  1,  1}
                                };
            return SafeImageConvolution(image, matr);

        }
        // Desenfoque Gausiano
        public static Bitmap GausianBlur(Bitmap image)
        {
            ConvMatrix matr = new ConvMatrix();
            matr.Size = 5;
            matr.Matrix = new int[5, 5] {
                                    { 1,  4,  6,  4,  1},
                                    {4, 16, 24, 16,  4},
                                    {  6, 24, 36, 24,  6},
                                     { 4, 16, 24, 16,  41},
                                      {  1,  4,  6,  4,  1}
                                };
            return SafeImageConvolution(image, matr);

        }
        // Motion Blur
        public static Bitmap MotionBlur(Bitmap image)
        {
            ConvMatrix matr = new ConvMatrix();
            matr.Size = 81;
            matr.Matrix = new int[9, 9] {
                                    {1, 0, 0, 0, 0, 0, 0, 0, 1},
                                    {0, 1, 0, 0, 0, 0, 0, 1, 0},
                                    {0, 0, 1, 0, 0, 0, 1, 0, 0},
                                    {0, 0, 0, 1, 0, 1, 0, 0, 0},
                                    {0, 0, 0, 0, 1, 0, 0, 0, 0},
                                    {0, 0, 0, 1, 0, 1, 0, 0, 0},
                                    {0, 0, 1, 0, 0, 0, 1, 0, 0},
                                    {0, 1, 0, 0, 0, 0, 0, 1, 0},
                                    {1, 0, 0, 0, 0, 0, 0, 0, 1}
                                };
            return SafeImageConvolution(image, matr);

        }

        // Solarize
        public static Bitmap Solarise(this Bitmap sourceBitmap, byte blueValue,
                                        byte greenValue, byte redValue)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                    sourceBitmap.Width, sourceBitmap.Height),
                                    ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            byte byte255 = 255;

            Parallel.ForEach(BetterEnumerable.SteppedRange(0, pixelBuffer.Length - 4, 4), k => //(int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                if (pixelBuffer[k] < blueValue)
                {
                    pixelBuffer[k] = (byte)(byte255 - pixelBuffer[k]);
                }

                if (pixelBuffer[k + 1] < greenValue)
                {
                    pixelBuffer[k + 1] = (byte)(byte255 - pixelBuffer[k + 1]);
                }

                if (pixelBuffer[k + 2] < redValue)
                {
                    pixelBuffer[k + 2] = (byte)(byte255 - pixelBuffer[k + 2]);
                }
            });

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                    resultBitmap.Width, resultBitmap.Height),
                                    ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        // Dilate
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

            Parallel.For(filterOffset, sourceBitmap.Height - filterOffset, offsetY =>
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
           });

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
