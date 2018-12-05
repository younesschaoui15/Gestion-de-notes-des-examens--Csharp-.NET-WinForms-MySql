using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.DAO;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Entites;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.forms;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.userControls;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.forms;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.userControls.admin
{
    public partial class uc_admin_affectation_mat_fil : UserControl
    {
        DAOImpl dao;
        int selectedMatiere=-1;

        public uc_admin_affectation_mat_fil()
        {
            InitializeComponent();
            dao = new DAOImpl();
        }

        private void uc_admin_affectation_mat_fil_Load(object sender, EventArgs e)
        {
            fill_listView_Matieres(dao.getListAllMatieres(), listView_Mat, imageList_Mat);
        }

        private void fill_listView_Matieres(List<Matiere> listeMatieres, ListView lv, ImageList imgL)
        {
            lv.LargeImageList = imgL;

            foreach (Matiere mm in listeMatieres)
            {
                ListViewItem item = new ListViewItem();
                item.Text = mm.nomM;
                item.ToolTipText = mm.numM+"-"+mm.nomM;

                if (mm.image != null)
                {
                    imgL.Images.Add("img_" + mm.numM, mm.image);
                    item.ImageKey = "img_" + mm.numM;
                }
                else
                {
                    imgL.Images.Add("img_" + mm.numM, Properties.Resources.M_0);
                    item.ImageKey = "img_" + mm.numM;
                }

                lv.Items.Add(item);
            }
        }

        private void fill_listView_Filieres(List<Filiere> listeFilieres, ListView lv, ImageList imgL)
        {
            lv.LargeImageList = imgL;

            foreach (Filiere ff in listeFilieres)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ff.nomF;
                item.ToolTipText = ff.numF + "-" + ff.nomF;

                switch (ff.numF)
                {
                    case 1: imgL.Images.Add("img_" + ff.numF, Properties.Resources.G_INF); break;
                    case 2: imgL.Images.Add("img_" + ff.numF, Properties.Resources.G_PEE); break;
                    case 3: imgL.Images.Add("img_" + ff.numF, Properties.Resources.G_E); break;
                    case 4: imgL.Images.Add("img_" + ff.numF, Properties.Resources.G_IND); break;
                    case 5: imgL.Images.Add("img_" + ff.numF, Properties.Resources.G_M); break;
                    case 6: imgL.Images.Add("img_" + ff.numF, Properties.Resources.G_C); break;
                    default: imgL.Images.Add("img_" + ff.numF, Properties.Resources.M_0); break;
                }
                item.ImageKey = "img_" + ff.numF;
                
                lv.Items.Add(item);
            }
        }

        private void listView_Mat_DoubleClick(object sender, EventArgs e)
        {
        //    btn_appliquer.Enabled = false;

        //    ListViewItem i = listView_Mat.SelectedItems[0];
        //    selectedMatiere = Convert.ToInt32(i.ToolTipText.Substring(0, i.ToolTipText.IndexOf('-')));
            
        //    listView_aff.Clear();
        //    fill_listView_Filieres(dao.getListAllFilieresByMatiere(selectedMatiere), listView_aff, imageList_aff);

        //    listView_non_aff.Clear();
        //    fill_listView_Filieres(dao.getListAllFilieresByNonMatiere(selectedMatiere), listView_non_aff, imageList_non_aff);
        }

        private void btn_appliquer_Click(object sender, EventArgs e)
        {   
            DialogResult res = MessageBox.Show("Etes-vous sûr d'effectuer cette opération ?\n\n", "Question",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(res==DialogResult.Yes)
            {
                if (listView_non_aff.SelectedItems.Count>0)
                    foreach(ListViewItem i in listView_non_aff.SelectedItems)
                    {
                        int numF = Convert.ToInt32(i.ToolTipText.Substring(0, i.ToolTipText.IndexOf('-')));
                        if(!dao.affecterMatiereToFiliere(selectedMatiere, numF))
                            MessageBox.Show("La Matière No:"+selectedMatiere+" n'est pas affectée à la filière No:"+numF, "Erreur", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else 
                    if (listView_aff.SelectedItems.Count > 0)
                    foreach (ListViewItem i in listView_aff.SelectedItems)
                    {
                        int numF = Convert.ToInt32(i.ToolTipText.Substring(0, i.ToolTipText.IndexOf('-')));
                        if(!dao.retirerMatiereFromFiliere(selectedMatiere, numF))
                            MessageBox.Show("La Matière No:" + selectedMatiere + " n'est pas retirée de la filière No:" + numF, "Erreur",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                btn_appliquer.Enabled = false;
                listView_aff.Clear();
                fill_listView_Filieres(dao.getListAllFilieresByMatiere(selectedMatiere), listView_aff, imageList_aff);
                listView_non_aff.Clear();
                fill_listView_Filieres(dao.getListAllFilieresByNonMatiere(selectedMatiere), listView_non_aff, imageList_non_aff);
                MessageBox.Show("Opérations terminées.\n\n", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listView_non_aff_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView_non_aff.SelectedItems.Count > 0)
            {
                listView_aff.SelectedItems.Clear();
                btn_appliquer.Enabled = true;
                btn_appliquer.Text = "Appliquer l'affectation";
            }
            else
            {
                btn_appliquer.Enabled = false;
                btn_appliquer.Text = "Appliquer l'affectation";
            }
        }

        private void listView_aff_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView_aff.SelectedItems.Count > 0)
            {
                listView_non_aff.SelectedItems.Clear();
                btn_appliquer.Enabled = true;
                btn_appliquer.Text = "Retirer";
            }
            else
            {
                btn_appliquer.Enabled = false;
                btn_appliquer.Text = "Retirer";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            adminForm.p_ch.Controls.RemoveAt(0);
            adminForm.p_ch.Controls.Add(new uc_admin_affectation());
            adminForm.p_ch.Refresh();
        }

        private void listView_Mat_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView_Mat.SelectedItems.Count > 0)
            {
                btn_appliquer.Enabled = false;

                ListViewItem i = listView_Mat.SelectedItems[0];
                selectedMatiere = Convert.ToInt32(i.ToolTipText.Substring(0, i.ToolTipText.IndexOf('-')));

                listView_aff.Clear();
                fill_listView_Filieres(dao.getListAllFilieresByMatiere(selectedMatiere), listView_aff, imageList_aff);

                listView_non_aff.Clear();
                fill_listView_Filieres(dao.getListAllFilieresByNonMatiere(selectedMatiere), listView_non_aff, imageList_non_aff);
       
                ll_selectedMat.Visible = true;
                string nomM = listView_Mat.SelectedItems[0].ToolTipText;
                ll_selectedMat.Text += nomM;
            }
            else
            {
                ll_selectedMat.Visible = false;
                ll_selectedMat.Text ="Matière séléctionnée : ";
            }
        }
    
    }
}
