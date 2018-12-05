using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.forms;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Entites;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.DAO;
using System.Text.RegularExpressions;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.userControls.admin
{
    public partial class uc_admin_enseignant_1 : UserControl
    {
        Enseignant enseignant;

        public uc_admin_enseignant_1()
        {
            InitializeComponent();
            enseignant = new Enseignant();
        }
        public uc_admin_enseignant_1(Enseignant ens)
        {
            InitializeComponent();
            enseignant = ens;

            tb_nom.Text=enseignant.nom;
            tb_prenom.Text=enseignant.prenom;
            tb_ville.Text=enseignant.ville;
            tb_email.Text=enseignant.email;
            tb_adresse.Text=enseignant.adresse;
            tb_cin.Text=enseignant.CIN;
            tb_tele.Text=enseignant.telephone;
            if (enseignant.genre == false)
            {
                rb_homme.Checked = true;
                rb_femme.Checked = false;
            } 
            else
            {
                rb_homme.Checked = false;
                rb_femme.Checked = true;
            }

            if (enseignant.image != null)
                pb_enseignant.BackgroundImage = ens.image;

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog_ens_image.ShowDialog();

            if (res == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog_ens_image.FileName);
                pb_enseignant.BackgroundImage = image;
                enseignant.image = image;
                enseignant.image.Tag = openFileDialog_ens_image.FileName;
                btn_chargerImage.BackColor = Color.NavajoWhite;
            }
        }

        private void btn_creer_Click(object sender, EventArgs e)
        {
            if (tb_nom.Text != "" && tb_prenom.Text != "" && tb_ville.Text != "" && tb_email.Text != ""
                && tb_email.Text.Contains("@") && tb_tele.Text != ""
                && new Regex("0[5,6,7]\\d{8}").IsMatch(tb_tele.Text)
                && (rb_homme.Checked==true || rb_femme.Checked==true))
            {
                enseignant.nom = tb_nom.Text;
                enseignant.prenom = tb_prenom.Text;
                enseignant.ville = tb_ville.Text;
                enseignant.email = tb_email.Text;
                enseignant.adresse = tb_adresse.Text;
                enseignant.CIN = tb_cin.Text;
                enseignant.telephone = tb_tele.Text;
                if (rb_homme.Checked)
                    enseignant.genre = false;
                else
                    enseignant.genre = true;
                
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Veuillez remplire tout les champs correctement !", "ATTENTION", 
                                MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Location = new Point(Location.X-35, Location.Y);
            if (Location.X <= -this.Width)
            {
                timer1.Stop();
                adminForm.p_ch.Controls.RemoveAt(0);
                adminForm.p_ch.Controls.Add(new uc_admin_enseignant_2(enseignant));
                adminForm.p_ch.Refresh();
            }
        }
    }
}
