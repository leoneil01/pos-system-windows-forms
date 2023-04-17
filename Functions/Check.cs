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
	internal class Check
	{
		Components.Connection con = new Components.Connection();

		public bool IsUsernameExists(string username, string userRole)
		{
			try
			{
				using(MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"SELECT u.username, ur.user_role
									FROM tbl_users AS u
									INNER JOIN tbl_user_role AS ur ON u.user_role_FID = ur.id
									WHERE u.username = @username AND ur.user_role = @userRole;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@username", username);
						cmd.Parameters.AddWithValue(@"userRole", userRole);

						connection.Open();

						MySqlDataAdapter da = new MySqlDataAdapter(cmd);
						DataTable dt = new DataTable();

						dt.Clear();
						da.Fill(dt);

						if(dt.Rows.Count > 0)
						{
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
				MessageBox.Show("Error checking username: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		public bool IsProductCodeExists(string productCode)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"SELECT p.product_code
									FROM tbl_products AS p
									WHERE p.product_code = @productCode;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@productCode", productCode);

						connection.Open();

						MySqlDataAdapter da = new MySqlDataAdapter(cmd);
						DataTable dt = new DataTable();

						dt.Clear();
						da.Fill(dt);

						if(dt.Rows.Count > 0)
						{
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
			catch( Exception ex )
			{
				MessageBox.Show("Error checking product code: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		public bool IsProductNameExists(string productName)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"SELECT p.product_name
									FROM tbl_products AS p
									WHERE p.product_name = @productName;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@productName", productName);

						connection.Open();

						MySqlDataAdapter da = new MySqlDataAdapter(cmd);
						DataTable dt = new DataTable();

						dt.Clear();
						da.Fill(dt);

						if(dt.Rows.Count > 0)
						{
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
			catch( Exception ex )
			{
				MessageBox.Show("Error checking product name: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
	}
}
