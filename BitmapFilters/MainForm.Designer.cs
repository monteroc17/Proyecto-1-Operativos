
namespace BitmapFilters
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.rdAjusteBrillo = new System.Windows.Forms.RadioButton();
            this.rdGausianBlur = new System.Windows.Forms.RadioButton();
            this.rdSepia = new System.Windows.Forms.RadioButton();
            this.rdMotionBlur = new System.Windows.Forms.RadioButton();
            this.rdGrayscale = new System.Windows.Forms.RadioButton();
            this.rdEmboss = new System.Windows.Forms.RadioButton();
            this.rdFindEdges = new System.Windows.Forms.RadioButton();
            this.rdNegative = new System.Windows.Forms.RadioButton();
            this.rdTransparency = new System.Windows.Forms.RadioButton();
            this.rdDilatacion = new System.Windows.Forms.RadioButton();
            this.rdSolarise = new System.Windows.Forms.RadioButton();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.lblTimeTaken = new System.Windows.Forms.Label();
            this.lblTiempoTitle = new System.Windows.Forms.Label();
            this.temporizador = new System.Timers.Timer();
            this.cmbCores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMethods = new System.Windows.Forms.ComboBox();
            this.valueBar1 = new System.Windows.Forms.TrackBar();
            this.lblBarValueData = new System.Windows.Forms.Label();
            this.rdDilate = new System.Windows.Forms.RadioButton();
            this.rdSolarized = new System.Windows.Forms.RadioButton();
            this.grbInput.SuspendLayout();
            this.grbOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temporizador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.rdSolarized);
            this.grbInput.Controls.Add(this.rdDilate);
            this.grbInput.Controls.Add(this.rdAjusteBrillo);
            this.grbInput.Controls.Add(this.rdGausianBlur);
            this.grbInput.Controls.Add(this.rdSepia);
            this.grbInput.Controls.Add(this.rdMotionBlur);
            this.grbInput.Controls.Add(this.rdGrayscale);
            this.grbInput.Controls.Add(this.rdEmboss);
            this.grbInput.Controls.Add(this.rdFindEdges);
            this.grbInput.Controls.Add(this.rdNegative);
            this.grbInput.Controls.Add(this.rdTransparency);
<<<<<<< HEAD
            this.grbInput.Location = new System.Drawing.Point(16, 15);
            this.grbInput.Margin = new System.Windows.Forms.Padding(4);
            this.grbInput.Name = "grbInput";
            this.grbInput.Padding = new System.Windows.Forms.Padding(4);
            this.grbInput.Size = new System.Drawing.Size(453, 362);
=======
            this.grbInput.Location = new System.Drawing.Point(12, 12);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(340, 294);
>>>>>>> master
            this.grbInput.TabIndex = 0;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Opciones de Filtros";
            // 
