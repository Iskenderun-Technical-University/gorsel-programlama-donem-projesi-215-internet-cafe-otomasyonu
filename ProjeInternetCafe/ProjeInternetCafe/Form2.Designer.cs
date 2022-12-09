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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMasaAc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKapa = new System.Windows.Forms.Button();
            this.buttonDurdur = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelGecen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSuresiz = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.timerM1 = new System.Windows.Forms.Timer(this.components);
            this.timerM2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonMasaAc
            // 
            this.buttonMasaAc.Location = new System.Drawing.Point(56, 189);
            this.buttonMasaAc.Name = "buttonMasaAc";
            this.buttonMasaAc.Size = new System.Drawing.Size(112, 29);
            this.buttonMasaAc.TabIndex = 3;
            this.buttonMasaAc.Text = "Masa aç";
            this.buttonMasaAc.UseVisualStyleBackColor = true;
            this.buttonMasaAc.Click += new System.EventHandler(this.buttonMasaAc_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(613, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 27);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Süre giriniz";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonKapa
            // 
            this.buttonKapa.Location = new System.Drawing.Point(56, 225);
            this.buttonKapa.Name = "buttonKapa";
            this.buttonKapa.Size = new System.Drawing.Size(112, 29);
            this.buttonKapa.TabIndex = 7;
            this.buttonKapa.Text = "Masa kapa";
            this.buttonKapa.UseVisualStyleBackColor = true;
            // 
            // buttonDurdur
            // 
            this.buttonDurdur.Location = new System.Drawing.Point(56, 260);
            this.buttonDurdur.Name = "buttonDurdur";
            this.buttonDurdur.Size = new System.Drawing.Size(112, 29);
            this.buttonDurdur.TabIndex = 8;
            this.buttonDurdur.Text = "Masa durdur";
            this.buttonDurdur.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.labelGecen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelCost);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(267, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 125);
            this.panel1.TabIndex = 9;
            // 
            // labelGecen
            // 
            this.labelGecen.AutoSize = true;
            this.labelGecen.Location = new System.Drawing.Point(121, 50);
            this.labelGecen.Name = "labelGecen";
            this.labelGecen.Size = new System.Drawing.Size(17, 20);
            this.labelGecen.TabIndex = 5;
            this.labelGecen.Text = "0";
            this.labelGecen.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Geçen süre:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(121, 74);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(50, 20);
            this.labelCost.TabIndex = 3;
            this.labelCost.Text = "label5";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(121, 25);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(75, 20);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "labelTime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ücret:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kalan süre:";
            // 
            // buttonSuresiz
            // 
            this.buttonSuresiz.Location = new System.Drawing.Point(630, 185);
            this.buttonSuresiz.Name = "buttonSuresiz";
            this.buttonSuresiz.Size = new System.Drawing.Size(112, 29);
            this.buttonSuresiz.TabIndex = 10;
            this.buttonSuresiz.Text = "Süresiz";
            this.buttonSuresiz.UseVisualStyleBackColor = true;
            this.buttonSuresiz.Click += new System.EventHandler(this.buttonSuresiz_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(56, 295);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(112, 29);
            this.buttonEkle.TabIndex = 11;
            this.buttonEkle.Text = "Süre ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            // 
            // timerM1
            // 
            this.timerM1.Tick += new System.EventHandler(this.timerM1_Tick);
            // 
            // timerM2
            // 
            this.timerM2.Tick += new System.EventHandler(this.timerM2_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 451);
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private Label label5;
        public Label labelGecen;
        private System.Windows.Forms.Timer timerM1;
        private System.Windows.Forms.Timer timerM2;
    }
}