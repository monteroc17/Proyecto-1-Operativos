using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using WebService_ImageFIlter.Models.Filters;

namespace WebService_ImageFIlter.Models
{
    public class FilterMethods
    {

        public string applyFilter(ImageFilterClass imageToFilter)
        {
            byte[] imageBytes = Convert.FromBase64String(imageToFilter.image);
            Image image;            

            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                image = Image.FromStream(ms, true);
                
                Bitmap result = applyFilterAux(imageToFilter, image);//
                return encodeBase64String(result);
            }
        }

        private Bitmap applyFilterAux(ImageFilterClass imgFilterClass, Image img)
        {
            Bitmap bmp  = new Bitmap(img);
            switch (imgFilterClass.tipoFiltro)
            {
                case "contrast":
                    return ContrastFilter.Contrast(bmp, imgFilterClass.cantidadContraste);
                case "grayscale":
                    return GrayScaleFilter.Grayscale(img);
                case "transparency":
                    return TransparencyFilter.Transparency(img);
                case "findEdges":
                    return FindEdgesFilter.FindEdgesMethod(bmp);
                case "emboss":
                    return EmbossFilter.EmbossMethod(bmp);
                case "negative":
                    return NegativeFilter.Negative(img);
                case "sepia":
                    return SepiaFilter.SepiaTone(img);
                case "motionBlur":
                    return MotionBlurFilter.MotionBlur(bmp);
                case "solarise":
                    return SolariseFilter.Solarise(bmp, 150, 50, 250);
                case "dilatation":
                    return DilatationFilter.Dilate(bmp, 17, false, true, true);
                default:
                    return ContrastFilter.Contrast(bmp, imgFilterClass.cantidadContraste);
            }
        }

        private string decodeBase64String(string base64Image)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(base64Image));
        } 

        private string encodeBase64String(Bitmap bitMapImage)
        {
            using (var ms = new MemoryStream())
            {
                using (var bitmap = new Bitmap(bitMapImage))
                {
                    bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return Convert.ToBase64String(ms.GetBuffer()); //Get Base64
                }
            }
        }
    }
}