<<<<<<< HEAD
            // rdAjusteBrillo
            // 
            this.rdAjusteBrillo.AutoSize = true;
            this.rdAjusteBrillo.Location = new System.Drawing.Point(0, 137);
            this.rdAjusteBrillo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            // rdtexture
            // 
            this.rdtexture.AutoSize = true;
            this.rdtexture.Location = new System.Drawing.Point(177, 98);
            this.rdtexture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdtexture.Name = "rdtexture";
            this.rdtexture.Size = new System.Drawing.Size(57, 17);
            this.rdtexture.TabIndex = 19;
            this.rdtexture.Text = "texture";
            this.rdtexture.UseVisualStyleBackColor = true;
            // 
            // rdParedLadrillo
            // 
            this.rdParedLadrillo.AutoSize = true;
            this.rdParedLadrillo.Location = new System.Drawing.Point(2, 198);
            this.rdParedLadrillo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdParedLadrillo.Name = "rdParedLadrillo";
            this.rdParedLadrillo.Size = new System.Drawing.Size(143, 17);
            this.rdParedLadrillo.TabIndex = 18;
            this.rdParedLadrillo.TabStop = true;
            this.rdParedLadrillo.Text = "Textura Pared de Ladrillo";
            this.rdParedLadrillo.UseVisualStyleBackColor = true;
            this.rdParedLadrillo.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdSegmentacion
            // 
            this.rdSegmentacion.AutoSize = true;
            this.rdSegmentacion.Location = new System.Drawing.Point(0, 176);
            this.rdSegmentacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdSegmentacion.Name = "rdSegmentacion";
            this.rdSegmentacion.Size = new System.Drawing.Size(93, 17);
            this.rdSegmentacion.TabIndex = 16;
            this.rdSegmentacion.TabStop = true;
            this.rdSegmentacion.Text = "Segmentación";
            this.rdSegmentacion.UseVisualStyleBackColor = true;
            this.rdSegmentacion.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdCompPerdida
            // 
            this.rdCompPerdida.AutoSize = true;
            this.rdCompPerdida.Location = new System.Drawing.Point(0, 156);
            this.rdCompPerdida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdCompPerdida.Name = "rdCompPerdida";
            this.rdCompPerdida.Size = new System.Drawing.Size(140, 17);
            this.rdCompPerdida.TabIndex = 14;
            this.rdCompPerdida.TabStop = true;
            this.rdCompPerdida.Text = "Compresión con Pérdida";
            this.rdCompPerdida.UseVisualStyleBackColor = true;
            this.rdCompPerdida.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdAjusteBrillo
            // 
            this.rdAjusteBrillo.AutoSize = true;
            this.rdAjusteBrillo.Location = new System.Drawing.Point(0, 134);
            this.rdAjusteBrillo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> master
            this.rdAjusteBrillo.Name = "rdAjusteBrillo";
            this.rdAjusteBrillo.Size = new System.Drawing.Size(79, 17);
            this.rdAjusteBrillo.TabIndex = 12;
            this.rdAjusteBrillo.TabStop = true;
            this.rdAjusteBrillo.Text = "Ajuste Brillo";
            this.rdAjusteBrillo.UseVisualStyleBackColor = true;
            this.rdAjusteBrillo.CheckedChanged += new System.EventHandler(this.turnBarOn);
            this.rdAjusteBrillo.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdGausianBlur
            // 
            this.rdGausianBlur.AutoSize = true;
            this.rdGausianBlur.Location = new System.Drawing.Point(178, 54);
            this.rdGausianBlur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdGausianBlur.Name = "rdGausianBlur";
            this.rdGausianBlur.Size = new System.Drawing.Size(82, 17);
            this.rdGausianBlur.TabIndex = 10;
            this.rdGausianBlur.TabStop = true;
            this.rdGausianBlur.Text = "GausianBlur";
            this.rdGausianBlur.UseVisualStyleBackColor = true;
            this.rdGausianBlur.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdSepia
            // 
            this.rdSepia.AutoSize = true;
<<<<<<< HEAD
            this.rdSepia.Location = new System.Drawing.Point(0, 110);
            this.rdSepia.Margin = new System.Windows.Forms.Padding(4);
=======
            this.rdSepia.Location = new System.Drawing.Point(0, 89);
>>>>>>> master
            this.rdSepia.Name = "rdSepia";
            this.rdSepia.Size = new System.Drawing.Size(52, 17);
            this.rdSepia.TabIndex = 6;
            this.rdSepia.Text = "Sepia";
            this.rdSepia.UseVisualStyleBackColor = true;
            this.rdSepia.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdMotionBlur
            // 
            this.rdMotionBlur.AutoSize = true;
<<<<<<< HEAD
            this.rdMotionBlur.Location = new System.Drawing.Point(236, 94);
            this.rdMotionBlur.Margin = new System.Windows.Forms.Padding(4);
=======
            this.rdMotionBlur.Location = new System.Drawing.Point(177, 76);
>>>>>>> master
            this.rdMotionBlur.Name = "rdMotionBlur";
            this.rdMotionBlur.Size = new System.Drawing.Size(75, 17);
            this.rdMotionBlur.TabIndex = 8;
            this.rdMotionBlur.Text = "MotionBlur";
            this.rdMotionBlur.UseVisualStyleBackColor = true;
            this.rdMotionBlur.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdGrayscale
            // 
            this.rdGrayscale.AutoSize = true;
            this.rdGrayscale.Checked = true;
<<<<<<< HEAD
            this.rdGrayscale.Location = new System.Drawing.Point(0, 23);
            this.rdGrayscale.Margin = new System.Windows.Forms.Padding(4);
=======
            this.rdGrayscale.Location = new System.Drawing.Point(0, 19);
>>>>>>> master
            this.rdGrayscale.Name = "rdGrayscale";
            this.rdGrayscale.Size = new System.Drawing.Size(89, 17);
            this.rdGrayscale.TabIndex = 3;
            this.rdGrayscale.TabStop = true;
            this.rdGrayscale.Text = "Escala Grises";
            this.rdGrayscale.UseVisualStyleBackColor = true;
            this.rdGrayscale.CheckedChanged += new System.EventHandler(this.WhichRBWasClicked);
            this.rdGrayscale.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdEmboss
            // 
            this.rdEmboss.AutoSize = true;
<<<<<<< HEAD
            this.rdEmboss.Location = new System.Drawing.Point(237, 39);
            this.rdEmboss.Margin = new System.Windows.Forms.Padding(4);
=======
            this.rdEmboss.Location = new System.Drawing.Point(178, 32);
