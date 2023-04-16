using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Odrunia_POS_System.Forms.Users
{
	public partial class frmUpdateUser : Form
	{
		public frmUpdateUser()
		{
			InitializeComponent();
		}

		Components.Value val = new Components.Value();
		Functions.UserRole userRole = new Functions.UserRole();
		Functions.User user = new Functions.User();
		Functions.Gender gender = new Functions.Gender();

		string imgLocation = string.Empty;
		private void frmUpdateUser_Load(object sender, EventArgs e)
		{
			userRole.LoadUserRolesInCmb(cmbUserRole);
			gender.LoadGendersInCmb(cmbGender);

			if(val.UserProfilePicture != null)
			{
				MemoryStream ms = new MemoryStream(val.UserProfilePicture);
				pbUserPicture.Image = Image.FromStream(ms);
			}

			cmbUserRole.Text = val.UserUserRole;
			txtFirstName.Text = val.UserFirstName;
			txtMiddleName.Text = val.UserMiddleName;
			txtLastName.Text = val.UserLastName;
			cmbGender.Text = val.UserGender;
			dateBirthday.Value = val.UserBirthday.Date;
			txtContactNumber.Text = val.UserContactNumber;
			txtEmail.Text = val.UserEmail;
			txtUsername.Text = val.UserUsername;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if(String.IsNullOrWhiteSpace(cmbUserRole.Text))
			{
				MessageBox.Show("User Role is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cmbUserRole.Focus();
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
				MessageBox.Show("Please provide contact information either contact number or email!", "", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				txtContactNumber.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtUsername.Text))
			{
				MessageBox.Show("Username is required!", "", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				txtUsername.Focus();
			}
			else
			{
				if(!String.IsNullOrWhiteSpace(imgLocation))
				{
					FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
					BinaryReader br = new BinaryReader(fs);
					val.UserProfilePicture = br.ReadBytes((int)fs.Length);
				}

				int age = DateTime.Today.Year - dateBirthday.Value.Year;
				if(dateBirthday.Value.Date > DateTime.Today.AddYears(-age))
				{
					age--;
				}

				if(user.UpdateUser(val.UserId, val.UserProfilePicture, cmbUserRole.Text,CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtFirstName.Text),CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtMiddleName.Text),CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtLastName.Text), cmbGender.Text, age, dateBirthday.Value.Date, txtContactNumber.Text, txtEmail.Text, txtUsername.Text))
				{
					MessageBox.Show("User successfully updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Failed to update user!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

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
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			imgLocation = string.Empty;
			pbUserPicture.ImageLocation = imgLocation;

			val.UserProfilePicture = null;
			pbUserPicture.Image = null;
		}
	}
}
