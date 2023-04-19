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
	public partial class frmProductAvailable : Form
	{
		public frmProductAvailable()
		{
			InitializeComponent();
		}

		Functions.Product product = new Functions.Product();

		private void frmProductAvailable_Load(object sender, EventArgs e)
		{
			product.LoadProducts(gridProducts);
		}

		private void frmProductAvailable_VisibleChanged(object sender, EventArgs e)
		{
			gridProducts.ClearSelection();
		}

		private void btnAddOrder_Click(object sender, EventArgs e)
		{
			if(gridProducts.SelectedRows.Count < 1)
			{
				MessageBox.Show("Select product first!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(product.GetProduct(int.Parse(gridProducts.SelectedCells[0].Value.ToString())))
			{
				Forms.Customers.frmAddCustomerOrder frmAddCustomerOrder = new Forms.Customers.frmAddCustomerOrder();
				frmAddCustomerOrder.Show();
				Application.OpenForms["frmCustomerDashboard"].Close();
			}
		}

		private void btnViewOrder_Click(object sender, EventArgs e)
		{

		}
	}
}
