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
    public partial class uc_admin_affectation_mat_prof : UserControl
    {
        DAOImpl dao;
        Enseignant ens = null;
        int selectedMatiere = -1, numNewEns=-1, numOldEns=-1;

        public uc_admin_affectation_mat_prof()
        {
            InitializeComponent();
            dao = new DAOImpl();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            adminForm.p_ch.Controls.RemoveAt(0);
            adminForm.p_ch.Controls.Add(new uc_admin_affectation());
            adminForm.p_ch.Refresh();
        }

        private void uc_admin_affectation_mat_prof_Load(object sender, EventArgs e)
        {
            fill_listView_Matieres(dao.getListAllMatieres(), listView_Mat, imageList_Mat);
            //listView_Enss.Clear();
            fill_listView_Enseignants(dao.getListAllEnseignant(), listView_Enss, imageList_Enss);
        }



        private void fill_listView_Matieres(List<Matiere> listeMatieres, ListView lv, ImageList imgL)
        {
            lv.LargeImageList = imgL;

            foreach (Matiere mm in listeMatieres)
            {
                ListViewItem item = new ListViewItem();
                item.Text = mm.nomM;
                item.ToolTipText = mm.numM + "-" + mm.nomM;

                if (mm.image != null)
                    imgL.Images.Add("img_" + mm.numM, mm.image);
                else
                    imgL.Images.Add("img_" + mm.numM, Properties.Resources.M_0);
                item.ImageKey = "img_" + mm.numM;

                lv.LargeImageList = imgL;
                lv.Items.Add(item);
            }
        }
        private void fill_listView_Enseignants(List<Enseignant> listeEns, ListView lv, ImageList imgL)
        {
            lv.LargeImageList = imgL;

            foreach (Enseignant ee in listeEns)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ee.nom+" "+ee.prenom;
                item.ToolTipText = ee.num_Ens+"-"+ee.nom+" "+ee.prenom;

                if (ee.image != null)
                {
                    imgL.Images.Add("img_" + ee.num_Ens, ee.image);
                    item.ImageKey = "img_" + ee.num_Ens;
                }
                else
                {
                    switch (ee.genre)
                    {
                        case true: imgL.Images.Add("img_" + ee.num_Ens, Properties.Resources.nobody_female); break;
                        case false: imgL.Images.Add("img_" + ee.num_Ens, Properties.Resources.nobody_male); break;
                    }
                    item.ImageKey = "img_" + ee.num_Ens;
                }

                lv.LargeImageList = imgL;
                lv.Items.Add(item);
            }
        }

        private void listView_Mat_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView_Mat.SelectedItems.Count > 0)
            {
                ListViewItem i = listView_Mat.SelectedItems[0];
                ll_selectedMat.Visible = true;
                ll_selectedMat.Text += i.ToolTipText;
                
                selectedMatiere = Convert.ToInt32(i.ToolTipText.Substring(0, i.ToolTipText.IndexOf('-')));

                ens = dao.getEnseignantByMatiere(selectedMatiere);
                if (ens != null)
                {
                    numOldEns = ens.num_Ens;

                    l_num.Text = ens.num_Ens + "";
                    l_nom.Text = ens.nom;
                    l_prenom.Text = ens.prenom;
                    l_email.Text = ens.email;
                    if (ens.image != null)
                        pb_ens.BackgroundImage = ens.image;
                    else
                        switch (ens.genre)
                        {
                            case false: pb_ens.BackgroundImage = Properties.Resources.nobody_male; break;
                            case true: pb_ens.BackgroundImage = Properties.Resources.nobody_female; break;
                        }
                    btn_retirer.Visible = true;
                }
                else
                {
                    btn_retirer.Visible = false;
                    numOldEns = -1;
                    l_num.Text = ". . .";
                    l_nom.Text = ". . .";
                    l_prenom.Text = ". . .";
                    l_email.Text = ". . .";
                    pb_ens.BackgroundImage = null;
                }

            }
            else
            {
                selectedMatiere = -1;
                ll_selectedMat.Visible = false;
                ll_selectedMat.Text = "Matière séléctionnée : ";
            }
        }
        private void listView_Enss_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView_Enss.SelectedItems.Count > 0)
            {
                ListViewItem i = listView_Enss.SelectedItems[0];
                btn_appliquer.Visible = true;

                numNewEns = Convert.ToInt32(i.ToolTipText.Substring(0, i.ToolTipText.IndexOf('-')));
            }
            else
            {
                btn_appliquer.Visible = false;
                numNewEns = -1;
            }
        }


        private void btn_appliquer_Click(object sender, EventArgs e)
        {
            if (numNewEns < 0)
            {
                MessageBox.Show("Veuillez séléctionner le nouveau enseignant(e) de cette matière.\n", "Attention",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (selectedMatiere < 0)
            {
                MessageBox.Show("Veuillez séléctionner une matière s'il vous plaît.\n", "Attention",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {   
                string op;
                //Existance d'un enseignant encien pour la matière
                if(ens!=null)
                    op = "Retirer Mr/Mme " + ens.nom + " " + ens.prenom + " et affecter" +
                                                    " le nouveau enseignant(e) à cette matière.\n\nÊtes-vous " +
                                                    "sûr d'effectuer cette opération ?\n\n";
                //Pas d'un enseignant encien pour la matière
                else
                    op = "Voulez-vous affecter un nouveau enseignant(e) à cette matière ?";


                DialogResult res = MessageBox.Show(op, "Question",
                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (dao.affecterMatiereToEnseignant(selectedMatiere, numNewEns))
                        MessageBox.Show("L'opération a terminée avec succes.\n\n", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("L'opération a échouée.\n\n", "Erreur",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

                
            /* Chargement des nouvelles données */
            if (listView_Mat.SelectedItems.Count > 0)
            {
                ens = dao.getEnseignantByMatiere(selectedMatiere);
                if (ens != null)
                {
                    numOldEns = ens.num_Ens;

                    l_num.Text = ens.num_Ens + "";
                    l_nom.Text = ens.nom;
                    l_prenom.Text = ens.prenom;
                    l_email.Text = ens.email;
                    if (ens.image != null)
                        pb_ens.BackgroundImage = ens.image;
                    else
                        switch (ens.genre)
                        {
                            case false: pb_ens.BackgroundImage = Properties.Resources.nobody_male; break;
                            case true: pb_ens.BackgroundImage = Properties.Resources.nobody_female; break;
                        }
                    btn_retirer.Visible = true;
                }
                else
                {
                    btn_retirer.Visible = false;
                    numOldEns = -1;
                    l_num.Text = ". . .";
                    l_nom.Text = ". . .";
                    l_prenom.Text = ". . .";
                    l_email.Text = ". . .";
                    pb_ens.BackgroundImage = null;
                }
            }
        }

        private void btn_retirer_Click(object sender, EventArgs e)
        {
            if (ens != null)
            {
                DialogResult res = MessageBox.Show("Êtes-vous sûr de retirer l'enseignant(e) actuel de cette matière ?\n\n", "Question",
                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (dao.retirerMatiereFromEnseignant(selectedMatiere))
                    {
                        MessageBox.Show("L'opération a terminée avec succes.\n\n", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_retirer.Visible = false;
                        numOldEns = -1;
                        l_num.Text = ". . .";
                        l_nom.Text = ". . .";
                        l_prenom.Text = ". . .";
                        l_email.Text = ". . .";
                        pb_ens.BackgroundImage = null;
                    }
                    else
                        MessageBox.Show("L'opération a echouée.\n\n", "Erreur",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Veuillez séléctionner une matière s'il vous plaît.\n", "Attention",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        

    }
}
