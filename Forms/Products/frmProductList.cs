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

		private void btnViewProduct_Click(object sender, EventArgs e)
		{
			if(gridProducts.SelectedRows.Count < 1)
			{
				MessageBox.Show("Select user first!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(product.GetProduct(int.Parse(gridProducts.SelectedCells[0].Value.ToString())))
			{
				Forms.Products.frmViewProduct frmViewProduct = new Forms.Products.frmViewProduct();
				frmViewProduct.Show();
				Application.OpenForms["frmAdminDashboard"].Close();
			}
		}

		private void btnUpdateProduct_Click(object sender, EventArgs e)
		{
			if(gridProducts.SelectedRows.Count < 1)
			{
				MessageBox.Show("Select user first!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(product.GetProduct(int.Parse(gridProducts.SelectedCells[0].Value.ToString())))
			{
				Forms.Products.frmUpdateProduct frmUpdateProduct = new frmUpdateProduct();
				frmUpdateProduct.Show();
				Application.OpenForms["frmAdminDashboard"].Close();
			}
		}

		private void btnDeleteProduct_Click(object sender, EventArgs e)
		{
			if(gridProducts.SelectedRows.Count < 1)
			{
				MessageBox.Show("Select user first!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(MessageBox.Show("Are you sure you want to delete this product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if(product.DeleteProduct(int.Parse(gridProducts.SelectedCells[0].Value.ToString())))
				{
					MessageBox.Show("Product successfully deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Failed to delete product!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				product.LoadProducts(gridProducts);
			}
		}
	}
}
