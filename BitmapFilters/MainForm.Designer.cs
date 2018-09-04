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
            this.rdParedLadrilloDraw = new System.Windows.Forms.RadioButton();
            this.rdParedLadrilloBits = new System.Windows.Forms.RadioButton();
            this.rdSegmentacionDraw = new System.Windows.Forms.RadioButton();
            this.rdSegmentacionBits = new System.Windows.Forms.RadioButton();
            this.rdCompPerdidaDraw = new System.Windows.Forms.RadioButton();
            this.rdCompPerdidaBits = new System.Windows.Forms.RadioButton();
            this.rdAjusteBrilloDraw = new System.Windows.Forms.RadioButton();
            this.rdAjusteBrilloBits = new System.Windows.Forms.RadioButton();
            this.rdGaussinDraw = new System.Windows.Forms.RadioButton();
            this.rdGaussinBits = new System.Windows.Forms.RadioButton();
            this.rdSepiaBits = new System.Windows.Forms.RadioButton();
            this.rdSepiaDraw = new System.Windows.Forms.RadioButton();
            this.rdNegativeDraw = new System.Windows.Forms.RadioButton();
            this.rdGrayscaleBits = new System.Windows.Forms.RadioButton();
            this.rdTransparencyDraw = new System.Windows.Forms.RadioButton();
            this.rdGrayscaleDraw = new System.Windows.Forms.RadioButton();
            this.rdNegativeBits = new System.Windows.Forms.RadioButton();
            this.rdTransparencyBits = new System.Windows.Forms.RadioButton();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.lblTimeTaken = new System.Windows.Forms.Label();
            this.lblTiempoTitle = new System.Windows.Forms.Label();
            this.btnLoadSource = new System.Windows.Forms.Button();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.cmbCores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.grbInput.SuspendLayout();
            this.grbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.rdParedLadrilloDraw);
            this.grbInput.Controls.Add(this.rdParedLadrilloBits);
            this.grbInput.Controls.Add(this.rdSegmentacionDraw);
            this.grbInput.Controls.Add(this.rdSegmentacionBits);
            this.grbInput.Controls.Add(this.rdCompPerdidaDraw);
            this.grbInput.Controls.Add(this.rdCompPerdidaBits);
            this.grbInput.Controls.Add(this.rdAjusteBrilloDraw);
            this.grbInput.Controls.Add(this.rdAjusteBrilloBits);
            this.grbInput.Controls.Add(this.rdGaussinDraw);
            this.grbInput.Controls.Add(this.rdGaussinBits);
            this.grbInput.Controls.Add(this.rdSepiaBits);
            this.grbInput.Controls.Add(this.rdSepiaDraw);
            this.grbInput.Controls.Add(this.rdNegativeDraw);
            this.grbInput.Controls.Add(this.rdGrayscaleBits);
            this.grbInput.Controls.Add(this.rdTransparencyDraw);
            this.grbInput.Controls.Add(this.rdGrayscaleDraw);
            this.grbInput.Controls.Add(this.rdNegativeBits);
            this.grbInput.Controls.Add(this.rdTransparencyBits);
            this.grbInput.Location = new System.Drawing.Point(16, 15);
            this.grbInput.Margin = new System.Windows.Forms.Padding(4);
            this.grbInput.Name = "grbInput";
            this.grbInput.Padding = new System.Windows.Forms.Padding(4);
            this.grbInput.Size = new System.Drawing.Size(453, 345);
            this.grbInput.TabIndex = 0;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Opciones de Filtros";
            // 
            // rdParedLadrilloDraw
            // 
            this.rdParedLadrilloDraw.AutoSize = true;
            this.rdParedLadrilloDraw.Location = new System.Drawing.Point(258, 263);
            this.rdParedLadrilloDraw.Name = "rdParedLadrilloDraw";
            this.rdParedLadrilloDraw.Size = new System.Drawing.Size(193, 38);
            this.rdParedLadrilloDraw.TabIndex = 19;
            this.rdParedLadrilloDraw.TabStop = true;
            this.rdParedLadrilloDraw.Text = "Textura Pared de Ladrillo \r\nDraw(P)";
            this.rdParedLadrilloDraw.UseVisualStyleBackColor = true;
            this.rdParedLadrilloDraw.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdParedLadrilloBits
            // 
            this.rdParedLadrilloBits.AutoSize = true;
            this.rdParedLadrilloBits.Location = new System.Drawing.Point(2, 263);
            this.rdParedLadrilloBits.Name = "rdParedLadrilloBits";
            this.rdParedLadrilloBits.Size = new System.Drawing.Size(193, 38);
            this.rdParedLadrilloBits.TabIndex = 18;
            this.rdParedLadrilloBits.TabStop = true;
            this.rdParedLadrilloBits.Text = "Textura Pared de Ladrillo \r\nBits(S)";
            this.rdParedLadrilloBits.UseVisualStyleBackColor = true;
            this.rdParedLadrilloBits.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdSegmentacionDraw
            // 
            this.rdSegmentacionDraw.AutoSize = true;
            this.rdSegmentacionDraw.Location = new System.Drawing.Point(258, 236);
            this.rdSegmentacionDraw.Name = "rdSegmentacionDraw";
            this.rdSegmentacionDraw.Size = new System.Drawing.Size(183, 21);
            this.rdSegmentacionDraw.TabIndex = 17;
            this.rdSegmentacionDraw.TabStop = true;
            this.rdSegmentacionDraw.Text = "Segmentación - Draw(P)";
            this.rdSegmentacionDraw.UseVisualStyleBackColor = true;
            this.rdSegmentacionDraw.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdSegmentacionBits
            // 
            this.rdSegmentacionBits.AutoSize = true;
            this.rdSegmentacionBits.Location = new System.Drawing.Point(0, 236);
            this.rdSegmentacionBits.Name = "rdSegmentacionBits";
            this.rdSegmentacionBits.Size = new System.Drawing.Size(174, 21);
            this.rdSegmentacionBits.TabIndex = 16;
            this.rdSegmentacionBits.TabStop = true;
            this.rdSegmentacionBits.Text = "Segmentación - Bits(S)";
            this.rdSegmentacionBits.UseVisualStyleBackColor = true;
            this.rdSegmentacionBits.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdCompPerdidaDraw
            // 
            this.rdCompPerdidaDraw.AutoSize = true;
            this.rdCompPerdidaDraw.Location = new System.Drawing.Point(258, 192);
            this.rdCompPerdidaDraw.Name = "rdCompPerdidaDraw";
            this.rdCompPerdidaDraw.Size = new System.Drawing.Size(184, 38);
            this.rdCompPerdidaDraw.TabIndex = 15;
            this.rdCompPerdidaDraw.TabStop = true;
            this.rdCompPerdidaDraw.Text = "Compresión con Pérdida\r\nDraw(P)";
            this.rdCompPerdidaDraw.UseVisualStyleBackColor = true;
            this.rdCompPerdidaDraw.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdCompPerdidaBits
            // 
            this.rdCompPerdidaBits.AutoSize = true;
            this.rdCompPerdidaBits.Location = new System.Drawing.Point(0, 192);
            this.rdCompPerdidaBits.Name = "rdCompPerdidaBits";
            this.rdCompPerdidaBits.Size = new System.Drawing.Size(184, 38);
            this.rdCompPerdidaBits.TabIndex = 14;
            this.rdCompPerdidaBits.TabStop = true;
            this.rdCompPerdidaBits.Text = "Compresión con Pérdida\r\nBits(S)";
            this.rdCompPerdidaBits.UseVisualStyleBackColor = true;
            this.rdCompPerdidaBits.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdAjusteBrilloDraw
            // 
            this.rdAjusteBrilloDraw.AutoSize = true;
            this.rdAjusteBrilloDraw.Location = new System.Drawing.Point(258, 165);
            this.rdAjusteBrilloDraw.Name = "rdAjusteBrilloDraw";
            this.rdAjusteBrilloDraw.Size = new System.Drawing.Size(167, 21);
            this.rdAjusteBrilloDraw.TabIndex = 13;
            this.rdAjusteBrilloDraw.TabStop = true;
            this.rdAjusteBrilloDraw.Text = "Ajuste Brillo - Draw(P)";
            this.rdAjusteBrilloDraw.UseVisualStyleBackColor = true;
            this.rdAjusteBrilloDraw.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdAjusteBrilloBits
            // 
            this.rdAjusteBrilloBits.AutoSize = true;
            this.rdAjusteBrilloBits.Location = new System.Drawing.Point(0, 165);
            this.rdAjusteBrilloBits.Name = "rdAjusteBrilloBits";
            this.rdAjusteBrilloBits.Size = new System.Drawing.Size(158, 21);
            this.rdAjusteBrilloBits.TabIndex = 12;
            this.rdAjusteBrilloBits.TabStop = true;
            this.rdAjusteBrilloBits.Text = "Ajuste Brillo - Bits(S)";
            this.rdAjusteBrilloBits.UseVisualStyleBackColor = true;
            this.rdAjusteBrilloBits.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdGaussinDraw
            // 
            this.rdGaussinDraw.AutoSize = true;
            this.rdGaussinDraw.Location = new System.Drawing.Point(258, 138);
            this.rdGaussinDraw.Name = "rdGaussinDraw";
            this.rdGaussinDraw.Size = new System.Drawing.Size(174, 21);
            this.rdGaussinDraw.TabIndex = 11;
            this.rdGaussinDraw.TabStop = true;
            this.rdGaussinDraw.Text = "Gaussin Blur - Draw(P)";
            this.rdGaussinDraw.UseVisualStyleBackColor = true;
            this.rdGaussinDraw.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdGaussinBits
            // 
            this.rdGaussinBits.AutoSize = true;
            this.rdGaussinBits.Location = new System.Drawing.Point(0, 138);
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
            this.rdSepiaBits.Margin = new System.Windows.Forms.Padding(4);
            this.rdSepiaBits.Name = "rdSepiaBits";
            this.rdSepiaBits.Size = new System.Drawing.Size(120, 21);
            this.rdSepiaBits.TabIndex = 6;
            this.rdSepiaBits.Text = "Sepia - Bits(S)";
            this.rdSepiaBits.UseVisualStyleBackColor = true;
            this.rdSepiaBits.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdSepiaDraw
            // 
            this.rdSepiaDraw.AutoSize = true;
            this.rdSepiaDraw.Location = new System.Drawing.Point(258, 110);
            this.rdSepiaDraw.Margin = new System.Windows.Forms.Padding(4);
            this.rdSepiaDraw.Name = "rdSepiaDraw";
            this.rdSepiaDraw.Size = new System.Drawing.Size(129, 21);
            this.rdSepiaDraw.TabIndex = 8;
            this.rdSepiaDraw.Text = "Sepia - Draw(P)";
            this.rdSepiaDraw.UseVisualStyleBackColor = true;
            this.rdSepiaDraw.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdNegativeDraw
            // 
            this.rdNegativeDraw.AutoSize = true;
            this.rdNegativeDraw.Location = new System.Drawing.Point(258, 81);
            this.rdNegativeDraw.Margin = new System.Windows.Forms.Padding(4);
            this.rdNegativeDraw.Name = "rdNegativeDraw";
            this.rdNegativeDraw.Size = new System.Drawing.Size(149, 21);
            this.rdNegativeDraw.TabIndex = 10;
            this.rdNegativeDraw.Text = "Negativo - Draw(P)";
            this.rdNegativeDraw.UseVisualStyleBackColor = true;
            this.rdNegativeDraw.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdGrayscaleBits
            // 
            this.rdGrayscaleBits.AutoSize = true;
            this.rdGrayscaleBits.Checked = true;
            this.rdGrayscaleBits.Location = new System.Drawing.Point(0, 23);
            this.rdGrayscaleBits.Margin = new System.Windows.Forms.Padding(4);
            this.rdGrayscaleBits.Name = "rdGrayscaleBits";
            this.rdGrayscaleBits.Size = new System.Drawing.Size(171, 21);
            this.rdGrayscaleBits.TabIndex = 3;
            this.rdGrayscaleBits.TabStop = true;
            this.rdGrayscaleBits.Text = "Escala Grises - Bits(S)";
            this.rdGrayscaleBits.UseVisualStyleBackColor = true;
            this.rdGrayscaleBits.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdTransparencyDraw
            // 
            this.rdTransparencyDraw.AutoSize = true;
            this.rdTransparencyDraw.Location = new System.Drawing.Point(258, 52);
            this.rdTransparencyDraw.Margin = new System.Windows.Forms.Padding(4);
            this.rdTransparencyDraw.Name = "rdTransparencyDraw";
            this.rdTransparencyDraw.Size = new System.Drawing.Size(185, 21);
            this.rdTransparencyDraw.TabIndex = 9;
            this.rdTransparencyDraw.Text = "Transparencia - Draw(P)";
            this.rdTransparencyDraw.UseVisualStyleBackColor = true;
            this.rdTransparencyDraw.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdGrayscaleDraw
            // 
            this.rdGrayscaleDraw.AutoSize = true;
            this.rdGrayscaleDraw.Location = new System.Drawing.Point(258, 23);
            this.rdGrayscaleDraw.Margin = new System.Windows.Forms.Padding(4);
            this.rdGrayscaleDraw.Name = "rdGrayscaleDraw";
            this.rdGrayscaleDraw.Size = new System.Drawing.Size(180, 21);
            this.rdGrayscaleDraw.TabIndex = 7;
            this.rdGrayscaleDraw.Text = "Escala Grises - Draw(P)";
            this.rdGrayscaleDraw.UseVisualStyleBackColor = true;
            this.rdGrayscaleDraw.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdNegativeBits
            // 
            this.rdNegativeBits.AutoSize = true;
            this.rdNegativeBits.Location = new System.Drawing.Point(0, 81);
            this.rdNegativeBits.Margin = new System.Windows.Forms.Padding(4);
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
            this.rdTransparencyBits.Margin = new System.Windows.Forms.Padding(4);
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
            this.grbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Padding = new System.Windows.Forms.Padding(4);
            this.grbOutput.Size = new System.Drawing.Size(287, 345);
            this.grbOutput.TabIndex = 1;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Duración";
            // 
            // lblTimeTaken
            // 
            this.lblTimeTaken.AutoSize = true;
            this.lblTimeTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTaken.Location = new System.Drawing.Point(150, 52);
            this.lblTimeTaken.Name = "lblTimeTaken";
            this.lblTimeTaken.Size = new System.Drawing.Size(39, 25);
            this.lblTimeTaken.TabIndex = 1;
            this.lblTimeTaken.Text = "0.0";
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
            // 
            // btnLoadSource
            // 
            this.btnLoadSource.Location = new System.Drawing.Point(16, 367);
            this.btnLoadSource.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadSource.Name = "btnLoadSource";
            this.btnLoadSource.Size = new System.Drawing.Size(147, 28);
            this.btnLoadSource.TabIndex = 2;
            this.btnLoadSource.Text = "Load Source";
            this.btnLoadSource.UseVisualStyleBackColor = true;
            this.btnLoadSource.Click += new System.EventHandler(this.btnLoadSource_Click);
            // 
            // temporizador
            // 
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // cmbCores
            // 
            this.cmbCores.FormattingEnabled = true;
            this.cmbCores.Location = new System.Drawing.Point(304, 367);
            this.cmbCores.Name = "cmbCores";
            this.cmbCores.Size = new System.Drawing.Size(101, 24);
            this.cmbCores.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Núcleos \r\nDisponibles";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(477, 367);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(287, 48);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 457);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCores);
            this.Controls.Add(this.btnLoadSource);
            this.Controls.Add(this.grbOutput);
            this.Controls.Add(this.grbInput);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitmap Filters";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbOutput.ResumeLayout(false);
            this.grbOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.Button btnLoadSource;
        private System.Windows.Forms.RadioButton rdGrayscaleBits;
        private System.Windows.Forms.RadioButton rdTransparencyBits;
        private System.Windows.Forms.RadioButton rdSepiaBits;
        private System.Windows.Forms.RadioButton rdNegativeBits;
        private System.Windows.Forms.RadioButton rdGrayscaleDraw;
        private System.Windows.Forms.RadioButton rdSepiaDraw;
        private System.Windows.Forms.RadioButton rdTransparencyDraw;
        private System.Windows.Forms.RadioButton rdNegativeDraw;
        private System.Windows.Forms.RadioButton rdParedLadrilloDraw;
        private System.Windows.Forms.RadioButton rdParedLadrilloBits;
        private System.Windows.Forms.RadioButton rdSegmentacionDraw;
        private System.Windows.Forms.RadioButton rdSegmentacionBits;
        private System.Windows.Forms.RadioButton rdCompPerdidaDraw;
        private System.Windows.Forms.RadioButton rdCompPerdidaBits;
        private System.Windows.Forms.RadioButton rdAjusteBrilloDraw;
        private System.Windows.Forms.RadioButton rdAjusteBrilloBits;
        private System.Windows.Forms.RadioButton rdGaussinDraw;
        private System.Windows.Forms.RadioButton rdGaussinBits;
        private System.Windows.Forms.ComboBox cmbCores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeTaken;
        private System.Windows.Forms.Label lblTiempoTitle;
        private System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Timer temporizador;
    }
}

