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

namespace Odrunia_POS_System.Forms.Users
{
	public partial class frmViewUser : Form
	{
		public frmViewUser()
		{
			InitializeComponent();
		}

		Components.Value val = new Components.Value();

		private void frmViewUser_Load(object sender, EventArgs e)
		{
			if(val.UserProfilePicture != null)
			{
				MemoryStream ms = new MemoryStream(val.UserProfilePicture);
				pbUserPicture.Image = Image.FromStream(ms);
			}

			txtUserRole.Text = val.UserUserRole;
			txtFirstName.Text = val.UserFirstName;
			txtMiddleName.Text = val.UserMiddleName;
			txtLastName.Text = val.UserLastName;
			txtGender.Text = val.UserGender;
			txtAge.Text = val.UserAge.ToString();
			txtBirthday.Text = val.UserBirthday.ToString("d");
			txtContactNumber.Text = val.UserContactNumber;
			txtEmail.Text = val.UserEmail;
			txtUsername.Text = val.UserUsername;
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
	}
}
