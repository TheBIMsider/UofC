using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Asst_2_Payroll_Manager_CStorms
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            // the program will close when the red "X" button on is clicked, with a pop-up to confirm your choice
            DialogResult quitDialog = MessageBox.Show("Do you really want to quit the Employee Payroll Calculator",
                                                      "Exit", MessageBoxButtons.YesNo);

            if (quitDialog == DialogResult.Yes)
            {
                Application.Exit();
            }

            else if (quitDialog == DialogResult.No)
            {
                return;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // the program will remove all employee date from display are and save any changes 
            // when the "Close"option in the file drop-down meanu is selected
       
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // the program will close when the "Exit" option in the file drop-down meanu is selected,
            // with a pop-up to confirm your choice
            DialogResult quitDialog = MessageBox.Show("You are about to close Employee Payroll Calculator, please save all changes first",
                                                      "Exit", MessageBoxButtons.YesNo);

            if (quitDialog == DialogResult.Yes)
            {
                Application.Exit();
            }

            else if (quitDialog == DialogResult.No)
            {

            }
        }
    }
}
