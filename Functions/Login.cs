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
	internal class Login
	{
		Components.Connection con = new Components.Connection();
		Components.Value val = new Components.Value();

		public bool AuthenticateUser(string username, string password, string userRole)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"SELECT u.id, u.profile_picture, ur.user_role, u.first_name, u.middle_name, u.last_name, g.gender, u.age, u.birthday, u.contact_number, u.email, u.username
									FROM tbl_users AS u
									INNER JOIN tbl_user_role AS ur ON u.user_role_FID = ur.id
									INNER JOIN tbl_genders AS g ON u.gender_FID = g.id
									WHERE u.username = @username
										AND u.password = MD5(@password)
										AND ur.user_role = @userRole;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@username", username);
						cmd.Parameters.AddWithValue("@password", password);
						cmd.Parameters.AddWithValue("@userRole", userRole);

						connection.Open();

						MySqlDataAdapter da = new MySqlDataAdapter(cmd);
						DataTable dt = new DataTable();

						dt.Clear();
						da.Fill(dt);

						if(dt.Rows.Count > 0)
						{
							val.MyId = dt.Rows[0].Field<int>("id");
							val.MyProfilePicture = dt.Rows[0].Field<byte[]>("profile_picture");
							val.MyUserRole = dt.Rows[0].Field<string>("user_role");
							val.MyFirstName = dt.Rows[0].Field<string>("first_name");
							val.MyMiddleName = dt.Rows[0].Field<string>("middle_name");
							val.MyLastName = dt.Rows[0].Field<string>("last_name");
							val.MyGender = dt.Rows[0].Field<string>("gender");
							val.MyAge = dt.Rows[0].Field<int>("age");
							val.MyBirthday = dt.Rows[0].Field<DateTime>("birthday");
							val.MyContactNumber = dt.Rows[0].Field<string>("contact_number");
							val.MyEmail = dt.Rows[0].Field<string>("email");
							val.MyUsername = dt.Rows[0].Field<string>("username");

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
				MessageBox.Show("Error authenticating users: " +  ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
	}
}
