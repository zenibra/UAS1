namespace UTS_pemrograman
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Welcome = new Label();
            mohon = new Label();
            LabelNama = new Label();
            LabelNomer = new Label();
            LabelAlamat = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            UkuranKaos = new ComboBox();
            groupBox3 = new GroupBox();
            PanjangLengan = new ComboBox();
            groupBox4 = new GroupBox();
            UkuranSablon = new ComboBox();
            groupBox5 = new GroupBox();
            button1 = new Button();
            groupBox6 = new GroupBox();
            BahanKaos = new ComboBox();
            TotalHarga = new Label();
            ButtonCheckout = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.BackColor = Color.Transparent;
            Welcome.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Welcome.ForeColor = SystemColors.MenuHighlight;
            Welcome.Location = new Point(66, 6);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(223, 29);
            Welcome.TabIndex = 0;
            Welcome.Text = "Selamat Datang";
            // 
            // mohon
            // 
            mohon.AutoSize = true;
            mohon.BackColor = Color.Transparent;
            mohon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mohon.ForeColor = SystemColors.Highlight;
            mohon.Location = new Point(85, 35);
            mohon.Name = "mohon";
            mohon.Size = new Size(185, 15);
            mohon.TabIndex = 1;
            mohon.Text = "Mohon isi data dan pesanan anda";
            // 
            // LabelNama
            // 
            LabelNama.BackColor = Color.IndianRed;
            LabelNama.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            LabelNama.ForeColor = SystemColors.ControlLightLight;
            LabelNama.Location = new Point(9, 64);
            LabelNama.Name = "LabelNama";
            LabelNama.Size = new Size(100, 23);
            LabelNama.TabIndex = 2;
            LabelNama.Text = "Nama Lengkap";
            LabelNama.TextAlign = ContentAlignment.MiddleLeft;
            LabelNama.Click += LabelNama_Click;
            // 
            // LabelNomer
            // 
            LabelNomer.BackColor = Color.IndianRed;
            LabelNomer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            LabelNomer.ForeColor = SystemColors.ControlLightLight;
            LabelNomer.Location = new Point(9, 90);
            LabelNomer.Name = "LabelNomer";
            LabelNomer.Size = new Size(100, 23);
            LabelNomer.TabIndex = 3;
            LabelNomer.Text = "No Whatsapp";
            LabelNomer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelAlamat
            // 
            LabelAlamat.BackColor = Color.IndianRed;
            LabelAlamat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            LabelAlamat.ForeColor = SystemColors.ControlLightLight;
            LabelAlamat.Location = new Point(9, 115);
            LabelAlamat.Name = "LabelAlamat";
            LabelAlamat.Size = new Size(100, 23);
            LabelAlamat.TabIndex = 4;
            LabelAlamat.Text = "Alamat";
            LabelAlamat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DodgerBlue;
            textBox1.ForeColor = SystemColors.HighlightText;
            textBox1.Location = new Point(115, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DodgerBlue;
            textBox2.ForeColor = SystemColors.HighlightText;
            textBox2.Location = new Point(115, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DodgerBlue;
            textBox3.ForeColor = SystemColors.HighlightText;
            textBox3.Location = new Point(115, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(217, 23);
            textBox3.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.BackgroundImage = Properties.Resources.back_color_3;
            groupBox1.Controls.Add(radioButton7);
            groupBox1.Controls.Add(radioButton8);
            groupBox1.Controls.Add(radioButton9);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(9, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 98);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Warna Kaos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton7
            // 
            radioButton7.BackColor = Color.Navy;
            radioButton7.ForeColor = SystemColors.ButtonHighlight;
            radioButton7.Location = new Point(209, 63);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(94, 24);
            radioButton7.TabIndex = 26;
            radioButton7.TabStop = true;
            radioButton7.Text = "Navy";
            radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton8
            // 
            radioButton8.BackColor = Color.Coral;
            radioButton8.ForeColor = SystemColors.ButtonHighlight;
            radioButton8.Location = new Point(209, 42);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(94, 24);
            radioButton8.TabIndex = 25;
            radioButton8.TabStop = true;
            radioButton8.Text = "Jingga";
            radioButton8.UseVisualStyleBackColor = false;
            // 
            // radioButton9
            // 
            radioButton9.BackColor = Color.LightCoral;
            radioButton9.ForeColor = SystemColors.ButtonHighlight;
            radioButton9.Location = new Point(209, 23);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(94, 19);
            radioButton9.TabIndex = 24;
            radioButton9.TabStop = true;
            radioButton9.Text = "Pink";
            radioButton9.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.BackColor = Color.PaleTurquoise;
            radioButton4.ForeColor = SystemColors.ButtonHighlight;
            radioButton4.Location = new Point(114, 63);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(94, 24);
            radioButton4.TabIndex = 23;
            radioButton4.TabStop = true;
            radioButton4.Text = "Biru";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            radioButton5.BackColor = Color.FromArgb(0, 192, 0);
            radioButton5.ForeColor = SystemColors.ButtonHighlight;
            radioButton5.Location = new Point(114, 42);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(94, 24);
            radioButton5.TabIndex = 22;
            radioButton5.TabStop = true;
            radioButton5.Text = "Hijau";
            radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton6
            // 
            radioButton6.BackColor = Color.Firebrick;
            radioButton6.ForeColor = SystemColors.ButtonHighlight;
            radioButton6.Location = new Point(114, 23);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(94, 19);
            radioButton6.TabIndex = 21;
            radioButton6.TabStop = true;
            radioButton6.Text = "Merah";
            radioButton6.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.BackColor = SystemColors.ActiveCaptionText;
            radioButton3.ForeColor = SystemColors.ButtonHighlight;
            radioButton3.Location = new Point(19, 63);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 24);
            radioButton3.TabIndex = 20;
            radioButton3.TabStop = true;
            radioButton3.Text = "Hitam";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.BackColor = SystemColors.AppWorkspace;
            radioButton2.Location = new Point(19, 42);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 24);
            radioButton2.TabIndex = 19;
            radioButton2.TabStop = true;
            radioButton2.Text = "Abu-Abu";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.BackColor = SystemColors.ButtonHighlight;
            radioButton1.ForeColor = SystemColors.ActiveCaptionText;
            radioButton1.Location = new Point(19, 23);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "Putih";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.back_color_2;
            groupBox2.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox2.Controls.Add(UkuranKaos);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.ImeMode = ImeMode.Off;
            groupBox2.Location = new Point(9, 258);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(161, 54);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ukuran Kaos";
            // 
            // UkuranKaos
            // 
            UkuranKaos.FormattingEnabled = true;
            UkuranKaos.Items.AddRange(new object[] { "S", "M", "L", "XL", "XXL", "XXL" });
            UkuranKaos.Location = new Point(6, 22);
            UkuranKaos.Name = "UkuranKaos";
            UkuranKaos.Size = new Size(149, 23);
            UkuranKaos.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = Properties.Resources.back_color;
            groupBox3.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox3.Controls.Add(PanjangLengan);
            groupBox3.ForeColor = SystemColors.ControlLightLight;
            groupBox3.Location = new Point(176, 258);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(156, 54);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Panjang Lengan";
            // 
            // PanjangLengan
            // 
            PanjangLengan.FormattingEnabled = true;
            PanjangLengan.Items.AddRange(new object[] { "Lengan Pendek", "Lengan Panjang" });
            PanjangLengan.Location = new Point(8, 22);
            PanjangLengan.Name = "PanjangLengan";
            PanjangLengan.Size = new Size(139, 23);
            PanjangLengan.TabIndex = 0;
            PanjangLengan.SelectedIndexChanged += PanjangLengan_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackgroundImage = Properties.Resources.back_color_2;
            groupBox4.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox4.Controls.Add(UkuranSablon);
            groupBox4.ForeColor = SystemColors.ControlLightLight;
            groupBox4.ImeMode = ImeMode.Off;
            groupBox4.Location = new Point(9, 318);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(161, 54);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ukuran Sablon";
            // 
            // UkuranSablon
            // 
            UkuranSablon.FormattingEnabled = true;
            UkuranSablon.Items.AddRange(new object[] { "A3 Depan", "A3 Belakang", "A4 Depan", "A4 Belakang", "A5 Depan", "A5 Belakang", "A6 Belakang", "A7 Depan Kiri", "A7 Depan Kanan" });
            UkuranSablon.Location = new Point(6, 22);
            UkuranSablon.Name = "UkuranSablon";
            UkuranSablon.Size = new Size(149, 23);
            UkuranSablon.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.BackgroundImage = Properties.Resources.back_color_2;
            groupBox5.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox5.Controls.Add(button1);
            groupBox5.ForeColor = SystemColors.ControlLightLight;
            groupBox5.ImeMode = ImeMode.Off;
            groupBox5.Location = new Point(8, 378);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(162, 54);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            groupBox5.Text = "Gambar Sablon";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.Desktop;
            button1.Location = new Point(7, 21);
            button1.Name = "button1";
            button1.Size = new Size(149, 23);
            button1.TabIndex = 0;
            button1.Text = "Kirim File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox6
            // 
            groupBox6.BackgroundImage = Properties.Resources.back_color;
            groupBox6.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox6.Controls.Add(BahanKaos);
            groupBox6.ForeColor = SystemColors.ControlLightLight;
            groupBox6.ImeMode = ImeMode.Off;
            groupBox6.Location = new Point(176, 318);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(156, 54);
            groupBox6.TabIndex = 22;
            groupBox6.TabStop = false;
            groupBox6.Text = "Bahan Kaos";
            // 
            // BahanKaos
            // 
            BahanKaos.FormattingEnabled = true;
            BahanKaos.Items.AddRange(new object[] { "Polymer", "Semi Katun", "Katun", "Katun Combed" });
            BahanKaos.Location = new Point(6, 21);
            BahanKaos.Name = "BahanKaos";
            BahanKaos.Size = new Size(141, 23);
            BahanKaos.TabIndex = 0;
            BahanKaos.SelectedIndexChanged += BahanKaos_SelectedIndexChanged;
            // 
            // TotalHarga
            // 
            TotalHarga.AutoSize = true;
            TotalHarga.BackColor = SystemColors.ButtonHighlight;
            TotalHarga.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalHarga.Location = new Point(18, 452);
            TotalHarga.Name = "TotalHarga";
            TotalHarga.Size = new Size(50, 21);
            TotalHarga.TabIndex = 23;
            TotalHarga.Text = "..........";
            TotalHarga.Click += CalculateTotalPrice_Click;
            // 
            // ButtonCheckout
            // 
            ButtonCheckout.BackColor = Color.FromArgb(255, 128, 0);
            ButtonCheckout.FlatStyle = FlatStyle.Flat;
            ButtonCheckout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonCheckout.ForeColor = SystemColors.ButtonHighlight;
            ButtonCheckout.Location = new Point(176, 449);
            ButtonCheckout.Name = "ButtonCheckout";
            ButtonCheckout.Size = new Size(170, 49);
            ButtonCheckout.TabIndex = 24;
            ButtonCheckout.Text = "CHECKOUT";
            ButtonCheckout.UseVisualStyleBackColor = false;
            ButtonCheckout.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.background;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(343, 452);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.DoubleClick += pictureBox1_DoubleClick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Location = new Point(-2, 449);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(348, 50);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 497);
            Controls.Add(ButtonCheckout);
            Controls.Add(TotalHarga);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LabelAlamat);
            Controls.Add(LabelNomer);
            Controls.Add(LabelNama);
            Controls.Add(mohon);
            Controls.Add(Welcome);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Aplikasi Kaos Kelompok 5";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Welcome;
        private Label mohon;
        private Label LabelNama;
        private Label LabelNomer;
        private Label LabelAlamat;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private GroupBox groupBox2;
        private ComboBox UkuranKaos;
        private GroupBox groupBox3;
        private ComboBox PanjangLengan;
        private GroupBox groupBox4;
        private ComboBox UkuranSablon;
        private GroupBox groupBox5;
        private Button button1;
        private GroupBox groupBox6;
        private ComboBox BahanKaos;
        private Label TotalHarga;
        private Button ButtonCheckout;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
