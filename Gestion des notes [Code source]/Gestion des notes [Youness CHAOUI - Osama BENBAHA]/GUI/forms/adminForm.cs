using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.userControls.admin;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.forms
{
    public partial class adminForm : Form
    {
        private bool begin=true;
        private uc_admin_accueil acc;

        public adminForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.contract_wrL_icon;
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            acc = new uc_admin_accueil();
            p_ch.Controls.Add(acc);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            p_ch.Controls.RemoveAt(0);
            begin = true;
            p_ch.Controls.Add(new uc_admin_enseignant_1());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Application.Restart();
            Environment.Exit(0);
        }

        private void btn_matiere_Click(object sender, EventArgs e)
        {
            p_ch.Controls.RemoveAt(0);
            begin = true;
            p_ch.Controls.Add(new uc_admin_matiere_1());
        }

        private void btn_home_Click_1(object sender, EventArgs e)
        {
            if(!p_ch.Contains(acc))
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (begin)
            {
                p_ch.Controls.RemoveAt(0);
                acc = new uc_admin_accueil();
                acc.Location = new Point(p_ch.Location.X, p_ch.Height);
                p_ch.Controls.Add(acc);
                begin = false;
            }
            else
            {
                acc.Location = new Point(p_ch.Location.X, acc.Location.Y - 30);
                if (acc.Location.Y <= 30)
                {
                    timer1.Stop();
                    p_ch.Refresh();
                }
            }
            
        }

        private void btn_affectation_Click(object sender, EventArgs e)
        {
            begin = true;
            p_ch.Controls.RemoveAt(0);
            p_ch.Controls.Add(new uc_admin_affectation());
        }
    }
}
