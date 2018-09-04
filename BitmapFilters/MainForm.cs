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

            //OnCheckChangedEventHandler(sender, e);
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
            temporizador.Start();//starts the timer

            for (int index = 0; index < Environment.ProcessorCount; index++)
            {
                cmbCores.Items.Add(index + 1);
            }

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
            ArrayList files = new ArrayList();
            foreach (string ext in exts)
            {
                string[] filePaths1 = Directory.GetFiles(path + "/images", ext);
                foreach(var fn in filePaths1)
                {
                    files.Add(fn);
                }
                
            }
            string[] filePaths = (string[])files.ToArray(typeof(string));
            int counta = 0;
            foreach (var filename in filePaths)
            {
                Bitmap bmp = null;
                bmp = new Bitmap(filename.ToString());
                Image i = (Image)bmp;
                try
                {
                    if (rdGrayscaleBits.Checked == true)
                    {
                        Console.WriteLine("Entro a la funcion cccc");
                        bmp = ExtBitmap.CopyAsGrayscale(i);
                        Console.WriteLine(bmp);
                        Image im = (Image)bmp;
                        string carpeta= "\\outputimages\\";
                        string c_path =path+carpeta +"result"+counta+".jpg";
                        Console.WriteLine(c_path);
                        im.Save(c_path);
                        counta++;
                    }
                    else if (rdGrayscaleDraw.Checked == true)
                    {
                        bmp = ExtBitmap.DrawAsGrayscale(i);
                        Console.WriteLine(bmp);
                        Image im = (Image)bmp;
                        string carpeta = "\\outputimages\\";
                        string c_path = path + carpeta + "result" + counta + ".jpg";
                        Console.WriteLine(c_path);
                        im.Save(c_path);
                        counta++;
                    }
                    else if (rdTransparencyBits.Checked == true)
                    {
                        bmp = ExtBitmap.CopyWithTransparency(i);
                        Console.WriteLine(bmp);
                        Image im = (Image)bmp;
                        string carpeta = "\\outputimages\\";
                        string c_path = path + carpeta + "result" + counta + ".jpg";
                        Console.WriteLine(c_path);
                        im.Save(c_path);
                        counta++;
                    }
                    else if (rdTransparencyDraw.Checked == true)
                    {
                        bmp = ExtBitmap.DrawWithTransparency(i);
                        Console.WriteLine(bmp);
                        Image im = (Image)bmp;
                        string carpeta = "\\outputimages\\";
                        string c_path = path + carpeta + "result" + counta + ".jpg";
                        Console.WriteLine(c_path);
                        im.Save(c_path);
                        counta++;

                    }
                    else if (rdNegativeBits.Checked == true)
                    {
                        bmp = ExtBitmap.CopyAsNegative(i);
                        Console.WriteLine(bmp);
                        Image im = (Image)bmp;
                        string carpeta = "\\outputimages\\";
                        string c_path = path + carpeta + "result" + counta + ".jpg";
                        Console.WriteLine(c_path);
                        im.Save(c_path);
                        counta++;

                    }
                    else if (rdNegativeDraw.Checked == true)
                    {
                        bmp = ExtBitmap.DrawAsNegative(i);
                        Console.WriteLine(bmp);
                        Image im = (Image)bmp;
                        string carpeta = "\\outputimages\\";
                        string c_path = path + carpeta + "result" + counta + ".jpg";
                        Console.WriteLine(c_path);
                        im.Save(c_path);
                        counta++;
                    }
                    else if (rdSepiaBits.Checked == true)
                    {
                        bmp = ExtBitmap.CopyAsSepiaTone(i);
                        Console.WriteLine(bmp);
                        Image im = (Image)bmp;
                        string carpeta = "\\outputimages\\";
                        string c_path = path + carpeta + "result" + counta + ".jpg";
                        Console.WriteLine(c_path);
                        im.Save(c_path);
                        counta++;
                    }
                    else if (rdSepiaDraw.Checked == true)
                    {
                        bmp = ExtBitmap.DrawAsSepiaTone(i);
                        Console.WriteLine(bmp);
                        Image im = (Image)bmp;
                        string carpeta = "\\outputimages\\";
                        string c_path = path + carpeta + "result" + counta + ".jpg";
                        Console.WriteLine(c_path);
                        im.Save(c_path);
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

        }
        private void rdGrayscaleBits_CheckedChanged(object sender, EventArgs e)
        {

        }



    }
}

        