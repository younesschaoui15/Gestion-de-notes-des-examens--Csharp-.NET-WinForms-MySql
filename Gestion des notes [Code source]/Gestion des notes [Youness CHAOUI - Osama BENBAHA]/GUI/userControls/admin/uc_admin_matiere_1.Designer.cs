namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.userControls.admin
{
    partial class uc_admin_matiere_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_admin_matiere_1));
            this.tb_nbrHeures = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomM = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog_mat_image = new System.Windows.Forms.OpenFileDialog();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_creer = new System.Windows.Forms.Button();
            this.btn_chargerImage = new System.Windows.Forms.Button();
            this.pb_matiere = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_matiere)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nbrHeures
            // 
            this.tb_nbrHeures.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_nbrHeures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nbrHeures.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nbrHeures.Location = new System.Drawing.Point(271, 207);
            this.tb_nbrHeures.MinimumSize = new System.Drawing.Size(20, 20);
            this.tb_nbrHeures.Name = "tb_nbrHeures";
            this.tb_nbrHeures.Size = new System.Drawing.Size(247, 27);
            this.tb_nbrHeures.TabIndex = 51;
            this.tb_nbrHeures.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(53, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nombre d\'heures *";
            // 
            // tb_nomM
            // 
            this.tb_nomM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_nomM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nomM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nomM.Location = new System.Drawing.Point(271, 142);
            this.tb_nomM.MinimumSize = new System.Drawing.Size(30, 20);
            this.tb_nomM.Name = "tb_nomM";
            this.tb_nomM.Size = new System.Drawing.Size(247, 27);
            this.tb_nomM.TabIndex = 50;
            this.tb_nomM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 47);
            this.panel1.TabIndex = 49;
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
            this.label16.Size = new System.Drawing.Size(276, 33);
            this.label16.TabIndex = 1;
            this.label16.Text = "Ajout d\'une matière";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(53, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 22);
            this.label2.TabIndex = 48;
            this.label2.Text = "Libellé  de la matière *";
            // 
            // btn_suivant
            // 
            this.btn_suivant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.btn_suivant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_suivant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.btn_suivant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_suivant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btn_suivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suivant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suivant.ForeColor = System.Drawing.Color.White;
            this.btn_suivant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suivant.Location = new System.Drawing.Point(57, 300);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(270, 38);
            this.btn_suivant.TabIndex = 54;
            this.btn_suivant.Text = "Affecter un enseignant(e)";
            this.btn_suivant.UseVisualStyleBackColor = false;
            this.btn_suivant.Click += new System.EventHandler(this.btn_suivant_Click);
            // 
            // btn_creer
            // 
            this.btn_creer.BackColor = System.Drawing.Color.Orange;
            this.btn_creer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_creer.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btn_creer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_creer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_creer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_creer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creer.ForeColor = System.Drawing.Color.White;
            this.btn_creer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_creer.Location = new System.Drawing.Point(333, 300);
            this.btn_creer.Name = "btn_creer";
            this.btn_creer.Size = new System.Drawing.Size(185, 38);
            this.btn_creer.TabIndex = 53;
            this.btn_creer.Text = "Créer";
            this.btn_creer.UseVisualStyleBackColor = false;
            this.btn_creer.Click += new System.EventHandler(this.btn_creer_Click);
            // 
            // btn_chargerImage
            // 
            this.btn_chargerImage.BackColor = System.Drawing.Color.LightGray;
            this.btn_chargerImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_chargerImage.FlatAppearance.BorderSize = 0;
            this.btn_chargerImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_chargerImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chargerImage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chargerImage.ForeColor = System.Drawing.Color.White;
            this.btn_chargerImage.Image = ((System.Drawing.Image)(resources.GetObject("btn_chargerImage.Image")));
            this.btn_chargerImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chargerImage.Location = new System.Drawing.Point(559, 346);
            this.btn_chargerImage.Name = "btn_chargerImage";
            this.btn_chargerImage.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_chargerImage.Size = new System.Drawing.Size(247, 40);
            this.btn_chargerImage.TabIndex = 52;
            this.btn_chargerImage.Text = "Charger  l\'image";
            this.btn_chargerImage.UseVisualStyleBackColor = false;
            this.btn_chargerImage.Click += new System.EventHandler(this.btn_chargerImage_Click);
            // 
            // pb_matiere
            // 
            this.pb_matiere.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_matiere.BackgroundImage")));
            this.pb_matiere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_matiere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_matiere.Location = new System.Drawing.Point(559, 100);
            this.pb_matiere.Name = "pb_matiere";
            this.pb_matiere.Size = new System.Drawing.Size(247, 240);
            this.pb_matiere.TabIndex = 47;
            this.pb_matiere.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uc_admin_matiere_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.btn_creer);
            this.Controls.Add(this.btn_chargerImage);
            this.Controls.Add(this.tb_nbrHeures);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nomM);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_matiere);
            this.Name = "uc_admin_matiere_1";
            this.Size = new System.Drawing.Size(849, 455);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_matiere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_chargerImage;
        private System.Windows.Forms.TextBox tb_nbrHeures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_matiere;
        private System.Windows.Forms.OpenFileDialog openFileDialog_mat_image;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_creer;
        private System.Windows.Forms.Timer timer1;
    }
}
