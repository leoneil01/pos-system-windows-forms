namespace Odrunia_POS_System.Forms.Customers
{
	partial class frmProductAvailable
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnViewOrder = new System.Windows.Forms.Button();
			this.btnRemoveOrder = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnAddOrder = new System.Windows.Forms.Button();
			this.gridProducts = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(179)))), ((int)(((byte)(178)))));
			this.panel1.Controls.Add(this.btnViewOrder);
			this.panel1.Controls.Add(this.btnRemoveOrder);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.btnAddOrder);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(1058, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(133, 358);
			this.panel1.TabIndex = 5;
			// 
			// btnViewOrder
			// 
			this.btnViewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnViewOrder.AutoSize = true;
			this.btnViewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnViewOrder.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnViewOrder.Location = new System.Drawing.Point(15, 139);
			this.btnViewOrder.Name = "btnViewOrder";
			this.btnViewOrder.Size = new System.Drawing.Size(101, 28);
			this.btnViewOrder.TabIndex = 19;
			this.btnViewOrder.TabStop = false;
			this.btnViewOrder.Text = "View Order";
			this.btnViewOrder.UseVisualStyleBackColor = true;
			this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
			// 
			// btnRemoveOrder
			// 
			this.btnRemoveOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemoveOrder.AutoSize = true;
			this.btnRemoveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemoveOrder.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemoveOrder.Location = new System.Drawing.Point(11, 318);
			this.btnRemoveOrder.Name = "btnRemoveOrder";
			this.btnRemoveOrder.Size = new System.Drawing.Size(114, 28);
			this.btnRemoveOrder.TabIndex = 18;
			this.btnRemoveOrder.TabStop = false;
			this.btnRemoveOrder.Text = "Remove Order";
			this.btnRemoveOrder.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(16, 22);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(98, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// btnAddOrder
			// 
			this.btnAddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddOrder.AutoSize = true;
			this.btnAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddOrder.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddOrder.Location = new System.Drawing.Point(16, 105);
			this.btnAddOrder.Name = "btnAddOrder";
			this.btnAddOrder.Size = new System.Drawing.Size(98, 28);
			this.btnAddOrder.TabIndex = 14;
			this.btnAddOrder.TabStop = false;
			this.btnAddOrder.Text = "Add Order";
			this.btnAddOrder.UseVisualStyleBackColor = true;
			this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
			// 
			// gridProducts
			// 
			this.gridProducts.AllowUserToAddRows = false;
			this.gridProducts.AllowUserToDeleteRows = false;
			this.gridProducts.AllowUserToResizeColumns = false;
			this.gridProducts.AllowUserToResizeRows = false;
			this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.gridProducts.ColumnHeadersHeight = 55;
			this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.gridProducts.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridProducts.DefaultCellStyle = dataGridViewCellStyle8;
			this.gridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridProducts.Location = new System.Drawing.Point(0, 0);
			this.gridProducts.Name = "gridProducts";
			this.gridProducts.ReadOnly = true;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.gridProducts.RowHeadersVisible = false;
			this.gridProducts.RowTemplate.Height = 80;
			this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridProducts.Size = new System.Drawing.Size(1058, 358);
			this.gridProducts.TabIndex = 6;
			this.gridProducts.TabStop = false;
			// 
			// frmProductAvailable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1191, 358);
			this.Controls.Add(this.gridProducts);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmProductAvailable";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Avalable Products";
			this.Load += new System.EventHandler(this.frmProductAvailable_Load);
			this.VisibleChanged += new System.EventHandler(this.frmProductAvailable_VisibleChanged);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnViewOrder;
		private System.Windows.Forms.Button btnRemoveOrder;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnAddOrder;
		public System.Windows.Forms.DataGridView gridProducts;
	}
}