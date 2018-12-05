using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.DAO;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Entites;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.forms;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.forms
{
    public partial class authentificationForm : Form
    {
        public authentificationForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.contract_wrL_icon;
        }

        private void checkBox_admin_Click(object sender, EventArgs e)
        {
            checkBox_ens.Checked = false;
            checkBox_admin.Checked = true;
        }

        private void checkBox_ens_Click(object sender, EventArgs e)
        {
            checkBox_admin.Checked = false;
            checkBox_ens.Checked = true;
        }

        private void btn_entrer_Click(object sender, EventArgs e)
        {   
            if(checkBox_ens.Checked)
            {
                DAOImpl dao = new DAOImpl();
                Enseignant ee = dao.isExiste(new Login(tb_username.Text, tb_password.Text));
                if (ee != null)
                {
                    new MDI_Form(ee).Show();
                    this.Dispose(false);
                }
                else
                    MessageBox.Show("Enseignant(e) non trouvé(e).\n\nNom d'utilisateur/Mot de passe est incorrect."
                                   , "Authentification"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Stop);
            }
            else if(checkBox_admin.Checked)
            {   
                string login = tb_username.Text;
                string passe = tb_password.Text;

                if (login=="admin" && passe=="admin")
                {
                    new adminForm().Show();
                    this.Dispose(false);
                }
                else
                    MessageBox.Show("Admin non trouvé.\n\nNom d'utilisateur/Mot de passe est incorrect."
                                   , "Authentification"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Stop);
            }
            
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            tb_username.Text = "";
            tb_password.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void authentificationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox_ens_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_admin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
