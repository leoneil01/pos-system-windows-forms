using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odrunia_POS_System.Forms.Users
{
	public partial class frmAddUser : Form
	{
		public frmAddUser()
		{
			InitializeComponent();
		}

		Functions.Gender gender = new Functions.Gender();
		Functions.Check check = new Functions.Check();
		Functions.UserRole userRole = new Functions.UserRole();
		Functions.User user = new Functions.User();

		string imgLocation = string.Empty;
		private void RemovePhoto()
		{
			imgLocation = string.Empty;
			pbUserPicture.ImageLocation = imgLocation;
		}

		private void frmAddUser_LoadComboBox(object sender, EventArgs e)
		{
			gender.LoadGendersInCmb(cmbGender);
			userRole.LoadUserRolesInCmb(cmbUserRole);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if(String.IsNullOrWhiteSpace(cmbUserRole.Text))
			{
				MessageBox.Show("User Role is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(String.IsNullOrWhiteSpace(txtFirstName.Text))
			{
				MessageBox.Show("First Name is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtFirstName.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtLastName.Text))
			{
				MessageBox.Show("Last Name is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtLastName.Focus();
			}
			else if(String.IsNullOrWhiteSpace(cmbGender.Text))
			{
				MessageBox.Show("Gender is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cmbGender.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtContactNumber.Text) && String.IsNullOrWhiteSpace(txtEmail.Text))
			{
				MessageBox.Show("Please provide contact information either contact number or email!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtContactNumber.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtUsername.Text))
			{
				MessageBox.Show("Username is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtUsername.Focus();
			}
			else if(check.IsUsernameExists(txtUsername.Text, cmbUserRole.Text))
			{
				MessageBox.Show("Username is already taken!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(String.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show("Password is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPassword.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtConfirmPassword.Text))
			{
				MessageBox.Show("Confirm Password is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtConfirmPassword.Focus();
			}
			else if(txtPassword.Text != txtConfirmPassword.Text)
			{
				MessageBox.Show("Password does not match!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				byte[] profilePicture = null;
				if(!String.IsNullOrWhiteSpace(imgLocation))
				{
					FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
					BinaryReader br = new BinaryReader(fs);
					profilePicture = br.ReadBytes((int)fs.Length);
				}

				int age = DateTime.Today.Year - dateBirthday.Value.Year;
				if(dateBirthday.Value.Date > DateTime.Today.AddYears(-age))
				{
					age--;
				}

				if(user.AddUser(profilePicture, cmbUserRole.Text,CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtFirstName.Text),CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtMiddleName.Text),CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtLastName.Text), cmbGender.Text, age, dateBirthday.Value.Date, txtContactNumber.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text))
				{
					MessageBox.Show("User successfully created!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

					RemovePhoto();

					txtFirstName.ResetText();
					txtMiddleName.ResetText();
					txtLastName.ResetText();
					txtContactNumber.ResetText();
					txtEmail.ResetText();
					txtUsername.ResetText();
					txtPassword.ResetText();
					txtConfirmPassword.ResetText();

					cmbUserRole.Text = null;
					cmbGender.Text = null;
					dateBirthday.Value = DateTime.Today;

					txtFirstName.Focus();
				}
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Forms.Users.frmUserList frmUserList = new Forms.Users.frmUserList();
			frmUserList.TopLevel = false;

			Forms.frmAdminDashboard frmAdminDashboard1 = new Forms.frmAdminDashboard();
			frmAdminDashboard1.Show();

			Forms.frmAdminDashboard frmAdminDashboard2 = (Forms.frmAdminDashboard)Application.OpenForms["frmAdminDashboard"];
			Panel pnlDashboard = (Panel)frmAdminDashboard2.Controls["pnlDashboard"];

			pnlDashboard.Controls.Add(frmUserList);
			frmUserList.Dock = DockStyle.Fill;
			frmUserList.Show();
			this.Close();
		}

		private void btnUpload_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.InitialDirectory = "d:\\Pictures";
			dialog.Filter = "PNG Files|*.png|JPG Files|*.jpg|All Files|*.*";

			if(dialog.ShowDialog() == DialogResult.OK)
			{
				imgLocation = dialog.FileName;
				pbUserPicture.ImageLocation = imgLocation;
			}

			txtFirstName.Focus();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			RemovePhoto();
			txtFirstName.Focus();
		}
	}
}
