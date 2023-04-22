namespace Odrunia_POS_System.Forms
{
	partial class frmCustomerDashboard
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
			this.btnViewOrder = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnOrder = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlDashboard = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// btnViewOrder
			// 
			this.btnViewOrder.AutoSize = true;
			this.btnViewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnViewOrder.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnViewOrder.Location = new System.Drawing.Point(442, 30);
			this.btnViewOrder.Name = "btnViewOrder";
			this.btnViewOrder.Size = new System.Drawing.Size(126, 28);
			this.btnViewOrder.TabIndex = 11;
			this.btnViewOrder.TabStop = false;
			this.btnViewOrder.Text = "View Order";
			this.btnViewOrder.UseVisualStyleBackColor = true;
			// 
			// btnExit
			// 
			this.btnExit.AutoSize = true;
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(1053, 32);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(126, 28);
			this.btnExit.TabIndex = 10;
			this.btnExit.TabStop = false;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// btnOrder
			// 
			this.btnOrder.AutoSize = true;
			this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOrder.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrder.Location = new System.Drawing.Point(310, 30);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(126, 28);
			this.btnOrder.TabIndex = 9;
			this.btnOrder.TabStop = false;
			this.btnOrder.Text = "Order";
			this.btnOrder.UseVisualStyleBackColor = true;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(585, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 27);
			this.label1.TabIndex = 8;
			this.label1.Text = "DASHBOARD";
			// 
			// pnlDashboard
			// 
			this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
			this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlDashboard.Location = new System.Drawing.Point(0, 92);
			this.pnlDashboard.Name = "pnlDashboard";
			this.pnlDashboard.Size = new System.Drawing.Size(1191, 358);
			this.pnlDashboard.TabIndex = 12;
			this.pnlDashboard.TabStop = true;
			// 
			// frmCustomerDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(209)))), ((int)(((byte)(208)))));
			this.ClientSize = new System.Drawing.Size(1191, 450);
			this.Controls.Add(this.pnlDashboard);
			this.Controls.Add(this.btnViewOrder);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnOrder);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmCustomerDashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customer";
			this.Load += new System.EventHandler(this.frmCustomerDashboard_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnViewOrder;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnOrder;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlDashboard;
	}
}