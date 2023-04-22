using Odrunia_POS_System.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odrunia_POS_System.Forms.Customers
{
	public partial class frmAddCustomerOrder : Form
	{
		private List<Cart> cartItems;
		public frmAddCustomerOrder()
		{
			InitializeComponent();
			cartItems = new List<Cart>();
		}

		Components.Value val = new Components.Value();

		private void frmAddCustomerOrder_Load(object sender, EventArgs e)
		{
			txtProductCode.Text = val.ProductCode;
			txtProductName.Text = val.ProductName;
			txtProductPrice.Text = val.ProductPrice.ToString();
			txtProductQuantity.Text = val.ProductQuantity.ToString();
		}

		private void btnOrder_Click(object sender, EventArgs e)
		{
			if(String.IsNullOrWhiteSpace(txtQuantityOrder.Text))
			{
				MessageBox.Show("Quantity Field is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtQuantityOrder.Focus();
			}
			else if(int.Parse(txtProductQuantity.Text) < int.Parse(txtQuantityOrder.Text))
			{
				MessageBox.Show("Product quantity must not exceed to the current product quantity!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtQuantityOrder.SelectAll();
				txtQuantityOrder.Focus();
			}
			else
			{
				Cart cartItem = new Cart()
				{
					ProductCode = txtProductCode.Text,
					ProductName = txtProductName.Text,
					ProductPrice = double.Parse(txtProductPrice.Text),
					ProductQuantity = int.Parse(txtProductQuantity.Text),
					DateCreated = DateTime.Now
				};

				cartItems.Add(cartItem);

				val.ProductQuantity -= int.Parse(txtProductQuantity.Text);

				Forms.Customers.frmProductAvailable frmProductAvailable = new Forms.Customers.frmProductAvailable();
				frmProductAvailable.TopLevel = false;

				Forms.frmCustomerDashboard frmCustomerDashboard1 = new Forms.frmCustomerDashboard();
				frmCustomerDashboard1.Show();

				Forms.frmCustomerDashboard frmCustomerDashboard2 = (Forms.frmCustomerDashboard)Application.OpenForms["frmCustomerDashboard"];
				Panel pnlDashboard = (Panel)frmCustomerDashboard2.Controls["pnlDashboard"];

				pnlDashboard.Controls.Add(frmProductAvailable);
				frmProductAvailable.Dock = DockStyle.Fill;
				frmProductAvailable.Show();
				this.Close();
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Forms.Customers.frmProductAvailable frmProductAvailable = new Forms.Customers.frmProductAvailable();
			frmProductAvailable.TopLevel = false;

			Forms.frmCustomerDashboard frmCustomerDashboard1 = new Forms.frmCustomerDashboard();
			frmCustomerDashboard1.Show();

			Forms.frmCustomerDashboard frmCustomerDashboard2 = (Forms.frmCustomerDashboard)Application.OpenForms["frmCustomerDashboard"];
			Panel pnlDashboard = (Panel)frmCustomerDashboard2.Controls["pnlDashboard"];

			pnlDashboard.Controls.Add(frmProductAvailable);
			frmProductAvailable.Dock = DockStyle.Fill;
			frmProductAvailable.Show();
			this.Close();
		}
	}
}
