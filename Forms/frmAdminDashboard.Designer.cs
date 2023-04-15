namespace Odrunia_POS_System.Forms
{
	partial class frmAdminDashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
			this.pnlDashboard = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnProducts = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnUsers = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// pnlDashboard
			// 
			this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
			this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlDashboard.Location = new System.Drawing.Point(0, 92);
			this.pnlDashboard.Name = "pnlDashboard";
			this.pnlDashboard.Size = new System.Drawing.Size(1191, 358);
			this.pnlDashboard.TabIndex = 0;
			this.pnlDashboard.TabStop = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(1043, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 27);
			this.label1.TabIndex = 1;
			this.label1.Text = "DASHBOARD";
			// 
			// btnProducts
			// 
			this.btnProducts.AutoSize = true;
			this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnProducts.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProducts.Location = new System.Drawing.Point(760, 32);
			this.btnProducts.Name = "btnProducts";
			this.btnProducts.Size = new System.Drawing.Size(126, 28);
			this.btnProducts.TabIndex = 2;
			this.btnProducts.TabStop = false;
			this.btnProducts.Text = "Products";
			this.btnProducts.UseVisualStyleBackColor = true;
			this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
			// 
			// btnExit
			// 
			this.btnExit.AutoSize = true;
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(12, 32);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(126, 28);
			this.btnExit.TabIndex = 5;
			this.btnExit.TabStop = false;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnUsers
			// 
			this.btnUsers.AutoSize = true;
			this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUsers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUsers.Location = new System.Drawing.Point(900, 32);
			this.btnUsers.Name = "btnUsers";
			this.btnUsers.Size = new System.Drawing.Size(126, 28);
			this.btnUsers.TabIndex = 7;
			this.btnUsers.TabStop = false;
			this.btnUsers.Text = "Users";
			this.btnUsers.UseVisualStyleBackColor = true;
			this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
			// 
			// frmAdminDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(209)))), ((int)(((byte)(208)))));
			this.ClientSize = new System.Drawing.Size(1191, 450);
			this.Controls.Add(this.btnUsers);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnProducts);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pnlDashboard);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmAdminDashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Odrunia\'s Mini Mart";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlDashboard;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnProducts;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnUsers;
	}
}