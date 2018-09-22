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
                            MemoryStream memoryStream = new MemoryStream();
                            lista[0].Save(memoryStream, devuelveFormato(filename.format));
                            memoryStream.Position = 0;
                            byte[] byteBuffer = memoryStream.ToArray();
                            memoryStream.Close();
                            string base64String = Convert.ToBase64String(byteBuffer);


                            MemoryStream memoryStream1 = new MemoryStream();
                            lista[1].Save(memoryStream1, devuelveFormato(filename.format));
                            memoryStream1.Position = 0;
                            byte[] byteBuffer1 = memoryStream1.ToArray();
                            memoryStream1.Close();
                            string base64String1 = Convert.ToBase64String(byteBuffer);
                            string imagen1 = "";
                            string imagen2 = "";
                            /*
                            Parallel.Invoke(() =>
                            {
                                imagen1= Clusters.HttpPostWebClient("", "", base64String);
                                //Aun no se sabe que recibe
                            },  // close first Action

                             () =>
                             {
                                 imagen2=Clusters.HttpPostWebClient("", "", base64String1);
                             }); //close parallel.*/
                            /*for (int x = 0; x < lista.Length; x++)
                            {
                                saveImage(lista[x], path, filename.format, counta);
                                counta++;
                            }*/
                            string respusta = Clusters.HttpPostWebClientPrueba("http://172.24.65.31:8080/todosProductos", "prueba","sss");
                            Console.WriteLine(respusta);
                        }
                        if (cmbMethods.SelectedItem.ToString() != "Clusters")
                        {
                            saveImage(bmp, path, filename.format, counta);
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

        