
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
            this.rdSolarized = new System.Windows.Forms.RadioButton();
            this.rdDilate = new System.Windows.Forms.RadioButton();
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
            this.grbInput.Location = new System.Drawing.Point(21, 18);
            this.grbInput.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grbInput.Name = "grbInput";
            this.grbInput.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grbInput.Size = new System.Drawing.Size(363, 446);
            this.grbInput.TabIndex = 0;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Opciones de Filtros";
            // 
            // rdSolarized
            // 
            this.rdSolarized.AutoSize = true;
            this.rdSolarized.Location = new System.Drawing.Point(3, 203);
            this.rdSolarized.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdSolarized.Name = "rdSolarized";
            this.rdSolarized.Size = new System.Drawing.Size(96, 21);
            this.rdSolarized.TabIndex = 14;
            this.rdSolarized.TabStop = true;
            this.rdSolarized.Text = "Solarizado";
            this.rdSolarized.UseVisualStyleBackColor = true;
            this.rdSolarized.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdDilate
            // 
            this.rdDilate.AutoSize = true;
            this.rdDilate.Location = new System.Drawing.Point(3, 238);
            this.rdDilate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdDilate.Name = "rdDilate";
            this.rdDilate.Size = new System.Drawing.Size(91, 21);
            this.rdDilate.TabIndex = 13;
            this.rdDilate.TabStop = true;
            this.rdDilate.Text = "Dilatación";
            this.rdDilate.UseVisualStyleBackColor = true;
            this.rdDilate.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdAjusteBrillo
            // 
            this.rdAjusteBrillo.AutoSize = true;
            this.rdAjusteBrillo.Location = new System.Drawing.Point(0, 169);
            this.rdAjusteBrillo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.rdGausianBlur.Location = new System.Drawing.Point(248, 100);
            this.rdGausianBlur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdGausianBlur.Name = "rdGausianBlur";
            this.rdGausianBlur.Size = new System.Drawing.Size(107, 21);
            this.rdGausianBlur.TabIndex = 10;
            this.rdGausianBlur.TabStop = true;
            this.rdGausianBlur.Text = "GausianBlur";
            this.rdGausianBlur.UseVisualStyleBackColor = true;
            this.rdGausianBlur.Click += new System.EventHandler(this.WhichRBWasClicked);
            // 
            // rdSepia
            // 
            this.rdSepia.AutoSize = true;
            this.rdSepia.Location = new System.Drawing.Point(0, 135);
            this.rdSepia.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.rdMotionBlur.Location = new System.Drawing.Point(247, 140);
            this.rdMotionBlur.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.rdGrayscale.Location = new System.Drawing.Point(0, 28);
            this.rdGrayscale.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.rdEmboss.Location = new System.Drawing.Point(248, 72);
            this.rdEmboss.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.rdFindEdges.Location = new System.Drawing.Point(248, 39);
            this.rdFindEdges.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.rdNegative.Location = new System.Drawing.Point(0, 100);
            this.rdNegative.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.rdTransparency.Location = new System.Drawing.Point(0, 64);
            this.rdTransparency.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rdTransparency.Name = "rdTransparency";
            this.rdTransparency.Size = new System.Drawing.Size(121, 21);
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
            this.grbOutput.Location = new System.Drawing.Point(394, 18);
            this.grbOutput.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grbOutput.Size = new System.Drawing.Size(473, 229);
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
            this.cmbCores.Location = new System.Drawing.Point(319, 441);
            this.cmbCores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCores.Name = "cmbCores";
            this.cmbCores.Size = new System.Drawing.Size(101, 24);
            this.cmbCores.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Núcleos \r\nDisponibles";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(525, 427);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(287, 48);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Método";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbMethods
            // 
            this.cmbMethods.FormattingEnabled = true;
            this.cmbMethods.Location = new System.Drawing.Point(95, 444);
            this.cmbMethods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMethods.Name = "cmbMethods";
            this.cmbMethods.Size = new System.Drawing.Size(77, 24);
            this.cmbMethods.TabIndex = 7;
            this.cmbMethods.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // valueBar1
            // 
            this.valueBar1.Location = new System.Drawing.Point(394, 254);
            this.valueBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valueBar1.Maximum = 100;
            this.valueBar1.Name = "valueBar1";
            this.valueBar1.Size = new System.Drawing.Size(473, 56);
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
            this.lblBarValueData.Location = new System.Drawing.Point(621, 312);
            this.lblBarValueData.Name = "lblBarValueData";
            this.lblBarValueData.Size = new System.Drawing.Size(16, 17);
            this.lblBarValueData.TabIndex = 26;
            this.lblBarValueData.Text = "0";
            this.lblBarValueData.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 546);
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
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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

