using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Timers;
using System.Net;
using System.Net.Sockets;
using System.Collections.Specialized;
namespace BitmapFilters
{
    class Clusters
    { 

        /// <summary>
        /// Funcion que se encarga de partir una imagen en trozos
        /// </summary>
        /// <param name="sourceImage"></param>
        /// <returns></returns>
        public static Bitmap[]trocearImagen(Image sourceImage)
        {
            int filas = 2;
            int columnas = 1;
            int tamW = sourceImage.Width/columnas;
            int tamH = sourceImage.Height / filas;
            // El tamaño proporcional del ancho y alto
            // correspondientes a los trozos a usar
            int tamTrozoW = sourceImage.Width / columnas;
            int tamTrozoH = sourceImage.Height / filas;
            // El rectángulo de cada nuevo trozo
            Rectangle rectDest = new Rectangle(0, 0, tamW, tamH);
            // Estas variables se usan en el bucle
            Bitmap bmpDest;
            Graphics g;
            Rectangle rectOri;
            // Array con el número de pictures necesarias
            Bitmap[] trozos = new Bitmap[columnas * filas];
            // Para contar cada columna y fila
            int c = 0, f = 0;
            // La posición X e Y en la imagen original
            int pX = 0, pY = 0;
            for (int i = 0; i < trozos.Length; i++)
            {
                // El trozo de la imagen original
                rectOri = new Rectangle(pX, pY, tamTrozoW, tamTrozoH);
                // La imagen de destino
                bmpDest = new Bitmap(tamW, tamH);
                g = Graphics.FromImage(bmpDest);
                // Obtenemos un trozo de la imagen original
                // y lo dibujamos en la imagen de destino
                g.DrawImage(sourceImage, rectDest, rectOri, GraphicsUnit.Pixel);
               
                trozos[i] = bmpDest;
                //
                // Calculamos la posición del próximo trozo
                c += 1;
                pX += tamTrozoW;
                // Cuando hayamos recorrido las columnas,
                // pasamos a la siguiente fila
                if (c >= columnas)
                {
                    c = 0;
                    f += 1;
                    pX = 0;
                    pY += tamTrozoH;
                }
            }
            return trozos;
        }
        /// <summary>
        /// Funcion que se encarga de unir dos imagenes
        /// </summary>
        /// <param name="imagen1"></param>
        /// <param name="imagen2"></param>
        /// <returns></returns>
        public static Bitmap UnirImagen(Bitmap imagen1,Bitmap imagen2)
        {
            int width = imagen1.Width;
            int height = imagen2.Height * 2;
            Bitmap fullBmp = new Bitmap(width, height);
            Graphics gr = Graphics.FromImage(fullBmp);
            gr.DrawImage(imagen1, 0, 0, imagen1.Width,imagen1.Height);
            gr.DrawImage(imagen2, 0, imagen1.Height);
            Console.WriteLine("La unio con exito");
            return fullBmp;
        }
        /// <summary>
        /// Request a al web service
        /// </summary>
        /// <param name="url"></param>
        /// <param name="post"></param>
        /// <param name="refer"></param>
        /// <returns></returns>
        public static string HttpPost(string url, string post, string refer = "")
        {
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
            //request.CookieContainer = cJar;
            //request.UserAgent = UserAgent;
            request.KeepAlive = false;
            request.Method = "POST";
            request.Referer = refer;
            byte[] postBytes = Encoding.ASCII.GetBytes(post);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postBytes.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(postBytes, 0, postBytes.Length);
            requestStream.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return sr.ReadToEnd();
        }
        public static string HttpPostWebClientContraste(string url, string cantidadC,string tipoF,string img)
        {
            var client = new WebClient();
            var values = new NameValueCollection();
            values["cantidadContraste"] =cantidadC;
            values["tipoFiltro"] = tipoF;
            values["image"] = img;
            var response = client.UploadValues(url, values);
            var responseString = Encoding.Default.GetString(response);
            return responseString;
        }
        public static string HttpPostWebClient(string url,string tipoF, string img)
        {
            var client = new WebClient();
            var values = new NameValueCollection();
            values["tipoFiltro"] = tipoF;
            values["image"] = img;
            var response = client.UploadValues(url, values);
            var responseString = Encoding.Default.GetString(response);
            return responseString;
        }
        
    }

}
