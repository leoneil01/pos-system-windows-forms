using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Odrunia_POS_System.Functions
{
	internal class Gender
	{
		Components.Connection con = new Components.Connection();

		public void LoadGendersInCmb(ComboBox cmb)
		{
			try
			{
				using(MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"SELECT gender
									FROM tbl_genders;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						connection.Open();

						MySqlDataReader dr = cmd.ExecuteReader();

						while(dr.Read())
						{
							string gender = dr.GetString("gender");
							cmb.Items.Add(gender);
						}
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error loading gender in combo box gender: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
