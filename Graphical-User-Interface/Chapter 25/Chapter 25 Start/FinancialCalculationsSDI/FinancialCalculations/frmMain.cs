using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinancialCalculations
{
    public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

        private void btnFutureValue_Click(object sender, EventArgs e)
        {
            Form newFutureValueForm = new frmFutureValue();
            newFutureValueForm.Show();
        }

        private void btnCalculateDepreciation_Click(object sender, EventArgs e)
        {
            Form newCalculateDepreciationForm = new frmDepreciation();
            newCalculateDepreciationForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}