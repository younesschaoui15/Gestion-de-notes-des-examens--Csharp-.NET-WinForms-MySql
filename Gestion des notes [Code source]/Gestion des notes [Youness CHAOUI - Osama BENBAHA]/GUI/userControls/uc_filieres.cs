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
    public partial class uc_filieres : UserControl
    {
        private DAOImpl dao;
        private Enseignant _Enseignant;

        public uc_filieres()
        {
            InitializeComponent();
            dao = new DAOImpl();
            _Enseignant = MDI_Form._Enseignant;
        }

        private void uc_filieres_Load(object sender, EventArgs e)
        {
            listView_Filieres.LargeImageList = imgList_Filieres;
            List<Filiere> liste = dao.getListFilieresByEnseignant(_Enseignant);

            foreach(Filiere f in liste)
            {
                ListViewItem item = new ListViewItem();
                item.Text = f.nomF;
                item.ToolTipText = "Numéro: " + f.numF +
                                    "\nNom: " + f.nomF +
                                    "\nMatières: " + f.nbrMatiere +
                                    "\nClasse: " + f.numC;
                switch (f.numF)
                {
                    case 1: item.ImageKey = "img_GINF"; break;
                    case 2: item.ImageKey = "img_GPEE"; break;
                    case 3: item.ImageKey = "img_GE"; break;
                    case 4: item.ImageKey = "img_GIND"; break;
                    case 5: item.ImageKey = "img_GM"; break;
                    case 6: item.ImageKey = "img_GC"; break;
                }
                listView_Filieres.Items.Add(item);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {   
            ListViewItem i = listView_Filieres.SelectedItems[0];
            
            if (MDI_Form.p_Child.Controls.Count > 1)
                MDI_Form.p_Child.Controls.RemoveAt(1);

            MDI_Form.p_Child.Controls.Add(new uc_classe_matieres(dao.getFiliereByName(i.Text)));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MDI_Form.p_Child.Controls.Count > 1)
                MDI_Form.p_Child.Controls.RemoveAt(1);

            MDI_Form.p_Child.Controls.Add(new uc_acceuil());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
