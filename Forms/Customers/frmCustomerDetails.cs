using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odrunia_POS_System.Forms.Customers
{
	public partial class frmCustomerDetails : Form
	{
		public frmCustomerDetails()
		{
			InitializeComponent();
		}

		private void btnOrder_Click(object sender, EventArgs e)
		{
			if(String.IsNullOrWhiteSpace(txtFirstName.Text))
			{
				MessageBox.Show("First Name is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtFirstName.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtLastName.Text))
			{
				MessageBox.Show("Last Name is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtLastName.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtContactNumber.Text) && String.IsNullOrWhiteSpace(txtEmail.Text))
			{
				MessageBox.Show("Please provide contact information either contact number or email!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtContactNumber.Focus();
			}
			else
			{
				Forms.frmCustomerDashboard frmCustomerDashboard = new Forms.frmCustomerDashboard();
				frmCustomerDashboard.Show();
				this.Close();
			}
		}
	}
}
