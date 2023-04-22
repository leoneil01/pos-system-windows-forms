namespace Odrunia_POS_System.Forms.Customers
{
	partial class frmViewCustomerOrder
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
			this.pbProductPicture = new System.Windows.Forms.PictureBox();
			this.txtProductQuantity = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtProductCode = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbProductPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// pbProductPicture
			// 
			this.pbProductPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
			this.pbProductPicture.ErrorImage = null;
			this.pbProductPicture.Location = new System.Drawing.Point(396, 41);
			this.pbProductPicture.Name = "pbProductPicture";
			this.pbProductPicture.Size = new System.Drawing.Size(150, 150);
			this.pbProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbProductPicture.TabIndex = 77;
			this.pbProductPicture.TabStop = false;
			// 
			// txtProductQuantity
			// 
			this.txtProductQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductQuantity.Location = new System.Drawing.Point(44, 258);
			this.txtProductQuantity.Name = "txtProductQuantity";
			this.txtProductQuantity.ReadOnly = true;
			this.txtProductQuantity.Size = new System.Drawing.Size(307, 27);
			this.txtProductQuantity.TabIndex = 72;
			this.txtProductQuantity.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(40, 236);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 19);
			this.label4.TabIndex = 76;
			this.label4.Text = "Product Quantity";
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductPrice.Location = new System.Drawing.Point(44, 194);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.ReadOnly = true;
			this.txtProductPrice.Size = new System.Drawing.Size(307, 27);
			this.txtProductPrice.TabIndex = 71;
			this.txtProductPrice.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(40, 172);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 19);
			this.label3.TabIndex = 75;
			this.label3.Text = "Product Price";
			// 
			// txtProductName
			// 
			this.txtProductName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductName.Location = new System.Drawing.Point(44, 129);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.ReadOnly = true;
			this.txtProductName.Size = new System.Drawing.Size(307, 27);
			this.txtProductName.TabIndex = 70;
			this.txtProductName.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 19);
			this.label2.TabIndex = 74;
			this.label2.Text = "Product Name";
			// 
			// txtProductCode
			// 
			this.txtProductCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductCode.Location = new System.Drawing.Point(44, 69);
			this.txtProductCode.Name = "txtProductCode";
			this.txtProductCode.ReadOnly = true;
			this.txtProductCode.Size = new System.Drawing.Size(307, 27);
			this.txtProductCode.TabIndex = 69;
			this.txtProductCode.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(40, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 19);
			this.label5.TabIndex = 73;
			this.label5.Text = "Product Code";
			// 
			// btnBack
			// 
			this.btnBack.AutoSize = true;
			this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(501, 363);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(84, 29);
			this.btnBack.TabIndex = 68;
			this.btnBack.TabStop = false;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			// 
			// frmViewCustomerOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
			this.ClientSize = new System.Drawing.Size(597, 404);
			this.Controls.Add(this.pbProductPicture);
			this.Controls.Add(this.txtProductQuantity);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtProductPrice);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtProductCode);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmViewCustomerOrder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "View Customer\'s Product";
			((System.ComponentModel.ISupportInitialize)(this.pbProductPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbProductPicture;
		private System.Windows.Forms.TextBox txtProductQuantity;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtProductCode;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnBack;
	}
}