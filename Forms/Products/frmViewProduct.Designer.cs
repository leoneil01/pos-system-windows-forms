namespace Odrunia_POS_System.Forms.Products
{
	partial class frmViewProduct
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewProduct));
			this.txtProductQuantity = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtProductCode = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.txtProductCreated = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtProductUpdated = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pbProductImg = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbProductImg)).BeginInit();
			this.SuspendLayout();
			// 
			// txtProductQuantity
			// 
			this.txtProductQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductQuantity.Location = new System.Drawing.Point(44, 258);
			this.txtProductQuantity.Name = "txtProductQuantity";
			this.txtProductQuantity.ReadOnly = true;
			this.txtProductQuantity.Size = new System.Drawing.Size(260, 27);
			this.txtProductQuantity.TabIndex = 49;
			this.txtProductQuantity.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(40, 236);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 19);
			this.label4.TabIndex = 55;
			this.label4.Text = "Product Quantity";
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductPrice.Location = new System.Drawing.Point(44, 194);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.ReadOnly = true;
			this.txtProductPrice.Size = new System.Drawing.Size(260, 27);
			this.txtProductPrice.TabIndex = 48;
			this.txtProductPrice.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(40, 172);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 19);
			this.label3.TabIndex = 54;
			this.label3.Text = "Product Price";
			// 
			// txtProductName
			// 
			this.txtProductName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductName.Location = new System.Drawing.Point(44, 129);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.ReadOnly = true;
			this.txtProductName.Size = new System.Drawing.Size(260, 27);
			this.txtProductName.TabIndex = 47;
			this.txtProductName.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 19);
			this.label2.TabIndex = 53;
			this.label2.Text = "Product Name";
			// 
			// txtProductCode
			// 
			this.txtProductCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductCode.Location = new System.Drawing.Point(44, 69);
			this.txtProductCode.Name = "txtProductCode";
			this.txtProductCode.ReadOnly = true;
			this.txtProductCode.Size = new System.Drawing.Size(260, 27);
			this.txtProductCode.TabIndex = 46;
			this.txtProductCode.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(40, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 19);
			this.label1.TabIndex = 52;
			this.label1.Text = "Product Code";
			// 
			// btnBack
			// 
			this.btnBack.AutoSize = true;
			this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBack.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(519, 336);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(97, 28);
			this.btnBack.TabIndex = 51;
			this.btnBack.TabStop = false;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// txtProductCreated
			// 
			this.txtProductCreated.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductCreated.Location = new System.Drawing.Point(323, 194);
			this.txtProductCreated.Name = "txtProductCreated";
			this.txtProductCreated.ReadOnly = true;
			this.txtProductCreated.Size = new System.Drawing.Size(260, 27);
			this.txtProductCreated.TabIndex = 56;
			this.txtProductCreated.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(319, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(122, 19);
			this.label5.TabIndex = 57;
			this.label5.Text = "Product Created";
			// 
			// txtProductUpdated
			// 
			this.txtProductUpdated.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductUpdated.Location = new System.Drawing.Point(323, 258);
			this.txtProductUpdated.Name = "txtProductUpdated";
			this.txtProductUpdated.ReadOnly = true;
			this.txtProductUpdated.Size = new System.Drawing.Size(260, 27);
			this.txtProductUpdated.TabIndex = 58;
			this.txtProductUpdated.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(319, 236);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(127, 19);
			this.label6.TabIndex = 59;
			this.label6.Text = "Product Updated";
			// 
			// pbProductImg
			// 
			this.pbProductImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
			this.pbProductImg.ErrorImage = null;
			this.pbProductImg.Location = new System.Drawing.Point(355, 34);
			this.pbProductImg.Name = "pbProductImg";
			this.pbProductImg.Size = new System.Drawing.Size(162, 122);
			this.pbProductImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbProductImg.TabIndex = 79;
			this.pbProductImg.TabStop = false;
			// 
			// frmViewProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
			this.ClientSize = new System.Drawing.Size(628, 376);
			this.Controls.Add(this.pbProductImg);
			this.Controls.Add(this.txtProductUpdated);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtProductCreated);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtProductQuantity);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtProductPrice);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtProductCode);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmViewProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "View Product";
			this.Load += new System.EventHandler(this.frmViewProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbProductImg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtProductQuantity;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtProductCode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.TextBox txtProductCreated;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtProductUpdated;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pbProductImg;
	}
}