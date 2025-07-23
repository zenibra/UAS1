using System;
using static System.Net.Mime.MediaTypeNames;

public class Class1
{
	public Class1()
	{
        this.Text = "QR Code";
        this.Size = new Size(400, 400);
        this.StartPosition = FormStartPosition.CenterParent;
        PictureBox pictureBox = new PictureBox
        {
            Dock = DockStyle.Fill,
            SizeMode = PictureBoxSizeMode.Zoom
        };
        try
        {
            pictureBox.Image = Image.FromFile("qrcode.png");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Gagal membuat gambar" + ex.Message);
        }
        this.Controls.Add(pictureBox);
    }
}
