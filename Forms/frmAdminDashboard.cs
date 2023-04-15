﻿using System;
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
	public partial class frmAdminDashboard : Form
	{
		public frmAdminDashboard()
		{
			InitializeComponent();
		}

		private void btnUsers_Click(object sender, EventArgs e)
		{
			pnlDashboard.Controls.Clear();
			Forms.Users.frmUserList frmUserList = new Forms.Users.frmUserList();
			frmUserList.TopLevel = false;
			pnlDashboard.Controls.Add(frmUserList);
			frmUserList.Dock = DockStyle.Fill;
			frmUserList.Show();
		}

		private void btnProducts_Click(object sender, EventArgs e)
		{
			pnlDashboard.Controls.Clear();
			Forms.Products.frmProductList frmProductList = new Products.frmProductList();
			frmProductList.TopLevel = false;
			pnlDashboard.Controls.Add(frmProductList);
			frmProductList.Dock = DockStyle.Fill;
			frmProductList.Show();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
