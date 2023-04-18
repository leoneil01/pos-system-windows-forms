using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Odrunia_POS_System.Functions
{
	internal class Product
	{
		Components.Connection con = new Components.Connection();
		Components.Value val = new Components.Value();

		public void LoadProducts(DataGridView grid)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"SELECT p.id, p.product_code, p.product_name, p.product_price, p.product_quantity,
									DATE_FORMAT(p.created_at, '%m/%d/%Y'),
									DATE_FORMAT(p.updated_at, '%m/%d/%Y')
									FROM tbl_products AS p
									ORDER BY p.created_at DESC, p.product_code;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						connection.Open();

						MySqlDataAdapter da = new MySqlDataAdapter(cmd);
						DataTable dt = new DataTable();

						dt.Clear();
						da.Fill(dt);

						grid.DataSource = dt;
						grid.ClearSelection();

						grid.Columns["id"].Visible = false;
						grid.Columns["product_code"].HeaderText = "Product Code";
						grid.Columns["product_name"].HeaderText = "Product Name";
						grid.Columns["product_price"].HeaderText = "Product Price";
						grid.Columns["product_quantity"].HeaderText = "Product Quantity";
						grid.Columns["DATE_FORMAT(p.created_at, '%m/%d/%Y')"].HeaderText = "Created At";
						grid.Columns["DATE_FORMAT(p.updated_at, '%m/%d/%Y')"].HeaderText = "Updated At";

						foreach(DataGridViewColumn column in grid.Columns)
						{
							column.SortMode = DataGridViewColumnSortMode.NotSortable;
						}

						connection.Close();
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error loading products: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public bool GetProduct(int id)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"SELECT p.id, p.product_code, p.product_name, p.product_price, p.product_quantity, p.created_at, p.updated_at
									FROM tbl_products AS p
									WHERE p.id = @id;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@id", id);

						connection.Open();

						MySqlDataAdapter da = new MySqlDataAdapter(cmd);
						DataTable dt = new DataTable();

						dt.Clear();
						da.Fill(dt);

						if(dt.Rows.Count > 0)
						{
							val.ProductId = dt.Rows[0].Field<int>("id");
							val.ProductCode = dt.Rows[0].Field<string>("product_code");
							val.ProductName = dt.Rows[0].Field<string>("product_name");
							val.ProductPrice = dt.Rows[0].Field<double>("product_price");
							val.ProductQuantity = dt.Rows[0].Field<int>("product_quantity");
							val.ProductCreated = dt.Rows[0].Field<DateTime>("created_at");
							val.ProductUpdated = dt.Rows[0].Field<DateTime>("updated_at");

							connection.Close();
							return true;
						}
						else
						{
							connection.Close();
							return false;
						}
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error getting products: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		public bool AddProduct(string productCode, string productName, double productPrice, int productQuantity)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"INSERT INTO tbl_products(product_code, product_name, product_price, product_quantity)
									VALUES(@productCode, @productName, @productPrice, @productQuantity);";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@productCode", productCode);
						cmd.Parameters.AddWithValue("@productName", productName);
						cmd.Parameters.AddWithValue("@productPrice", productPrice);
						cmd.Parameters.AddWithValue("@productQuantity", productQuantity);

						connection.Open();

						MySqlDataReader dr = cmd.ExecuteReader();
						dr.Close();

						connection.Close();

						return true;
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error adding product: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		public bool UpdateProduct(int id, string productCode, string productName, double productPrice, int productQuantity)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"UPDATE tbl_products
								SET product_code = @productCode, product_name = @productName, product_price = @productPrice, product_quantity = @productQuantity, updated_at = CURRENT_TIMESTAMP
								WHERE id = @id;";

					using(MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@id", id);
						cmd.Parameters.AddWithValue("@productCode", productCode);
						cmd.Parameters.AddWithValue("@productName", productName);
						cmd.Parameters.AddWithValue("@productPrice", productPrice);
						cmd.Parameters.AddWithValue("@productQuantity", productQuantity);

						connection.Open();

						MySqlDataReader dr = cmd.ExecuteReader();
						dr.Close();

						connection.Close();
						return true;
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error updating products: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
	}
}
