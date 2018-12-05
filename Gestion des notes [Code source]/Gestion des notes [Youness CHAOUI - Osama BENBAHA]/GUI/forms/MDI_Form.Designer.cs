using System.Windows.Forms;
namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.forms
{
    partial class MDI_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_Form));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.quiSommeNous = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.p_parent = new System.Windows.Forms.Panel();
            p_Child = new System.Windows.Forms.Panel();
            this.p_menu = new System.Windows.Forms.Panel();
            this.btn_deconnecter = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.btn_filieres = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.p_icoMenu = new System.Windows.Forms.Panel();
            this.pb_menu = new System.Windows.Forms.PictureBox();
            this.p_Filieres = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.p_parent.SuspendLayout();
            p_Child.SuspendLayout();
            this.p_menu.SuspendLayout();
            this.p_icoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(992, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(71, 20);
            this.fileMenu.Text = "&Application";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(105, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "&Quitter";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator6,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator7,
            this.selectAllToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(72, 20);
            this.editMenu.Text = "&Opérations";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.redoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(153, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(153, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.quiSommeNous});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(40, 20);
            this.helpMenu.Text = "&Aide";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(157, 6);
            // 
            // quiSommeNous
            // 
            this.quiSommeNous.Name = "quiSommeNous";
            this.quiSommeNous.Size = new System.Drawing.Size(160, 22);
            this.quiSommeNous.Text = "&Qui somme nous ?";
            this.quiSommeNous.Click += new System.EventHandler(this.quiSommeNous_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 651);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(992, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStripStatusLabel.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(972, 17);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.Text = "Développée par : Youness CHAOUI && Osama BENBAHA - COPYRIGHT ENSA AGADIR 2018";
            this.toolStripStatusLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripStatusLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            // 
            // p_parent
            // 
            this.p_parent.BackColor = System.Drawing.Color.Cornsilk;
            this.p_parent.Controls.Add(p_Child);
            this.p_parent.Controls.Add(this.p_icoMenu);
            this.p_parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_parent.Location = new System.Drawing.Point(0, 24);
            this.p_parent.Name = "p_parent";
            this.p_parent.Size = new System.Drawing.Size(992, 627);
            this.p_parent.TabIndex = 17;
            // 
            // p_Child
            // 
            p_Child.AutoScroll = true;
            p_Child.BackColor = System.Drawing.Color.White;
            p_Child.Controls.Add(this.p_menu);
            p_Child.Dock = System.Windows.Forms.DockStyle.Fill;
            p_Child.Location = new System.Drawing.Point(54, 0);
            p_Child.Name = "p_Child";
            p_Child.Size = new System.Drawing.Size(938, 627);
            p_Child.TabIndex = 1;
            // 
            // p_menu
            // 
            this.p_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(53)))));
            this.p_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_menu.Controls.Add(this.btn_deconnecter);
            this.p_menu.Controls.Add(this.btn_quitter);
            this.p_menu.Controls.Add(this.btn_filieres);
            this.p_menu.Controls.Add(this.btn_home);
            this.p_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_menu.Location = new System.Drawing.Point(0, 0);
            this.p_menu.Name = "p_menu";
            this.p_menu.Size = new System.Drawing.Size(221, 627);
            this.p_menu.TabIndex = 20;
            // 
            // btn_deconnecter
            // 
            this.btn_deconnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.btn_deconnecter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_deconnecter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.btn_deconnecter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn_deconnecter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_deconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deconnecter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deconnecter.ForeColor = System.Drawing.Color.White;
            this.btn_deconnecter.Image = ((System.Drawing.Image)(resources.GetObject("btn_deconnecter.Image")));
            this.btn_deconnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deconnecter.Location = new System.Drawing.Point(6, 182);
            this.btn_deconnecter.Name = "btn_deconnecter";
            this.btn_deconnecter.Size = new System.Drawing.Size(210, 38);
            this.btn_deconnecter.TabIndex = 24;
            this.btn_deconnecter.Text = "Déconnecter";
            this.btn_deconnecter.UseVisualStyleBackColor = false;
            this.btn_deconnecter.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.btn_quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_quitter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.btn_quitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn_quitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitter.ForeColor = System.Drawing.Color.White;
            this.btn_quitter.Image = ((System.Drawing.Image)(resources.GetObject("btn_quitter.Image")));
            this.btn_quitter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_quitter.Location = new System.Drawing.Point(6, 248);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(210, 38);
            this.btn_quitter.TabIndex = 23;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = false;
            this.btn_quitter.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_filieres
            // 
            this.btn_filieres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.btn_filieres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_filieres.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.btn_filieres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_filieres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btn_filieres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filieres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filieres.ForeColor = System.Drawing.Color.White;
            this.btn_filieres.Image = ((System.Drawing.Image)(resources.GetObject("btn_filieres.Image")));
            this.btn_filieres.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_filieres.Location = new System.Drawing.Point(6, 109);
            this.btn_filieres.Name = "btn_filieres";
            this.btn_filieres.Size = new System.Drawing.Size(210, 38);
            this.btn_filieres.TabIndex = 20;
            this.btn_filieres.Text = "Filières";
            this.btn_filieres.UseVisualStyleBackColor = false;
            this.btn_filieres.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_home.Location = new System.Drawing.Point(6, 39);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(210, 38);
            this.btn_home.TabIndex = 19;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_entrer_Click);
            // 
            // p_icoMenu
            // 
            this.p_icoMenu.BackColor = System.Drawing.Color.DarkOrange;
            this.p_icoMenu.Controls.Add(this.pb_menu);
            this.p_icoMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_icoMenu.Location = new System.Drawing.Point(0, 0);
            this.p_icoMenu.Name = "p_icoMenu";
            this.p_icoMenu.Size = new System.Drawing.Size(54, 627);
            this.p_icoMenu.TabIndex = 0;
            // 
            // pb_menu
            // 
            this.pb_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_menu.BackgroundImage")));
            this.pb_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_menu.Location = new System.Drawing.Point(0, 0);
            this.pb_menu.Name = "pb_menu";
            this.pb_menu.Size = new System.Drawing.Size(54, 39);
            this.pb_menu.TabIndex = 0;
            this.pb_menu.TabStop = false;
            this.pb_menu.Click += new System.EventHandler(this.pb_menu_Click);
            // 
            // p_Filieres
            // 
            this.p_Filieres.AutoScroll = true;
            this.p_Filieres.BackColor = System.Drawing.Color.Crimson;
            this.p_Filieres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_Filieres.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.p_Filieres.Location = new System.Drawing.Point(0, 0);
            this.p_Filieres.Name = "p_Filieres";
            this.p_Filieres.Size = new System.Drawing.Size(992, 602);
            this.p_Filieres.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MDI_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(992, 673);
            this.Controls.Add(this.p_parent);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MDI_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des notes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed);
            this.Load += new System.EventHandler(this.MDI_Form_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.p_parent.ResumeLayout(false);
            p_Child.ResumeLayout(false);
            this.p_menu.ResumeLayout(false);
            this.p_icoMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Create edit box form

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem quiSommeNous;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel p_parent;
        private System.Windows.Forms.Panel p_icoMenu;
        private System.Windows.Forms.PictureBox pb_menu;
        private System.Windows.Forms.Timer timer1;
        private Panel p_Filieres;
        private Panel p_menu;
        private Button btn_filieres;
        private Button btn_home;
        private Button btn_quitter;
        private ToolStripMenuItem editMenu;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private Button btn_deconnecter;
        public static Panel p_Child;
    }
}



