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
    public partial class uc_classe_matieres : UserControl
    {
        private static Filiere filiere;
        public int idFiliere;

        public uc_classe_matieres()
        {
            InitializeComponent();
        }

        public uc_classe_matieres(Filiere f)
        {
            InitializeComponent();
            filiere = f;
        }

        private void uc_classe_matieres_Load(object sender, EventArgs e)
        {
            l_nomFiliere.Text = filiere.nomF;
        }


        //** pictureBox2 **//
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            ll_matiere.ForeColor = Color.FromArgb(255, 235, 183);
            ll_matiere.Font = new System.Drawing.Font("Century Gothic", 41.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            ll_matiere.Location = new Point(ll_matiere.Location.X - 7, ll_matiere.Location.Y);
            pp_hover2.BackColor = Color.FromArgb(255, 235, 183); 
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            ll_matiere.ForeColor = Color.White;
            ll_matiere.Font = new System.Drawing.Font("Century Gothic", 39.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            ll_matiere.Location = new Point(ll_matiere.Location.X + 7, ll_matiere.Location.Y);
            pp_hover2.BackColor = Color.White;
        }

        //** pictureBox1 **//
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ll_classe.ForeColor = Color.FromArgb(255, 235, 183);
            ll_classe.Font = new System.Drawing.Font("Century Gothic", 41.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            ll_classe.Location = new Point(ll_classe.Location.X - 7, ll_classe.Location.Y);
            pp_hover1.BackColor = Color.FromArgb(255, 235, 183); 
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ll_classe.ForeColor = Color.White;
            ll_classe.Font = new System.Drawing.Font("Century Gothic", 39.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            ll_classe.Location = new Point(ll_classe.Location.X + 7, ll_classe.Location.Y);
            pp_hover1.BackColor = Color.White; 
        }
        

        //vers la classe
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("Vers la classe ...");
            if (MDI_Form.p_Child.Controls.Count > 1)
                MDI_Form.p_Child.Controls.RemoveAt(1);

            MDI_Form.p_Child.Controls.Add(new uc_classe(filiere));
        }

        //vers les matieres
        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("Vers les matières ...");
            if (MDI_Form.p_Child.Controls.Count > 1)
                MDI_Form.p_Child.Controls.RemoveAt(1);

            MDI_Form.p_Child.Controls.Add(new uc_matieres(filiere));
        }

        //Retour
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MDI_Form.p_Child.Controls.Count > 1)
                MDI_Form.p_Child.Controls.RemoveAt(1);

            MDI_Form.p_Child.Controls.Add(new uc_filieres());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        

        
    }
}
