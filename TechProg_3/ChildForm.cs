using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechProg_3
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        public void LoadPicture(string FileName)
        {
            if (System.IO.File.Exists(FileName))
            {
                this.pictureBox1.Load(FileName);

                if (pictureBox1.Image.Width < pictureBox1.ClientRectangle.Width / 10)
                {
                    ViewingStyle.SelectedIndex = 2;
                }
                else
                    ViewingStyle.SelectedIndex = 0;


                statusStrip1.Items[0].Text = "Ширина: " + pictureBox1.Image.Width.ToString() + "; Высота: " + pictureBox1.Image.Height.ToString();
            }
        }

        private void ViewingStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.AutoScroll = false;
            this.pictureBox1.Dock = DockStyle.Fill;

            switch (ViewingStyle.SelectedIndex)
            {
                case 0: this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; break;
                case 1: this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; break;
                case 2: this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage; break;
                case 3: ScrollUpdate(); break;
            }
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            this.pictureBox1.Size = this.panel1.ClientSize;
        }

        private void ScrollUpdate()
        {
            this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            this.pictureBox1.Dock = DockStyle.None;
            this.pictureBox1.Location = new Point(0, 0);

            this.panel1.AutoScroll = true;
        }
    }
}
