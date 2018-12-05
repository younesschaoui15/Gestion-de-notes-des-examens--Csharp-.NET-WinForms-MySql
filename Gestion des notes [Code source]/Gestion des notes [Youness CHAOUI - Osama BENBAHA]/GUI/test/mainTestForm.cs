using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.forms;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.test
{
    public partial class mainTestForm : Form
    {   
        UserControl1 con1;
        UserControl2 con2;

        public mainTestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Remove(con2);
            panel1.Controls.Remove(con1);
            con1 = new UserControl1();
            panel1.Controls.Add(con1);
        }

        private void Forme1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Remove(con1);
            panel1.Controls.Remove(con2);
            con2 = new UserControl2();
            panel1.Controls.Add(con2);
        }
    }
}
