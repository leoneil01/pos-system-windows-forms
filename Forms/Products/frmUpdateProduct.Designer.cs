namespace Odrunia_POS_System.Forms.Products
{
	partial class frmUpdateProduct
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateProduct));
			this.btnBack = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtProductQuantity = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtProductCode = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnUpload = new System.Windows.Forms.Button();
			this.pbProductImg = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbProductImg)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.AutoSize = true;
			this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBack.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(371, 336);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(97, 28);
			this.btnBack.TabIndex = 38;
			this.btnBack.TabStop = false;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnSave
			// 
			this.btnSave.AutoSize = true;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(477, 336);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(97, 28);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtProductQuantity
			// 
			this.txtProductQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductQuantity.Location = new System.Drawing.Point(44, 258);
			this.txtProductQuantity.Name = "txtProductQuantity";
			this.txtProductQuantity.Size = new System.Drawing.Size(260, 27);
			this.txtProductQuantity.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(40, 236);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 19);
			this.label4.TabIndex = 45;
			this.label4.Text = "Product Quantity";
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductPrice.Location = new System.Drawing.Point(44, 194);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.Size = new System.Drawing.Size(260, 27);
			this.txtProductPrice.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(40, 172);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 19);
			this.label3.TabIndex = 43;
			this.label3.Text = "Product Price";
			// 
			// txtProductName
			// 
			this.txtProductName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductName.Location = new System.Drawing.Point(44, 129);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(260, 27);
			this.txtProductName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 19);
			this.label2.TabIndex = 41;
			this.label2.Text = "Product Name";
			// 
			// txtProductCode
			// 
			this.txtProductCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductCode.Location = new System.Drawing.Point(44, 69);
			this.txtProductCode.Name = "txtProductCode";
			this.txtProductCode.Size = new System.Drawing.Size(260, 27);
			this.txtProductCode.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(40, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 19);
			this.label1.TabIndex = 39;
			this.label1.Text = "Product Code";
			// 
			// btnRemove
			// 
			this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemove.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemove.Location = new System.Drawing.Point(346, 204);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(97, 28);
			this.btnRemove.TabIndex = 83;
			this.btnRemove.TabStop = false;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			// 
			// btnUpload
			// 
			this.btnUpload.AutoSize = true;
			this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpload.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpload.Location = new System.Drawing.Point(449, 204);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(97, 28);
			this.btnUpload.TabIndex = 82;
			this.btnUpload.TabStop = false;
			this.btnUpload.Text = "Upload";
			this.btnUpload.UseVisualStyleBackColor = true;
			// 
			// pbProductImg
			// 
			this.pbProductImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
			this.pbProductImg.ErrorImage = null;
			this.pbProductImg.Location = new System.Drawing.Point(371, 41);
			this.pbProductImg.Name = "pbProductImg";
			this.pbProductImg.Size = new System.Drawing.Size(150, 150);
			this.pbProductImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbProductImg.TabIndex = 81;
			this.pbProductImg.TabStop = false;
			// 
			// frmUpdateProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
			this.ClientSize = new System.Drawing.Size(586, 376);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.pbProductImg);
			this.Controls.Add(this.txtProductQuantity);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtProductPrice);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtProductCode);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmUpdateProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Update Product";
			this.Load += new System.EventHandler(this.frmUpdateProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbProductImg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtProductQuantity;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtProductCode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.PictureBox pbProductImg;
	}
}