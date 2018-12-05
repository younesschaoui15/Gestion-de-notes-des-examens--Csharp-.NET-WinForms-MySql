using System.Windows.Forms;
namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.forms
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            p_ch = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.btn_affectation = new System.Windows.Forms.Button();
            this.btn_matiere = new System.Windows.Forms.Button();
            this.btn_enseignant = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(p_ch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 538);
            this.panel1.TabIndex = 1;
            // 
            // p_ch
            // 
            p_ch.BackColor = System.Drawing.Color.White;
            p_ch.Dock = System.Windows.Forms.DockStyle.Bottom;
            p_ch.Location = new System.Drawing.Point(0, 70);
            p_ch.Name = "p_ch";
            p_ch.Size = new System.Drawing.Size(843, 466);
            p_ch.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.btn_home);
            this.panel2.Controls.Add(this.btn_quitter);
            this.panel2.Controls.Add(this.btn_affectation);
            this.panel2.Controls.Add(this.btn_matiere);
            this.panel2.Controls.Add(this.btn_enseignant);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 67);
            this.panel2.TabIndex = 2;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Orange;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(9, 9);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(51, 48);
            this.btn_home.TabIndex = 24;
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click_1);
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Tomato;
            this.btn_quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_quitter.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.btn_quitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_quitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitter.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitter.ForeColor = System.Drawing.Color.White;
            this.btn_quitter.Image = ((System.Drawing.Image)(resources.GetObject("btn_quitter.Image")));
            this.btn_quitter.Location = new System.Drawing.Point(781, 9);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(53, 48);
            this.btn_quitter.TabIndex = 23;
            this.btn_quitter.UseVisualStyleBackColor = false;
            this.btn_quitter.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_affectation
            // 
            this.btn_affectation.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_affectation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_affectation.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btn_affectation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_affectation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_affectation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_affectation.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_affectation.ForeColor = System.Drawing.Color.White;
            this.btn_affectation.Image = ((System.Drawing.Image)(resources.GetObject("btn_affectation.Image")));
            this.btn_affectation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_affectation.Location = new System.Drawing.Point(426, 9);
            this.btn_affectation.Name = "btn_affectation";
            this.btn_affectation.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btn_affectation.Size = new System.Drawing.Size(174, 48);
            this.btn_affectation.TabIndex = 22;
            this.btn_affectation.Text = "Affectation";
            this.btn_affectation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_affectation.UseVisualStyleBackColor = false;
            this.btn_affectation.Click += new System.EventHandler(this.btn_affectation_Click);
            // 
            // btn_matiere
            // 
            this.btn_matiere.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_matiere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_matiere.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btn_matiere.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_matiere.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_matiere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_matiere.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_matiere.ForeColor = System.Drawing.Color.White;
            this.btn_matiere.Image = ((System.Drawing.Image)(resources.GetObject("btn_matiere.Image")));
            this.btn_matiere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_matiere.Location = new System.Drawing.Point(246, 9);
            this.btn_matiere.Name = "btn_matiere";
            this.btn_matiere.Size = new System.Drawing.Size(174, 48);
            this.btn_matiere.TabIndex = 21;
            this.btn_matiere.Text = "Matière";
            this.btn_matiere.UseVisualStyleBackColor = false;
            this.btn_matiere.Click += new System.EventHandler(this.btn_matiere_Click);
            // 
            // btn_enseignant
            // 
            this.btn_enseignant.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_enseignant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_enseignant.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btn_enseignant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_enseignant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_enseignant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enseignant.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enseignant.ForeColor = System.Drawing.Color.White;
            this.btn_enseignant.Image = ((System.Drawing.Image)(resources.GetObject("btn_enseignant.Image")));
            this.btn_enseignant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_enseignant.Location = new System.Drawing.Point(66, 9);
            this.btn_enseignant.Name = "btn_enseignant";
            this.btn_enseignant.Size = new System.Drawing.Size(174, 48);
            this.btn_enseignant.TabIndex = 20;
            this.btn_enseignant.Text = "Enseignant";
            this.btn_enseignant.UseVisualStyleBackColor = false;
            this.btn_enseignant.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 538);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.Button btn_affectation;
        private System.Windows.Forms.Button btn_matiere;
        private System.Windows.Forms.Button btn_enseignant;
        private System.Windows.Forms.Timer timer1;
        public static Panel p_ch;



    }
}