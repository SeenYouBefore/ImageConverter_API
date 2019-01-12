namespace ImgConvertingApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.Page;

    public partial class MainForm : Form
    {
        private Point initialMousePos;
        private Rectangle rect;
        private ImageApi.Image api = new ImageApi.Image();

        public MainForm()
        {
            this.InitializeComponent();
        }

        public string Source { get; set; }

        public string Destination { get; set; }

        private void SaveFile()
        {
            SaveFileDialog of = new SaveFileDialog();
            of.Filter = "jpg files (*.jpg)|*.jpeg| bmp files (*.bmp)|*.bmp| gif files (*.gif)|*.gif| png files (*.png)|*.png";
            of.ShowDialog();
            this.Destination = of.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            of.Filter = " jpg files (*.jpg)|*.jpg| jpeg files (*.jpeg)|*.jpeg| bmp files (*.bmp)|*.bmp| gif files (*.gif)|*.gif| png files (*.png)|*.png";
            of.ShowDialog();
            this.Source = of.FileName;
            this.PictureBox1.Image = new Bitmap(of.FileName);
            this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            this.label1.Text = of.FileName;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.SaveFile();
            this.api.Convert(this.Source, this.Destination, "jpg");
            this.label2.Text = this.Destination;
            this.PictureBox1.Image = new Bitmap(this.Destination);
            this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.SaveFile();
            this.api.Convert(this.Source, this.Destination, "png");
            this.label2.Text = this.Destination;
            this.PictureBox1.Image = new Bitmap(this.Destination);
            this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.SaveFile();
            this.api.Convert(this.Source, this.Destination, "gif");
            this.label2.Text = this.Destination;
            this.PictureBox1.Image = new Bitmap(this.Destination);
            this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.SaveFile();
            this.api.Resize(this.Source, this.Destination, "scew", 400, 400, 0, 0);
            this.label2.Text = this.Destination;
            this.PictureBox1.Image = new Bitmap(this.Destination);
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.initialMousePos = e.Location;
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Point finalMousePos = e.Location;
            this.rect = Rectangle.FromLTRB(this.initialMousePos.X, this.initialMousePos.Y, finalMousePos.X, finalMousePos.Y);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.SaveFile();
            this.api.Resize(this.Source, this.Destination, "crop", this.rect.Width, this.rect.Height, this.initialMousePos.X, this.initialMousePos.Y);
            this.label2.Text = this.Destination;
            this.PictureBox1.Image = new Bitmap(this.Destination);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            int width = int.Parse(this.TextBox_Width.Text);
            int height = 0;
            if (this.TextBox_Width.Text != null)
            {
                height = int.Parse(this.TextBox_Width.Text);
            }

            this.SaveFile();
            this.api.Resize(this.Source, this.Destination, "keepaspect", width, height, 0, 0);
            this.label2.Text = this.Destination;
            this.PictureBox1.Image = new Bitmap(this.Destination);
        }
    }
}
