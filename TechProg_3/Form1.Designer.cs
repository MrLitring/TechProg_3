﻿namespace TechProg_3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolCloseAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusWindowsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ToolOpen = new System.Windows.Forms.ToolStripButton();
            this.ToolAboutAuthor = new System.Windows.Forms.ToolStripButton();
            this.ToolAboutProgram = new System.Windows.Forms.ToolStripButton();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAboutAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
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
            // MenuVertical
            // 
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(180, 22);
            this.MenuVertical.Text = "Вертикально";
            this.MenuVertical.Click += new System.EventHandler(this.MenuVertical_Click);
            // 
            // MenuHorizontal
            // 
            this.MenuHorizontal.Name = "MenuHorizontal";
            this.MenuHorizontal.Size = new System.Drawing.Size(180, 22);
            this.MenuHorizontal.Text = "Горизонтально";
            this.MenuHorizontal.Click += new System.EventHandler(this.MenuHorizontal_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
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
            this.toolStrip1.Size = new System.Drawing.Size(724, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolCloseAll
            // 
            this.toolCloseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCloseAll.Image = global::TechProg_3.Properties.Resources.zakryt_vse_okna;
            this.toolCloseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCloseAll.Name = "toolCloseAll";
            this.toolCloseAll.Size = new System.Drawing.Size(23, 22);
            this.toolCloseAll.Text = "Закрыть все";
            this.toolCloseAll.Click += new System.EventHandler(this.MenuCloseAll_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusPath,
            this.StatusWindowsCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(724, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusPath
            // 
            this.StatusPath.Name = "StatusPath";
            this.StatusPath.Size = new System.Drawing.Size(559, 17);
            this.StatusPath.Spring = true;
            this.StatusPath.Text = "StatusPath";
            this.StatusPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusWindowsCount
            // 
            this.StatusWindowsCount.AutoSize = false;
            this.StatusWindowsCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusWindowsCount.Name = "StatusWindowsCount";
            this.StatusWindowsCount.Size = new System.Drawing.Size(150, 17);
            this.StatusWindowsCount.Text = "StatusWindowsCount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.splitter1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 330);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файлы изображений";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 311);
            this.listBox1.TabIndex = 1;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(182, 16);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(15, 311);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // ToolOpen
            // 
            this.ToolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolOpen.Image = global::TechProg_3.Properties.Resources.imageres_184;
            this.ToolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolOpen.Name = "ToolOpen";
            this.ToolOpen.Size = new System.Drawing.Size(23, 22);
            this.ToolOpen.Text = "Открыть папку";
            this.ToolOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // ToolAboutAuthor
            // 
            this.ToolAboutAuthor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolAboutAuthor.Image = global::TechProg_3.Properties.Resources.imageres_1010;
            this.ToolAboutAuthor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolAboutAuthor.Name = "ToolAboutAuthor";
            this.ToolAboutAuthor.Size = new System.Drawing.Size(23, 22);
            this.ToolAboutAuthor.Text = "Об авторе";
            this.ToolAboutAuthor.Click += new System.EventHandler(this.MenuAboutAuthor_Click);
            // 
            // ToolAboutProgram
            // 
            this.ToolAboutProgram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolAboutProgram.Image = global::TechProg_3.Properties.Resources.imageres_81;
            this.ToolAboutProgram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolAboutProgram.Name = "ToolAboutProgram";
            this.ToolAboutProgram.Size = new System.Drawing.Size(23, 22);
            this.ToolAboutProgram.Text = "О программе";
            this.ToolAboutProgram.Click += new System.EventHandler(this.MenuAboutProgram_Click);
            // 
            // MenuOpen
            // 
            this.MenuOpen.Image = global::TechProg_3.Properties.Resources.imageres_184;
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.Size = new System.Drawing.Size(156, 22);
            this.MenuOpen.Text = "Открыть папку";
            this.MenuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // MenuQuit
            // 
            this.MenuQuit.Image = global::TechProg_3.Properties.Resources.imageres_5303;
            this.MenuQuit.Name = "MenuQuit";
            this.MenuQuit.Size = new System.Drawing.Size(156, 22);
            this.MenuQuit.Text = "Выход";
            this.MenuQuit.Click += new System.EventHandler(this.MenuQuit_Click);
            // 
            // MenuCascade
            // 
            this.MenuCascade.Image = global::TechProg_3.Properties.Resources.kaskad;
            this.MenuCascade.Name = "MenuCascade";
            this.MenuCascade.Size = new System.Drawing.Size(180, 22);
            this.MenuCascade.Text = "Каскад";
            this.MenuCascade.Click += new System.EventHandler(this.MenuCascade_Click);
            // 
            // MenuCloseAll
            // 
            this.MenuCloseAll.Image = global::TechProg_3.Properties.Resources.zakryt_vse_okna;
            this.MenuCloseAll.Name = "MenuCloseAll";
            this.MenuCloseAll.Size = new System.Drawing.Size(180, 22);
            this.MenuCloseAll.Text = "Закрыть все";
            this.MenuCloseAll.Click += new System.EventHandler(this.MenuCloseAll_Click);
            // 
            // MenuAboutAuthor
            // 
            this.MenuAboutAuthor.Image = global::TechProg_3.Properties.Resources.imageres_1010;
            this.MenuAboutAuthor.Name = "MenuAboutAuthor";
            this.MenuAboutAuthor.Size = new System.Drawing.Size(149, 22);
            this.MenuAboutAuthor.Text = "Об авторе";
            this.MenuAboutAuthor.Click += new System.EventHandler(this.MenuAboutAuthor_Click);
            // 
            // MenuAboutProgram
            // 
            this.MenuAboutProgram.Image = global::TechProg_3.Properties.Resources.imageres_81;
            this.MenuAboutProgram.Name = "MenuAboutProgram";
            this.MenuAboutProgram.Size = new System.Drawing.Size(149, 22);
            this.MenuAboutProgram.Text = "О программе";
            this.MenuAboutProgram.Click += new System.EventHandler(this.MenuAboutProgram_Click);
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 401);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripStatusLabel StatusPath;
        private System.Windows.Forms.ToolStripStatusLabel StatusWindowsCount;
    }
}

