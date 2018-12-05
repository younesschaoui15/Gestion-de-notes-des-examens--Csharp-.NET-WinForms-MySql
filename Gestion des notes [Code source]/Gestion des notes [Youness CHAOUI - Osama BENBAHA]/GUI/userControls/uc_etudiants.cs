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
    public partial class uc_etudiants : UserControl
    {
        private DAOImpl dao;
        private static Enseignant _Enseignant;
        private static Filiere filiere;

        public uc_etudiants()
        {
            InitializeComponent();
            dao = new DAOImpl();
            _Enseignant = MDI_Form._Enseignant;
        }

        public uc_etudiants(Filiere f)
        {
            InitializeComponent();
            dao = new DAOImpl();
            _Enseignant = MDI_Form._Enseignant;
            filiere = f;
        }

        private void uc_etudiants_Load(object sender, EventArgs e)
        {
            l_nomClasse.Text = filiere.nomF;
            
            //
            listView_Etudiants.LargeImageList = imgList_etudiants;
            List<Etudiant> liste = dao.getListEtudiantsByClass(filiere.numC);

            foreach (Etudiant ee in liste)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ee.nom+" "+ee.prenom;
                item.ToolTipText = "Numéro: " + ee.num_Etud;
                if (ee.image != null)
                {
                    imgList_etudiants.Images.Add("f_"+ee.nom,ee.image);
                    item.ImageKey = "f_" + ee.nom;                    
                }
                else
                    switch (ee.genre)
                    {
                        case false: 
                            imgList_etudiants.Images.Add("f_" + ee.nom, Properties.Resources.nobody_male);
                            item.ImageKey = "f_" + ee.nom;
                            break;
                        case true: 
                            imgList_etudiants.Images.Add("f_" + ee.nom, Properties.Resources.nobody_female);
                            item.ImageKey = "f_" + ee.nom;
                            break;
                    }
                    
                listView_Etudiants.Items.Add(item);
            }
        }

        //retour
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MDI_Form.p_Child.Controls.Count > 1)
                MDI_Form.p_Child.Controls.RemoveAt(1);

            MDI_Form.p_Child.Controls.Add(new uc_classe(filiere));
        }

        private void listView_Etudiants_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem i = listView_Etudiants.SelectedItems[0];

            if (MDI_Form.p_Child.Controls.Count > 1)
                MDI_Form.p_Child.Controls.RemoveAt(1);

            string ss = i.ToolTipText.Substring(8, i.ToolTipText.Length-8);
            int num = Int32.Parse(ss);
            MDI_Form.p_Child.Controls.Add(new uc_etudiantInfos(dao.findEtudiantByNum(num)));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }


    }
}
