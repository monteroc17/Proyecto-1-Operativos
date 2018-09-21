/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Net;

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
        private void temporizador_Tick(object sender, EventArgs e)
        {
            cont++;
            lblTimeTaken.Text = cont.ToString();
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
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
            foreach (var filename in files)
            {
                Bitmap bmp = null;
                bmp = new Bitmap(filename.path.ToString());
                Image i = (Image)bmp;
                try
                {
                    if (rdGrayscaleBits.Checked == true)
                    {
                        if (cmbMethods.SelectedItem.ToString() == "Secuencial")
                        {
                            bmp = ExtBitmap.CopyAsGrayscale(i);
                        }
                        if(cmbMethods.SelectedItem.ToString() == "Paralelo")
                        {
                            if(bandera)
                            {
                                Console.WriteLine(files[0].path.ToString());
                                Console.WriteLine(files[1].path.ToString());
                                Bitmap primeraImagen = null;
                                primeraImagen = new Bitmap(files[0].path.ToString());
                                Bitmap segundaImagen = null;
                                segundaImagen = new Bitmap(files[1].path.ToString());
                                Bitmap respuesta =Clusters.UnirImagen(primeraImagen,segundaImagen);
                                saveImage(respuesta, path, filename.format, counta);
                                counta++;
                                bandera=false;
                            }
                        }
                        if (cmbMethods.SelectedItem.ToString() == "Clusters")
                        {
                            Bitmap[] lista=Clusters.trocearImagen(bmp);
                            for(int x = 0; x < lista.Length; x++)
                            {
                                saveImage(lista[x], path, filename.format,counta);
                                counta++;
                            }
                        }
                        if(cmbMethods.SelectedItem.ToString() != "Clusters")
                        {
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                    }
                    else if (rdFindEdges.Checked == true)
                    {
                        bmp = ExtBitmap.FindEdges(bmp);
                        Console.WriteLine(bmp);
                        saveImage(bmp, path, filename.format, counta);
                        counta++;
                    }
                    else if (rdGausianBlur.Checked == true)
                    {
                        bmp = ExtBitmap.GausianBlur(bmp);
                        saveImage(bmp, path, filename.format, counta);
                        counta++;
                    }
                    else if (rdTransparencyBits.Checked == true)
                    {
                        bmp = ExtBitmap.CopyWithTransparency(i);
                        Console.WriteLine(bmp);
                        saveImage(bmp, path, filename.format, counta);
                        counta++;
                    }
                    else if (rdEmboss.Checked == true)
                    {
                        bmp = ExtBitmap.Emboss(bmp);
                        saveImage(bmp, path, filename.format, counta);
                        counta++;

                    }
                    else if (rdNegativeBits.Checked == true)
                    {
                        bmp = ExtBitmap.CopyAsNegative(i);
                        Console.WriteLine(bmp);
                        saveImage(bmp, path, filename.format, counta);
                        counta++;

                    }
                    else if (rdSepiaBits.Checked == true)
                    {
                        bmp = ExtBitmap.CopyAsSepiaTone(i);
                        Console.WriteLine(bmp);
                        saveImage(bmp, path, filename.format, counta);
                        counta++;
                    }
                    else if (rdMotionBlur.Checked == true)
                    {
                        bmp = ExtBitmap.MotionBlur(bmp);
                        saveImage(bmp,path, filename.format,counta);
                        counta++;

                    }
                    else if (rdtexture.Checked == true)
                    {
                        bmp = ExtBitmap.texture(bmp);
                        saveImage(bmp, path, filename.format, counta);
                        counta++;

                    }
                }
                catch (Exception ex)
                {
                    // remove this if you don't want to see the exception message
                    MessageBox.Show(ex.Message);
                    continue;
                }
            }
            lblTimeTaken.Text = "Proceso terminado.\nTiempo de ejecución: " + cont +"ms";
            temporizador.Stop();
        }
        /// <summary>
        /// Request a al web service
        /// </summary>
        /// <param name="url"></param>
        /// <param name="post"></param>
        /// <param name="refer"></param>
        /// <returns></returns>
        public string HttpPost(string url, string post, string refer = "")
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

        public static void POST(string url, JSON data, JSONRequestCompleteEvent callback)
        {
            WebClient wc = new WebClient();
            string rdata = "";
            foreach (string key in data.Keys)
            {
                rdata += key + "=" + data[key] + "&";
            }
            postCompleteEvent = callback;
            wc.UploadStringCompleted += new UploadStringCompletedEventHandler(wc_UploadStringCompleted);
            wc.Headers["Content-Type"] = "application/x-www-form-urlencoded";
            wc.Encoding = Encoding.UTF8;
            wc.UploadStringAsync(new Uri(url), "POST", rdata);
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
    }
}

        