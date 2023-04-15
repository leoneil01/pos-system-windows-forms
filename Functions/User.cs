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
	internal class User
	{
		Components.Connection con = new Components.Connection();
		Components.Value val = new Components.Value();

		public void LoadUsers(DataGridView grid)
		{
			try
			{
				using(MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"SELECT u.id, u.profile_picture, ur.user_role, u.first_name, u.middle_name, u.last_name, g.gender, u.age,
								DATE_FORMAT(u.birthday, '%m/%d/%Y'),
									u.contact_number, u.email,
								DATE_FORMAT(u.created_at, '%m/%d/%Y'),
								DATE_FORMAT(u.updated_at, '%m/%d/%Y')
									FROM tbl_users AS u
									INNER JOIN tbl_user_role AS ur ON u.user_role_FID = ur.id
									INNER JOIN tbl_genders AS g ON u.gender_FID = g.id
									ORDER BY u.created_at DESC, u.last_name, u.first_name;";

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
						grid.Columns["profile_picture"].HeaderText = "Profile Picture";
						grid.Columns["user_role"].HeaderText = "User Role";
						grid.Columns["first_name"].HeaderText = "First Name";
						grid.Columns["middle_name"].HeaderText = "Middle Name";
						grid.Columns["last_name"].HeaderText = "Last Name";
						grid.Columns["gender"].HeaderText = "Gender";
						grid.Columns["age"].HeaderText = "Age";
						grid.Columns["DATE_FORMAT(u.birthday, '%m/%d/%Y')"].HeaderText = "Birthday";
						grid.Columns["contact_number"].HeaderText = "Contact Number";
						grid.Columns["email"].HeaderText = "Email";
						grid.Columns["DATE_FORMAT(u.created_at, '%m/%d/%Y')"].HeaderText = "CreatedAt";
						grid.Columns["DATE_FORMAT(u.updated_at, '%m/%d/%Y')"].HeaderText = "UpdatedAt";

						DataGridViewImageColumn clmProfilePicture = new DataGridViewImageColumn();
						clmProfilePicture = (DataGridViewImageColumn)grid.Columns["profile_picture"];
						clmProfilePicture.ImageLayout = DataGridViewImageCellLayout.Stretch;

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
				MessageBox.Show("Error loading users: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public bool GetUser(int id)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"SELECT u.id, u.profile_picture, ur.user_role, u.first_name, u.middle_name, u.last_name, g.gender, u.age, u.birthday, u.contact_number, u.email, u.username
									FROM tbl_users AS u
									INNER JOIN tbl_user_role AS ur ON u.user_role_FID = ur.id
									INNER JOIN tbl_genders AS g ON u.gender_FID = g.id
									WHERE u.id = @id;";

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
							val.UserId = dt.Rows[0].Field<int>("id");
							val.UserProfilePicture = dt.Rows[0].Field<byte[]>("profile_picture");
							val.UserUserRole = dt.Rows[0].Field<string>("user_role");
							val.UserFirstName = dt.Rows[0].Field<string>("first_name");
							val.UserMiddleName = dt.Rows[0].Field<string>("middle_name");
							val.UserLastName = dt.Rows[0].Field<string>("last_name");
							val.UserGender = dt.Rows[0].Field<string>("gender");
							val.UserAge = dt.Rows[0].Field<int>("age");
							val.UserBirthday = dt.Rows[0].Field<DateTime>("birthday");
							val.UserContactNumber = dt.Rows[0].Field<string>("contact_number");
							val.UserEmail = dt.Rows[0].Field<string>("email");
							val.UserUsername = dt.Rows[0].Field<string>("username");

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
				MessageBox.Show("Error getting users: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		public bool AddUser(byte[] profilePicture, string userRole, string firstName, string middleName, string lastName, string gender, int age, DateTime birthday, string contactNumber, string email, string username, string password)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"SELECT id
									FROM tbl_genders
									WHERE gender = @gender;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@gender", gender);

						connection.Open();

						MySqlDataAdapter da = new MySqlDataAdapter(cmd);
						DataTable dt = new DataTable();

						dt.Clear();
						da.Fill(dt);

						val.GenderId = dt.Rows[0].Field<int>("id");
					}

					sql = @"SELECT id
							FROM tbl_user_role
							WHERE user_role = @userRole;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@userRole", userRole);

						MySqlDataAdapter da = new MySqlDataAdapter(cmd);
						DataTable dt = new DataTable();

						dt.Clear();
						da.Fill(dt);

						val.UserRoleId = dt.Rows[0].Field<int>("id");
					}

					sql = @"INSERT INTO tbl_users(profile_picture, user_role_FID, first_name, middle_name, last_name, gender_FID, age, birthday, contact_number, email, username, password)
							VALUES(@profilePicture, @userRoleFID, @firstName, @middleName, @lastName, @genderFID, @age, @birthday, @contactNumber, @email, @username, MD5(@password));";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@profilePicture", profilePicture);
						cmd.Parameters.AddWithValue("@userRoleFID", val.UserRoleId);
						cmd.Parameters.AddWithValue("@firstName", firstName);
						cmd.Parameters.AddWithValue("@middleName", middleName);
						cmd.Parameters.AddWithValue("@lastName", lastName);
						cmd.Parameters.AddWithValue("@genderFID", val.GenderId);
						cmd.Parameters.AddWithValue("@age", age);
						cmd.Parameters.AddWithValue("@birthday", birthday);
						cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
						cmd.Parameters.AddWithValue("@email", email);
						cmd.Parameters.AddWithValue("@username", username);
						cmd.Parameters.AddWithValue("@password", password);

						MySqlDataReader dr = cmd.ExecuteReader();
						dr.Close();

						connection.Close();

						return true;
					}
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine("Error adding user: " + ex.ToString());
				return false;
			}
		}

		public bool UpdateUser(int id, byte[] profilePicture, string userRole, string firstName, string middleName, string lastName, string gender, int age, DateTime birthday, string contactNumber, string email, string username)
		{
			try
			{
				using (MySqlConnection connection =  new MySqlConnection(con.conString()))
				{
					string sql = @"SELECT id
									FROM tbl_genders
									WHERE gender = @gender;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@gender", gender);

						connection.Open();

						MySqlDataAdapter da = new MySqlDataAdapter(cmd);
						DataTable dt = new DataTable();

						dt.Clear();
						da.Fill(dt);

						val.GenderId = dt.Rows[0].Field<int>("id");
					}

					sql = @"SELECT id
							FROM tbl_user_role
							WHERE user_role = @userRole;";

					using(MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@userRole", userRole);

						MySqlDataAdapter da = new MySqlDataAdapter(cmd);
						DataTable dt = new DataTable();

						dt.Clear();
						da.Fill(dt);

						val.UserRoleId = dt.Rows[0].Field<int>("id");
					}

					sql = @"UPDATE tbl_users
								SET profile_picture = @profilePicture, user_role_FID = @userRoleFID, first_name = @firstName, middle_name = @middleName, last_name = @lastName, gender_FID = @genderFID, age = @age, birthday = @birthday, contact_number = @contactNumber, email = @email, username = @username, updated_at = CURRENT_TIMESTAMP
								WHERE id = @id;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@id", id);
						cmd.Parameters.AddWithValue("@profilePicture", profilePicture);
						cmd.Parameters.AddWithValue("@userRoleFID", val.UserRoleId);
						cmd.Parameters.AddWithValue("@firstName", firstName);
						cmd.Parameters.AddWithValue("@middleName", middleName);
						cmd.Parameters.AddWithValue("@lastName", lastName);
						cmd.Parameters.AddWithValue("@genderFID", val.GenderId);
						cmd.Parameters.AddWithValue("@age", age);
						cmd.Parameters.AddWithValue("@birthday", birthday);
						cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
						cmd.Parameters.AddWithValue("@email", email);
						cmd.Parameters.AddWithValue("@username", username);

						MySqlDataReader dr = cmd.ExecuteReader();
						dr.Close();

						connection.Close();

						return true;
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error updating users: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
	}
}
