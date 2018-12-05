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
    public partial class uc_admin_matiere_2 : UserControl
    {   
        DAOImpl dao;
        Matiere matiere;
        ListViewItem selectedItem;

        public uc_admin_matiere_2()
        {
            InitializeComponent();
            dao = new DAOImpl();
        }

        public uc_admin_matiere_2(Matiere mat)
        {
            InitializeComponent();
            dao = new DAOImpl();
            matiere = mat;
        }

        private void btn_creer_Click(object sender, EventArgs e)
        {
            Match m = new Regex("\\d").Match(selectedItem.ToolTipText);
            string no = "";
            if (m.Success)
                for (int i = 0; i < 6; i++)
                {
                    no += m.Value;
                    m = m.NextMatch();
                }
            int num = Convert.ToInt32(no);

            matiere.num_Ens = num;
            if (dao.addMatiere(matiere))
            {
                MessageBox.Show("Matière créer avec succes.", "SUCCES",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_precedent.Enabled = false;
                btn_creer.Enabled = false;
                adminForm.p_ch.Controls.RemoveAt(0);
                adminForm.p_ch.Controls.Add(new uc_admin_matiere_1());
            }
            else
                MessageBox.Show("Matière n'est pas crée !", "ATTENTION",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void uc_admin_matiere_2_Load(object sender, EventArgs e)
        {
            listView_Ens.LargeImageList = imageList_Ens;
            List<Enseignant> liste = dao.getListAllEnseignant();

            foreach (Enseignant ee in liste)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ee.nom + " " + ee.prenom;
                item.ToolTipText = "Numéro: " + ee.num_Ens + "\nNom & Prénom: " + item.Text;

                if (ee.image != null)
                {
                    imageList_Ens.Images.Add("f_" + ee.num_Ens, ee.image);
                    item.ImageKey = "f_" + ee.num_Ens;
                }
                else
                    switch (ee.genre)
                    {
                        case false:
                            imageList_Ens.Images.Add("f_" + ee.num_Ens, Properties.Resources.nobody_male);
                            item.ImageKey = "f_" + ee.num_Ens;
                            break;
                        case true:
                            imageList_Ens.Images.Add("f_" + ee.num_Ens, Properties.Resources.nobody_female);
                            item.ImageKey = "f_" + ee.num_Ens;
                            break;
                    }

                listView_Ens.Items.Add(item);
            }
        }

        private void listView_Ens_Click(object sender, EventArgs e)
        {
            selectedItem = listView_Ens.SelectedItems[0]; 
            btn_creer.Enabled = true;            
        }

        private void btn_suivant_Click(object sender, EventArgs e)
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
                adminForm.p_ch.Controls.Add(new uc_admin_matiere_1(matiere));
                adminForm.p_ch.Refresh();
            }
        }
    }
}
