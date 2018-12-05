using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.userControls;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Entites;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Config;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.DAO;
using System.Diagnostics;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.forms;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.forms
{
    public partial class MDI_Form : Form
    {
        public static Enseignant _Enseignant;
        //

        private int childFormNumber = 0;
        bool isHide;
        float wMenuPanel;
        //Edit Form
        public Form editForm;
        

        public MDI_Form()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.contract_wrL_icon;
            wMenuPanel = p_menu.Width;
            p_menu.Width = 0;
            isHide = true;
        }

        public MDI_Form(Enseignant ee)
        {
            InitializeComponent();
            this.Icon = Properties.Resources.contract_wrL_icon;
            wMenuPanel = p_menu.Width;
            p_menu.Width = 0;
            isHide = true;
            _Enseignant = ee;
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void MDI_Form_Load(object sender, EventArgs e)
        {
            p_Child.Controls.Add(new uc_acceuil());
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pb_menu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isHide)
            {
                p_menu.Width += 35;
                if (p_menu.Width >= wMenuPanel)
                {
                    timer1.Stop();
                    isHide = false;
                    this.Refresh();
                }
            }
            else
            {
                p_menu.Width -= 35;
                if (p_menu.Width <= 0)
                {
                    timer1.Stop();
                    isHide = true;
                    this.Refresh();
                }
            }
        }

        private void btn_entrer_Click(object sender, EventArgs e)
        {
            if(p_Child.Controls.Count>1)
                p_Child.Controls.RemoveAt(1);
            p_Child.Controls.Add(new uc_acceuil());
            timer1.Start();
            this.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (p_Child.Controls.Count > 1)
                p_Child.Controls.RemoveAt(1);
            p_Child.Controls.Add(new uc_filieres());
            timer1.Start();
            this.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            /* Méthode 1 */
            Application.Restart();
            Environment.Exit(0);
            
            /* Méthode 2 */
            //Process.Start(Application.ExecutablePath); // to start new instance of application
            //this.Close(); //to turn off current app
        }

        private void quiSommeNous_Click(object sender, EventArgs e)
        {
            new aboutUs().ShowDialog();
        }

    }
}
