using System;
namespace backupLosGatos
{
    partial class dashboardScreen
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
            System.Windows.Forms.Label equipmentDescriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardScreen));
            this.dashboardGrid = new System.Windows.Forms.DataGridView();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSubmittedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.welderSignatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorSignatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP6DataSet = new backupLosGatos.GROUP6DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.ticketsTableAdapter = new backupLosGatos.GROUP6DataSetTableAdapters.TicketsTableAdapter();
            this.pageOptions = new System.Windows.Forms.MenuStrip();
            this.dashboardPage = new System.Windows.Forms.ToolStripMenuItem();
            this.viewKiosk = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.queryTicket = new System.Windows.Forms.TextBox();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.equipmentOption = new System.Windows.Forms.ComboBox();
            this.technicianOption = new System.Windows.Forms.ComboBox();
            this.statusOption = new System.Windows.Forms.ComboBox();
            this.assignedLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            equipmentDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pageOptions.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // equipmentDescriptionLabel
            // 
            equipmentDescriptionLabel.AutoSize = true;
            equipmentDescriptionLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equipmentDescriptionLabel.Location = new System.Drawing.Point(23, 69);
            equipmentDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            equipmentDescriptionLabel.Name = "equipmentDescriptionLabel";
            equipmentDescriptionLabel.Size = new System.Drawing.Size(89, 19);
            equipmentDescriptionLabel.TabIndex = 28;
            equipmentDescriptionLabel.Text = "Equipment:";
            // 
            // dashboardGrid
            // 
            this.dashboardGrid.AllowUserToAddRows = false;
            this.dashboardGrid.AllowUserToDeleteRows = false;
            this.dashboardGrid.AutoGenerateColumns = false;
            this.dashboardGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dashboardGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.priorityLevelDataGridViewTextBoxColumn,
            this.dateSubmittedDataGridViewTextBoxColumn,
            this.equipmentID,
            this.welderSignatureDataGridViewTextBoxColumn,
            this.inspectorSignatureDataGridViewTextBoxColumn,
            this.additionalInformationDataGridViewTextBoxColumn});
            this.dashboardGrid.DataSource = this.ticketsBindingSource;
            this.dashboardGrid.Location = new System.Drawing.Point(23, 234);
            this.dashboardGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardGrid.Name = "dashboardGrid";
            this.dashboardGrid.ReadOnly = true;
            this.dashboardGrid.RowHeadersWidth = 51;
            this.dashboardGrid.RowTemplate.Height = 24;
            this.dashboardGrid.Size = new System.Drawing.Size(873, 278);
            this.dashboardGrid.TabIndex = 0;
            this.dashboardGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dashboardGrid_CellDoubleClick);
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "ticketID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "Ticket #";
            this.ticketIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "unitID";
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // priorityLevelDataGridViewTextBoxColumn
            // 
            this.priorityLevelDataGridViewTextBoxColumn.DataPropertyName = "priorityLevel";
            this.priorityLevelDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priorityLevelDataGridViewTextBoxColumn.Name = "priorityLevelDataGridViewTextBoxColumn";
            this.priorityLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.priorityLevelDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.priorityLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateSubmittedDataGridViewTextBoxColumn
            // 
            this.dateSubmittedDataGridViewTextBoxColumn.DataPropertyName = "dateSubmitted";
            this.dateSubmittedDataGridViewTextBoxColumn.HeaderText = "Date Submitted";
            this.dateSubmittedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateSubmittedDataGridViewTextBoxColumn.Name = "dateSubmittedDataGridViewTextBoxColumn";
            this.dateSubmittedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateSubmittedDataGridViewTextBoxColumn.Width = 125;
            // 
            // equipmentID
            // 
            this.equipmentID.DataPropertyName = "equipmentID";
            this.equipmentID.HeaderText = "Equipment";
            this.equipmentID.MinimumWidth = 6;
            this.equipmentID.Name = "equipmentID";
            this.equipmentID.ReadOnly = true;
            this.equipmentID.Width = 125;
            // 
            // welderSignatureDataGridViewTextBoxColumn
            // 
            this.welderSignatureDataGridViewTextBoxColumn.DataPropertyName = "welderSignature";
            this.welderSignatureDataGridViewTextBoxColumn.HeaderText = "Welder";
            this.welderSignatureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.welderSignatureDataGridViewTextBoxColumn.Name = "welderSignatureDataGridViewTextBoxColumn";
            this.welderSignatureDataGridViewTextBoxColumn.ReadOnly = true;
            this.welderSignatureDataGridViewTextBoxColumn.Width = 125;
            // 
            // inspectorSignatureDataGridViewTextBoxColumn
            // 
            this.inspectorSignatureDataGridViewTextBoxColumn.DataPropertyName = "inspectorSignature";
            this.inspectorSignatureDataGridViewTextBoxColumn.HeaderText = "Inspector";
            this.inspectorSignatureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inspectorSignatureDataGridViewTextBoxColumn.Name = "inspectorSignatureDataGridViewTextBoxColumn";
            this.inspectorSignatureDataGridViewTextBoxColumn.ReadOnly = true;
            this.inspectorSignatureDataGridViewTextBoxColumn.Width = 125;
            // 
            // additionalInformationDataGridViewTextBoxColumn
            // 
            this.additionalInformationDataGridViewTextBoxColumn.DataPropertyName = "additionalInformation";
            this.additionalInformationDataGridViewTextBoxColumn.HeaderText = "Additional Information";
            this.additionalInformationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInformationDataGridViewTextBoxColumn.Name = "additionalInformationDataGridViewTextBoxColumn";
            this.additionalInformationDataGridViewTextBoxColumn.ReadOnly = true;
            this.additionalInformationDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.gROUP6DataSet;
            // 
            // gROUP6DataSet
            // 
            this.gROUP6DataSet.DataSetName = "GROUP6DataSet";
            this.gROUP6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Weld Progress Tracking System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(847, 31);
            this.labelRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(80, 17);
            this.labelRole.TabIndex = 29;
            this.labelRole.Text = "coordinator";
            this.labelRole.Visible = false;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // pageOptions
            // 
            this.pageOptions.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pageOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardPage,
            this.viewKiosk,
            this.logout});
            this.pageOptions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.pageOptions.Location = new System.Drawing.Point(0, 0);
            this.pageOptions.Name = "pageOptions";
            this.pageOptions.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.pageOptions.Size = new System.Drawing.Size(923, 28);
            this.pageOptions.TabIndex = 32;
            this.pageOptions.Click += new System.EventHandler(this.logout_Click);
            // 
            // dashboardPage
            // 
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Size = new System.Drawing.Size(77, 24);
            this.dashboardPage.Text = "Refresh";
            this.dashboardPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viewKiosk
            // 
            this.viewKiosk.Name = "viewKiosk";
            this.viewKiosk.Size = new System.Drawing.Size(170, 34);
            this.viewKiosk.Text = "View Kiosk Requests";
            this.viewKiosk.Click += new System.EventHandler(this.viewKiosk_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(74, 24);
            this.logout.Text = "Logout";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // ticketLabel
            // 
            this.ticketLabel.AllowDrop = true;
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketLabel.Location = new System.Drawing.Point(16, 16);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(65, 19);
            this.ticketLabel.TabIndex = 23;
            this.ticketLabel.Text = "Ticket #:";
            // 
            // queryTicket
            // 
            this.queryTicket.AllowDrop = true;
            this.queryTicket.Location = new System.Drawing.Point(87, 16);
            this.queryTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryTicket.Multiline = true;
            this.queryTicket.Name = "queryTicket";
            this.queryTicket.Size = new System.Drawing.Size(157, 25);
            this.queryTicket.TabIndex = 20;
            this.queryTicket.TextChanged += new System.EventHandler(this.queryTicket_TextChanged);
            // 
            // filterPanel
            // 
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterPanel.Controls.Add(this.refreshButton);
            this.filterPanel.Controls.Add(this.equipmentOption);
            this.filterPanel.Controls.Add(equipmentDescriptionLabel);
            this.filterPanel.Controls.Add(this.technicianOption);
            this.filterPanel.Controls.Add(this.statusOption);
            this.filterPanel.Controls.Add(this.assignedLabel);
            this.filterPanel.Controls.Add(this.statusLabel);
            this.filterPanel.Location = new System.Drawing.Point(-2, 98);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(522, 123);
            this.filterPanel.TabIndex = 36;
            // 
            // refreshButton
            // 
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(345, 66);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(157, 26);
            this.refreshButton.TabIndex = 31;
            this.refreshButton.Text = "Reset";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // equipmentOption
            // 
            this.equipmentOption.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.equipmentOption.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.equipmentOption.FormattingEnabled = true;
            this.equipmentOption.Location = new System.Drawing.Point(120, 68);
            this.equipmentOption.Margin = new System.Windows.Forms.Padding(4);
            this.equipmentOption.Name = "equipmentOption";
            this.equipmentOption.Size = new System.Drawing.Size(157, 24);
            this.equipmentOption.TabIndex = 29;
            // 
            // technicianOption
            // 
            this.technicianOption.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.technicianOption.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.technicianOption.DisplayMember = "associateID";
            this.technicianOption.FormattingEnabled = true;
            this.technicianOption.Location = new System.Drawing.Point(120, 16);
            this.technicianOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.technicianOption.Name = "technicianOption";
            this.technicianOption.Size = new System.Drawing.Size(157, 24);
            this.technicianOption.TabIndex = 18;
            this.technicianOption.ValueMember = "associateID";
            // 
            // statusOption
            // 
            this.statusOption.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.statusOption.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.statusOption.DisplayMember = "status";
            this.statusOption.FormattingEnabled = true;
            this.statusOption.Location = new System.Drawing.Point(345, 17);
            this.statusOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusOption.Name = "statusOption";
            this.statusOption.Size = new System.Drawing.Size(157, 24);
            this.statusOption.TabIndex = 19;
            this.statusOption.ValueMember = "status";
            // 
            // assignedLabel
            // 
            this.assignedLabel.AutoSize = true;
            this.assignedLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedLabel.Location = new System.Drawing.Point(20, 16);
            this.assignedLabel.Name = "assignedLabel";
            this.assignedLabel.Size = new System.Drawing.Size(90, 19);
            this.assignedLabel.TabIndex = 21;
            this.assignedLabel.Text = "Assigned To:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(285, 16);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(54, 19);
            this.statusLabel.TabIndex = 22;
            this.statusLabel.Text = "Status:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ticketLabel);
            this.panel1.Controls.Add(this.queryTicket);
            this.panel1.Location = new System.Drawing.Point(529, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 123);
            this.panel1.TabIndex = 37;
            this.panel1.Click += new System.EventHandler(this.dashboardScreen_Load);
            // 
            // dashboardScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 540);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pageOptions);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dashboardGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dashboardScreen";
            this.Text = "Los Gatos Morados: Weld Progress Tracking System - Coordinator Dashboard";
            this.Load += new System.EventHandler(this.dashboardScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pageOptions.ResumeLayout(false);
            this.pageOptions.PerformLayout();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dashboardGrid;
        public System.Windows.Forms.Label labelRole;
        private GROUP6DataSet gROUP6DataSet;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private GROUP6DataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.MenuStrip pageOptions;
        private System.Windows.Forms.ToolStripMenuItem dashboardPage;
        private System.Windows.Forms.ToolStripMenuItem viewKiosk;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSubmittedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn welderSignatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorSignatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label ticketLabel;
        private System.Windows.Forms.TextBox queryTicket;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox equipmentOption;
        public System.Windows.Forms.ComboBox technicianOption;
        private System.Windows.Forms.ComboBox statusOption;
        private System.Windows.Forms.Label assignedLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel panel1;
    }
}