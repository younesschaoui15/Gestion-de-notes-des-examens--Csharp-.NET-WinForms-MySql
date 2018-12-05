namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.userControls.admin
{
    partial class uc_admin_affectation_mat_fil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_admin_affectation_mat_fil));
            this.listView_Mat = new System.Windows.Forms.ListView();
            this.listView_non_aff = new System.Windows.Forms.ListView();
            this.btn_appliquer = new System.Windows.Forms.Button();
            this.ll_aff = new System.Windows.Forms.Label();
            this.listView_aff = new System.Windows.Forms.ListView();
            this.imageList_Mat = new System.Windows.Forms.ImageList(this.components);
            this.imageList_non_aff = new System.Windows.Forms.ImageList(this.components);
            this.imageList_aff = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ll_non_aff = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ll_selectedMat = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Mat
            // 
            this.listView_Mat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.listView_Mat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Mat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Mat.Location = new System.Drawing.Point(14, 63);
            this.listView_Mat.MultiSelect = false;
            this.listView_Mat.Name = "listView_Mat";
            this.listView_Mat.ShowItemToolTips = true;
            this.listView_Mat.Size = new System.Drawing.Size(319, 315);
            this.listView_Mat.TabIndex = 75;
            this.listView_Mat.TileSize = new System.Drawing.Size(50, 50);
            this.listView_Mat.UseCompatibleStateImageBehavior = false;
            this.listView_Mat.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_Mat_ItemSelectionChanged);
            this.listView_Mat.Click += new System.EventHandler(this.listView_Mat_DoubleClick);
            // 
            // listView_non_aff
            // 
            this.listView_non_aff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.listView_non_aff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_non_aff.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_non_aff.Location = new System.Drawing.Point(391, 256);
            this.listView_non_aff.Margin = new System.Windows.Forms.Padding(0);
            this.listView_non_aff.Name = "listView_non_aff";
            this.listView_non_aff.ShowItemToolTips = true;
            this.listView_non_aff.Size = new System.Drawing.Size(427, 122);
            this.listView_non_aff.TabIndex = 76;
            this.listView_non_aff.TileSize = new System.Drawing.Size(50, 50);
            this.listView_non_aff.UseCompatibleStateImageBehavior = false;
            this.listView_non_aff.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_non_aff_ItemSelectionChanged);
            // 
            // btn_appliquer
            // 
            this.btn_appliquer.BackColor = System.Drawing.Color.Orange;
            this.btn_appliquer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_appliquer.Enabled = false;
            this.btn_appliquer.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btn_appliquer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_appliquer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_appliquer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_appliquer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_appliquer.ForeColor = System.Drawing.Color.White;
            this.btn_appliquer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_appliquer.Location = new System.Drawing.Point(391, 394);
            this.btn_appliquer.Name = "btn_appliquer";
            this.btn_appliquer.Size = new System.Drawing.Size(242, 38);
            this.btn_appliquer.TabIndex = 78;
            this.btn_appliquer.Text = "Appliquer l\'affectation";
            this.btn_appliquer.UseVisualStyleBackColor = false;
            this.btn_appliquer.Click += new System.EventHandler(this.btn_appliquer_Click);
            // 
            // ll_aff
            // 
            this.ll_aff.AutoSize = true;
            this.ll_aff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ll_aff.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_aff.ForeColor = System.Drawing.Color.DarkGray;
            this.ll_aff.Location = new System.Drawing.Point(1, -1);
            this.ll_aff.Name = "ll_aff";
            this.ll_aff.Size = new System.Drawing.Size(193, 20);
            this.ll_aff.TabIndex = 81;
            this.ll_aff.Text = "Les filières déjà affectées";
            // 
            // listView_aff
            // 
            this.listView_aff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.listView_aff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_aff.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_aff.Location = new System.Drawing.Point(391, 83);
            this.listView_aff.Margin = new System.Windows.Forms.Padding(0);
            this.listView_aff.Name = "listView_aff";
            this.listView_aff.ShowItemToolTips = true;
            this.listView_aff.Size = new System.Drawing.Size(427, 122);
            this.listView_aff.TabIndex = 80;
            this.listView_aff.TileSize = new System.Drawing.Size(50, 50);
            this.listView_aff.UseCompatibleStateImageBehavior = false;
            this.listView_aff.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_aff_ItemSelectionChanged);
            // 
            // imageList_Mat
            // 
            this.imageList_Mat.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList_Mat.ImageSize = new System.Drawing.Size(40, 40);
            this.imageList_Mat.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList_non_aff
            // 
            this.imageList_non_aff.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList_non_aff.ImageSize = new System.Drawing.Size(70, 70);
            this.imageList_non_aff.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList_aff
            // 
            this.imageList_aff.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList_aff.ImageSize = new System.Drawing.Size(70, 70);
            this.imageList_aff.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(183)))));
            this.panel2.Controls.Add(this.ll_aff);
            this.panel2.Location = new System.Drawing.Point(391, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 20);
            this.panel2.TabIndex = 82;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(183)))));
            this.panel3.Controls.Add(this.ll_non_aff);
            this.panel3.Location = new System.Drawing.Point(391, 236);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(427, 20);
            this.panel3.TabIndex = 83;
            // 
            // ll_non_aff
            // 
            this.ll_non_aff.AutoSize = true;
            this.ll_non_aff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ll_non_aff.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_non_aff.ForeColor = System.Drawing.Color.DarkGray;
            this.ll_non_aff.Location = new System.Drawing.Point(1, -1);
            this.ll_non_aff.Name = "ll_non_aff";
            this.ll_non_aff.Size = new System.Drawing.Size(188, 20);
            this.ll_non_aff.TabIndex = 81;
            this.ll_non_aff.Text = "Les filières non affectées";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(763, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 50);
            this.pictureBox3.TabIndex = 84;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ll_selectedMat
            // 
            this.ll_selectedMat.AutoSize = true;
            this.ll_selectedMat.BackColor = System.Drawing.Color.Transparent;
            this.ll_selectedMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ll_selectedMat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_selectedMat.ForeColor = System.Drawing.Color.Gray;
            this.ll_selectedMat.Location = new System.Drawing.Point(10, 381);
            this.ll_selectedMat.MaximumSize = new System.Drawing.Size(319, 0);
            this.ll_selectedMat.Name = "ll_selectedMat";
            this.ll_selectedMat.Size = new System.Drawing.Size(153, 17);
            this.ll_selectedMat.TabIndex = 85;
            this.ll_selectedMat.Text = "Matière séléctionnée : ";
            this.ll_selectedMat.Visible = false;
            // 
            // uc_admin_affectation_mat_fil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ll_selectedMat);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView_aff);
            this.Controls.Add(this.btn_appliquer);
            this.Controls.Add(this.listView_non_aff);
            this.Controls.Add(this.listView_Mat);
            this.Name = "uc_admin_affectation_mat_fil";
            this.Size = new System.Drawing.Size(849, 455);
            this.Load += new System.EventHandler(this.uc_admin_affectation_mat_fil_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Mat;
        private System.Windows.Forms.ListView listView_non_aff;
        private System.Windows.Forms.Button btn_appliquer;
        private System.Windows.Forms.Label ll_aff;
        private System.Windows.Forms.ListView listView_aff;
        private System.Windows.Forms.ImageList imageList_Mat;
        private System.Windows.Forms.ImageList imageList_non_aff;
        private System.Windows.Forms.ImageList imageList_aff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ll_non_aff;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label ll_selectedMat;

    }
}
