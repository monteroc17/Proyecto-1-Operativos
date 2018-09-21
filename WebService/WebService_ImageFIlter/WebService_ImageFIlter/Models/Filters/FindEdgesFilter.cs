using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WebService_ImageFIlter.Models.Filters
{
    public static class FindEdgesFilter
    {
        public static Bitmap FindEdgesMethod(Bitmap image)
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

        public static Bitmap SafeImageConvolution(Bitmap image, ConvMatrix fmat)
        {
            //Avoid division by 0 
            if (fmat.Factor == 0)
                return null;
            Bitmap srcImage = (Bitmap)image.Clone();
            int x, y, filterx, filtery;
            int s = fmat.Size / 2;
            int r, g, b;
            Color tempPix;
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            for (y = s; y < srcImage.Height - s; y++)
            {
                for (x = s; x < srcImage.Width - s; x++)
                {
                    r = g = b = 0;

                    // Convolution 
                    for (filtery = 0; filtery < fmat.Size; filtery++)
                    {
                        for (filterx = 0; filterx < fmat.Size; filterx++)
                        {

                            tempPix = srcImage.GetPixel(x + filterx - s, y + filtery - s);

                            r += fmat.Matrix[filtery, filterx] * tempPix.R + 5;
                            g += fmat.Matrix[filtery, filterx] * tempPix.G + 5;
                            b += fmat.Matrix[filtery, filterx] * tempPix.B + 5;
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
    }
}