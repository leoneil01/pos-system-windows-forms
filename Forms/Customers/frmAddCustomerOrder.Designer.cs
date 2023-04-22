namespace Odrunia_POS_System.Forms.Customers
{
	partial class frmAddCustomerOrder
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtQuantityOrder = new System.Windows.Forms.TextBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnOrder = new System.Windows.Forms.Button();
			this.txtProductQuantity = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtProductCode = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pbProductPicture = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbProductPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(40, 317);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(341, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please input the quantity that you want to add:";
			// 
			// txtQuantityOrder
			// 
			this.txtQuantityOrder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuantityOrder.Location = new System.Drawing.Point(387, 314);
			this.txtQuantityOrder.Name = "txtQuantityOrder";
			this.txtQuantityOrder.Size = new System.Drawing.Size(159, 27);
			this.txtQuantityOrder.TabIndex = 1;
			// 
			// btnBack
			// 
			this.btnBack.AutoSize = true;
			this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(411, 363);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(84, 29);
			this.btnBack.TabIndex = 12;
			this.btnBack.TabStop = false;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnOrder
			// 
			this.btnOrder.AutoSize = true;
			this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOrder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrder.Location = new System.Drawing.Point(501, 363);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(84, 29);
			this.btnOrder.TabIndex = 11;
			this.btnOrder.Text = "Order";
			this.btnOrder.UseVisualStyleBackColor = true;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// txtProductQuantity
			// 
			this.txtProductQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductQuantity.Location = new System.Drawing.Point(44, 258);
			this.txtProductQuantity.Name = "txtProductQuantity";
			this.txtProductQuantity.ReadOnly = true;
			this.txtProductQuantity.Size = new System.Drawing.Size(307, 27);
			this.txtProductQuantity.TabIndex = 59;
			this.txtProductQuantity.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(40, 236);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 19);
			this.label4.TabIndex = 63;
			this.label4.Text = "Product Quantity";
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductPrice.Location = new System.Drawing.Point(44, 194);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.ReadOnly = true;
			this.txtProductPrice.Size = new System.Drawing.Size(307, 27);
			this.txtProductPrice.TabIndex = 58;
			this.txtProductPrice.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(40, 172);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 19);
			this.label3.TabIndex = 62;
			this.label3.Text = "Product Price";
			// 
			// txtProductName
			// 
			this.txtProductName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductName.Location = new System.Drawing.Point(44, 129);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.ReadOnly = true;
			this.txtProductName.Size = new System.Drawing.Size(307, 27);
			this.txtProductName.TabIndex = 57;
			this.txtProductName.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 19);
			this.label2.TabIndex = 61;
			this.label2.Text = "Product Name";
			// 
			// txtProductCode
			// 
			this.txtProductCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductCode.Location = new System.Drawing.Point(44, 69);
			this.txtProductCode.Name = "txtProductCode";
			this.txtProductCode.ReadOnly = true;
			this.txtProductCode.Size = new System.Drawing.Size(307, 27);
			this.txtProductCode.TabIndex = 56;
			this.txtProductCode.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(40, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 19);
			this.label5.TabIndex = 60;
			this.label5.Text = "Product Code";
			// 
			// pbProductPicture
			// 
			this.pbProductPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
			this.pbProductPicture.ErrorImage = null;
			this.pbProductPicture.Location = new System.Drawing.Point(396, 41);
			this.pbProductPicture.Name = "pbProductPicture";
			this.pbProductPicture.Size = new System.Drawing.Size(150, 150);
			this.pbProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbProductPicture.TabIndex = 64;
			this.pbProductPicture.TabStop = false;
			// 
			// frmAddCustomerOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
			this.Controls.Add(this.btnOrder);
			this.Controls.Add(this.txtQuantityOrder);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmAddCustomerOrder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Customer\'s Order";
			this.Load += new System.EventHandler(this.frmAddCustomerOrder_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbProductPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtQuantityOrder;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnOrder;
		private System.Windows.Forms.TextBox txtProductQuantity;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtProductCode;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pbProductPicture;
	}
}