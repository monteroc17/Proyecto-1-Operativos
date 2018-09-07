﻿
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
            this.rdDilatacion = new System.Windows.Forms.RadioButton();
            this.rdSolarise = new System.Windows.Forms.RadioButton();
            this.rdParedLadrillo = new System.Windows.Forms.RadioButton();
            this.rdSegmentacion = new System.Windows.Forms.RadioButton();
            this.rdCompPerdida = new System.Windows.Forms.RadioButton();
            this.rdAjusteBrillo = new System.Windows.Forms.RadioButton();
            this.rdGausianBlur = new System.Windows.Forms.RadioButton();
            this.rdSepia = new System.Windows.Forms.RadioButton();
            this.rdMotionBlur = new System.Windows.Forms.RadioButton();
            this.rdGrayscale = new System.Windows.Forms.RadioButton();
            this.rdEmboss = new System.Windows.Forms.RadioButton();
            this.rdFindEdges = new System.Windows.Forms.RadioButton();
            this.rdNegative = new System.Windows.Forms.RadioButton();
            this.rdTransparency = new System.Windows.Forms.RadioButton();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.lblTimeTaken = new System.Windows.Forms.Label();
            this.lblTiempoTitle = new System.Windows.Forms.Label();
            this.temporizador = new System.Timers.Timer();
            this.cmbCores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.valueBar = new System.Windows.Forms.TrackBar();
            this.lblBarValue = new System.Windows.Forms.Label();
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbInput.SuspendLayout();
            this.grbOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temporizador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueBar)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.rdDilatacion);
            this.grbInput.Controls.Add(this.rdSolarise);
            this.grbInput.Controls.Add(this.rdParedLadrillo);
            this.grbInput.Controls.Add(this.rdSegmentacion);
            this.grbInput.Controls.Add(this.rdCompPerdida);
            this.grbInput.Controls.Add(this.rdAjusteBrillo);
            this.grbInput.Controls.Add(this.rdGausianBlur);
            this.grbInput.Controls.Add(this.rdSepia);
            this.grbInput.Controls.Add(this.rdMotionBlur);
            this.grbInput.Controls.Add(this.rdGrayscale);
            this.grbInput.Controls.Add(this.rdEmboss);
            this.grbInput.Controls.Add(this.rdFindEdges);
            this.grbInput.Controls.Add(this.rdNegative);
            this.grbInput.Controls.Add(this.rdTransparency);
            this.grbInput.Location = new System.Drawing.Point(16, 15);
            this.grbInput.Margin = new System.Windows.Forms.Padding(4);
            this.grbInput.Name = "grbInput";
            this.grbInput.Padding = new System.Windows.Forms.Padding(4);
            this.grbInput.Size = new System.Drawing.Size(453, 441);
            this.grbInput.TabIndex = 0;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Opciones de Filtros";
            // 
            // rdDilatacion
            // 
            this.rdDilatacion.AutoSize = true;
            this.rdDilatacion.Location = new System.Drawing.Point(258, 139);
            this.rdDilatacion.Margin = new System.Windows.Forms.Padding(4);
            this.rdDilatacion.Name = "rdDilatacion";
            this.rdDilatacion.Size = new System.Drawing.Size(91, 21);
            this.rdDilatacion.TabIndex = 20;
            this.rdDilatacion.Text = "Dilatación";
            this.rdDilatacion.UseVisualStyleBackColor = true;
            // 
            // rdSolarise
            // 
            this.rdSolarise.AutoSize = true;
            this.rdSolarise.Location = new System.Drawing.Point(259, 110);
            this.rdSolarise.Margin = new System.Windows.Forms.Padding(4);
            this.rdSolarise.Name = "rdSolarise";
            this.rdSolarise.Size = new System.Drawing.Size(80, 21);
            this.rdSolarise.TabIndex = 19;
            this.rdSolarise.Text = "Solarise";
            this.rdSolarise.UseVisualStyleBackColor = true;
            // 
            // rdParedLadrillo
            // 
            this.rdParedLadrillo.AutoSize = true;
            this.rdParedLadrillo.Location = new System.Drawing.Point(3, 244);
            this.rdParedLadrillo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdParedLadrillo.Name = "rdParedLadrillo";
            this.rdParedLadrillo.Size = new System.Drawing.Size(189, 21);
            this.rdParedLadrillo.TabIndex = 18;
            this.rdParedLadrillo.TabStop = true;
            this.rdParedLadrillo.Text = "Textura Pared de Ladrillo";
            this.rdParedLadrillo.UseVisualStyleBackColor = true;
            this.rdParedLadrillo.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdSegmentacion
            // 
            this.rdSegmentacion.AutoSize = true;
            this.rdSegmentacion.Location = new System.Drawing.Point(0, 217);
            this.rdSegmentacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdSegmentacion.Name = "rdSegmentacion";
            this.rdSegmentacion.Size = new System.Drawing.Size(119, 21);
            this.rdSegmentacion.TabIndex = 16;
            this.rdSegmentacion.TabStop = true;
            this.rdSegmentacion.Text = "Segmentación";
            this.rdSegmentacion.UseVisualStyleBackColor = true;
            this.rdSegmentacion.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdCompPerdida
            // 
            this.rdCompPerdida.AutoSize = true;
            this.rdCompPerdida.Location = new System.Drawing.Point(0, 192);
            this.rdCompPerdida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdCompPerdida.Name = "rdCompPerdida";
            this.rdCompPerdida.Size = new System.Drawing.Size(184, 21);
            this.rdCompPerdida.TabIndex = 14;
            this.rdCompPerdida.TabStop = true;
            this.rdCompPerdida.Text = "Compresión con Pérdida";
            this.rdCompPerdida.UseVisualStyleBackColor = true;
            this.rdCompPerdida.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdAjusteBrillo
            // 
            this.rdAjusteBrillo.AutoSize = true;
            this.rdAjusteBrillo.Location = new System.Drawing.Point(0, 165);
            this.rdAjusteBrillo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdAjusteBrillo.Name = "rdAjusteBrillo";
            this.rdAjusteBrillo.Size = new System.Drawing.Size(103, 21);
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
            this.rdGausianBlur.Location = new System.Drawing.Point(0, 138);
            this.rdGausianBlur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdGausianBlur.Name = "rdGausianBlur";
            this.rdGausianBlur.Size = new System.Drawing.Size(110, 21);
            this.rdGausianBlur.TabIndex = 3;
            this.rdGausianBlur.TabStop = true;
            this.rdGausianBlur.Text = "Gaussin Blur";
            this.rdGausianBlur.UseVisualStyleBackColor = true;
            this.rdGausianBlur.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdSepia
            // 
            this.rdSepia.AutoSize = true;
            this.rdSepia.Location = new System.Drawing.Point(0, 110);
            this.rdSepia.Margin = new System.Windows.Forms.Padding(4);
            this.rdSepia.Name = "rdSepia";
            this.rdSepia.Size = new System.Drawing.Size(65, 21);
            this.rdSepia.TabIndex = 6;
            this.rdSepia.Text = "Sepia";
            this.rdSepia.UseVisualStyleBackColor = true;
            this.rdSepia.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdMotionBlur
            // 
            this.rdMotionBlur.AutoSize = true;
            this.rdMotionBlur.Location = new System.Drawing.Point(259, 81);
            this.rdMotionBlur.Margin = new System.Windows.Forms.Padding(4);
            this.rdMotionBlur.Name = "rdMotionBlur";
            this.rdMotionBlur.Size = new System.Drawing.Size(96, 21);
            this.rdMotionBlur.TabIndex = 8;
            this.rdMotionBlur.Text = "MotionBlur";
            this.rdMotionBlur.UseVisualStyleBackColor = true;
            this.rdMotionBlur.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdGrayscale
            // 
            this.rdGrayscale.AutoSize = true;
            this.rdGrayscale.Checked = true;
            this.rdGrayscale.Location = new System.Drawing.Point(0, 23);
            this.rdGrayscale.Margin = new System.Windows.Forms.Padding(4);
            this.rdGrayscale.Name = "rdGrayscale";
            this.rdGrayscale.Size = new System.Drawing.Size(116, 21);
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
            this.rdEmboss.Location = new System.Drawing.Point(259, 52);
            this.rdEmboss.Margin = new System.Windows.Forms.Padding(4);
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
            this.rdFindEdges.Margin = new System.Windows.Forms.Padding(4);
            this.rdFindEdges.Name = "rdFindEdges";
            this.rdFindEdges.Size = new System.Drawing.Size(100, 21);
            this.rdFindEdges.TabIndex = 7;
            this.rdFindEdges.Text = "Find Edges";
            this.rdFindEdges.UseVisualStyleBackColor = true;
            this.rdFindEdges.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdNegative
            // 
            this.rdNegative.AutoSize = true;
            this.rdNegative.Location = new System.Drawing.Point(0, 81);
            this.rdNegative.Margin = new System.Windows.Forms.Padding(4);
            this.rdNegative.Name = "rdNegative";
            this.rdNegative.Size = new System.Drawing.Size(85, 21);
            this.rdNegative.TabIndex = 5;
            this.rdNegative.Text = "Negativo";
            this.rdNegative.UseVisualStyleBackColor = true;
            this.rdNegative.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdTransparency
            // 
            this.rdTransparency.AutoSize = true;
            this.rdTransparency.Location = new System.Drawing.Point(0, 52);
            this.rdTransparency.Margin = new System.Windows.Forms.Padding(4);
            this.rdTransparency.Name = "rdTransparency";
            this.rdTransparency.Size = new System.Drawing.Size(121, 21);
            this.rdTransparency.TabIndex = 4;
            this.rdTransparency.Text = "Transparencia";
            this.rdTransparency.UseVisualStyleBackColor = true;
            this.rdTransparency.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.lblTimeTaken);
            this.grbOutput.Controls.Add(this.lblTiempoTitle);
            this.grbOutput.Location = new System.Drawing.Point(477, 15);
            this.grbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Padding = new System.Windows.Forms.Padding(4);
            this.grbOutput.Size = new System.Drawing.Size(287, 186);
            this.grbOutput.TabIndex = 1;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Estado";
            // 
            // lblTimeTaken
            // 
            this.lblTimeTaken.AutoSize = true;
            this.lblTimeTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTaken.Location = new System.Drawing.Point(8, 106);
            this.lblTimeTaken.Name = "lblTimeTaken";
            this.lblTimeTaken.Size = new System.Drawing.Size(0, 25);
            this.lblTimeTaken.TabIndex = 1;
            this.lblTimeTaken.Click += new System.EventHandler(this.lblTimeTaken_Click);
            // 
            // lblTiempoTitle
            // 
            this.lblTiempoTitle.AutoSize = true;
            this.lblTiempoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoTitle.Location = new System.Drawing.Point(8, 52);
            this.lblTiempoTitle.Name = "lblTiempoTitle";
            this.lblTiempoTitle.Size = new System.Drawing.Size(0, 25);
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
            this.cmbCores.Location = new System.Drawing.Point(368, 473);
            this.cmbCores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCores.Name = "cmbCores";
            this.cmbCores.Size = new System.Drawing.Size(101, 24);
            this.cmbCores.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 473);
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
            // cmbMetodo
            // 
            this.cmbMetodo.FormattingEnabled = true;
            this.cmbMetodo.Items.AddRange(new object[] {
            "Secuencial",
            "Paralelo"});
            this.cmbMetodo.Location = new System.Drawing.Point(79, 473);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(121, 24);
            this.cmbMetodo.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Método";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 547);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMetodo);
            this.Controls.Add(this.lblBarValue);
            this.Controls.Add(this.valueBar);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCores);
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
            ((System.ComponentModel.ISupportInitialize)(this.temporizador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueBar)).EndInit();
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
        private System.Windows.Forms.RadioButton rdParedLadrillo;
        private System.Windows.Forms.RadioButton rdSegmentacion;
        private System.Windows.Forms.RadioButton rdCompPerdida;
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
        private System.Windows.Forms.RadioButton rdSolarise;
        private System.Windows.Forms.RadioButton rdDilatacion;
        private System.Windows.Forms.TrackBar valueBar;
        private System.Windows.Forms.Label lblBarValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMetodo;
    }
}

