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
	public partial class frmProductList : Form
	{
		public frmProductList()
		{
			InitializeComponent();
		}

		Functions.Product product = new Functions.Product();

		private void frmProductList_LoadProduct(object sender, EventArgs e)
		{
			product.LoadProducts(gridProducts);
		}

		private void frmProductList_VisibleChanged(object sender, EventArgs e)
		{
			gridProducts.ClearSelection();
		}

		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			Forms.Products.frmAddProduct frmAddProduct = new Forms.Products.frmAddProduct();
			frmAddProduct.Show();
			Application.OpenForms["frmAdminDashboard"].Close();
		}
	}
}
