namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.userControls.admin
{
    partial class uc_admin_matiere_2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_admin_matiere_2));
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_creer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.pb_1 = new System.Windows.Forms.PictureBox();
            this.listView_Ens = new System.Windows.Forms.ListView();
            this.imageList_Ens = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_precedent
            // 
            this.btn_precedent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.btn_precedent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_precedent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.btn_precedent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_precedent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btn_precedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_precedent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_precedent.ForeColor = System.Drawing.Color.White;
            this.btn_precedent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_precedent.Location = new System.Drawing.Point(25, 385);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(243, 38);
            this.btn_precedent.TabIndex = 73;
            this.btn_precedent.Text = "Annuler l\'affectation";
            this.btn_precedent.UseVisualStyleBackColor = false;
            this.btn_precedent.Click += new System.EventHandler(this.btn_suivant_Click);
            // 
            // btn_creer
            // 
            this.btn_creer.BackColor = System.Drawing.Color.Orange;
            this.btn_creer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_creer.Enabled = false;
            this.btn_creer.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btn_creer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_creer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_creer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_creer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creer.ForeColor = System.Drawing.Color.White;
            this.btn_creer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_creer.Location = new System.Drawing.Point(299, 385);
            this.btn_creer.Name = "btn_creer";
            this.btn_creer.Size = new System.Drawing.Size(243, 38);
            this.btn_creer.TabIndex = 72;
            this.btn_creer.Text = "Affecter && créer";
            this.btn_creer.UseVisualStyleBackColor = false;
            this.btn_creer.Click += new System.EventHandler(this.btn_creer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 47);
            this.panel1.TabIndex = 71;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(136, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(363, 33);
            this.label16.TabIndex = 1;
            this.label16.Text = "Ajout d\'une matière (suite)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_1
            // 
            this.pb_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_1.BackgroundImage")));
            this.pb_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_1.Location = new System.Drawing.Point(563, 83);
            this.pb_1.Name = "pb_1";
            this.pb_1.Size = new System.Drawing.Size(272, 272);
            this.pb_1.TabIndex = 70;
            this.pb_1.TabStop = false;
            // 
            // listView_Ens
            // 
            this.listView_Ens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.listView_Ens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Ens.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Ens.Location = new System.Drawing.Point(25, 83);
            this.listView_Ens.Name = "listView_Ens";
            this.listView_Ens.ShowItemToolTips = true;
            this.listView_Ens.Size = new System.Drawing.Size(517, 272);
            this.listView_Ens.TabIndex = 74;
            this.listView_Ens.TileSize = new System.Drawing.Size(50, 50);
            this.listView_Ens.UseCompatibleStateImageBehavior = false;
            this.listView_Ens.Click += new System.EventHandler(this.listView_Ens_Click);
            // 
            // imageList_Ens
            // 
            this.imageList_Ens.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList_Ens.ImageSize = new System.Drawing.Size(80, 80);
            this.imageList_Ens.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uc_admin_matiere_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.listView_Ens);
            this.Controls.Add(this.btn_precedent);
            this.Controls.Add(this.btn_creer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_1);
            this.Name = "uc_admin_matiere_2";
            this.Size = new System.Drawing.Size(849, 455);
            this.Load += new System.EventHandler(this.uc_admin_matiere_2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_creer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pb_1;
        private System.Windows.Forms.ListView listView_Ens;
        private System.Windows.Forms.ImageList imageList_Ens;
        private System.Windows.Forms.Timer timer1;
    }
}
