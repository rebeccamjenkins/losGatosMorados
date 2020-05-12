namespace backupLosGatos
{
    partial class kioskRequest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kioskRequest));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboardGrid = new System.Windows.Forms.DataGridView();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSubmittedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicianNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kioskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP6DataSet = new backupLosGatos.GROUP6DataSet();
            this.pageOptions = new System.Windows.Forms.MenuStrip();
            this.dashboardPage = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketPage = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mangButton = new System.Windows.Forms.Button();
            this.coordButton = new System.Windows.Forms.Button();
            this.kioskTableAdapter = new backupLosGatos.GROUP6DataSetTableAdapters.KioskTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kioskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP6DataSet)).BeginInit();
            this.pageOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 40);
            this.label1.TabIndex = 29;
            this.label1.Text = "Weld Progress Tracking System";
            // 
            // dashboardGrid
            // 
            this.dashboardGrid.AutoGenerateColumns = false;
            this.dashboardGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dashboardGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.equipmentIDDataGridViewTextBoxColumn,
            this.priorityLevelDataGridViewTextBoxColumn,
            this.dateSubmittedDataGridViewTextBoxColumn,
            this.technicianNameDataGridViewTextBoxColumn,
            this.additionalInfoDataGridViewTextBoxColumn});
            this.dashboardGrid.DataSource = this.kioskBindingSource;
            this.dashboardGrid.Location = new System.Drawing.Point(17, 190);
            this.dashboardGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashboardGrid.Name = "dashboardGrid";
            this.dashboardGrid.RowHeadersWidth = 51;
            this.dashboardGrid.RowTemplate.Height = 24;
            this.dashboardGrid.Size = new System.Drawing.Size(793, 225);
            this.dashboardGrid.TabIndex = 28;
            this.dashboardGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dashboardGrid_CellContentClick);
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "ticketID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "Ticket #";
            this.ticketIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "unitID";
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // equipmentIDDataGridViewTextBoxColumn
            // 
            this.equipmentIDDataGridViewTextBoxColumn.DataPropertyName = "equipmentID";
            this.equipmentIDDataGridViewTextBoxColumn.HeaderText = "Equipment";
            this.equipmentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.equipmentIDDataGridViewTextBoxColumn.Name = "equipmentIDDataGridViewTextBoxColumn";
            this.equipmentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // priorityLevelDataGridViewTextBoxColumn
            // 
            this.priorityLevelDataGridViewTextBoxColumn.DataPropertyName = "priorityLevel";
            this.priorityLevelDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priorityLevelDataGridViewTextBoxColumn.Name = "priorityLevelDataGridViewTextBoxColumn";
            this.priorityLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateSubmittedDataGridViewTextBoxColumn
            // 
            this.dateSubmittedDataGridViewTextBoxColumn.DataPropertyName = "dateSubmitted";
            this.dateSubmittedDataGridViewTextBoxColumn.HeaderText = "Date Submitted";
            this.dateSubmittedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateSubmittedDataGridViewTextBoxColumn.Name = "dateSubmittedDataGridViewTextBoxColumn";
            this.dateSubmittedDataGridViewTextBoxColumn.Width = 125;
            // 
            // technicianNameDataGridViewTextBoxColumn
            // 
            this.technicianNameDataGridViewTextBoxColumn.DataPropertyName = "technicianName";
            this.technicianNameDataGridViewTextBoxColumn.HeaderText = "Technician Name";
            this.technicianNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.technicianNameDataGridViewTextBoxColumn.Name = "technicianNameDataGridViewTextBoxColumn";
            this.technicianNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // additionalInfoDataGridViewTextBoxColumn
            // 
            this.additionalInfoDataGridViewTextBoxColumn.DataPropertyName = "additionalInfo";
            this.additionalInfoDataGridViewTextBoxColumn.HeaderText = "Additional Information";
            this.additionalInfoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInfoDataGridViewTextBoxColumn.Name = "additionalInfoDataGridViewTextBoxColumn";
            this.additionalInfoDataGridViewTextBoxColumn.Width = 125;
            // 
            // kioskBindingSource
            // 
            this.kioskBindingSource.DataMember = "Kiosk";
            this.kioskBindingSource.DataSource = this.gROUP6DataSet;
            // 
            // gROUP6DataSet
            // 
            this.gROUP6DataSet.DataSetName = "GROUP6DataSet";
            this.gROUP6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pageOptions
            // 
            this.pageOptions.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pageOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardPage,
            this.ticketPage,
            this.logout});
            this.pageOptions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.pageOptions.Location = new System.Drawing.Point(0, 0);
            this.pageOptions.Name = "pageOptions";
            this.pageOptions.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.pageOptions.Size = new System.Drawing.Size(838, 25);
            this.pageOptions.TabIndex = 32;
            // 
            // dashboardPage
            // 
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Size = new System.Drawing.Size(85, 21);
            this.dashboardPage.Text = "Dashboard";
            this.dashboardPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardPage.Click += new System.EventHandler(this.dashboardPage_Click);
            // 
            // ticketPage
            // 
            this.ticketPage.Name = "ticketPage";
            this.ticketPage.Size = new System.Drawing.Size(100, 21);
            this.ticketPage.Text = "Create Ticket";
            this.ticketPage.Click += new System.EventHandler(this.createTicket_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(62, 21);
            this.logout.Text = "Logout";
            this.logout.Click += new System.EventHandler(this.logout_Click_1);
            // 
            // mangButton
            // 
            this.mangButton.Location = new System.Drawing.Point(738, 102);
            this.mangButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mangButton.Name = "mangButton";
            this.mangButton.Size = new System.Drawing.Size(41, 19);
            this.mangButton.TabIndex = 36;
            this.mangButton.Text = "mang";
            this.mangButton.UseVisualStyleBackColor = true;
            this.mangButton.Visible = false;
            // 
            // coordButton
            // 
            this.coordButton.Location = new System.Drawing.Point(738, 79);
            this.coordButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.coordButton.Name = "coordButton";
            this.coordButton.Size = new System.Drawing.Size(41, 19);
            this.coordButton.TabIndex = 35;
            this.coordButton.Text = "coord";
            this.coordButton.UseVisualStyleBackColor = true;
            this.coordButton.Visible = false;
            // 
            // kioskTableAdapter
            // 
            this.kioskTableAdapter.ClearBeforeFill = true;
            // 
            // kioskRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 427);
            this.Controls.Add(this.mangButton);
            this.Controls.Add(this.coordButton);
            this.Controls.Add(this.pageOptions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dashboardGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "kioskRequest";
            this.Text = "kioskRequest";
            this.Load += new System.EventHandler(this.kioskRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kioskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP6DataSet)).EndInit();
            this.pageOptions.ResumeLayout(false);
            this.pageOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dashboardGrid;
        private System.Windows.Forms.ToolStripMenuItem dashboardPage;
        private System.Windows.Forms.ToolStripMenuItem logout;
        public System.Windows.Forms.Button mangButton;
        public System.Windows.Forms.Button coordButton;
        public System.Windows.Forms.ToolStripMenuItem ticketPage;
        public System.Windows.Forms.MenuStrip pageOptions;
        private GROUP6DataSet gROUP6DataSet;
        private System.Windows.Forms.BindingSource kioskBindingSource;
        private GROUP6DataSetTableAdapters.KioskTableAdapter kioskTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSubmittedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInfoDataGridViewTextBoxColumn;
    }
}