>>>>>>> master
            this.rdEmboss.Name = "rdEmboss";
            this.rdEmboss.Size = new System.Drawing.Size(62, 17);
            this.rdEmboss.TabIndex = 9;
            this.rdEmboss.Text = "Emboss";
            this.rdEmboss.UseVisualStyleBackColor = true;
            this.rdEmboss.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdFindEdges
            // 
            this.rdFindEdges.AutoSize = true;
<<<<<<< HEAD
            this.rdFindEdges.Location = new System.Drawing.Point(237, 12);
            this.rdFindEdges.Margin = new System.Windows.Forms.Padding(4);
=======
            this.rdFindEdges.Location = new System.Drawing.Point(178, 10);
>>>>>>> master
            this.rdFindEdges.Name = "rdFindEdges";
            this.rdFindEdges.Size = new System.Drawing.Size(78, 17);
            this.rdFindEdges.TabIndex = 7;
            this.rdFindEdges.Text = "Find Edges";
            this.rdFindEdges.UseVisualStyleBackColor = true;
            this.rdFindEdges.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdNegative
            // 
            this.rdNegative.AutoSize = true;
<<<<<<< HEAD
            this.rdNegative.Location = new System.Drawing.Point(0, 81);
            this.rdNegative.Margin = new System.Windows.Forms.Padding(4);
=======
            this.rdNegative.Location = new System.Drawing.Point(0, 66);
>>>>>>> master
            this.rdNegative.Name = "rdNegative";
            this.rdNegative.Size = new System.Drawing.Size(68, 17);
            this.rdNegative.TabIndex = 5;
            this.rdNegative.Text = "Negativo";
            this.rdNegative.UseVisualStyleBackColor = true;
            this.rdNegative.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdTransparency
            // 
            this.rdTransparency.AutoSize = true;
<<<<<<< HEAD
            this.rdTransparency.Location = new System.Drawing.Point(0, 52);
            this.rdTransparency.Margin = new System.Windows.Forms.Padding(4);
=======
            this.rdTransparency.Location = new System.Drawing.Point(0, 42);
>>>>>>> master
            this.rdTransparency.Name = "rdTransparency";
            this.rdTransparency.Size = new System.Drawing.Size(93, 17);
            this.rdTransparency.TabIndex = 4;
            this.rdTransparency.Text = "Transparencia";
            this.rdTransparency.UseVisualStyleBackColor = true;
            this.rdTransparency.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdDilatacion
            // 
            this.rdDilatacion.Location = new System.Drawing.Point(0, 0);
            this.rdDilatacion.Name = "rdDilatacion";
            this.rdDilatacion.Size = new System.Drawing.Size(104, 24);
            this.rdDilatacion.TabIndex = 0;
            this.rdDilatacion.Text = "Dilatación";
            // 
            // rdSolarise
            // 
            this.rdSolarise.Location = new System.Drawing.Point(0, 0);
            this.rdSolarise.Name = "rdSolarise";
            this.rdSolarise.Size = new System.Drawing.Size(104, 24);
            this.rdSolarise.TabIndex = 0;
            this.rdSolarise.Text = "Solarisado";
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.lblTimeTaken);
            this.grbOutput.Controls.Add(this.lblTiempoTitle);
<<<<<<< HEAD
            this.grbOutput.Location = new System.Drawing.Point(477, 15);
            this.grbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Padding = new System.Windows.Forms.Padding(4);
            this.grbOutput.Size = new System.Drawing.Size(391, 186);
=======
            this.grbOutput.Location = new System.Drawing.Point(358, 12);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Size = new System.Drawing.Size(293, 151);
