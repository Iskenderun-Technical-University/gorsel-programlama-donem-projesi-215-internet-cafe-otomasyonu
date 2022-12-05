namespace ProjeInternetCafe
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMasaAc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKapa = new System.Windows.Forms.Button();
            this.buttonDurdur = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSuresiz = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 98);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(679, 25);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(279, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // buttonMasaAc
            // 
            this.buttonMasaAc.Location = new System.Drawing.Point(49, 142);
            this.buttonMasaAc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMasaAc.Name = "buttonMasaAc";
            this.buttonMasaAc.Size = new System.Drawing.Size(98, 22);
            this.buttonMasaAc.TabIndex = 3;
            this.buttonMasaAc.Text = "Masa aç";
            this.buttonMasaAc.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(536, 164);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 23);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Süre giriniz";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonKapa
            // 
            this.buttonKapa.Location = new System.Drawing.Point(49, 169);
            this.buttonKapa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKapa.Name = "buttonKapa";
            this.buttonKapa.Size = new System.Drawing.Size(98, 22);
            this.buttonKapa.TabIndex = 7;
            this.buttonKapa.Text = "Masa kapa";
            this.buttonKapa.UseVisualStyleBackColor = true;
            // 
            // buttonDurdur
            // 
            this.buttonDurdur.Location = new System.Drawing.Point(49, 195);
            this.buttonDurdur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDurdur.Name = "buttonDurdur";
            this.buttonDurdur.Size = new System.Drawing.Size(98, 22);
            this.buttonDurdur.TabIndex = 8;
            this.buttonDurdur.Text = "Masa durdur";
            this.buttonDurdur.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.labelCost);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(234, 127);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 94);
            this.panel1.TabIndex = 9;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(106, 42);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(38, 15);
            this.labelCost.TabIndex = 3;
            this.labelCost.Text = "label5";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(106, 19);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(58, 15);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "labelTime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ücret:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kalan süre:";
            // 
            // buttonSuresiz
            // 
            this.buttonSuresiz.Location = new System.Drawing.Point(551, 139);
            this.buttonSuresiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSuresiz.Name = "buttonSuresiz";
            this.buttonSuresiz.Size = new System.Drawing.Size(98, 22);
            this.buttonSuresiz.TabIndex = 10;
            this.buttonSuresiz.Text = "Süresiz";
            this.buttonSuresiz.UseVisualStyleBackColor = true;
            this.buttonSuresiz.Click += new System.EventHandler(this.buttonSuresiz_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(49, 221);
            this.buttonEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(98, 22);
            this.buttonEkle.TabIndex = 11;
            this.buttonEkle.Text = "Süre ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.buttonSuresiz);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDurdur);
            this.Controls.Add(this.buttonKapa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonMasaAc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private Button buttonMasaAc;
        private TextBox textBox1;
        private Label label2;
        private Button buttonKapa;
        private Button buttonDurdur;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label labelTime;
        private Label labelCost;
        private Button buttonSuresiz;
        private Button buttonEkle;
        public Label label1;
    }
}