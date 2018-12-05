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
    public partial class uc_voirNotes : UserControl
    {
        private static Filiere filiere;
        private static Enseignant _Enseignant;
        private DAOImpl dao;

        public uc_voirNotes()
        {
            InitializeComponent();
            dao = new DAOImpl();
            _Enseignant = MDI_Form._Enseignant;
        }

        public uc_voirNotes(Filiere f)
        {
            InitializeComponent();
            dao = new DAOImpl();
            _Enseignant = MDI_Form._Enseignant;
            filiere = f;
        }

        private void uc_voirNotes_Load(object sender, EventArgs e)
        {
            l_nomClasse.Text = dao.getClasseByNum(filiere.numC).nomC;
            List<Matiere> listeMatieres = dao.getListMatieresByEnseignantFiliere(_Enseignant, filiere);
            List<Etudiant> listeEtudiants = dao.getListEtudiantsByClass(filiere.numC);

            int nbMatieres = listeMatieres.Count;

            //Ajout des des colonnes pour les (matières) :
            foreach (Matiere m in listeMatieres)
            { 
                if(m.nomM.Length<7)
                    listView_Notes.Columns.Add(m.nomM, m.nomM.Length * 20);
                else
                    listView_Notes.Columns.Add(m.nomM, m.nomM.Length * 13);
            }
                

            foreach (Etudiant ee in listeEtudiants)
            {   
                //Construction de la ligne [dans la table des notes]
                ListViewItem item = new ListViewItem(ee.CNE+"");
                item.SubItems.Add(ee.nom);
                item.SubItems.Add(ee.prenom);

                foreach (Matiere m in listeMatieres)
                {
                    double note = dao.getNoteByEtudiantMatiere(ee, m);
                    if(note>=0 && note<=20)
                        item.SubItems.Add(note+"");
                    else
                        item.SubItems.Add("-");
                }

                //Ajout de la ligne
                listView_Notes.Items.Add(item);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MDI_Form.p_Child.Controls.Count > 1)
                MDI_Form.p_Child.Controls.RemoveAt(1);

            MDI_Form.p_Child.Controls.Add(new uc_classe());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
