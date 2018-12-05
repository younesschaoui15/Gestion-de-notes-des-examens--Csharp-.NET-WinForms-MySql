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
    public partial class uc_matieres : UserControl
    {
        private static Filiere filiere;
        private static Enseignant _Enseignant;
        private DAOImpl dao;

        public uc_matieres()
        {
            InitializeComponent();
            _Enseignant = MDI_Form._Enseignant;
            dao = new DAOImpl();
        }

        public uc_matieres(Filiere f)
        {
            InitializeComponent();
            dao = new DAOImpl();
            _Enseignant = MDI_Form._Enseignant;
            filiere = f;
        }

        private void uc_matieres_Load(object sender, EventArgs e)
        {
            l_nomFiliere.Text = filiere.nomF;
            listView_Matieres.LargeImageList = imageList_matieres;
            List<Matiere> listeMatieres = dao.getListMatieresByEnseignantFiliere(_Enseignant, filiere);
            foreach (Matiere m in listeMatieres)
            {
                ListViewItem item = new ListViewItem();
                item.Text = m.nomM;
                if(m.image!=null)
                {
                    imageList_matieres.Images.Add("img_"+m.numM,m.image);
                    item.ImageKey="img_"+m.numM;
                }
                //item.ImageKey = "M_0";
                else
                {
                    imageList_matieres.Images.Add("img_" + m.numM, Properties.Resources.M_0);
                    item.ImageKey = "img_" + m.numM;
                }

                listView_Matieres.Items.Add(item);
            }
        }

        private void listView_Matieres_DoubleClick(object sender, EventArgs e)
        {
            if (MDI_Form.p_Child.Controls.Count > 1)
                MDI_Form.p_Child.Controls.RemoveAt(1);

            //La matiere séléctionée
            Matiere matiere = dao.findMatiereByName(listView_Matieres.SelectedItems[0].Text);

            MDI_Form.p_Child.Controls.Add(new uc_modifierNotes(matiere, filiere));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MDI_Form.p_Child.Controls.Count > 1)
                MDI_Form.p_Child.Controls.RemoveAt(1);

            MDI_Form.p_Child.Controls.Add(new uc_classe_matieres(filiere));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
