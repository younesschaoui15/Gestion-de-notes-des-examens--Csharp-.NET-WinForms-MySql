using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.forms;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.userControls.admin
{
    public partial class uc_admin_affectation : UserControl
    {
        UserControl uc;

        public uc_admin_affectation()
        {
            InitializeComponent();
        }

        private void btn_mat_prof_Click(object sender, EventArgs e)
        {
            uc = new uc_admin_affectation_mat_prof();
            timer1.Start();
        }

        private void btn_mat_fil_Click(object sender, EventArgs e)
        {
            uc = new uc_admin_affectation_mat_fil();
            timer1.Start();
        }

        private void btn_mat_prof_MouseEnter(object sender, EventArgs e)
        {
            btn_mat_prof.ForeColor = Color.FromArgb(255, 235, 183);
            btn_mat_prof.Font = new System.Drawing.Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            pp_mat_prof.BackColor = Color.FromArgb(255, 235, 183);
        }

        private void btn_mat_prof_MouseLeave(object sender, EventArgs e)
        {
            btn_mat_prof.ForeColor = Color.White;
            btn_mat_prof.Font = new System.Drawing.Font("Century Gothic", 19.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            pp_mat_prof.BackColor = Color.White;
        }

        private void btn_mat_fil_MouseEnter(object sender, EventArgs e)
        {
            btn_mat_fil.ForeColor = Color.FromArgb(255, 235, 183);
            btn_mat_fil.Font = new System.Drawing.Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            pp_mat_fil.BackColor = Color.FromArgb(255, 235, 183);
        }

        private void btn_mat_fil_MouseLeave(object sender, EventArgs e)
        {
            btn_mat_fil.ForeColor = Color.White;
            btn_mat_fil.Font = new System.Drawing.Font("Century Gothic", 19.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            pp_mat_fil.BackColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Location = new Point(Location.X - 10, Location.Y);
            if (Location.X <= -this.Width)
            {
                timer1.Stop();
                adminForm.p_ch.Controls.RemoveAt(0);
                adminForm.p_ch.Controls.Add(uc);
                adminForm.p_ch.Refresh();
            }
        }

        
    }
}
