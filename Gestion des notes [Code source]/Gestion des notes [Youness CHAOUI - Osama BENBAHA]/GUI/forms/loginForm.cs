using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.userControls;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Entites;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Config;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.DAO;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.forms
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.contract_wrL_icon;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_entrer_Click(object sender, EventArgs e)
        {
            DAOImpl dao = new DAOImpl();
            Enseignant ee = dao.isExiste(new Login(tb_username.Text, tb_password.Text));
            if (ee != null)
            {
                new MDI_Form(ee).Show();
                this.Dispose(false);
            }
            else
                MessageBox.Show("Enseignant(e) non trouvé(e).\n\nNom d'utilisateur/Mot de passe incorrect."
                               , "Authentification"
                               , MessageBoxButtons.OK
                               , MessageBoxIcon.Stop);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_username.Text = "";
            tb_password.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
