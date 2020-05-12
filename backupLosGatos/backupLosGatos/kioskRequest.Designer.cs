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
            this.pageOptions = new System.Windows.Forms.MenuStrip();
            this.dashboardPage = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketPage = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mangButton = new System.Windows.Forms.Button();
            this.coordButton = new System.Windows.Forms.Button();
            this.kioskTickets = new backupLosGatos.KioskTickets();
            this.kioskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kioskTableAdapter = new backupLosGatos.KioskTicketsTableAdapters.KioskTableAdapter();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicianNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSubmittedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardGrid)).BeginInit();
            this.pageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kioskTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kioskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 49);
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
            this.technicianNameDataGridViewTextBoxColumn,
            this.additionalInfoDataGridViewTextBoxColumn,
            this.dateSubmittedDataGridViewTextBoxColumn});
            this.dashboardGrid.DataSource = this.kioskBindingSource;
            this.dashboardGrid.Location = new System.Drawing.Point(29, 124);
            this.dashboardGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardGrid.Name = "dashboardGrid";
            this.dashboardGrid.RowHeadersWidth = 51;
            this.dashboardGrid.RowTemplate.Height = 24;
            this.dashboardGrid.Size = new System.Drawing.Size(873, 277);
            this.dashboardGrid.TabIndex = 28;
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
            this.pageOptions.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.pageOptions.Size = new System.Drawing.Size(926, 28);
            this.pageOptions.TabIndex = 32;
            // 
            // dashboardPage
            // 
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Size = new System.Drawing.Size(104, 24);
            this.dashboardPage.Text = "Dashboard";
            this.dashboardPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardPage.Click += new System.EventHandler(this.dashboardPage_Click);
            // 
            // ticketPage
            // 
            this.ticketPage.Name = "ticketPage";
            this.ticketPage.Size = new System.Drawing.Size(120, 24);
            this.ticketPage.Text = "Create Ticket";
            this.ticketPage.Click += new System.EventHandler(this.createTicket_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(74, 24);
            this.logout.Text = "Logout";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // mangButton
            // 
            this.mangButton.Location = new System.Drawing.Point(859, 60);
            this.mangButton.Name = "mangButton";
            this.mangButton.Size = new System.Drawing.Size(55, 23);
            this.mangButton.TabIndex = 36;
            this.mangButton.Text = "mang";
            this.mangButton.UseVisualStyleBackColor = true;
            this.mangButton.Visible = false;
            // 
            // coordButton
            // 
            this.coordButton.Location = new System.Drawing.Point(859, 31);
            this.coordButton.Name = "coordButton";
            this.coordButton.Size = new System.Drawing.Size(55, 23);
            this.coordButton.TabIndex = 35;
            this.coordButton.Text = "coord";
            this.coordButton.UseVisualStyleBackColor = true;
            this.coordButton.Visible = false;
            // 
            // kioskTickets
            // 
            this.kioskTickets.DataSetName = "KioskTickets";
            this.kioskTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kioskBindingSource
            // 
            this.kioskBindingSource.DataMember = "Kiosk";
            this.kioskBindingSource.DataSource = this.kioskTickets;
            // 
            // kioskTableAdapter
            // 
            this.kioskTableAdapter.ClearBeforeFill = true;
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "ticketID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "ticketID";
            this.ticketIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "unitID";
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "unitID";
            this.unitIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // equipmentIDDataGridViewTextBoxColumn
            // 
            this.equipmentIDDataGridViewTextBoxColumn.DataPropertyName = "equipmentID";
            this.equipmentIDDataGridViewTextBoxColumn.HeaderText = "equipmentID";
            this.equipmentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.equipmentIDDataGridViewTextBoxColumn.Name = "equipmentIDDataGridViewTextBoxColumn";
            this.equipmentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // priorityLevelDataGridViewTextBoxColumn
            // 
            this.priorityLevelDataGridViewTextBoxColumn.DataPropertyName = "priorityLevel";
            this.priorityLevelDataGridViewTextBoxColumn.HeaderText = "priorityLevel";
            this.priorityLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priorityLevelDataGridViewTextBoxColumn.Name = "priorityLevelDataGridViewTextBoxColumn";
            this.priorityLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // technicianNameDataGridViewTextBoxColumn
            // 
            this.technicianNameDataGridViewTextBoxColumn.DataPropertyName = "technicianName";
            this.technicianNameDataGridViewTextBoxColumn.HeaderText = "technicianName";
            this.technicianNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.technicianNameDataGridViewTextBoxColumn.Name = "technicianNameDataGridViewTextBoxColumn";
            this.technicianNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // additionalInfoDataGridViewTextBoxColumn
            // 
            this.additionalInfoDataGridViewTextBoxColumn.DataPropertyName = "additionalInfo";
            this.additionalInfoDataGridViewTextBoxColumn.HeaderText = "additionalInfo";
            this.additionalInfoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInfoDataGridViewTextBoxColumn.Name = "additionalInfoDataGridViewTextBoxColumn";
            this.additionalInfoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateSubmittedDataGridViewTextBoxColumn
            // 
            this.dateSubmittedDataGridViewTextBoxColumn.DataPropertyName = "dateSubmitted";
            this.dateSubmittedDataGridViewTextBoxColumn.HeaderText = "dateSubmitted";
            this.dateSubmittedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateSubmittedDataGridViewTextBoxColumn.Name = "dateSubmittedDataGridViewTextBoxColumn";
            this.dateSubmittedDataGridViewTextBoxColumn.Width = 125;
            // 
            // kioskRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 423);
            this.Controls.Add(this.mangButton);
            this.Controls.Add(this.coordButton);
            this.Controls.Add(this.pageOptions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dashboardGrid);
            this.Name = "kioskRequest";
            this.Text = "kioskRequest";
            this.Load += new System.EventHandler(this.kioskRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardGrid)).EndInit();
            this.pageOptions.ResumeLayout(false);
            this.pageOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kioskTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kioskBindingSource)).EndInit();
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
        private KioskTickets kioskTickets;
        private System.Windows.Forms.BindingSource kioskBindingSource;
        private KioskTicketsTableAdapters.KioskTableAdapter kioskTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSubmittedDataGridViewTextBoxColumn;
    }
}