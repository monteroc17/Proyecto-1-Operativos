﻿/*
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
            foreach (var filename in files)
            {
                Bitmap bmp = null;
                bmp = new Bitmap(filename.path.ToString());
                Image i = (Image)bmp;
                try
                {
                    if (rdGrayscaleBits.Checked == true)
                    {
                        bmp = ExtBitmap.CopyAsGrayscale(i);
                        Console.WriteLine(bmp);
                        saveImage(bmp, path, filename.format, counta);
                        counta++;
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
                    else if (rdAjusteBrilloBits.Checked == true)
                    {
                        bmp = ExtBitmap.Contrast(bmp, valueBar.Value);
                        saveImage(bmp,path,filename.format,counta);
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
                        saveImage(bmp, path, filename.format, counta);
                        counta++;

                    }
                    else if (rdSolarise.Checked == true)
                    {
                        bmp = ExtBitmap.Solarise(bmp, 150, 50, 250);
                        saveImage(bmp, path, filename.format, counta);
                        counta++;
                    }
                    else if (rdDilatacion.Checked == true)
                    {
                        bmp = ExtBitmap.Dilate(bmp,17, false, true, true);
                        saveImage(bmp,path,filename.format,counta);
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

        private void turnBarOn(object sender, EventArgs e)
        {
            valueBar.Visible = true;
            lblBarValue.Visible = true;
        }

        private void valueBar_Scroll(object sender, EventArgs e)
        {
            lblBarValue.Text = valueBar.Value.ToString();
        }
    }
}

        