using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odrunia_POS_System.Forms.Products
{
	public partial class frmViewProduct : Form
	{
		public frmViewProduct()
		{
			InitializeComponent();
		}

		Components.Value val = new Components.Value();

		private void frmViewProduct_Load(object sender, EventArgs e)
		{
			txtProductCode.Text = val.ProductCode;
			txtProductName.Text = val.ProductName;
			txtProductPrice.Text = val.ProductPrice.ToString();
			txtProductQuantity.Text = val.ProductQuantity.ToString();
			txtProductCreated.Text = val.ProductCreated.ToString("MM/dd/yyyy HH:mm");
			txtProductUpdated.Text = val.ProductUpdated.ToString("MM/dd/yyyy HH:mm");
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Forms.Products.frmProductList frmProductList = new Forms.Products.frmProductList();
			frmProductList.TopLevel = false;

			Forms.frmAdminDashboard frmAdminDashboard1 = new Forms.frmAdminDashboard();
			frmAdminDashboard1.Show();

			Forms.frmAdminDashboard frmAdminDashboard2 = (Forms.frmAdminDashboard)Application.OpenForms["frmAdminDashboard"];
			Panel pnlDashboard = (Panel)frmAdminDashboard2.Controls["pnlDashboard"];

			pnlDashboard.Controls.Add(frmProductList);
			frmProductList.Dock = DockStyle.Fill;
			frmProductList.Show();
			this.Close();
		}
	}
}
