using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Odrunia_POS_System.Functions
{
	internal class UserRole
	{
		Components.Connection con = new Components.Connection();

		public void LoadUserRolesInCmb(ComboBox cmb)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"SELECT user_role
									FROM tbl_user_role;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						connection.Open();

						MySqlDataReader dr = cmd.ExecuteReader();

						while (dr.Read())
						{
							string userRole = dr.GetString("user_role");
							cmb.Items.Add(userRole);
						}
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error loading user role in combo box user role: " + ex.ToString());
			}
		}
	}
}
