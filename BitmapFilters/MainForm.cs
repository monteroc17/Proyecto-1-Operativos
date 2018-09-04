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
namespace BitmapFilters
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadSource_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Png files (*.png)|*.png|Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                Bitmap sourceBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();
                //picSource.BackgroundImage = sourceBitmap;
                OnCheckChangedEventHandler(sender, e);
            }*/
            string path = Directory.GetCurrentDirectory();
            System.Console.WriteLine(path+"no mames guey");
            //string[] filePaths = Directory.GetFiles(path,"*.jpg");
        }
        private void OnCheckChangedEventHandler(object sender, EventArgs e)
        {
            //if (picSource.BackgroundImage != null)
            {
                if (rdGrayscaleBits.Checked == true)
                {
                    //picOutput.BackgroundImage = picSource.BackgroundImage.CopyAsGrayscale();
                }
                else if (rdGrayscaleDraw.Checked == true)
                {
                    //picOutput.BackgroundImage = picSource.BackgroundImage.DrawAsGrayscale();
                }
                else if (rdTransparencyBits.Checked == true)
                {
                    //picOutput.BackgroundImage = picSource.BackgroundImage.CopyWithTransparency();
                }
                else if (rdTransparencyDraw.Checked == true)
                {
                    //picOutput.BackgroundImage = picSource.BackgroundImage.DrawWithTransparency();
                }
                else if (rdNegativeBits.Checked == true)
                {
                   // picOutput.BackgroundImage = picSource.BackgroundImage.CopyAsNegative();
                }
                else if (rdNegativeDraw.Checked == true)
                {
                    //picOutput.BackgroundImage = picSource.BackgroundImage.DrawAsNegative();
                }
                else if (rdSepiaBits.Checked == true)
                {
                    //picOutput.BackgroundImage = picSource.BackgroundImage.CopyAsSepiaTone();
                }
                else if (rdSepiaDraw.Checked == true)
                {
                    //picOutput.BackgroundImage = picSource.BackgroundImage.DrawAsSepiaTone();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            temporizador.Start();//starts the timer

            for (int index = 0; index < Environment.ProcessorCount; index++)
            {
                cmbCores.Items.Add(index+1);
            }
            
        }

        int cont = 0;
        private void temporizador_Tick(object sender, EventArgs e)
        {
            cont++;
            lblTimeTaken.Text = cont.ToString();
        }
    }
}
