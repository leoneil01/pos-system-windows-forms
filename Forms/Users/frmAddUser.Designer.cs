namespace Odrunia_POS_System.Forms.Users
{
	partial class frmAddUser
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.pbUserPicture = new System.Windows.Forms.PictureBox();
			this.txtMiddleName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtContactNumber = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.dateBirthday = new System.Windows.Forms.DateTimePicker();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnUpload = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.cmbUserRole = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// txtFirstName
			// 
			this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirstName.Location = new System.Drawing.Point(33, 300);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(260, 27);
			this.txtFirstName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(29, 278);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "First Name";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(486, 52);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(377, 48);
			this.label6.TabIndex = 10;
			this.label6.Text = "- Read the instructions on the form carefully before filling it out.\r\n- Fill in a" +
    "ll the fields that apply to you. Do not leave any blanks or\r\n   write “N/A” unle" +
    "ss instructed to do so.";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(486, 100);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 16);
			this.label7.TabIndex = 11;
			this.label7.Text = "*Required";
			// 
			// pbUserPicture
			// 
			this.pbUserPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
			this.pbUserPicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbUserPicture.ErrorImage")));
			this.pbUserPicture.Location = new System.Drawing.Point(33, 28);
			this.pbUserPicture.Name = "pbUserPicture";
			this.pbUserPicture.Size = new System.Drawing.Size(150, 150);
			this.pbUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbUserPicture.TabIndex = 12;
			this.pbUserPicture.TabStop = false;
			// 
			// txtMiddleName
			// 
			this.txtMiddleName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMiddleName.Location = new System.Drawing.Point(33, 363);
			this.txtMiddleName.Name = "txtMiddleName";
			this.txtMiddleName.Size = new System.Drawing.Size(260, 27);
			this.txtMiddleName.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(29, 341);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 19);
			this.label2.TabIndex = 14;
			this.label2.Text = "Middle Name";
			// 
			// txtLastName
			// 
			this.txtLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLastName.Location = new System.Drawing.Point(33, 423);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(260, 27);
			this.txtLastName.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(29, 401);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 19);
			this.label3.TabIndex = 16;
			this.label3.Text = "Last Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(313, 217);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 19);
			this.label4.TabIndex = 18;
			this.label4.Text = "Gender";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(313, 278);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 19);
			this.label5.TabIndex = 20;
			this.label5.Text = "Birthday";
			// 
			// txtContactNumber
			// 
			this.txtContactNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContactNumber.Location = new System.Drawing.Point(317, 363);
			this.txtContactNumber.Name = "txtContactNumber";
			this.txtContactNumber.Size = new System.Drawing.Size(260, 27);
			this.txtContactNumber.TabIndex = 6;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(313, 341);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(124, 19);
			this.label8.TabIndex = 22;
			this.label8.Text = "Contact Number";
			// 
			// cmbGender
			// 
			this.cmbGender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Location = new System.Drawing.Point(317, 239);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(260, 27);
			this.cmbGender.TabIndex = 4;
			// 
			// dateBirthday
			// 
			this.dateBirthday.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateBirthday.Location = new System.Drawing.Point(317, 300);
			this.dateBirthday.Name = "dateBirthday";
			this.dateBirthday.Size = new System.Drawing.Size(260, 27);
			this.dateBirthday.TabIndex = 5;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(317, 423);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(260, 27);
			this.txtEmail.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(313, 401);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 19);
			this.label9.TabIndex = 26;
			this.label9.Text = "Email";
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(603, 239);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(260, 27);
			this.txtUsername.TabIndex = 8;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(599, 217);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 19);
			this.label10.TabIndex = 28;
			this.label10.Text = "Username";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(603, 300);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(260, 27);
			this.txtPassword.TabIndex = 9;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(599, 278);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(76, 19);
			this.label11.TabIndex = 30;
			this.label11.Text = "Password";
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConfirmPassword.Location = new System.Drawing.Point(603, 363);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.Size = new System.Drawing.Size(260, 27);
			this.txtConfirmPassword.TabIndex = 10;
			this.txtConfirmPassword.UseSystemPasswordChar = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(599, 341);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(138, 19);
			this.label12.TabIndex = 32;
			this.label12.Text = "Confirm Password";
			// 
			// btnAdd
			// 
			this.btnAdd.AutoSize = true;
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(739, 405);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(97, 28);
			this.btnAdd.TabIndex = 11;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnBack
			// 
			this.btnBack.AutoSize = true;
			this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBack.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(633, 405);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(97, 28);
			this.btnBack.TabIndex = 34;
			this.btnBack.TabStop = false;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnUpload
			// 
			this.btnUpload.AutoSize = true;
			this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpload.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpload.Location = new System.Drawing.Point(197, 72);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(97, 28);
			this.btnUpload.TabIndex = 35;
			this.btnUpload.TabStop = false;
			this.btnUpload.Text = "Upload";
			this.btnUpload.UseVisualStyleBackColor = true;
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemove.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemove.Location = new System.Drawing.Point(197, 107);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(97, 28);
			this.btnRemove.TabIndex = 36;
			this.btnRemove.TabStop = false;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(29, 217);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(77, 19);
			this.label13.TabIndex = 37;
			this.label13.Text = "User Role";
			// 
			// cmbUserRole
			// 
			this.cmbUserRole.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbUserRole.FormattingEnabled = true;
			this.cmbUserRole.Location = new System.Drawing.Point(33, 239);
			this.cmbUserRole.Name = "cmbUserRole";
			this.cmbUserRole.Size = new System.Drawing.Size(260, 27);
			this.cmbUserRole.TabIndex = 0;
			// 
			// frmAddUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
			this.ClientSize = new System.Drawing.Size(917, 480);
			this.Controls.Add(this.cmbUserRole);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtConfirmPassword);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dateBirthday);
			this.Controls.Add(this.cmbGender);
			this.Controls.Add(this.txtContactNumber);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMiddleName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pbUserPicture);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmAddUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add User";
			this.Load += new System.EventHandler(this.frmAddUser_LoadComboBox);
			((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pbUserPicture;
		private System.Windows.Forms.TextBox txtMiddleName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtContactNumber;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbGender;
		private System.Windows.Forms.DateTimePicker dateBirthday;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cmbUserRole;
	}
}