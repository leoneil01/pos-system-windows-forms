﻿namespace Odrunia_POS_System
{
	partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.cmbUserRole = new System.Windows.Forms.ComboBox();
			this.btnCustomer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(84, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(88, 92);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(260, 30);
			this.txtUsername.TabIndex = 0;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(88, 156);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(260, 30);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(84, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// btnLogin
			// 
			this.btnLogin.AutoSize = true;
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(224, 246);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(84, 29);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnExit
			// 
			this.btnExit.AutoSize = true;
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(134, 246);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(84, 29);
			this.btnExit.TabIndex = 5;
			this.btnExit.TabStop = false;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// cmbUserRole
			// 
			this.cmbUserRole.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbUserRole.FormattingEnabled = true;
			this.cmbUserRole.Location = new System.Drawing.Point(142, 204);
			this.cmbUserRole.Name = "cmbUserRole";
			this.cmbUserRole.Size = new System.Drawing.Size(155, 31);
			this.cmbUserRole.TabIndex = 2;
			// 
			// btnCustomer
			// 
			this.btnCustomer.AutoSize = true;
			this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCustomer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCustomer.Location = new System.Drawing.Point(134, 305);
			this.btnCustomer.Name = "btnCustomer";
			this.btnCustomer.Size = new System.Drawing.Size(174, 29);
			this.btnCustomer.TabIndex = 6;
			this.btnCustomer.Text = "Customer";
			this.btnCustomer.UseVisualStyleBackColor = true;
			this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(209)))), ((int)(((byte)(208)))));
			this.ClientSize = new System.Drawing.Size(461, 450);
			this.Controls.Add(this.btnCustomer);
			this.Controls.Add(this.cmbUserRole);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Odrunia\'s Mini Mart";
			this.Load += new System.EventHandler(this.frmLogin_LoadUserRole);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ComboBox cmbUserRole;
		private System.Windows.Forms.Button btnCustomer;
	}
}

