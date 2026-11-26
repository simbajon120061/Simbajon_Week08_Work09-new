using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payot_Week08_Work09
{
    public partial class FrmMainScreen : Form
    {
        public FrmMainScreen()
        {
            InitializeComponent();
        }

        //1st nagibuhat
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployeeForm frmEmployeeForm = new FrmEmployeeForm();
            frmEmployeeForm.MdiParent = this;
            frmEmployeeForm.Show();
        }
    }
}
