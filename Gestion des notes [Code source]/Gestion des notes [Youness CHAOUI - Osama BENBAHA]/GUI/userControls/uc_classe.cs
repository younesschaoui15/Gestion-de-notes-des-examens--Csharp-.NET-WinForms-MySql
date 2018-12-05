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
    public partial class uc_classe : UserControl
    {
        private static Filiere filiere;

        public uc_classe()
        {
            InitializeComponent();
        }
        public uc_classe(Filiere f)
        {
            InitializeComponent();
            filiere = f;
        }

        /** pictureBox1 && ll_etudiants **/
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ll_etudiants.ForeColor = Color.FromArgb(255, 235, 183);
            ll_etudiants.Font = new System.Drawing.Font("Century Gothic", 41.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            ll_etudiants.Location = new Point(ll_etudiants.Location.X - 7, ll_etudiants.Location.Y);
            pp_hover1.BackColor = Color.FromArgb(255, 235, 183);
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ll_etudiants.ForeColor = Color.White;
            ll_etudiants.Font = new System.Drawing.Font("Century Gothic", 39.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            ll_etudiants.Location = new Point(ll_etudiants.Location.X + 7, ll_etudiants.Location.Y);
            pp_hover1.BackColor = Color.White;
        }

        /** pictureBox2 && ll_notes **/
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            ll_notes.ForeColor = Color.FromArgb(255, 235, 183);
            ll_notes.Font = new System.Drawing.Font("Century Gothic", 41.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            ll_notes.Location = new Point(ll_notes.Location.X - 7, ll_notes.Location.Y);
            pp_hover2.BackColor = Color.FromArgb(255, 235, 183);
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            ll_notes.ForeColor = Color.White;
            ll_notes.Font = new System.Drawing.Font("Century Gothic", 39.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            ll_notes.Location = new Point(ll_notes.Location.X + 7, ll_notes.Location.Y);
            pp_hover2.BackColor = Color.White;
        }

        //chargement
        private void uc_classe_Load(object sender, EventArgs e)
        {   
            if(filiere.nomF.Length<25)
                l_nomClasse.Text = filiere.nomF;
            else
                l_nomClasse.Text = filiere.nomF.Substring(0,24)+"...";
        }

        //vers les étudiants
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (MDI_Form.p_Child.Controls.Count > 1)
                MDI_Form.p_Child.Controls.RemoveAt(1);

            MDI_Form.p_Child.Controls.Add(new uc_etudiants(filiere));
        }

        //Consulter les notes
        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            if (MDI_Form.p_Child.Controls.Count > 1)
                MDI_Form.p_Child.Controls.RemoveAt(1);

            MDI_Form.p_Child.Controls.Add(new uc_voirNotes(filiere));
        }

        //retour
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MDI_Form.p_Child.Controls.Count > 1)
                MDI_Form.p_Child.Controls.RemoveAt(1);

            MDI_Form.p_Child.Controls.Add(new uc_classe_matieres(filiere));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        

    }
}
