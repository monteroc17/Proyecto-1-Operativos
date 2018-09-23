using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Net;
using System.Diagnostics;
using System.Drawing.Imaging;

using System.Threading;
using System.Threading.Tasks;
namespace BitmapFilters
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void OnCheckChangedEventHandler(object sender, EventArgs e)
        {

            
        }
        delegate void StringArgReturningVoidDelegate(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lblTimeTaken.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lblTimeTaken.Text = text;
            }
        }
        /// <summary>
        /// Allows to detect which radiobutton was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WhichRBWasClicked(Object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                //RadioButton rb = (RadioButton)sender;
                btnStart.Enabled = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            

            for (int index = 0; index < Environment.ProcessorCount; index++)
            {
                cmbCores.Items.Add(index + 1);
            }
            cmbMethods.Items.Add("Secuencial");
            cmbMethods.Items.Add("Paralelo");
            cmbMethods.Items.Add("Clusters");

        }
        int cont = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            lblTiempoTitle.Text = "Ejecutando...";
            btnStart.Enabled = false;
            string path = Directory.GetCurrentDirectory();
            String[] exts = { "*.png","*.bmp","*.jpg","*.tif" };
            List<Img> files = new List<Img>();
            foreach (string ext in exts)
            {
                string[] filePaths1 = Directory.GetFiles(path + "/images", ext);
                foreach(var fn in filePaths1)
                {
                    Img img = new Img();
                    img.path = fn;
                    img.format = ext;
                    files.Add(img);
                }
            }
            
            int counta = 0;
            temporizador.Start();//starts the timer
            Stopwatch timer = Stopwatch.StartNew();
            foreach (var filename in files)
            {
                Bitmap bmp = null;
                bmp = new Bitmap(filename.path.ToString());
                Image i = (Image)bmp;
                try
                {
                    if (rdGrayscale.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString() == "Secuencial")
                        {
                            bmp = SequentialFilters.Grayscale(i);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString() == "Paralelo")
                        {
                            bmp = ParallelFilters.Grayscale(i);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString() == "Clusters")
                        {
                            Bitmap[] lista = Clusters.TrocearImagen(bmp);
                            string base64String = ImageToBase64(lista[0], devuelveFormato(filename.format));
                            string base64String1 = ImageToBase64(lista[1],devuelveFormato(filename.format));
                            string imagen1 = "";
                            string imagen2 = "";
                            Parallel.Invoke(() =>
                            {
                                imagen1= Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter","grayscale",base64String);
                            },  // close first Action
                             () =>
                             {
                                 imagen2=Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "grayscale", base64String1);
                             });
                            while(true)
                            {
                                if (imagen1 != "" && imagen2 != "")
                                {
                                    Console.WriteLine("Entro");
                                    break;
                                }
                            }
                            imagen1 = imagen1.Substring(1, imagen1.Length - 2);
                            imagen2 = imagen2.Substring(1, imagen2.Length - 2);
                            Image imagenresult1 = Base64ToImage(imagen1);
                            Image imagenresult2 = Base64ToImage(imagen2);
                            Bitmap result1 = (Bitmap)imagenresult1;
                            Bitmap result2 = (Bitmap)imagenresult2;
                            bmp=Clusters.UnirImagen(result1, result2);
                            counta++;

                        }
                        saveImage(bmp, path, filename.format,counta);
                    }
                    else if (rdFindEdges.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.FindEdges(bmp);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.FindEdges(bmp);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString() == "Clusters")
                        {
                            Bitmap[] lista = Clusters.TrocearImagen(bmp);
                            string base64String = ImageToBase64(lista[0], devuelveFormato(filename.format));
                            string base64String1 = ImageToBase64(lista[1], devuelveFormato(filename.format));
                            string imagen1 = "";
                            string imagen2 = "";
                            Parallel.Invoke(() =>
                            {
                                imagen1 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "findEdges", base64String);
                            },  // close first Action
                             () =>
                             {
                                 imagen2 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "findEdges", base64String1);
                             });
                            while (true)
                            {
                                if (imagen1 != "" && imagen2 != "")
                                {
                                    break;
                                }
                            }
                            imagen1 = imagen1.Substring(1, imagen1.Length - 2);
                            imagen2 = imagen2.Substring(1, imagen2.Length - 2);
                            Image imagenresult1 = Base64ToImage(imagen1);
                            Image imagenresult2 = Base64ToImage(imagen2);
                            Bitmap result1 = (Bitmap)imagenresult1;
                            Bitmap result2 = (Bitmap)imagenresult2;
                            bmp = Clusters.UnirImagen(result1, result2);
                            counta++;
                        }
                        saveImage(bmp, path, filename.format, counta);

                    }
                    else if (rdGausianBlur.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.GausianBlur(bmp);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.GausianBlur(bmp);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString().Equals("Clusters"))
                        {
                            Bitmap[] lista = Clusters.TrocearImagen(bmp);
                            string base64String = ImageToBase64(lista[0], devuelveFormato(filename.format));
                            string base64String1 = ImageToBase64(lista[1], devuelveFormato(filename.format));
                            string imagen1 = "";
                            string imagen2 = "";
                            Parallel.Invoke(() =>
                            {
                                imagen1 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "motionBlur", base64String);
                            },  // close first Action
                             () =>
                             {
                                 imagen2 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "motionBlur", base64String1);
                             });
                            while (true)
                            {
                                if (imagen1 != "" && imagen2 != "")
                                {
                                    Console.WriteLine("Entro");
                                    break;
                                }
                            }
                            imagen1 = imagen1.Substring(1, imagen1.Length - 2);
                            imagen2 = imagen2.Substring(1, imagen2.Length - 2);
                            Image imagenresult1 = Base64ToImage(imagen1);
                            Image imagenresult2 = Base64ToImage(imagen2);
                            Bitmap result1 = (Bitmap)imagenresult1;
                            Bitmap result2 = (Bitmap)imagenresult2;
                            bmp = Clusters.UnirImagen(result1, result2);
                            counta++;
                        }
                        saveImage(bmp, path, filename.format, counta);

                    }
                    else if (rdTransparency.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.Transparency(i);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.Transparency(i);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString().Equals("Clusters"))
                        {
                            Bitmap[] lista = Clusters.TrocearImagen(bmp);
                            string base64String = ImageToBase64(lista[0], devuelveFormato(filename.format));
                            string base64String1 = ImageToBase64(lista[1], devuelveFormato(filename.format));
                            string imagen1 = "";
                            string imagen2 = "";
                            Parallel.Invoke(() =>
                            {
                                imagen1 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "transparency", base64String);
                            },  // close first Action
                             () =>
                             {
                                 imagen2 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "transparency", base64String1);
                             });
                            while (true)
                            {
                                if (imagen1 != "" && imagen2 != "")
                                {
                                    Console.WriteLine("Entro");
                                    break;
                                }
                            }
                            imagen1 = imagen1.Substring(1, imagen1.Length - 2);
                            imagen2 = imagen2.Substring(1, imagen2.Length - 2);
                            Image imagenresult1 = Base64ToImage(imagen1);
                            Image imagenresult2 = Base64ToImage(imagen2);
                            Bitmap result1 = (Bitmap)imagenresult1;
                            Bitmap result2 = (Bitmap)imagenresult2;
                            bmp = Clusters.UnirImagen(result1, result2);
                            counta++;
                        }
                        saveImage(bmp, path, filename.format, counta);

                    }
                    else if (rdEmboss.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.Emboss(bmp);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.Emboss(bmp);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString().Equals("Clusters"))
                        {
                            Bitmap[] lista = Clusters.TrocearImagen(bmp);
                            string base64String = ImageToBase64(lista[0], devuelveFormato(filename.format));
                            string base64String1 = ImageToBase64(lista[1], devuelveFormato(filename.format));
                            string imagen1 = "";
                            string imagen2 = "";
                            Parallel.Invoke(() =>
                            {
                                imagen1 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "emboss", base64String);
                            },  // close first Action
                             () =>
                             {
                                 imagen2 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "emboss", base64String1);
                             });
                            while (true)
                            {
                                if (imagen1 != "" && imagen2 != "")
                                {
                                    Console.WriteLine("Entro");
                                    break;
                                }
                            }
                            imagen1 = imagen1.Substring(1, imagen1.Length - 2);
                            imagen2 = imagen2.Substring(1, imagen2.Length - 2);
                            Image imagenresult1 = Base64ToImage(imagen1);
                            Image imagenresult2 = Base64ToImage(imagen2);
                            Bitmap result1 = (Bitmap)imagenresult1;
                            Bitmap result2 = (Bitmap)imagenresult2;
                            bmp = Clusters.UnirImagen(result1, result2);
                            counta++;
                        }
                        saveImage(bmp, path, filename.format, counta);

                    }
                    else if (rdAjusteBrillo.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.Contrast(bmp,valueBar1.Value);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.Contrast(bmp, valueBar1.Value);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString().Equals("Clusters"))
                        {
                            Bitmap[] lista = Clusters.TrocearImagen(bmp);
                            string base64String = ImageToBase64(lista[0], devuelveFormato(filename.format));
                            string base64String1 = ImageToBase64(lista[1], devuelveFormato(filename.format));
                            string imagen1 = "";
                            string imagen2 = "";
                            string valorBrillo = valueBar1.Value.ToString();
                            Parallel.Invoke(() =>
                            {

                                imagen1 = Clusters.HttpPostWebClientContraste("http://25.6.85.182:80/WSImageFilter/ApplyFilter",valorBrillo, "contrast", base64String);
                            },  // close first Action
                             () =>
                             {
                                 imagen2 = Clusters.HttpPostWebClientContraste("http://25.6.85.182:80/WSImageFilter/ApplyFilter", valorBrillo, "contrast", base64String1);
                             });
                            while (true)
                            {
                                if (imagen1 != "" && imagen2 != "")
                                {
                                    Console.WriteLine("Entro");
                                    break;
                                }
                            }
                            imagen1 = imagen1.Substring(1, imagen1.Length - 2);
                            imagen2 = imagen2.Substring(1, imagen2.Length - 2);
                            Image imagenresult1 = Base64ToImage(imagen1);
                            Image imagenresult2 = Base64ToImage(imagen2);
                            Bitmap result1 = (Bitmap)imagenresult1;
                            Bitmap result2 = (Bitmap)imagenresult2;
                            bmp = Clusters.UnirImagen(result1, result2);
                            counta++;
                        }
                        saveImage(bmp, path, filename.format, counta);
                    }
                    else if (rdNegative.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.Negative(i);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.Negative(i);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString().Equals("Clusters"))
                        {
                            Bitmap[] lista = Clusters.TrocearImagen(bmp);
                            string base64String = ImageToBase64(lista[0], devuelveFormato(filename.format));
                            string base64String1 = ImageToBase64(lista[1], devuelveFormato(filename.format));
                            string imagen1 = "";
                            string imagen2 = "";
                            Parallel.Invoke(() =>
                            {
                                imagen1 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "negative", base64String);
                            },  // close first Action
                             () =>
                             {
                                 imagen2 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "negative", base64String1);
                             });
                            while (true)
                            {
                                if (imagen1 != "" && imagen2 != "")
                                {
                                    Console.WriteLine("Entro");
                                    break;
                                }
                            }
                            imagen1 = imagen1.Substring(1, imagen1.Length - 2);
                            imagen2 = imagen2.Substring(1, imagen2.Length - 2);
                            Image imagenresult1 = Base64ToImage(imagen1);
                            Image imagenresult2 = Base64ToImage(imagen2);
                            Bitmap result1 = (Bitmap)imagenresult1;
                            Bitmap result2 = (Bitmap)imagenresult2;
                            bmp = Clusters.UnirImagen(result1, result2);
                            counta++;
                        }
                        saveImage(bmp, path, filename.format, counta);
                    }
                    else if (rdSepia.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.Sepia(i);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.Sepia(i);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString().Equals("Clusters"))
                        {
                            Bitmap[] lista = Clusters.TrocearImagen(bmp);
                            string base64String = ImageToBase64(lista[0], devuelveFormato(filename.format));
                            string base64String1 = ImageToBase64(lista[1], devuelveFormato(filename.format));
                            string imagen1 = "";
                            string imagen2 = "";
                            Parallel.Invoke(() =>
                            {
                                imagen1 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "sepia", base64String);
                            },  // close first Action
                             () =>
                             {
                                 imagen2 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "sepia", base64String1);
                             });
                            while (true)
                            {
                                if (imagen1 != "" && imagen2 != "")
                                {
                                    Console.WriteLine("Entro");
                                    break;
                                }
                            }
                            imagen1 = imagen1.Substring(1, imagen1.Length - 2);
                            imagen2 = imagen2.Substring(1, imagen2.Length - 2);
                            Image imagenresult1 = Base64ToImage(imagen1);
                            Image imagenresult2 = Base64ToImage(imagen2);
                            Bitmap result1 = (Bitmap)imagenresult1;
                            Bitmap result2 = (Bitmap)imagenresult2;
                            bmp = Clusters.UnirImagen(result1, result2);
                            counta++;
                        }
                        saveImage(bmp, path, filename.format, counta);
                    }
                    else if (rdMotionBlur.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.MotionBlur(bmp);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.MotionBlur(bmp);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString().Equals("Clusters"))
                        {
                            Bitmap[] lista = Clusters.TrocearImagen(bmp);
                            string base64String = ImageToBase64(lista[0], devuelveFormato(filename.format));
                            string base64String1 = ImageToBase64(lista[1], devuelveFormato(filename.format));
                            string imagen1 = "";
                            string imagen2 = "";
                            Parallel.Invoke(() =>
                            {
                                imagen1 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "motionBlur", base64String);
                            },  // close first Action
                             () =>
                             {
                                 imagen2 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "motionBlur", base64String1);
                             });
                            while (true)
                            {
                                if (imagen1 != "" && imagen2 != "")
                                {
                                    Console.WriteLine("Entro");
                                    break;
                                }
                            }
                            imagen1 = imagen1.Substring(1, imagen1.Length - 2);
                            imagen2 = imagen2.Substring(1, imagen2.Length - 2);
                            Image imagenresult1 = Base64ToImage(imagen1);
                            Image imagenresult2 = Base64ToImage(imagen2);
                            Bitmap result1 = (Bitmap)imagenresult1;
                            Bitmap result2 = (Bitmap)imagenresult2;
                            bmp = Clusters.UnirImagen(result1, result2);
                            counta++;
                        }
                        saveImage(bmp, path, filename.format, counta);

                    }
                    else if (rdSolarized.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.Solarise(bmp, 150, 50, 250);
                            counta++;
                        }
                        else if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.Solarise(bmp, 150, 50, 250);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString().Equals("Clusters"))
                        {
                            Bitmap[] lista = Clusters.TrocearImagen(bmp);
                            string base64String = ImageToBase64(lista[0], devuelveFormato(filename.format));
                            string base64String1 = ImageToBase64(lista[1], devuelveFormato(filename.format));
                            string imagen1 = "";
                            string imagen2 = "";
                            Parallel.Invoke(() =>
                            {
                                imagen1 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "solarise", base64String);
                            },  // close first Action
                             () =>
                             {
                                 imagen2 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "solarise", base64String1);
                             });
                            while (true)
                            {
                                if (imagen1 != "" && imagen2 != "")
                                {
                                    Console.WriteLine("Entro");
                                    break;
                                }
                            }
                            imagen1 = imagen1.Substring(1, imagen1.Length - 2);
                            imagen2 = imagen2.Substring(1, imagen2.Length - 2);
                            Image imagenresult1 = Base64ToImage(imagen1);
                            Image imagenresult2 = Base64ToImage(imagen2);
                            Bitmap result1 = (Bitmap)imagenresult1;
                            Bitmap result2 = (Bitmap)imagenresult2;
                            bmp = Clusters.UnirImagen(result1, result2);
                            counta++;
                        }
                        saveImage(bmp, path, filename.format, counta);
                    }
                    else if (rdDilate.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.Dilate(bmp, 17, false, true, true);
                            counta++;
                        }
                        else if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.Dilate(bmp, 17, false, true, true);
                            counta++;
                        }
                        if (cmbMethods.SelectedItem.ToString().Equals("Clusters"))
                        {
                            Bitmap[] lista = Clusters.TrocearImagen(bmp);
                            string base64String = ImageToBase64(lista[0], devuelveFormato(filename.format));
                            string base64String1 = ImageToBase64(lista[1], devuelveFormato(filename.format));
                            string imagen1 = "";
                            string imagen2 = "";
                            Parallel.Invoke(() =>
                            {
                                imagen1 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "dilatation", base64String);
                            },  // close first Action
                             () =>
                             {
                                 imagen2 = Clusters.HttpPostWebClient("http://25.6.85.182:80/WSImageFilter/ApplyFilter", "dilatation", base64String1);
                             });
                            while (true)
                            {
                                if (imagen1 != "" && imagen2 != "")
                                {
                                    Console.WriteLine("Entro");
                                    break;
                                }
                            }
                            imagen1 = imagen1.Substring(1, imagen1.Length - 2);
                            imagen2 = imagen2.Substring(1, imagen2.Length - 2);
                            Image imagenresult1 = Base64ToImage(imagen1);
                            Image imagenresult2 = Base64ToImage(imagen2);
                            Bitmap result1 = (Bitmap)imagenresult1;
                            Bitmap result2 = (Bitmap)imagenresult2;
                            bmp = Clusters.UnirImagen(result1, result2);
                            counta++;
                        }
                        saveImage(bmp, path, filename.format, counta);
                    }
                }
                catch (Exception ex)
                {
                    // remove this if you don't want to see the exception message
                    MessageBox.Show(ex.Message);
                    continue;
                }
            }
            lblTiempoTitle.Text = "Proceso terminado.\nTiempo de ejecución: " + timer.ElapsedMilliseconds +"ms";
            btnStart.Enabled = true;
        }
        /// <summary>
        /// Funcion que se encarga de devolver el formato en tipo ImageFormat
        /// </summary>
        /// <param name="formato"></param>
        /// <returns>el formato de la imagen</returns>
        public ImageFormat devuelveFormato(string formato)
        {
            if(formato== "*.png")
            {
                return ImageFormat.Png;
            }else if(formato== "*.jpg")
            {
                return ImageFormat.Jpeg;
            }
            else if(formato== "*.bmp")
            {
                return ImageFormat.Bmp;
            }
            return ImageFormat.Exif;
        }
        /// Convierte de imagen a base 64
        /// </summary>
        /// <param name="image">Imagen por convertir</param>
        /// <param name="format">formato de la imagen</param>
        /// <returns>una imagen en formato base64</returns>
        public string ImageToBase64(Bitmap image,System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }/// <summary>
        /// Convierte de base64 a imagen
        /// </summary>
        /// <param name="base64String">Nombre del objeto en base64</param>
        /// <returns>La imagen equivalente</returns>
        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        /// <summary>
        /// Guarda una imagen en la PC
        /// </summary>
        /// <param name="bmp">Imagen por guardar</param>
        /// <param name="path">ubicación donde guardar</param>
        /// <param name="format">formato de la imagen</param>
        /// <param name="counta">contador para saber cual imagen es</param>
        public void saveImage(Bitmap bmp,string path,string format,int counta)
        {
            
            Console.WriteLine(bmp);
            Image im = (Image)bmp;
            string carpeta = "\\outputimages\\";
            int len = format.Length - 1;
            string c_path = path + carpeta + "result" + counta +format.Substring(1, len);
            Console.WriteLine(c_path);
            im.Save(c_path);

        }
        private void rdGrayscaleBits_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTiempoTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblTimeTaken_Click(object sender, EventArgs e)
        {

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void turnBarOn(object sender, EventArgs e)
        {
            valueBar1.Visible = true;
            lblBarValueData.Visible = true;
        }

        private void valueBar_Scroll(object sender, EventArgs e)
        {
            lblBarValueData.Text = valueBar1.Value.ToString();
        }

        private void valueBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}

        