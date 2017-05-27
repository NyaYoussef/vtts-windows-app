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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.Menu_StaffManagement = new MetroFramework.Controls.MetroTile();
            this.Menu_ConvocationManagement = new MetroFramework.Controls.MetroTile();
            this.Menu_Mission_Order_Management = new MetroFramework.Controls.MetroTile();
            this.ExitmetroTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // Menu_StaffManagement
            // 
            resources.ApplyResources(this.Menu_StaffManagement, "Menu_StaffManagement");
            this.Menu_StaffManagement.ActiveControl = null;
            this.Menu_StaffManagement.Name = "Menu_StaffManagement";
            this.Menu_StaffManagement.UseSelectable = true;
            this.Menu_StaffManagement.Click += new System.EventHandler(this.Menu_StaffManagement_Click);
            // 
            // Menu_ConvocationManagement
            // 
            resources.ApplyResources(this.Menu_ConvocationManagement, "Menu_ConvocationManagement");
            this.Menu_ConvocationManagement.ActiveControl = null;
            this.Menu_ConvocationManagement.Name = "Menu_ConvocationManagement";
            this.Menu_ConvocationManagement.UseSelectable = true;
            this.Menu_ConvocationManagement.Click += new System.EventHandler(this.Menu_ConvocationManagement_Click);
            // 
            // Menu_Mission_Order_Management
            // 
            resources.ApplyResources(this.Menu_Mission_Order_Management, "Menu_Mission_Order_Management");
            this.Menu_Mission_Order_Management.ActiveControl = null;
            this.Menu_Mission_Order_Management.Name = "Menu_Mission_Order_Management";
            this.Menu_Mission_Order_Management.UseSelectable = true;
            this.Menu_Mission_Order_Management.Click += new System.EventHandler(this.Menu_Mission_Order_Management_Click);
            // 
            // ExitmetroTile
            // 
            resources.ApplyResources(this.ExitmetroTile, "ExitmetroTile");
            this.ExitmetroTile.ActiveControl = null;
            this.ExitmetroTile.BackColor = System.Drawing.Color.Red;
            this.ExitmetroTile.Name = "ExitmetroTile";
            this.ExitmetroTile.Style = MetroFramework.MetroColorStyle.Red;
            this.ExitmetroTile.UseSelectable = true;
            this.ExitmetroTile.Click += new System.EventHandler(this.ExitmetroTile_Click);
            // 
            // FormMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExitmetroTile);
            this.Controls.Add(this.Menu_Mission_Order_Management);
            this.Controls.Add(this.Menu_ConvocationManagement);
            this.Controls.Add(this.Menu_StaffManagement);
            this.Name = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.Controls.SetChildIndex(this.Menu_StaffManagement, 0);
            this.Controls.SetChildIndex(this.Menu_ConvocationManagement, 0);
            this.Controls.SetChildIndex(this.Menu_Mission_Order_Management, 0);
            this.Controls.SetChildIndex(this.ExitmetroTile, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile Menu_StaffManagement;
        private MetroFramework.Controls.MetroTile Menu_ConvocationManagement;
        private MetroFramework.Controls.MetroTile Menu_Mission_Order_Management;
        private MetroFramework.Controls.MetroTile ExitmetroTile;
    }
}