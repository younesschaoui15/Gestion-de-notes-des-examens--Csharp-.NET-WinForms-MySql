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
    public partial class uc_etudiantInfos : UserControl
    {
        Etudiant etudiant;
        DAOImpl dao;

        public uc_etudiantInfos()
        {
            InitializeComponent();
            dao = new DAOImpl();
        }

        public uc_etudiantInfos(Etudiant etudiant)
        {
            InitializeComponent();
            this.etudiant = etudiant;
            dao = new DAOImpl();
        }

        private void uc_etudiantInfos_Load(object sender, EventArgs e)
        {
            l_nomEtudiant.Text = etudiant.prenom+" "+etudiant.nom;
            l_cne.Text = etudiant.CNE+"";
            l_nom.Text = etudiant.nom;
            l_prenom.Text = etudiant.prenom;
            l_filiere.Text = dao.getFiliereByEtudiant(etudiant).nomF;
            l_dateNaissance.Text = etudiant.date_naissance;
            l_ville.Text = etudiant.ville;
            l_adresse.Text = etudiant.adresse;
            l_tele.Text = etudiant.telephone;
            l_cin.Text = etudiant.CIN;

            if (etudiant.image != null)
                pb_etudiant.BackgroundImage = etudiant.image;
            else
                switch (etudiant.genre)
                {
                    case false: pb_etudiant.BackgroundImage = Properties.Resources.nobody_male; break;
                    case true: pb_etudiant.BackgroundImage = Properties.Resources.nobody_female; break;
                }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MDI_Form.p_Child.Controls.Count > 1)
                MDI_Form.p_Child.Controls.RemoveAt(1);

            MDI_Form.p_Child.Controls.Add(new uc_etudiants());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
