namespace Editor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            mainToolBar = new ToolStrip();
            toolStripButtonNew = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonOpen = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButtonSave = new ToolStripButton();
            toolStripButtonSaveAs = new ToolStripButton();
            mainStatusBar = new StatusStrip();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            fontDialog = new FontDialog();
            textEditor = new RichTextBox();
            editToolStripMenuItem = new ToolStripMenuItem();
            loadZNUNewsToolStripMenuItem = new ToolStripMenuItem();
            mainMenu.SuspendLayout();
            mainToolBar.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Padding = new Padding(7, 3, 0, 3);
            mainMenu.Size = new Size(914, 30);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, toolStripSeparator2, openToolStripMenuItem, toolStripSeparator4, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator3, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(224, 26);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(221, 6);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(221, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(224, 26);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(224, 26);
            saveAsToolStripMenuItem.Text = "Save &as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // mainToolBar
            // 
            mainToolBar.ImageScalingSize = new Size(20, 20);
            mainToolBar.Items.AddRange(new ToolStripItem[] { toolStripButtonNew, toolStripSeparator1, toolStripButtonOpen, toolStripSeparator5, toolStripButtonSave, toolStripButtonSaveAs });
            mainToolBar.Location = new Point(0, 30);
            mainToolBar.Name = "mainToolBar";
            mainToolBar.Size = new Size(914, 27);
            mainToolBar.TabIndex = 2;
            mainToolBar.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            toolStripButtonNew.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonNew.Image = (Image)resources.GetObject("toolStripButtonNew.Image");
            toolStripButtonNew.ImageTransparentColor = Color.Magenta;
            toolStripButtonNew.Name = "toolStripButtonNew";
            toolStripButtonNew.Size = new Size(43, 24);
            toolStripButtonNew.Text = "New";
            toolStripButtonNew.TextImageRelation = TextImageRelation.TextAboveImage;
            toolStripButtonNew.Click += newToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripButtonOpen
            // 
            toolStripButtonOpen.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonOpen.Image = (Image)resources.GetObject("toolStripButtonOpen.Image");
            toolStripButtonOpen.ImageTransparentColor = Color.Magenta;
            toolStripButtonOpen.Name = "toolStripButtonOpen";
            toolStripButtonOpen.Size = new Size(49, 24);
            toolStripButtonOpen.Text = "Open";
            toolStripButtonOpen.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 27);
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonSave.Image = (Image)resources.GetObject("toolStripButtonSave.Image");
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(44, 24);
            toolStripButtonSave.Text = "Save";
            toolStripButtonSave.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripButtonSaveAs
            // 
            toolStripButtonSaveAs.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonSaveAs.Image = (Image)resources.GetObject("toolStripButtonSaveAs.Image");
            toolStripButtonSaveAs.ImageTransparentColor = Color.Magenta;
            toolStripButtonSaveAs.Name = "toolStripButtonSaveAs";
            toolStripButtonSaveAs.Size = new Size(64, 24);
            toolStripButtonSaveAs.Text = "Save As";
            toolStripButtonSaveAs.Click += saveAsToolStripMenuItem_Click;
            // 
            // mainStatusBar
            // 
            mainStatusBar.ImageScalingSize = new Size(20, 20);
            mainStatusBar.Location = new Point(0, 578);
            mainStatusBar.Name = "mainStatusBar";
            mainStatusBar.Padding = new Padding(1, 0, 16, 0);
            mainStatusBar.Size = new Size(914, 22);
            mainStatusBar.TabIndex = 3;
            mainStatusBar.Text = "statusStrip1";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // textEditor
            // 
            textEditor.Dock = DockStyle.Fill;
            textEditor.Location = new Point(0, 57);
            textEditor.Margin = new Padding(3, 4, 3, 4);
            textEditor.Name = "textEditor";
            textEditor.Size = new Size(914, 521);
            textEditor.TabIndex = 4;
            textEditor.Text = "";
            textEditor.TextChanged += textEditor_TextChanged;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadZNUNewsToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // loadZNUNewsToolStripMenuItem
            // 
            loadZNUNewsToolStripMenuItem.Name = "loadZNUNewsToolStripMenuItem";
            loadZNUNewsToolStripMenuItem.Size = new Size(224, 26);
            loadZNUNewsToolStripMenuItem.Text = "Load ZNU News";
            loadZNUNewsToolStripMenuItem.Click += loadZNUNewsToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textEditor);
            Controls.Add(mainStatusBar);
            Controls.Add(mainToolBar);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Simple Edit";
            FormClosing += MainForm_FormClosing;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            mainToolBar.ResumeLayout(false);
            mainToolBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStrip mainToolBar;
        private StatusStrip mainStatusBar;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        private RichTextBox textEditor;
        private ToolStripButton toolStripButtonNew;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButtonOpen;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButtonSave;
        private ToolStripButton toolStripButtonSaveAs;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem loadZNUNewsToolStripMenuItem;
    }
}