namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.userControls.admin
{
    partial class uc_admin_affectation_mat_prof
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_admin_affectation_mat_prof));
            this.ll_selectedMat = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.listView_Enss = new System.Windows.Forms.ListView();
            this.btn_appliquer = new System.Windows.Forms.Button();
            this.listView_Mat = new System.Windows.Forms.ListView();
            this.pb_ens = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ll_non_aff = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ll_aff = new System.Windows.Forms.Label();
            this.l_email = new System.Windows.Forms.Label();
            this.l_prenom = new System.Windows.Forms.Label();
            this.l_nom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_num = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList_Mat = new System.Windows.Forms.ImageList(this.components);
            this.imageList_Enss = new System.Windows.Forms.ImageList(this.components);
            this.btn_retirer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ens)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ll_selectedMat
            // 
            this.ll_selectedMat.AutoSize = true;
            this.ll_selectedMat.BackColor = System.Drawing.Color.Transparent;
            this.ll_selectedMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ll_selectedMat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_selectedMat.ForeColor = System.Drawing.Color.Gray;
            this.ll_selectedMat.Location = new System.Drawing.Point(20, 399);
            this.ll_selectedMat.MaximumSize = new System.Drawing.Size(319, 0);
            this.ll_selectedMat.Name = "ll_selectedMat";
            this.ll_selectedMat.Size = new System.Drawing.Size(153, 17);
            this.ll_selectedMat.TabIndex = 90;
            this.ll_selectedMat.Text = "Matière séléctionnée : ";
            this.ll_selectedMat.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(763, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 50);
            this.pictureBox3.TabIndex = 89;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // listView_Enss
            // 
            this.listView_Enss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.listView_Enss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Enss.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Enss.Location = new System.Drawing.Point(401, 218);
            this.listView_Enss.Margin = new System.Windows.Forms.Padding(0);
            this.listView_Enss.MultiSelect = false;
            this.listView_Enss.Name = "listView_Enss";
            this.listView_Enss.ShowItemToolTips = true;
            this.listView_Enss.Size = new System.Drawing.Size(427, 178);
            this.listView_Enss.TabIndex = 88;
            this.listView_Enss.TileSize = new System.Drawing.Size(50, 50);
            this.listView_Enss.UseCompatibleStateImageBehavior = false;
            this.listView_Enss.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_Enss_ItemSelectionChanged);
            // 
            // btn_appliquer
            // 
            this.btn_appliquer.BackColor = System.Drawing.Color.Orange;
            this.btn_appliquer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_appliquer.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btn_appliquer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_appliquer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_appliquer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_appliquer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_appliquer.ForeColor = System.Drawing.Color.White;
            this.btn_appliquer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_appliquer.Location = new System.Drawing.Point(401, 399);
            this.btn_appliquer.Name = "btn_appliquer";
            this.btn_appliquer.Size = new System.Drawing.Size(242, 38);
            this.btn_appliquer.TabIndex = 87;
            this.btn_appliquer.Text = "Affecter à cette matière";
            this.btn_appliquer.UseVisualStyleBackColor = false;
            this.btn_appliquer.Visible = false;
            this.btn_appliquer.Click += new System.EventHandler(this.btn_appliquer_Click);
            // 
            // listView_Mat
            // 
            this.listView_Mat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.listView_Mat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Mat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Mat.Location = new System.Drawing.Point(24, 23);
            this.listView_Mat.MultiSelect = false;
            this.listView_Mat.Name = "listView_Mat";
            this.listView_Mat.ShowItemToolTips = true;
            this.listView_Mat.Size = new System.Drawing.Size(319, 373);
            this.listView_Mat.TabIndex = 86;
            this.listView_Mat.TileSize = new System.Drawing.Size(50, 50);
            this.listView_Mat.UseCompatibleStateImageBehavior = false;
            this.listView_Mat.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_Mat_ItemSelectionChanged);
            // 
            // pb_ens
            // 
            this.pb_ens.BackColor = System.Drawing.Color.Black;
            this.pb_ens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_ens.Location = new System.Drawing.Point(401, 45);
            this.pb_ens.Margin = new System.Windows.Forms.Padding(0);
            this.pb_ens.Name = "pb_ens";
            this.pb_ens.Size = new System.Drawing.Size(126, 116);
            this.pb_ens.TabIndex = 91;
            this.pb_ens.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(183)))));
            this.panel3.Controls.Add(this.ll_non_aff);
            this.panel3.Location = new System.Drawing.Point(401, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 20);
            this.panel3.TabIndex = 92;
            // 
            // ll_non_aff
            // 
            this.ll_non_aff.AutoSize = true;
            this.ll_non_aff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ll_non_aff.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_non_aff.ForeColor = System.Drawing.Color.DarkGray;
            this.ll_non_aff.Location = new System.Drawing.Point(1, 1);
            this.ll_non_aff.Name = "ll_non_aff";
            this.ll_non_aff.Size = new System.Drawing.Size(123, 17);
            this.ll_non_aff.TabIndex = 81;
            this.ll_non_aff.Text = "Enseignant actuel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(183)))));
            this.panel2.Controls.Add(this.ll_aff);
            this.panel2.Location = new System.Drawing.Point(401, 198);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 20);
            this.panel2.TabIndex = 93;
            // 
            // ll_aff
            // 
            this.ll_aff.AutoSize = true;
            this.ll_aff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ll_aff.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_aff.ForeColor = System.Drawing.Color.DarkGray;
            this.ll_aff.Location = new System.Drawing.Point(1, -1);
            this.ll_aff.Name = "ll_aff";
            this.ll_aff.Size = new System.Drawing.Size(204, 20);
            this.ll_aff.TabIndex = 81;
            this.ll_aff.Text = "La liste des enseignants(es)";
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_email.Location = new System.Drawing.Point(620, 140);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(28, 17);
            this.l_email.TabIndex = 99;
            this.l_email.Text = ". . .";
            // 
            // l_prenom
            // 
            this.l_prenom.AutoSize = true;
            this.l_prenom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_prenom.Location = new System.Drawing.Point(620, 110);
            this.l_prenom.Name = "l_prenom";
            this.l_prenom.Size = new System.Drawing.Size(28, 17);
            this.l_prenom.TabIndex = 98;
            this.l_prenom.Text = ". . .";
            // 
            // l_nom
            // 
            this.l_nom.AutoSize = true;
            this.l_nom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_nom.Location = new System.Drawing.Point(620, 79);
            this.l_nom.Name = "l_nom";
            this.l_nom.Size = new System.Drawing.Size(28, 17);
            this.l_nom.TabIndex = 97;
            this.l_nom.Text = ". . .";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(540, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 96;
            this.label4.Text = "Email ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(540, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 95;
            this.label3.Text = "Prénom ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(540, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 94;
            this.label2.Text = "Nom ";
            // 
            // l_num
            // 
            this.l_num.AutoSize = true;
            this.l_num.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_num.Location = new System.Drawing.Point(620, 48);
            this.l_num.Name = "l_num";
            this.l_num.Size = new System.Drawing.Size(28, 17);
            this.l_num.TabIndex = 101;
            this.l_num.Text = ". . .";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(540, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 100;
            this.label5.Text = "Num";
            // 
            // imageList_Mat
            // 
            this.imageList_Mat.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList_Mat.ImageSize = new System.Drawing.Size(40, 40);
            this.imageList_Mat.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList_Enss
            // 
            this.imageList_Enss.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList_Enss.ImageSize = new System.Drawing.Size(70, 70);
            this.imageList_Enss.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_retirer
            // 
            this.btn_retirer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.btn_retirer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_retirer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.btn_retirer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn_retirer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.btn_retirer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retirer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retirer.ForeColor = System.Drawing.Color.White;
            this.btn_retirer.Location = new System.Drawing.Point(401, 161);
            this.btn_retirer.Margin = new System.Windows.Forms.Padding(0);
            this.btn_retirer.Name = "btn_retirer";
            this.btn_retirer.Size = new System.Drawing.Size(126, 25);
            this.btn_retirer.TabIndex = 102;
            this.btn_retirer.Tag = "vvvvvv";
            this.btn_retirer.Text = "Retirer";
            this.btn_retirer.UseVisualStyleBackColor = false;
            this.btn_retirer.Visible = false;
            this.btn_retirer.Click += new System.EventHandler(this.btn_retirer_Click);
            // 
            // uc_admin_affectation_mat_prof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_retirer);
            this.Controls.Add(this.l_num);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.l_prenom);
            this.Controls.Add(this.l_nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pb_ens);
            this.Controls.Add(this.ll_selectedMat);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.listView_Enss);
            this.Controls.Add(this.btn_appliquer);
            this.Controls.Add(this.listView_Mat);
            this.Name = "uc_admin_affectation_mat_prof";
            this.Size = new System.Drawing.Size(849, 455);
            this.Load += new System.EventHandler(this.uc_admin_affectation_mat_prof_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ens)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ll_selectedMat;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListView listView_Enss;
        private System.Windows.Forms.Button btn_appliquer;
        private System.Windows.Forms.ListView listView_Mat;
        private System.Windows.Forms.PictureBox pb_ens;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ll_non_aff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ll_aff;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.Label l_prenom;
        private System.Windows.Forms.Label l_nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList_Mat;
        private System.Windows.Forms.ImageList imageList_Enss;
        private System.Windows.Forms.Button btn_retirer;

    }
}
