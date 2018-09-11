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
using System.Diagnostics;

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

        }
        int cont = 0;
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            if(cmbMetodo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un método", "Error");
                return;
            }
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
                        if (cmbMetodo.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = ExtBitmap.CopyAsGrayscale(i);
                            Console.WriteLine(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                        
                    }
                    else if (rdFindEdges.Checked == true)
                    {
                        if (cmbMetodo.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = ExtBitmap.FindEdges(bmp);
                            Console.WriteLine(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                            
                    }
                    else if (rdGausianBlur.Checked == true)
                    {
                        if (cmbMetodo.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = ExtBitmap.GausianBlur(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                            
                    }
                    else if (rdTransparency.Checked == true)
                    {
                        if (cmbMetodo.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = ExtBitmap.CopyWithTransparency(i);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                        else if (cmbMetodo.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.Transparency(i);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                            
                    }
                    else if (rdEmboss.Checked == true)
                    {
                        if (cmbMetodo.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = ExtBitmap.Emboss(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                            

                    }
                    else if (rdAjusteBrillo.Checked == true)
                    {
                        if (cmbMetodo.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = ExtBitmap.Contrast(bmp, valueBar.Value);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                    }
                    else if (rdNegative.Checked == true)
                    {
                        if (cmbMetodo.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = ExtBitmap.CopyAsNegative(i);
                            Console.WriteLine(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                        else if (cmbMetodo.SelectedItem.ToString().Equals("Paralelo"))
                        {
                            bmp = ParallelFilters.Negative(i);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                    }
                    else if (rdSepia.Checked == true)
                    {
                        if (cmbMetodo.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = ExtBitmap.CopyAsSepiaTone(i);
                            Console.WriteLine(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                            
                    }
                    else if (rdMotionBlur.Checked == true)
                    {
                        if (cmbMetodo.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = ExtBitmap.MotionBlur(bmp);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                            

                    }
                    else if(rdCompPerdida.Checked == true)
                    {
                        Compression c = new Compression();
                        c.SaveJpg(bmp, filename.format, 2);
                    }
                    else if (rdSolarise.Checked == true)
                    {
                        if (cmbMetodo.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = ExtBitmap.Solarise(bmp, 150, 50, 250);
                            saveImage(bmp, path, filename.format, counta);
                            counta++;
                        }
                    }
                    else if (rdDilatacion.Checked == true)
                    {
                        if (cmbMetodo.SelectedItem.ToString().Equals("Secuencial"))
                        {
                            bmp = ExtBitmap.Dilate(bmp, 17, false, true, true);
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

        