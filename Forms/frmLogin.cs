using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odrunia_POS_System
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		Functions.UserRole userRole = new Functions.UserRole();
		Functions.Login login = new Functions.Login();
		Components.Value val = new Components.Value();

		private void frmLogin_LoadUserRole(object sender, EventArgs e)
		{
			userRole.LoadUserRolesInCmb(cmbUserRole);
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if(String.IsNullOrWhiteSpace(txtUsername.Text) && String.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show("Username and Password are required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtUsername.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtUsername.Text))
			{
				MessageBox.Show("Username is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtUsername.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show("Password is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPassword.Focus();
			}
			else if(String.IsNullOrWhiteSpace(cmbUserRole.Text))
			{
				MessageBox.Show("User Role is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(login.AuthenticateUser(txtUsername.Text, txtPassword.Text, cmbUserRole.Text))
			{
				if(cmbUserRole.Text == "ADMIN")
				{
					Forms.frmAdminDashboard frmAdminDashboard = new Forms.frmAdminDashboard();
					frmAdminDashboard.Show();
					this.Hide();

					MessageBox.Show($"Welcome Admin {val.MyFullName}!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if(cmbUserRole.Text == "CASHIER")
				{
					Forms.frmCashierDashboard frmCashierDashboard = new Forms.frmCashierDashboard();
					frmCashierDashboard.Show();
					this.Hide();

					MessageBox.Show($"Welcome Cashier {val.MyFullName}!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("Your credentials does not match in our record!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtUsername.SelectAll();
				txtPassword.SelectAll();
				txtUsername.Focus();
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnCustomer_Click(object sender, EventArgs e)
		{
			Forms.Customers.frmCustomerDetails frmCustomerDetails = new Forms.Customers.frmCustomerDetails();
			frmCustomerDetails.Show();
			this.Hide();
		}
	}
}
