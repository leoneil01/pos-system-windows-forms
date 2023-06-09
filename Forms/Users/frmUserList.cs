﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odrunia_POS_System.Forms.Users
{
	public partial class frmUserList : Form
	{
		public frmUserList()
		{
			InitializeComponent();
		}

		Functions.User user = new Functions.User();

		private void frmUserList_LoadUser(object sender, EventArgs e)
		{
			user.LoadUsers(gridUsers);
		}

		private void frmUserList_VisibleChanged(object send, EventArgs e)
		{
			gridUsers.ClearSelection();
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			Forms.Users.frmAddUser frmAddUser = new Forms.Users.frmAddUser();
			frmAddUser.Show();
			Application.OpenForms["frmAdminDashboard"].Close();
		}

		private void btnViewUser_Click(object sender, EventArgs e)
		{
			if(gridUsers.SelectedRows.Count < 1)
			{
				MessageBox.Show("Select user first!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(user.GetUser(int.Parse(gridUsers.SelectedCells[0].Value.ToString())))
			{
				Forms.Users.frmViewUser frmViewUser = new Forms.Users.frmViewUser();
				frmViewUser.Show();
				Application.OpenForms["frmAdminDashboard"].Close();
			}
		}

		private void btnUpdateUser_Click(object sender, EventArgs e)
		{
			if(gridUsers.SelectedRows.Count < 1)
			{
				MessageBox.Show("Select user first!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(user.GetUser(int.Parse(gridUsers.SelectedCells[0].Value.ToString())))
			{
				Forms.Users.frmUpdateUser frmUpdateUser = new Forms.Users.frmUpdateUser();
				frmUpdateUser.Show();
				Application.OpenForms["frmAdminDashboard"].Close();
			}
		}

		private void btnDeleteUser_Click(object sender, EventArgs e)
		{
			if(gridUsers.SelectedRows.Count < 1)
			{
				MessageBox.Show("Select user first!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(MessageBox.Show("Are you sure you want to delete this user?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if(user.DeleteUser(int.Parse(gridUsers.SelectedCells[0].Value.ToString())))
				{
					MessageBox.Show("User successfully deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					user.LoadUsers(gridUsers);
				}
				else
				{
					MessageBox.Show("Failed to delete user!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				user.LoadUsers(gridUsers);
			}
		}
	}
}
