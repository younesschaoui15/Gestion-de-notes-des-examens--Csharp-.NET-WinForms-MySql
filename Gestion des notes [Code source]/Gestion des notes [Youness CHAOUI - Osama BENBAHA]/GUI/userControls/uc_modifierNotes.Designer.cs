namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.userControls
{
    partial class uc_modifierNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_modifierNotes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView_Notes = new System.Windows.Forms.DataGridView();
            this.c_cne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_matiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox_modif = new System.Windows.Forms.CheckBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Notes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 47);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correction des notes.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(828, 149);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(370, 366);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1078, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView_Notes
            // 
            this.dataGridView_Notes.AllowUserToAddRows = false;
            this.dataGridView_Notes.AllowUserToDeleteRows = false;
            this.dataGridView_Notes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_Notes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Notes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Notes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Notes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Notes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_cne,
            this.c_nom,
            this.c_prenom,
            this.c_matiere});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Notes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Notes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView_Notes.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_Notes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView_Notes.Location = new System.Drawing.Point(17, 149);
            this.dataGridView_Notes.MultiSelect = false;
            this.dataGridView_Notes.Name = "dataGridView_Notes";
            this.dataGridView_Notes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_Notes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Notes.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkOrange;
            this.dataGridView_Notes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Notes.Size = new System.Drawing.Size(783, 452);
            this.dataGridView_Notes.TabIndex = 28;
            this.dataGridView_Notes.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_Notes_CellBeginEdit);
            this.dataGridView_Notes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Notes_CellEndEdit);
            // 
            // c_cne
            // 
            this.c_cne.HeaderText = "CNE";
            this.c_cne.Name = "c_cne";
            this.c_cne.Width = 130;
            // 
            // c_nom
            // 
            this.c_nom.HeaderText = "Nom";
            this.c_nom.Name = "c_nom";
            this.c_nom.Width = 180;
            // 
            // c_prenom
            // 
            this.c_prenom.HeaderText = "Prénom";
            this.c_prenom.Name = "c_prenom";
            this.c_prenom.Width = 180;
            // 
            // c_matiere
            // 
            this.c_matiere.HeaderText = "XXX";
            this.c_matiere.Name = "c_matiere";
            this.c_matiere.Width = 290;
            // 
            // checkBox_modif
            // 
            this.checkBox_modif.AutoSize = true;
            this.checkBox_modif.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox_modif.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox_modif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.checkBox_modif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox_modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_modif.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_modif.ForeColor = System.Drawing.Color.Gray;
            this.checkBox_modif.Location = new System.Drawing.Point(823, 528);
            this.checkBox_modif.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_modif.Name = "checkBox_modif";
            this.checkBox_modif.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_modif.Size = new System.Drawing.Size(287, 22);
            this.checkBox_modif.TabIndex = 31;
            this.checkBox_modif.Text = "Autoriser la modification des notes *";
            this.checkBox_modif.UseVisualStyleBackColor = false;
            this.checkBox_modif.CheckedChanged += new System.EventHandler(this.checkBox_modif_CheckedChanged);
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.btn_import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_import.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.btn_import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_import.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.ForeColor = System.Drawing.Color.White;
            this.btn_import.Image = ((System.Drawing.Image)(resources.GetObject("btn_import.Image")));
            this.btn_import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_import.Location = new System.Drawing.Point(828, 607);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(282, 38);
            this.btn_import.TabIndex = 32;
            this.btn_import.Text = "Importer les notes";
            this.btn_import.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Visible = false;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.btn_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_export.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.btn_export.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Image = ((System.Drawing.Image)(resources.GetObject("btn_export.Image")));
            this.btn_export.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_export.Location = new System.Drawing.Point(828, 563);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(282, 38);
            this.btn_export.TabIndex = 33;
            this.btn_export.Text = "Exporter les notes";
            this.btn_export.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "pdf";
            this.saveFileDialog1.InitialDirectory = "C:/Users/Public/Desktop/";
            this.saveFileDialog1.Title = "Exportation des notes";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1139, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // uc_modifierNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.checkBox_modif);
            this.Controls.Add(this.dataGridView_Notes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Name = "uc_modifierNotes";
            this.Size = new System.Drawing.Size(1221, 656);
            this.Load += new System.EventHandler(this.uc_modifierNotes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Notes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_cne;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_matiere;
        private System.Windows.Forms.CheckBox checkBox_modif;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        //public static System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
