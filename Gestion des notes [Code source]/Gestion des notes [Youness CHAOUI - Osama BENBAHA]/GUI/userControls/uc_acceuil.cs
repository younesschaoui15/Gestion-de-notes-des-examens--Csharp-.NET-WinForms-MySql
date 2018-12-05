using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.forms;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Entites;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Config;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.DAO;


namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.userControls
{
    public partial class uc_acceuil : UserControl
    {
        DAOImpl dao;

        Enseignant _Enseignant;

        Form editForm;
        TextBox tb_newPassword;

        public uc_acceuil()
        {
            InitializeComponent();
            dao = new DAOImpl();
            _Enseignant = MDI_Form._Enseignant;
        }

        private void uc_acceuil_Load(object sender, EventArgs e)
        {
            switch (_Enseignant.genre)
            {
                case false: l_bnj.Text = "Bonjour Mr "; break;
                case true: l_bnj.Text = "Bonjour Mme "; break;
            }
            l_prof.Text = _Enseignant.nom + " " + _Enseignant.prenom;

            l_suite.Text = " dans votre espace de gestion des notes.";
            l_suite.Location = new Point(l_prof.Location.X+l_prof.Width, l_suite.Location.Y);
            
            l_nom.Text = _Enseignant.nom;
            l_prenom.Text = _Enseignant.prenom;
            l_cin.Text = _Enseignant.CIN;
            l_ville.Text = _Enseignant.ville;
            l_adresse.Text = _Enseignant.adresse;
            l_email.Text = _Enseignant.email;
            l_tele.Text = _Enseignant.telephone;
            l_username.Text = _Enseignant.login;
            if (_Enseignant.image != null && !_Enseignant.image.Equals(DBNull.Value))
                pb_enseignant.BackgroundImage = _Enseignant.image;
            else
                switch (_Enseignant.genre)
                {
                    case false: pb_enseignant.BackgroundImage = Properties.Resources.nobody_male; break;
                    case true: pb_enseignant.BackgroundImage = Properties.Resources.nobody_female; break;
                }
                
        }

        private void pb_see_Click(object sender, EventArgs e)
        {
            if (l_password.Text.Equals("* * * * * * * * * * * * * * *"))
                l_password.Text = dao.getPasswordByLogin(_Enseignant.login);
            else
                l_password.Text = "* * * * * * * * * * * * * * *";
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            editForm.Close();
        }

        private void btn_changer_Click(object sender, EventArgs e)
        {
            //changer le mot de passe
            if (tb_newPassword.Text != "" && tb_newPassword.Text.Length > 4)
            {
                dao.changePassword(_Enseignant.login, tb_newPassword.Text);
                editForm.Close();
                l_password.Text = "* * * * * * * * * * * * * * *";
                MessageBox.Show("Le mot de passe a été changé avec succes."
                                   , "Information"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Information);
            }
            else
            {
                tb_newPassword.Text = "";
                MessageBox.Show("Le mot de passe ne doit pas être vide ou moins de 5 caractères !"
                                   , "Attention"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Exclamation);
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            editForm.Close();
        }

        private void pb_edit_Click(object sender, EventArgs e)
        {
            cfrom();
        }



        /////////  CFOM ///////
        private void cfrom()
        {
            //editForm
            editForm = new Form();
            editForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            //editForm.BackColor = Color.DarkOrange;
            editForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(55)))));
            editForm.FormBorderStyle = FormBorderStyle.None;
            editForm.StartPosition = FormStartPosition.CenterScreen;
            //editForm.Location = new System.Drawing.Point(0, 0);
            editForm.Name = "editForm";
            editForm.Text = "Modification - Mot de passe";
            editForm.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            editForm.Size = new System.Drawing.Size(350, 150);

            // pictureBox2
            PictureBox pb1 = new PictureBox();
            pb1.BackColor = System.Drawing.Color.Transparent;
            pb1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.icons8_synchronize_480));
            pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pb1.Location = new System.Drawing.Point(263, 40);
            pb1.Name = "pictureBox2";
            pb1.Size = new System.Drawing.Size(85, 85);

            // Lablel X
            Label label4 = new Label();
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(editForm.Width - 20, 3);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(17, 20);
            label4.TabIndex = 25;
            label4.Text = "x";
            label4.Click += new System.EventHandler(label4_Click_1);

            // label1 : Authentification
            Label label1 = new Label();
            label1.Font = new System.Drawing.Font("Century Gothic", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(10, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(300, 33);
            label1.Text = "Changer le mot de passe ";

            // label2: mot de passe
            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(10, label1.Location.Y + label1.Height + 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 17);
            label2.TabIndex = 20;
            label2.Text = "Mot de passe :";

            // textBox1 : mot de passe 
            tb_newPassword = new TextBox();
            tb_newPassword.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            tb_newPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tb_newPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tb_newPassword.Location = new System.Drawing.Point(10, label2.Location.Y + label2.Height + 10);
            tb_newPassword.MinimumSize = new System.Drawing.Size(20, 20);
            tb_newPassword.Name = "tb_newPassword";
            tb_newPassword.Size = new System.Drawing.Size(247, 23);
            tb_newPassword.TabIndex = 21;
            tb_newPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            tb_newPassword.UseSystemPasswordChar = true;

            // btn_entrer
            Button btn_entrer = new Button();
            btn_entrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            btn_entrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_entrer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            btn_entrer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
            btn_entrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            btn_entrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_entrer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_entrer.ForeColor = System.Drawing.Color.White;
            btn_entrer.Location = new System.Drawing.Point(10, tb_newPassword.Location.Y + tb_newPassword.Height + 10);
            btn_entrer.Name = "btn_changer";
            btn_entrer.Size = new System.Drawing.Size(116, 38);
            //btn_entrer.TabIndex = 18;
            btn_entrer.Text = "Changer";
            btn_entrer.UseVisualStyleBackColor = false;
            btn_entrer.Click += new System.EventHandler(this.btn_changer_Click);

            // btn_entrer
            Button btn_annuler = new Button();
            btn_annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            btn_annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_annuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            btn_annuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
            btn_annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_annuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_annuler.ForeColor = System.Drawing.Color.White;
            btn_annuler.Location = new System.Drawing.Point(btn_entrer.Location.X + btn_entrer.Width + 10, tb_newPassword.Location.Y + tb_newPassword.Height + 10);
            btn_annuler.Name = "btn_annuler";
            btn_annuler.Size = new System.Drawing.Size(116, 38);
            btn_annuler.Text = "Annuler";
            btn_annuler.UseVisualStyleBackColor = false;
            btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);



            // Ajout des composantes :
            editForm.Controls.Add(label4);
            editForm.Controls.Add(label1);
            editForm.Controls.Add(pb1);
            editForm.Controls.Add(label2);
            editForm.Controls.Add(tb_newPassword);
            editForm.Controls.Add(btn_entrer);
            editForm.Controls.Add(btn_annuler);

            //editForm.Show(this);
            editForm.ShowDialog(this);
        }

        private void p_Acceuil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        

    }
}
