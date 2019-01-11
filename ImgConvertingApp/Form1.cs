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

namespace ImgConvertingApp
{
    public partial class Form1 : Form
    {
        public string source { get; set; }
        public string destination { get; set; }

        public void saveFile()
        {
            SaveFileDialog of = new SaveFileDialog();
            of.Filter = "jpg files (*.jpg)|*.jpeg| bmp files (*.bmp)|*.bmp| gif files (*.gif)|*.gif| png files (*.png)|*.png";
            of.ShowDialog();
            destination = of.FileName;
        }

        ImageApi.Class1 api = new ImageApi.Class1();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory= Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            of.Filter = " jpg files (*.jpg)|*.jpg| jpeg files (*.jpeg)|*.jpeg| bmp files (*.bmp)|*.bmp| gif files (*.gif)|*.gif| png files (*.png)|*.png";
            of.ShowDialog();
            source = of.FileName;
            pictureBox1.Image = new Bitmap(of.FileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            label1.Text = of.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFile();
            api.Convert(source, destination, "jpg");
            label2.Text = destination;
            pictureBox1.Image = new Bitmap(destination);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFile();
            api.Convert(source, destination, "png");
            label2.Text = destination;
            pictureBox1.Image = new Bitmap(destination);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFile();
            api.Convert(source, destination, "gif");
            label2.Text = destination;
            pictureBox1.Image = new Bitmap(destination);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFile();
            api.Resize(source, destination, "scew", 400, 400,0,0);
            label2.Text = destination;
            pictureBox1.Image = new Bitmap(destination);
        }

        private Point initialMousePos;
        private Rectangle rect;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.initialMousePos = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // Save the final position of the mouse
            Point finalMousePos = e.Location;

            // Create the rectangle from the two points
            rect = Rectangle.FromLTRB(this.initialMousePos.X,this.initialMousePos.Y, finalMousePos.X, finalMousePos.Y);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFile();
            api.Resize(source, destination,"crop", rect.Width, rect.Height, this.initialMousePos.X, this.initialMousePos.Y);
            label2.Text = destination;
            pictureBox1.Image = new Bitmap(destination);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int width = int.Parse(textBox2.Text);
            int height = 0;
            if (textBox2.Text != null)
            {
                height = int.Parse(textBox2.Text);
            }
            saveFile();
            api.Resize(source, destination, "keepaspect", width, height, 0, 0);
            label2.Text = destination;
            pictureBox1.Image = new Bitmap(destination);
        }
    }
}