>>>>>>> master
            this.grbOutput.TabIndex = 1;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Estado";
            // 
            // lblTimeTaken
            // 
            this.lblTimeTaken.AutoSize = true;
            this.lblTimeTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTaken.Location = new System.Drawing.Point(6, 86);
            this.lblTimeTaken.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeTaken.Name = "lblTimeTaken";
            this.lblTimeTaken.Size = new System.Drawing.Size(0, 20);
            this.lblTimeTaken.TabIndex = 1;
            this.lblTimeTaken.Click += new System.EventHandler(this.lblTimeTaken_Click);
            // 
            // lblTiempoTitle
            // 
            this.lblTiempoTitle.AutoSize = true;
            this.lblTiempoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoTitle.Location = new System.Drawing.Point(6, 42);
            this.lblTiempoTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiempoTitle.Name = "lblTiempoTitle";
            this.lblTiempoTitle.Size = new System.Drawing.Size(0, 20);
            this.lblTiempoTitle.TabIndex = 0;
            this.lblTiempoTitle.Click += new System.EventHandler(this.lblTiempoTitle_Click);
            // 
            // temporizador
            // 
            this.temporizador.Enabled = true;
            this.temporizador.Interval = 1D;
            this.temporizador.SynchronizingObject = this;
            // 
            // cmbCores
            // 
            this.cmbCores.FormattingEnabled = true;
            this.cmbCores.Location = new System.Drawing.Point(239, 358);
            this.cmbCores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCores.Name = "cmbCores";
            this.cmbCores.Size = new System.Drawing.Size(77, 21);
            this.cmbCores.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 353);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Núcleos \r\nDisponibles";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(394, 347);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(215, 39);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 361);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Método";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbMethods
            // 
            this.cmbMethods.FormattingEnabled = true;
            this.cmbMethods.Location = new System.Drawing.Point(71, 361);
            this.cmbMethods.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMethods.Name = "cmbMethods";
            this.cmbMethods.Size = new System.Drawing.Size(59, 21);
            this.cmbMethods.TabIndex = 7;
            this.cmbMethods.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // valueBar1
            // 
            this.valueBar1.Location = new System.Drawing.Point(420, 169);
            this.valueBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valueBar1.Maximum = 100;
            this.valueBar1.Name = "valueBar1";
            this.valueBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.valueBar1.Size = new System.Drawing.Size(45, 126);
            this.valueBar1.TabIndex = 25;
            this.valueBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.valueBar1.Value = 50;
            this.valueBar1.Visible = false;
            this.valueBar1.Scroll += new System.EventHandler(this.valueBar1_Scroll);
            this.valueBar1.ValueChanged += new System.EventHandler(this.valueBar_Scroll);
            // 
            // lblBarValueData
            // 
            this.lblBarValueData.AutoSize = true;
            this.lblBarValueData.Enabled = false;
            this.lblBarValueData.Location = new System.Drawing.Point(424, 297);
            this.lblBarValueData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarValueData.Name = "lblBarValueData";
            this.lblBarValueData.Size = new System.Drawing.Size(13, 13);
            this.lblBarValueData.TabIndex = 26;
            this.lblBarValueData.Text = "0";
            this.lblBarValueData.Visible = false;
            // 
            // rdDilate
            // 
            this.rdDilate.AutoSize = true;
            this.rdDilate.Location = new System.Drawing.Point(2, 193);
            this.rdDilate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdDilate.Name = "rdDilate";
            this.rdDilate.Size = new System.Drawing.Size(91, 21);
            this.rdDilate.TabIndex = 13;
            this.rdDilate.TabStop = true;
            this.rdDilate.Text = "Dilatación";
            this.rdDilate.UseVisualStyleBackColor = true;
            this.rdDilate.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdSolarized
            // 
            this.rdSolarized.AutoSize = true;
            this.rdSolarized.Location = new System.Drawing.Point(2, 165);
            this.rdSolarized.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdSolarized.Name = "rdSolarized";
            this.rdSolarized.Size = new System.Drawing.Size(96, 21);
            this.rdSolarized.TabIndex = 14;
            this.rdSolarized.TabStop = true;
            this.rdSolarized.Text = "Solarizado";
            this.rdSolarized.UseVisualStyleBackColor = true;
            this.rdSolarized.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 444);
            this.Controls.Add(this.lblBarValueData);
            this.Controls.Add(this.valueBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMethods);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCores);
            this.Controls.Add(this.grbOutput);
            this.Controls.Add(this.grbInput);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(4);
=======
>>>>>>> master
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitmap Filters";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbOutput.ResumeLayout(false);
            this.grbOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temporizador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.RadioButton rdGrayscale;
        private System.Windows.Forms.RadioButton rdTransparency;
        private System.Windows.Forms.RadioButton rdSepia;
        private System.Windows.Forms.RadioButton rdNegative;
        private System.Windows.Forms.RadioButton rdAjusteBrillo;
        private System.Windows.Forms.RadioButton rdGausianBlur;
        private System.Windows.Forms.ComboBox cmbCores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeTaken;
        private System.Windows.Forms.Label lblTiempoTitle;
        private System.Windows.Forms.Button btnStart;
        public System.Timers.Timer temporizador;
        private System.Windows.Forms.RadioButton rdMotionBlur;
        private System.Windows.Forms.RadioButton rdEmboss;
        private System.Windows.Forms.RadioButton rdFindEdges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMethods;
        private System.Windows.Forms.RadioButton rdSolarise;
        private System.Windows.Forms.RadioButton rdDilatacion;
        private System.Windows.Forms.TrackBar valueBar;
        private System.Windows.Forms.Label lblBarValue;
        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.TrackBar valueBar1;
        private System.Windows.Forms.Label lblBarValueData;
        private System.Windows.Forms.RadioButton rdSolarized;
        private System.Windows.Forms.RadioButton rdDilate;
    }
}

