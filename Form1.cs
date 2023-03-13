using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void loadform(Form frm)
        {
            fluentDesignFormContainer1.Controls.Clear();
            AddOwnedForm(frm);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Tag = frm;
            fluentDesignFormContainer1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            loadform(new FormThongke());

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            loadform(new FormBieudo());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadform(new FormThongke());
        }


    }
}
