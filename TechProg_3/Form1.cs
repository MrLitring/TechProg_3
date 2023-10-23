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
                string folderName = folderDialog.SelectedPath;
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
    }
}
