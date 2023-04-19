using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odrunia_POS_System.Forms
{
	public partial class frmCustomerDashboard : Form
	{
		public frmCustomerDashboard()
		{
			InitializeComponent();
		}

		private void btnOrder_Click(object sender, EventArgs e)
		{
			pnlDashboard.Controls.Clear();
			Forms.Customers.frmProductAvailable frmProductAvailable = new Forms.Customers.frmProductAvailable();
			frmProductAvailable.TopLevel = false;
			pnlDashboard.Controls.Add(frmProductAvailable);
			frmProductAvailable.Dock = DockStyle.Fill;
			frmProductAvailable.Show();
		}

		private void frmCustomerDashboard_Load(object sender, EventArgs e)
		{

		}
	}
}
