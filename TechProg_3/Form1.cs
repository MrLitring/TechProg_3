using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechProg_3
{
    public partial class MDIParent : Form
    {
        string folderName;
        public MDIParent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            if(folderDialog.ShowDialog(this)==DialogResult.OK)
            {
                listBox1.Items.Clear();
                folderName = folderDialog.SelectedPath;
                this.statusStrip1.Items[0].Text = folderName;

                listBox1.Items.Clear();

                foreach(string elem in Directory.GetFiles(folderName
                    , "*.bmp", SearchOption.TopDirectoryOnly))
                {
                    this.listBox1.Items.Add(System.IO.Path.GetFileName(elem));
                }
                foreach (string elem in Directory.GetFiles(folderName
                    , "*.jpg", SearchOption.TopDirectoryOnly))
                {
                    this.listBox1.Items.Add(System.IO.Path.GetFileName(elem));
                }
                foreach (string elem in Directory.GetFiles(folderName
                    , "*.png", SearchOption.TopDirectoryOnly))
                {
                    this.listBox1.Items.Add(System.IO.Path.GetFileName(elem));
                }
            }
        }

        private void ClosingForm(Form form)
        {
            form.Hide();
            form.MdiParent = null;
            CalculateWinCount();
        }


        private void CalculateWinCount()
        {
            int winCount = this.MdiChildren.Count();
            this.StatusWindowsCount.Text = "Открыть окно: " + Convert.ToString(winCount);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string FileName = listBox1.SelectedItem.ToString();
            ChildForm Frm = new ChildForm(); 
            Frm.MdiParent = this;
            Frm.Width = (int)(this.Width * 0.6); 
            Frm.Height = (int)(this.Height * 0.6); 
            Frm.Text = "Изображение: " + FileName; 
            Frm.LoadPicture(folderName + "\\" + FileName); 
            
            Frm.FormClosed += (obj, args) => ClosingForm(Frm);
            Frm.Show(); 
            CalculateWinCount(); 
        }

        private void MenuQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuCloseAll_Click(object sender, EventArgs e)
        {
            foreach(Form form in MdiChildren)
            {
                form.Close();
            }
        }

        private void MenuCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MenuVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MenuHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MenuAboutAuthor_Click(object sender, EventArgs e)
        {
            AboutAuthor AA = new AboutAuthor();
            AA.ShowDialog();
        }

        private void MenuAboutProgram_Click(object sender, EventArgs e)
        {

        }
    }
}
