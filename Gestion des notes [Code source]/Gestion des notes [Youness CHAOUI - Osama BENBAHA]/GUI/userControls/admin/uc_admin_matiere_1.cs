using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Entites;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.DAO;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.forms;
using System.Text.RegularExpressions;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.userControls.admin
{
    public partial class uc_admin_matiere_1 : UserControl
    {
        Matiere matiere;
        DAOImpl dao;

        public uc_admin_matiere_1()
        {
            InitializeComponent();
            matiere = new Matiere();
            dao = new DAOImpl();
        }

        public uc_admin_matiere_1(Matiere matiere)
        {
            InitializeComponent();
            dao = new DAOImpl();
            this.matiere = matiere;
            tb_nomM.Text = matiere.nomM;
            tb_nbrHeures.Text = matiere.nbrheures.ToString();
        }

        private void btn_chargerImage_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog_mat_image.ShowDialog();

            if (res == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog_mat_image.FileName);
                pb_matiere.BackgroundImage = image;
                matiere.image = image;
                matiere.image.Tag = openFileDialog_mat_image.FileName;
                btn_chargerImage.BackColor = Color.NavajoWhite;
            }
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            if (tb_nomM.Text != "" && tb_nbrHeures.Text != "" && new Regex("\\d").IsMatch(tb_nbrHeures.Text)==true)
            {
                matiere.nomM = tb_nomM.Text;
                matiere.nbrheures = Convert.ToInt32( tb_nbrHeures.Text);

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
            Location = new Point(Location.X - 35, Location.Y);
            if (Location.X <= -this.Width)
            {
                timer1.Stop();
                adminForm.p_ch.Controls.RemoveAt(0);
                adminForm.p_ch.Controls.Add(new uc_admin_matiere_2(matiere));
                adminForm.p_ch.Refresh();
            }
        }

        private void btn_creer_Click(object sender, EventArgs e)
        {
            if (tb_nomM.Text != "" && tb_nbrHeures.Text != "" && new Regex("\\d").IsMatch(tb_nbrHeures.Text) == true)
            {
                matiere.nomM = tb_nomM.Text;
                matiere.nbrheures = Convert.ToInt32(tb_nbrHeures.Text);
                
                if (dao.addMatiere(matiere))
                {
                    MessageBox.Show("Matière créer avec succes.", "SUCCES",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_nomM.Text = "";
                    tb_nbrHeures.Text = "";
                    btn_suivant.Enabled = false;
                    btn_creer.Enabled = false;
                }
                else
                    MessageBox.Show("Matière n'est pas crée !", "ATTENTION",
                            MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("Veuillez remplire tout les champs correctement !", "ATTENTION",
                                MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
