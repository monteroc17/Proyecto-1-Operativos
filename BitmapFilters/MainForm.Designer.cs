
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
            this.components = new System.ComponentModel.Container();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.rdParedLadrilloBits = new System.Windows.Forms.RadioButton();
            this.rdSegmentacionBits = new System.Windows.Forms.RadioButton();
            this.rdCompPerdidaBits = new System.Windows.Forms.RadioButton();
            this.rdAjusteBrilloBits = new System.Windows.Forms.RadioButton();
            this.rdGaussinBits = new System.Windows.Forms.RadioButton();
            this.rdSepiaBits = new System.Windows.Forms.RadioButton();
            this.rdMotionBlur = new System.Windows.Forms.RadioButton();
            this.rdGrayscaleBits = new System.Windows.Forms.RadioButton();
            this.rdEmboss = new System.Windows.Forms.RadioButton();
            this.rdFindEdges = new System.Windows.Forms.RadioButton();
            this.rdNegativeBits = new System.Windows.Forms.RadioButton();
            this.rdTransparencyBits = new System.Windows.Forms.RadioButton();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.lblTimeTaken = new System.Windows.Forms.Label();
            this.lblTiempoTitle = new System.Windows.Forms.Label();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.cmbCores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.rdSolarise = new System.Windows.Forms.RadioButton();
            this.rdDilatacion = new System.Windows.Forms.RadioButton();
            this.rdGausianBlur = new System.Windows.Forms.RadioButton();
            this.valueBar = new System.Windows.Forms.TrackBar();
            this.lblBarValue = new System.Windows.Forms.Label();
            this.grbInput.SuspendLayout();
            this.grbOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueBar)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.rdDilatacion);
            this.grbInput.Controls.Add(this.rdSolarise);
            this.grbInput.Controls.Add(this.rdParedLadrilloBits);
            this.grbInput.Controls.Add(this.rdSegmentacionBits);
            this.grbInput.Controls.Add(this.rdCompPerdidaBits);
            this.grbInput.Controls.Add(this.rdAjusteBrilloBits);
            this.grbInput.Controls.Add(this.rdGaussinBits);
            this.grbInput.Controls.Add(this.rdSepiaBits);
            this.grbInput.Controls.Add(this.rdMotionBlur);
            this.grbInput.Controls.Add(this.rdGausianBlur);
            this.grbInput.Controls.Add(this.rdGrayscaleBits);
            this.grbInput.Controls.Add(this.rdEmboss);
            this.grbInput.Controls.Add(this.rdFindEdges);
            this.grbInput.Controls.Add(this.rdNegativeBits);
            this.grbInput.Controls.Add(this.rdTransparencyBits);
            this.grbInput.Location = new System.Drawing.Point(16, 15);
            this.grbInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbInput.Name = "grbInput";
            this.grbInput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbInput.Size = new System.Drawing.Size(453, 441);
            this.grbInput.TabIndex = 0;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Opciones de Filtros";
            // 
            // rdParedLadrilloBits
            // 
            this.rdParedLadrilloBits.AutoSize = true;
            this.rdParedLadrilloBits.Location = new System.Drawing.Point(3, 263);
            this.rdParedLadrilloBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdParedLadrilloBits.Name = "rdParedLadrilloBits";
            this.rdParedLadrilloBits.Size = new System.Drawing.Size(193, 38);
            this.rdParedLadrilloBits.TabIndex = 18;
            this.rdParedLadrilloBits.TabStop = true;
            this.rdParedLadrilloBits.Text = "Textura Pared de Ladrillo \r\nBits(S)";
            this.rdParedLadrilloBits.UseVisualStyleBackColor = true;
            this.rdParedLadrilloBits.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdSegmentacionBits
            // 
            this.rdSegmentacionBits.AutoSize = true;
            this.rdSegmentacionBits.Location = new System.Drawing.Point(0, 236);
            this.rdSegmentacionBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdSegmentacionBits.Name = "rdSegmentacionBits";
            this.rdSegmentacionBits.Size = new System.Drawing.Size(174, 21);
            this.rdSegmentacionBits.TabIndex = 16;
            this.rdSegmentacionBits.TabStop = true;
            this.rdSegmentacionBits.Text = "Segmentación - Bits(S)";
            this.rdSegmentacionBits.UseVisualStyleBackColor = true;
            this.rdSegmentacionBits.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdCompPerdidaBits
            // 
            this.rdCompPerdidaBits.AutoSize = true;
            this.rdCompPerdidaBits.Location = new System.Drawing.Point(0, 192);
            this.rdCompPerdidaBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdCompPerdidaBits.Name = "rdCompPerdidaBits";
            this.rdCompPerdidaBits.Size = new System.Drawing.Size(184, 38);
            this.rdCompPerdidaBits.TabIndex = 14;
            this.rdCompPerdidaBits.TabStop = true;
            this.rdCompPerdidaBits.Text = "Compresión con Pérdida\r\nBits(S)";
            this.rdCompPerdidaBits.UseVisualStyleBackColor = true;
            this.rdCompPerdidaBits.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdAjusteBrilloBits
            // 
            this.rdAjusteBrilloBits.AutoSize = true;
            this.rdAjusteBrilloBits.Location = new System.Drawing.Point(0, 165);
            this.rdAjusteBrilloBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdAjusteBrilloBits.Name = "rdAjusteBrilloBits";
            this.rdAjusteBrilloBits.Size = new System.Drawing.Size(158, 21);
            this.rdAjusteBrilloBits.TabIndex = 12;
            this.rdAjusteBrilloBits.TabStop = true;
            this.rdAjusteBrilloBits.Text = "Ajuste Brillo - Bits(S)";
            this.rdAjusteBrilloBits.UseVisualStyleBackColor = true;
            this.rdAjusteBrilloBits.CheckedChanged += new System.EventHandler(this.turnBarOn);
            this.rdAjusteBrilloBits.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdGaussinBits
            // 
            this.rdGaussinBits.AutoSize = true;
            this.rdGaussinBits.Location = new System.Drawing.Point(0, 138);
            this.rdGaussinBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdGaussinBits.Name = "rdGaussinBits";
            this.rdGaussinBits.Size = new System.Drawing.Size(165, 21);
            this.rdGaussinBits.TabIndex = 3;
            this.rdGaussinBits.TabStop = true;
            this.rdGaussinBits.Text = "Gaussin Blur - Bits(S)";
            this.rdGaussinBits.UseVisualStyleBackColor = true;
            this.rdGaussinBits.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdSepiaBits
            // 
            this.rdSepiaBits.AutoSize = true;
            this.rdSepiaBits.Location = new System.Drawing.Point(0, 110);
            this.rdSepiaBits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdSepiaBits.Name = "rdSepiaBits";
            this.rdSepiaBits.Size = new System.Drawing.Size(120, 21);
            this.rdSepiaBits.TabIndex = 6;
            this.rdSepiaBits.Text = "Sepia - Bits(S)";
            this.rdSepiaBits.UseVisualStyleBackColor = true;
            this.rdSepiaBits.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdMotionBlur
            // 
            this.rdMotionBlur.AutoSize = true;
            this.rdMotionBlur.Location = new System.Drawing.Point(259, 110);
            this.rdMotionBlur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdMotionBlur.Name = "rdMotionBlur";
            this.rdMotionBlur.Size = new System.Drawing.Size(96, 21);
            this.rdMotionBlur.TabIndex = 8;
            this.rdMotionBlur.Text = "MotionBlur";
            this.rdMotionBlur.UseVisualStyleBackColor = true;
            this.rdMotionBlur.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdGrayscaleBits
            // 
            this.rdGrayscaleBits.AutoSize = true;
            this.rdGrayscaleBits.Checked = true;
            this.rdGrayscaleBits.Location = new System.Drawing.Point(0, 23);
            this.rdGrayscaleBits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdGrayscaleBits.Name = "rdGrayscaleBits";
            this.rdGrayscaleBits.Size = new System.Drawing.Size(171, 21);
            this.rdGrayscaleBits.TabIndex = 3;
            this.rdGrayscaleBits.TabStop = true;
            this.rdGrayscaleBits.Text = "Escala Grises - Bits(S)";
            this.rdGrayscaleBits.UseVisualStyleBackColor = true;
            this.rdGrayscaleBits.CheckedChanged += new System.EventHandler(this.WhichRBWasClicked);
            this.rdGrayscaleBits.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdEmboss
            // 
            this.rdEmboss.AutoSize = true;
            this.rdEmboss.Location = new System.Drawing.Point(259, 52);
            this.rdEmboss.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdEmboss.Name = "rdEmboss";
            this.rdEmboss.Size = new System.Drawing.Size(79, 21);
            this.rdEmboss.TabIndex = 9;
            this.rdEmboss.Text = "Emboss";
            this.rdEmboss.UseVisualStyleBackColor = true;
            this.rdEmboss.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdFindEdges
            // 
            this.rdFindEdges.AutoSize = true;
            this.rdFindEdges.Location = new System.Drawing.Point(259, 23);
            this.rdFindEdges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdFindEdges.Name = "rdFindEdges";
            this.rdFindEdges.Size = new System.Drawing.Size(100, 21);
            this.rdFindEdges.TabIndex = 7;
            this.rdFindEdges.Text = "Find Edges";
            this.rdFindEdges.UseVisualStyleBackColor = true;
            this.rdFindEdges.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdNegativeBits
            // 
            this.rdNegativeBits.AutoSize = true;
            this.rdNegativeBits.Location = new System.Drawing.Point(0, 81);
            this.rdNegativeBits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdNegativeBits.Name = "rdNegativeBits";
            this.rdNegativeBits.Size = new System.Drawing.Size(140, 21);
            this.rdNegativeBits.TabIndex = 5;
            this.rdNegativeBits.Text = "Negativo - Bits(S)";
            this.rdNegativeBits.UseVisualStyleBackColor = true;
            this.rdNegativeBits.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdTransparencyBits
            // 
            this.rdTransparencyBits.AutoSize = true;
            this.rdTransparencyBits.Location = new System.Drawing.Point(0, 52);
            this.rdTransparencyBits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdTransparencyBits.Name = "rdTransparencyBits";
            this.rdTransparencyBits.Size = new System.Drawing.Size(176, 21);
            this.rdTransparencyBits.TabIndex = 4;
            this.rdTransparencyBits.Text = "Transparencia - Bits(S)";
            this.rdTransparencyBits.UseVisualStyleBackColor = true;
            this.rdTransparencyBits.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.lblTimeTaken);
            this.grbOutput.Controls.Add(this.lblTiempoTitle);
            this.grbOutput.Location = new System.Drawing.Point(477, 15);
            this.grbOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbOutput.Size = new System.Drawing.Size(287, 186);
            this.grbOutput.TabIndex = 1;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Duración";
            // 
            // lblTimeTaken
            // 
            this.lblTimeTaken.AutoSize = true;
            this.lblTimeTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTaken.Location = new System.Drawing.Point(8, 106);
            this.lblTimeTaken.Name = "lblTimeTaken";
            this.lblTimeTaken.Size = new System.Drawing.Size(39, 25);
            this.lblTimeTaken.TabIndex = 1;
            this.lblTimeTaken.Text = "0.0";
            this.lblTimeTaken.Click += new System.EventHandler(this.lblTimeTaken_Click);
            // 
            // lblTiempoTitle
            // 
            this.lblTiempoTitle.AutoSize = true;
            this.lblTiempoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoTitle.Location = new System.Drawing.Point(8, 52);
            this.lblTiempoTitle.Name = "lblTiempoTitle";
            this.lblTiempoTitle.Size = new System.Drawing.Size(84, 25);
            this.lblTiempoTitle.TabIndex = 0;
            this.lblTiempoTitle.Text = "Tiempo:";
            this.lblTiempoTitle.Click += new System.EventHandler(this.lblTiempoTitle_Click);
            // 
            // temporizador
            // 
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // cmbCores
            // 
            this.cmbCores.FormattingEnabled = true;
            this.cmbCores.Location = new System.Drawing.Point(303, 473);
            this.cmbCores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCores.Name = "cmbCores";
            this.cmbCores.Size = new System.Drawing.Size(101, 24);
            this.cmbCores.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Núcleos \r\nDisponibles";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(476, 473);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(287, 48);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rdSolarise
            // 
            this.rdSolarise.AutoSize = true;
            this.rdSolarise.Location = new System.Drawing.Point(259, 139);
            this.rdSolarise.Margin = new System.Windows.Forms.Padding(4);
            this.rdSolarise.Name = "rdSolarise";
            this.rdSolarise.Size = new System.Drawing.Size(80, 21);
            this.rdSolarise.TabIndex = 19;
            this.rdSolarise.Text = "Solarise";
            this.rdSolarise.UseVisualStyleBackColor = true;
            // 
            // rdDilatacion
            // 
            this.rdDilatacion.AutoSize = true;
            this.rdDilatacion.Location = new System.Drawing.Point(258, 168);
            this.rdDilatacion.Margin = new System.Windows.Forms.Padding(4);
            this.rdDilatacion.Name = "rdDilatacion";
            this.rdDilatacion.Size = new System.Drawing.Size(91, 21);
            this.rdDilatacion.TabIndex = 20;
            this.rdDilatacion.Text = "Dilatación";
            this.rdDilatacion.UseVisualStyleBackColor = true;
            // 
            // rdGausianBlur
            // 
            this.rdGausianBlur.AutoSize = true;
            this.rdGausianBlur.Location = new System.Drawing.Point(259, 81);
            this.rdGausianBlur.Margin = new System.Windows.Forms.Padding(4);
            this.rdGausianBlur.Name = "rdGausianBlur";
            this.rdGausianBlur.Size = new System.Drawing.Size(107, 21);
            this.rdGausianBlur.TabIndex = 10;
            this.rdGausianBlur.Text = "GausianBlur";
            this.rdGausianBlur.UseVisualStyleBackColor = true;
            this.rdGausianBlur.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // valueBar
            // 
            this.valueBar.Location = new System.Drawing.Point(477, 207);
            this.valueBar.Maximum = 100;
            this.valueBar.Minimum = -100;
            this.valueBar.Name = "valueBar";
            this.valueBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.valueBar.Size = new System.Drawing.Size(56, 217);
            this.valueBar.TabIndex = 21;
            this.valueBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.valueBar.Visible = false;
            this.valueBar.Scroll += new System.EventHandler(this.valueBar_Scroll);
            // 
            // lblBarValue
            // 
            this.lblBarValue.AutoSize = true;
            this.lblBarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarValue.Location = new System.Drawing.Point(476, 431);
            this.lblBarValue.Name = "lblBarValue";
            this.lblBarValue.Size = new System.Drawing.Size(23, 25);
            this.lblBarValue.TabIndex = 22;
            this.lblBarValue.Text = "0";
            this.lblBarValue.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 547);
            this.Controls.Add(this.lblBarValue);
            this.Controls.Add(this.valueBar);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCores);
            this.Controls.Add(this.grbOutput);
            this.Controls.Add(this.grbInput);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitmap Filters";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbOutput.ResumeLayout(false);
            this.grbOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.RadioButton rdGrayscaleBits;
        private System.Windows.Forms.RadioButton rdTransparencyBits;
        private System.Windows.Forms.RadioButton rdSepiaBits;
        private System.Windows.Forms.RadioButton rdNegativeBits;
        private System.Windows.Forms.RadioButton rdParedLadrilloBits;
        private System.Windows.Forms.RadioButton rdSegmentacionBits;
        private System.Windows.Forms.RadioButton rdCompPerdidaBits;
        private System.Windows.Forms.RadioButton rdAjusteBrilloBits;
        private System.Windows.Forms.RadioButton rdGaussinBits;
        private System.Windows.Forms.ComboBox cmbCores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeTaken;
        private System.Windows.Forms.Label lblTiempoTitle;
        private System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.RadioButton rdMotionBlur;
        private System.Windows.Forms.RadioButton rdEmboss;
        private System.Windows.Forms.RadioButton rdFindEdges;
        private System.Windows.Forms.RadioButton rdSolarise;
        private System.Windows.Forms.RadioButton rdDilatacion;
        private System.Windows.Forms.RadioButton rdGausianBlur;
        private System.Windows.Forms.TrackBar valueBar;
        private System.Windows.Forms.Label lblBarValue;
    }
}

