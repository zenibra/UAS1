using System.Diagnostics;
using System.Drawing.Printing;
using System.Drawing.Text;


namespace UTS_pemrograman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Pilih file yang akan di-submit",
                Filter = "All Files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("File yang dipilih : " + openFileDialog.FileName);
            }
        }

        private void PanjangLengan_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculatedTotalPrice();
        }

        private void LabelNama_Click(object sender, EventArgs e)
        {

        }

        private void CalculateTotalPrice_Click(object sender, EventArgs e)
        {

        }
        private void CalculatedTotalPrice()
        {
            int total = 0;
            total += 20000;

            if (PanjangLengan.SelectedItem != null && PanjangLengan.SelectedItem.ToString() == "Lengan Panjang")
            {
                total += 5000;
            }

            if (BahanKaos.SelectedItem != null)
            {
                string selectedbahan = BahanKaos.SelectedItem.ToString();
                switch (selectedbahan)
                {
                    case "Polymer":
                        total += 20000;
                        break;
                    case "Semi Katun":
                        total += 30000;
                        break;
                    case "Katun":
                        total += 40000;
                        break;
                    case "Katun Combed":
                        total += 50000;
                        break;
                }
            }
            TotalHarga.Text = "Total Harga" + "\n" + total.ToString("N0") + " Rupiah";
        }

        private void BahanKaos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculatedTotalPrice();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;
            radioButton3.CheckedChanged += radioButton_CheckedChanged;
            radioButton4.CheckedChanged += radioButton_CheckedChanged;
            radioButton5.CheckedChanged += radioButton_CheckedChanged;
            radioButton6.CheckedChanged += radioButton_CheckedChanged;
            radioButton7.CheckedChanged += radioButton_CheckedChanged;
            radioButton8.CheckedChanged += radioButton_CheckedChanged;
            radioButton9.CheckedChanged += radioButton_CheckedChanged;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            CalculatedTotalPrice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string summary = "Ringkasan Pesanan :\n\n";

            summary += "Nama \t\t: " + textBox1.Text + "\n";
            summary += "No Whatsapp \t: " + textBox2.Text + "\n";
            summary += "Alamat \t\t: " + textBox3.Text + "\n\n";

            string selectedColor = "";
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    selectedColor = rb.Text;
                    break;
                }
            }
            summary += "Warna Kaos \t: " + selectedColor + "\n";
            summary += "Ukuran Kaos \t: " + (UkuranKaos.SelectedItem != null ? UkuranKaos.SelectedItem.ToString() : "") + "\n";
            summary += "Panjang Lengan \t: " + (PanjangLengan.SelectedItem != null ? PanjangLengan.SelectedItem.ToString() : "") + "\n";
            summary += "Bahan Kaos \t: " + (BahanKaos.SelectedItem != null ? BahanKaos.SelectedItem.ToString() : "") + "\n";
            summary += "Ukuran Sablon \t: " + (UkuranSablon.SelectedItem != null ? UkuranSablon.SelectedItem.ToString() : "") + "\n\n";
            summary += TotalHarga.Text;
            {
                DialogResult result = MessageBox.Show(summary, "Ringkasan Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler(PrintPageHandler);

                    try
                    {
                        pd.Print();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan saat mencetak, mohon hubungi operator" + ex.Message);
                    }
                }
            }
        }


        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            string selectedColor = "";
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    selectedColor = rb.Text;
                    break;
                }
            }

            string printText = "Ringkasan Pesanan :\n\n" +
            "Nama \t\t: " + textBox1.Text + "\n" +
            "No Whatsapp \t: " + textBox2.Text + "\n" +
            "Alamat \t\t: " + textBox3.Text + "\n\n" +
            "Warna Kaos \t: " + selectedColor + "\n" +
            "Ukuran Kaos \t: " + (UkuranKaos.SelectedItem != null ? UkuranKaos.SelectedItem.ToString() : "") + "\n" +
            "Panjang Lengan \t: " + (PanjangLengan.SelectedItem != null ? PanjangLengan.SelectedItem.ToString() : "") + "\n" +
            "Bahan Kaos \t: " + (BahanKaos.SelectedItem != null ? BahanKaos.SelectedItem.ToString() : "") + "\n" +
            "Ukuran Sablon \t: " + (UkuranSablon.SelectedItem != null ? UkuranSablon.SelectedItem.ToString() : "") + "\n\n" +
            TotalHarga.Text;

            Font printFont = new Font("Arial", 12);
            e.Graphics.DrawString(printText, printFont, Brushes.Black, new PointF(50, 50));


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Welcome.Parent = pictureBox1;
            Welcome.BackColor = Color.Transparent;
            mohon.Parent = pictureBox1;
            mohon.BackColor = Color.Transparent;
        }
    }
}
