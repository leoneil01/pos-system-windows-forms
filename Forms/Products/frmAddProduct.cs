using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odrunia_POS_System.Forms.Products
{
	public partial class frmAddProduct : Form
	{
		public frmAddProduct()
		{
			InitializeComponent();
		}

		Functions.Check check = new Functions.Check();

		Functions.Product product = new Functions.Product();

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if(check.IsProductCodeExists(txtProductCode.Text))
			{
				MessageBox.Show("Product code is already taken!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtProductCode.SelectAll();
				txtProductCode.Focus();
			}
			else if(check.IsProductNameExists(txtProductName.Text))
			{
				MessageBox.Show("Product name is already taken!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtProductName.SelectAll();
				txtProductName.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtProductCode.Text))
			{
				MessageBox.Show("Product code is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtProductCode.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtProductName.Text))
			{
				MessageBox.Show("Product name is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtProductName.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtProductPrice.Text))
			{
				MessageBox.Show("Product price is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtProductPrice.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtProductQuantity.Text))
			{
				MessageBox.Show("Product quantity is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtProductQuantity.Focus();
			}
			else
			{
				if(product.AddProduct(txtProductCode.Text, CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtProductName.Text), double.Parse(txtProductPrice.Text), int.Parse(txtProductQuantity.Text)))
				{
					MessageBox.Show("Product successfully added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

					txtProductCode.ResetText();
					txtProductName.ResetText();
					txtProductPrice.ResetText();
					txtProductQuantity.ResetText();

					txtProductCode.Focus();
				}
				else
				{
					MessageBox.Show("Failed to add product!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
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
