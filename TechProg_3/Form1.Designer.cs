namespace TechProg_3
{
    partial class MDIParent
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAboutAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolCloseAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolAboutAuthor = new System.Windows.Forms.ToolStripButton();
            this.ToolAboutProgram = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolOpen,
            this.toolStripSeparator3,
            this.toolCloseAll,
            this.toolStripSeparator4,
            this.ToolAboutAuthor,
            this.ToolAboutProgram});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.splitter1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 379);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файлы изображений";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(182, 16);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(15, 360);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 360);
            this.listBox1.TabIndex = 1;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpen,
            this.toolStripSeparator2,
            this.MenuQuit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // MenuOpen
            // 
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.Size = new System.Drawing.Size(180, 22);
            this.MenuOpen.Text = "Открыть папку";
            // 
            // MenuQuit
            // 
            this.MenuQuit.Name = "MenuQuit";
            this.MenuQuit.Size = new System.Drawing.Size(180, 22);
            this.MenuQuit.Text = "Выход";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCascade,
            this.MenuVertical,
            this.MenuHorizontal,
            this.toolStripSeparator1,
            this.MenuCloseAll});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem2.Text = "Окна";
            // 
            // MenuCascade
            // 
            this.MenuCascade.Name = "MenuCascade";
            this.MenuCascade.Size = new System.Drawing.Size(180, 22);
            this.MenuCascade.Text = "Каскад";
            // 
            // MenuVertical
            // 
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(180, 22);
            this.MenuVertical.Text = "Вертикально";
            // 
            // MenuHorizontal
            // 
            this.MenuHorizontal.Name = "MenuHorizontal";
            this.MenuHorizontal.Size = new System.Drawing.Size(180, 22);
            this.MenuHorizontal.Text = "Горизонтально";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuCloseAll
            // 
            this.MenuCloseAll.Name = "MenuCloseAll";
            this.MenuCloseAll.Size = new System.Drawing.Size(180, 22);
            this.MenuCloseAll.Text = "Закрыть все";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAboutAuthor,
            this.MenuAboutProgram});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // MenuAboutAuthor
            // 
            this.MenuAboutAuthor.Name = "MenuAboutAuthor";
            this.MenuAboutAuthor.Size = new System.Drawing.Size(180, 22);
            this.MenuAboutAuthor.Text = "Об авторе";
            // 
            // MenuAboutProgram
            // 
            this.MenuAboutProgram.Name = "MenuAboutProgram";
            this.MenuAboutProgram.Size = new System.Drawing.Size(180, 22);
            this.MenuAboutProgram.Text = "О программе";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // ToolOpen
            // 
            this.ToolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolOpen.Image = ((System.Drawing.Image)(resources.GetObject("ToolOpen.Image")));
            this.ToolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolOpen.Name = "ToolOpen";
            this.ToolOpen.Size = new System.Drawing.Size(23, 22);
            this.ToolOpen.Text = "toolStripButton1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolCloseAll
            // 
            this.toolCloseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCloseAll.Image = ((System.Drawing.Image)(resources.GetObject("toolCloseAll.Image")));
            this.toolCloseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCloseAll.Name = "toolCloseAll";
            this.toolCloseAll.Size = new System.Drawing.Size(23, 22);
            this.toolCloseAll.Text = "toolStripButton2";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolAboutAuthor
            // 
            this.ToolAboutAuthor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolAboutAuthor.Image = ((System.Drawing.Image)(resources.GetObject("ToolAboutAuthor.Image")));
            this.ToolAboutAuthor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolAboutAuthor.Name = "ToolAboutAuthor";
            this.ToolAboutAuthor.Size = new System.Drawing.Size(23, 22);
            this.ToolAboutAuthor.Text = "toolStripButton3";
            // 
            // ToolAboutProgram
            // 
            this.ToolAboutProgram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolAboutProgram.Image = ((System.Drawing.Image)(resources.GetObject("ToolAboutProgram.Image")));
            this.ToolAboutProgram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolAboutProgram.Name = "ToolAboutProgram";
            this.ToolAboutProgram.Size = new System.Drawing.Size(23, 22);
            this.ToolAboutProgram.Text = "toolStripButton4";
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обозреватель изображений: Лавка Лапок";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem MenuQuit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuCascade;
        private System.Windows.Forms.ToolStripMenuItem MenuVertical;
        private System.Windows.Forms.ToolStripMenuItem MenuHorizontal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuCloseAll;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAboutAuthor;
        private System.Windows.Forms.ToolStripMenuItem MenuAboutProgram;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ToolOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolCloseAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ToolAboutAuthor;
        private System.Windows.Forms.ToolStripButton ToolAboutProgram;
    }
}

