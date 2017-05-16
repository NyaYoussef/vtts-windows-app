namespace vtts
{
    partial class FormMenu
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
            if (disposing && (components != null))
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
            this.Menu_StaffManagement = new MetroFramework.Controls.MetroTile();
            this.Menu_ConvocationManagement = new MetroFramework.Controls.MetroTile();
            this.Menu_PrintMissionOrderManagement = new MetroFramework.Controls.MetroTile();
            this.Menu_Mission_Order_Management = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // Menu_StaffManagement
            // 
            this.Menu_StaffManagement.ActiveControl = null;
            this.Menu_StaffManagement.Location = new System.Drawing.Point(59, 129);
            this.Menu_StaffManagement.Name = "Menu_StaffManagement";
            this.Menu_StaffManagement.Size = new System.Drawing.Size(227, 63);
            this.Menu_StaffManagement.TabIndex = 2;
            this.Menu_StaffManagement.Text = "Staff Management";
            this.Menu_StaffManagement.UseSelectable = true;
            this.Menu_StaffManagement.Click += new System.EventHandler(this.Menu_StaffManagement_Click);
            // 
            // Menu_ConvocationManagement
            // 
            this.Menu_ConvocationManagement.ActiveControl = null;
            this.Menu_ConvocationManagement.Location = new System.Drawing.Point(59, 229);
            this.Menu_ConvocationManagement.Name = "Menu_ConvocationManagement";
            this.Menu_ConvocationManagement.Size = new System.Drawing.Size(227, 63);
            this.Menu_ConvocationManagement.TabIndex = 3;
            this.Menu_ConvocationManagement.Text = "Mission Convocation Management";
            this.Menu_ConvocationManagement.UseSelectable = true;
            this.Menu_ConvocationManagement.Click += new System.EventHandler(this.Menu_ConvocationManagement_Click);
            // 
            // Menu_PrintMissionOrderManagement
            // 
            this.Menu_PrintMissionOrderManagement.ActiveControl = null;
            this.Menu_PrintMissionOrderManagement.Location = new System.Drawing.Point(468, 229);
            this.Menu_PrintMissionOrderManagement.Name = "Menu_PrintMissionOrderManagement";
            this.Menu_PrintMissionOrderManagement.Size = new System.Drawing.Size(227, 63);
            this.Menu_PrintMissionOrderManagement.TabIndex = 4;
            this.Menu_PrintMissionOrderManagement.Text = "Print Mission Order";
            this.Menu_PrintMissionOrderManagement.UseSelectable = true;
            this.Menu_PrintMissionOrderManagement.Click += new System.EventHandler(this.Menu_PrintMissionOrderManagement_Click);
            // 
            // Menu_Mission_Order_Management
            // 
            this.Menu_Mission_Order_Management.ActiveControl = null;
            this.Menu_Mission_Order_Management.Location = new System.Drawing.Point(468, 129);
            this.Menu_Mission_Order_Management.Name = "Menu_Mission_Order_Management";
            this.Menu_Mission_Order_Management.Size = new System.Drawing.Size(227, 63);
            this.Menu_Mission_Order_Management.TabIndex = 5;
            this.Menu_Mission_Order_Management.Text = "Mission Order Management";
            this.Menu_Mission_Order_Management.UseSelectable = true;
            this.Menu_Mission_Order_Management.Click += new System.EventHandler(this.Menu_Mission_Order_Management_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 325);
            this.Controls.Add(this.Menu_Mission_Order_Management);
            this.Controls.Add(this.Menu_PrintMissionOrderManagement);
            this.Controls.Add(this.Menu_ConvocationManagement);
            this.Controls.Add(this.Menu_StaffManagement);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormMenu";
            this.Text = "GwinApp";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.Controls.SetChildIndex(this.Menu_StaffManagement, 0);
            this.Controls.SetChildIndex(this.Menu_ConvocationManagement, 0);
            this.Controls.SetChildIndex(this.Menu_PrintMissionOrderManagement, 0);
            this.Controls.SetChildIndex(this.Menu_Mission_Order_Management, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile Menu_StaffManagement;
        private MetroFramework.Controls.MetroTile Menu_ConvocationManagement;
        private MetroFramework.Controls.MetroTile Menu_PrintMissionOrderManagement;
        private MetroFramework.Controls.MetroTile Menu_Mission_Order_Management;
    }
}