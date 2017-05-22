namespace vtts.Presentation.MissionManagement
{
    partial class MissionConvocationFrom
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MissionConvocationFrom));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ThemeCategorys = new App.Gwin.Fields.ManyToManyField();
            this.MissionCategory = new App.Gwin.Fields.ManyToOneField();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_form.SuspendLayout();
            this.FlowLayoutContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // FlowLayoutContainer
            // 
            this.FlowLayoutContainer.Controls.Add(this.groupBox1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MissionCategory);
            this.groupBox1.Controls.Add(this.ThemeCategorys);
            this.groupBox1.Location = new System.Drawing.Point(61, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject";
            // 
            // ThemeCategorys
            // 
            this.ThemeCategorys.AutoSizeConfig = true;
            this.ThemeCategorys.EntityBAO = null;
            this.ThemeCategorys.Location = new System.Drawing.Point(197, 19);
            this.ThemeCategorys.Name = "ThemeCategorys";
            this.ThemeCategorys.OrientationField = System.Windows.Forms.Orientation.Horizontal;
            this.ThemeCategorys.PropertyInfo = null;
            this.ThemeCategorys.Size = new System.Drawing.Size(171, 111);
            this.ThemeCategorys.SizeControl = new System.Drawing.Size(100, 20);
            this.ThemeCategorys.SizeLabel = new System.Drawing.Size(100, 20);
            this.ThemeCategorys.TabIndex = 0;
            this.ThemeCategorys.Text_Label = "Theme Categorys";
            this.ThemeCategorys.Value = ((object)(resources.GetObject("ThemeCategorys.Value")));
            // 
            // MissionCategory
            // 
            this.MissionCategory.AutoSizeConfig = true;
            this.MissionCategory.ConfigEntity = null;
            this.MissionCategory.configProperty = null;
            this.MissionCategory.DataSource = null;
            this.MissionCategory.DisplayMember = "";
            this.MissionCategory.Location = new System.Drawing.Point(93, 151);
            this.MissionCategory.MainContainner = null;
            this.MissionCategory.Name = "MissionCategory";
            this.MissionCategory.OrientationField = System.Windows.Forms.Orientation.Horizontal;
            this.MissionCategory.PropertyInfo = null;
            this.MissionCategory.SelectedIndex = -1;
            this.MissionCategory.SelectedValue = null;
            this.MissionCategory.Size = new System.Drawing.Size(239, 75);
            this.MissionCategory.SizeControl = new System.Drawing.Size(100, 20);
            this.MissionCategory.SizeLabel = new System.Drawing.Size(100, 20);
            this.MissionCategory.TabIndex = 1;
            this.MissionCategory.Text_Label = "Mission Category";
            this.MissionCategory.TextCombobox = "";
            this.MissionCategory.Value = null;
            this.MissionCategory.ValueMember = "";
            this.MissionCategory.Load += new System.EventHandler(this.MissionCategory_Load);
            // 
            // MissionConvocationFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MissionConvocationFrom";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_form.ResumeLayout(false);
            this.FlowLayoutContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private App.Gwin.Fields.ManyToManyField ThemeCategorys;
        private App.Gwin.Fields.ManyToOneField MissionCategory;
    }
}
