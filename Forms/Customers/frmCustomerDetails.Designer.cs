namespace Odrunia_POS_System.Forms.Customers
{
	partial class frmCustomerDetails
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
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMiddleName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtContactNumber = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnOrder = new System.Windows.Forms.Button();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtFirstName
			// 
			this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirstName.Location = new System.Drawing.Point(53, 85);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(260, 30);
			this.txtFirstName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(49, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "First Name";
			// 
			// txtMiddleName
			// 
			this.txtMiddleName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMiddleName.Location = new System.Drawing.Point(53, 154);
			this.txtMiddleName.Name = "txtMiddleName";
			this.txtMiddleName.Size = new System.Drawing.Size(260, 30);
			this.txtMiddleName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(49, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Middle Name";
			// 
			// txtLastName
			// 
			this.txtLastName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLastName.Location = new System.Drawing.Point(53, 222);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(260, 30);
			this.txtLastName.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(49, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Last Name";
			// 
			// txtContactNumber
			// 
			this.txtContactNumber.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContactNumber.Location = new System.Drawing.Point(53, 290);
			this.txtContactNumber.Name = "txtContactNumber";
			this.txtContactNumber.Size = new System.Drawing.Size(260, 30);
			this.txtContactNumber.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(49, 264);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(147, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Contact Number";
			// 
			// btnExit
			// 
			this.btnExit.AutoSize = true;
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(222, 409);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(84, 29);
			this.btnExit.TabIndex = 10;
			this.btnExit.TabStop = false;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// btnOrder
			// 
			this.btnOrder.AutoSize = true;
			this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOrder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrder.Location = new System.Drawing.Point(312, 409);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(84, 29);
			this.btnOrder.TabIndex = 5;
			this.btnOrder.Text = "Order";
			this.btnOrder.UseVisualStyleBackColor = true;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(53, 357);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(260, 30);
			this.txtEmail.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(49, 331);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Email";
			// 
			// frmCustomerDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(209)))), ((int)(((byte)(208)))));
			this.ClientSize = new System.Drawing.Size(408, 450);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnOrder);
			this.Controls.Add(this.txtContactNumber);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMiddleName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "frmCustomerDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customer Credential";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMiddleName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtContactNumber;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnOrder;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label5;
	}
}