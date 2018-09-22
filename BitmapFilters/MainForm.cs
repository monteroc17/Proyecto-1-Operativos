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
        Thread t;//Hilo para saber cuando se devolvieron las dos imagenes
       
        public MainForm()
        {
            t = new Thread(unirImagenes);
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
           /* if(cmbMetodo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un método", "Error");
                return;
            }*/
            lblTiempoTitle.Text = "Ejecutando...";
            btnStart.Enabled = false;
            string path = Directory.GetCurrentDirectory();
            String[] exts = { "*.png","*.bmp","*.jpg" };
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
            Boolean bandera = true;
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
                        }
                        if (cmbMethods.SelectedItem.ToString() == "Paralelo")
                        {
                            if (bandera)
                            {
                                Console.WriteLine(files[0].path.ToString());
                                Console.WriteLine(files[1].path.ToString());
                                Bitmap primeraImagen = null;
                                primeraImagen = new Bitmap(files[0].path.ToString());
                                Bitmap segundaImagen = null;
                                segundaImagen = new Bitmap(files[1].path.ToString());
                                Bitmap respuesta = Clusters.UnirImagen(primeraImagen, segundaImagen);
                                saveImage(respuesta, path, filename.format, counta);
                                counta++;
                                bandera = false;
                            }
                        }
                        if (cmbMethods.SelectedItem.ToString() == "Clusters")
                        {
                            Bitmap[] lista = Clusters.trocearImagen(bmp);

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
                            //t.Start();
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
                            Bitmap imagenUnida=Clusters.UnirImagen(result1, result2);
                            saveImage(imagenUnida,path,filename.format,counta);
                            counta++;
                        }
                    }
                    else if (rdFindEdges.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.FindEdges(bmp);
                            Console.WriteLine(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                        else if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.FindEdges(bmp);
                            Console.WriteLine(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }

                    }
                    else if (rdGausianBlur.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.GausianBlur(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                        else if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.GausianBlur(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }

                    }
                    else if (rdTransparency.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.Transparency(i);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                        else if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.Transparency(i);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }

                    }
                    else if (rdEmboss.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.Emboss(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                        else if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.Emboss(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }

                    }
                    else if (rdAjusteBrillo.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.Contrast(bmp,valueBar1.Value);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                        else if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.Contrast(bmp, valueBar1.Value);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                    }
                    else if (rdNegative.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.Negative(i);
                            Console.WriteLine(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                        else if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.Negative(i);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                    }
                    else if (rdSepia.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.Sepia(i);
                            Console.WriteLine(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                        else if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.Sepia(i);
                            Console.WriteLine(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }

                    }
                    else if (rdMotionBlur.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.MotionBlur(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                        else if (cmbMethods.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.MotionBlur(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }

                    }
                    else if (rdtexture.Checked == true)
                    {
                        bmp = SequentialFilters.Transparency(bmp);
                        saveImage(bmp, path, filename.format, counta);
                        counta++;
                    }
                    else if (rdCompPerdida.Checked == true)
                    {
                        Compression c = new Compression();
                        c.SaveJpg(bmp, filename.format, 2);
                    }
                    else if (rdSolarise.Checked == true)
                    {
                        if (cmbMetodo.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.Solarise(bmp, 150, 50, 250);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                        else if (cmbMetodo.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.Solarise(bmp, 150, 50, 250);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                    }
                    else if (rdDilatacion.Checked == true)
                    {
                        if (cmbMetodo.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = SequentialFilters.Dilate(bmp, 17, false, true, true);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                        else if (cmbMetodo.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.Dilate(bmp, 17, false, true, true);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
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
        /// <returns></returns>
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
        }/// <summary>
        /// Funcion para unir dos imagenes
        /// </summary>
        public void unirImagenes()
        {
            t.Abort();
        }/// <summary>
        /// Convierte de imagen a base 64
        /// </summary>
        /// <param name="image"></param>
        /// <param name="format"></param>
        /// <returns></returns>
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
        /// <param name="base64String"></param>
        /// <returns></returns>
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
        
    }
}

        