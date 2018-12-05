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

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.userControls.admin
{
    public partial class uc_admin_enseignant_2 : UserControl
    {
        Enseignant enseignant=null;
        DAOImpl dao;

        public uc_admin_enseignant_2(Enseignant ens)
        {
            InitializeComponent();
            dao = new DAOImpl();
            enseignant = ens;
        }

        private void btn_creer_Click(object sender, EventArgs e)
        {
            if (tb_login.Text != "" && tb_passe.Text != "")
            {
                enseignant.login = tb_login.Text;

                if (dao.addLogin(new Login(tb_login.Text, tb_passe.Text)))
                    if (dao.addEnseignant(enseignant))
                    {
                        MessageBox.Show("Enseignant créer avec succes.", "SUCCES",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_login.Text = "";
                        tb_passe.Text = "";
                        adminForm.p_ch.Controls.RemoveAt(0);
                        adminForm.p_ch.Controls.Add(new uc_admin_enseignant_1());
                    }
                    else
                        MessageBox.Show("Enseignant n'est pas crée!", "ATTENTION",
                                MessageBoxButtons.OK, MessageBoxIcon.Question);
                else
                    MessageBox.Show("ATTENTION Ce nom d'utilisateur est déjà utilisé par un autre enseignant!", "ATTENTION",
                                MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
                MessageBox.Show("Veuillez remplire tout les champs correctement !", "ATTENTION",
                                MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btn_avant_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Location = new Point(Location.X + 35, Location.Y);
            if (Location.X >= this.Width)
            {
                timer1.Stop();
                adminForm.p_ch.Controls.RemoveAt(0);
                adminForm.p_ch.Controls.Add(new uc_admin_enseignant_1(enseignant));
                adminForm.p_ch.Refresh();
            }
        }
    }
}
