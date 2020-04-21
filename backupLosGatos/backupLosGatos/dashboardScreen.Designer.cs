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
            this.equipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSubmittedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.welderSignatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorSignatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP6DataSet = new backupLosGatos.GROUP6DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.queryTicket = new System.Windows.Forms.TextBox();
            this.statusOption = new System.Windows.Forms.ComboBox();
            this.technicianOption = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.ticketsTableAdapter = new backupLosGatos.GROUP6DataSetTableAdapters.TicketsTableAdapter();
            this.pageOptions = new System.Windows.Forms.MenuStrip();
            this.dashboardPage = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketPage = new System.Windows.Forms.ToolStripMenuItem();
            this.viewKioskRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersTableAdapter = new backupLosGatos.GROUP6DataSetTableAdapters.UsersTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.equipmentOption = new System.Windows.Forms.ComboBox();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentTableAdapter = new backupLosGatos.GROUP6DataSetTableAdapters.EquipmentTableAdapter();
            this.tableAdapterManager = new backupLosGatos.GROUP6DataSetTableAdapters.TableAdapterManager();
            this.labelRole = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            equipmentDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.pageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
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
            equipmentDescriptionLabel.TabIndex = 25;
            equipmentDescriptionLabel.Text = "Equipment:";
            // 
            // dashboardGrid
            // 
            this.dashboardGrid.AutoGenerateColumns = false;
            this.dashboardGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dashboardGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.equipmentIDDataGridViewTextBoxColumn,
            this.dateSubmittedDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.welderSignatureDataGridViewTextBoxColumn,
            this.inspectorSignatureDataGridViewTextBoxColumn,
            this.additionalInformationDataGridViewTextBoxColumn});
            this.dashboardGrid.DataSource = this.ticketsBindingSource;
            this.dashboardGrid.Location = new System.Drawing.Point(23, 234);
            this.dashboardGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardGrid.Name = "dashboardGrid";
            this.dashboardGrid.RowHeadersWidth = 51;
            this.dashboardGrid.RowTemplate.Height = 24;
            this.dashboardGrid.Size = new System.Drawing.Size(873, 278);
            this.dashboardGrid.TabIndex = 0;
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
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "Unit ";
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
            // dateSubmittedDataGridViewTextBoxColumn
            // 
            this.dateSubmittedDataGridViewTextBoxColumn.DataPropertyName = "dateSubmitted";
            this.dateSubmittedDataGridViewTextBoxColumn.HeaderText = "Date Submitted";
            this.dateSubmittedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateSubmittedDataGridViewTextBoxColumn.Name = "dateSubmittedDataGridViewTextBoxColumn";
            this.dateSubmittedDataGridViewTextBoxColumn.Width = 125;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            this.priorityDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // welderSignatureDataGridViewTextBoxColumn
            // 
            this.welderSignatureDataGridViewTextBoxColumn.DataPropertyName = "welderSignature";
            this.welderSignatureDataGridViewTextBoxColumn.HeaderText = "Welder";
            this.welderSignatureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.welderSignatureDataGridViewTextBoxColumn.Name = "welderSignatureDataGridViewTextBoxColumn";
            this.welderSignatureDataGridViewTextBoxColumn.Width = 125;
            // 
            // inspectorSignatureDataGridViewTextBoxColumn
            // 
            this.inspectorSignatureDataGridViewTextBoxColumn.DataPropertyName = "inspectorSignature";
            this.inspectorSignatureDataGridViewTextBoxColumn.HeaderText = "Inspector";
            this.inspectorSignatureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inspectorSignatureDataGridViewTextBoxColumn.Name = "inspectorSignatureDataGridViewTextBoxColumn";
            this.inspectorSignatureDataGridViewTextBoxColumn.Width = 125;
            // 
            // additionalInformationDataGridViewTextBoxColumn
            // 
            this.additionalInformationDataGridViewTextBoxColumn.DataPropertyName = "additionalInformation";
            this.additionalInformationDataGridViewTextBoxColumn.HeaderText = "Additional Information";
            this.additionalInformationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInformationDataGridViewTextBoxColumn.Name = "additionalInformationDataGridViewTextBoxColumn";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Assigned To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(515, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ticket #:";
            // 
            // queryTicket
            // 
            this.queryTicket.AllowDrop = true;
            this.queryTicket.Location = new System.Drawing.Point(588, 16);
            this.queryTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryTicket.Multiline = true;
            this.queryTicket.Name = "queryTicket";
            this.queryTicket.Size = new System.Drawing.Size(157, 25);
            this.queryTicket.TabIndex = 9;
            // 
            // statusOption
            // 
            this.statusOption.DataSource = this.ticketsBindingSource;
            this.statusOption.DisplayMember = "status";
            this.statusOption.FormattingEnabled = true;
            this.statusOption.Location = new System.Drawing.Point(348, 16);
            this.statusOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusOption.Name = "statusOption";
            this.statusOption.Size = new System.Drawing.Size(157, 24);
            this.statusOption.TabIndex = 8;
            this.statusOption.ValueMember = "status";
            this.statusOption.SelectedIndexChanged += new System.EventHandler(this.statusOption_SelectedIndexChanged);
            // 
            // technicianOption
            // 
            this.technicianOption.DataSource = this.usersBindingSource;
            this.technicianOption.DisplayMember = "username";
            this.technicianOption.FormattingEnabled = true;
            this.technicianOption.Location = new System.Drawing.Point(120, 16);
            this.technicianOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.technicianOption.Name = "technicianOption";
            this.technicianOption.Size = new System.Drawing.Size(157, 24);
            this.technicianOption.TabIndex = 7;
            this.technicianOption.ValueMember = "associateID";
            this.technicianOption.SelectedIndexChanged += new System.EventHandler(this.technicianOption_SelectedIndexChanged);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.gROUP6DataSet;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(755, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 26);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            this.ticketPage,
            this.viewKioskRequestsToolStripMenuItem});
            this.pageOptions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.pageOptions.Location = new System.Drawing.Point(0, 0);
            this.pageOptions.Name = "pageOptions";
            this.pageOptions.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.pageOptions.Size = new System.Drawing.Size(923, 28);
            this.pageOptions.TabIndex = 26;
            // 
            // dashboardPage
            // 
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Size = new System.Drawing.Size(104, 24);
            this.dashboardPage.Text = "Dashboard";
            this.dashboardPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ticketPage
            // 
            this.ticketPage.DoubleClickEnabled = true;
            this.ticketPage.Name = "ticketPage";
            this.ticketPage.Size = new System.Drawing.Size(120, 24);
            this.ticketPage.Text = "Create Ticket";
            this.ticketPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ticketPage.Click += new System.EventHandler(this.ticketPage_Click);
            // 
            // viewKioskRequestsToolStripMenuItem
            // 
            this.viewKioskRequestsToolStripMenuItem.Name = "viewKioskRequestsToolStripMenuItem";
            this.viewKioskRequestsToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.viewKioskRequestsToolStripMenuItem.Text = "View Kiosk Requests";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
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
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.refreshButton);
            this.filterPanel.Controls.Add(equipmentDescriptionLabel);
            this.filterPanel.Controls.Add(this.equipmentOption);
            this.filterPanel.Controls.Add(this.technicianOption);
            this.filterPanel.Controls.Add(this.statusOption);
            this.filterPanel.Controls.Add(this.queryTicket);
            this.filterPanel.Controls.Add(this.btnSearch);
            this.filterPanel.Controls.Add(this.label4);
            this.filterPanel.Controls.Add(this.label6);
            this.filterPanel.Controls.Add(this.label5);
            this.filterPanel.Location = new System.Drawing.Point(0, 98);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(923, 123);
            this.filterPanel.TabIndex = 28;
            // 
            // equipmentOption
            // 
            this.equipmentOption.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "equipmentDescription", true));
            this.equipmentOption.DataSource = this.equipmentBindingSource;
            this.equipmentOption.DisplayMember = "equipmentDescription";
            this.equipmentOption.FormattingEnabled = true;
            this.equipmentOption.Location = new System.Drawing.Point(120, 69);
            this.equipmentOption.Margin = new System.Windows.Forms.Padding(4);
            this.equipmentOption.Name = "equipmentOption";
            this.equipmentOption.Size = new System.Drawing.Size(157, 24);
            this.equipmentOption.TabIndex = 26;
            this.equipmentOption.TabStop = false;
            this.equipmentOption.ValueMember = "equipmentID";
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.gROUP6DataSet;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquipmentTableAdapter = this.equipmentTableAdapter;
            this.tableAdapterManager.TicketsTableAdapter = this.ticketsTableAdapter;
            this.tableAdapterManager.UpdateOrder = backupLosGatos.GROUP6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
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
            // refreshButton
            // 
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(755, 67);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(139, 26);
            this.refreshButton.TabIndex = 27;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // dashboardScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 540);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pageOptions);
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
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.pageOptions.ResumeLayout(false);
            this.pageOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox queryTicket;
        private System.Windows.Forms.ComboBox statusOption;
        private System.Windows.Forms.Button btnSearch;
        private GROUP6DataSet gROUP6DataSet;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private GROUP6DataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem dashboardPage;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private GROUP6DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem viewKioskRequestsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSubmittedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn welderSignatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorSignatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private GROUP6DataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private GROUP6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox equipmentOption;
        public System.Windows.Forms.ToolStripMenuItem ticketPage;
        public System.Windows.Forms.DataGridView dashboardGrid;
        public System.Windows.Forms.MenuStrip pageOptions;
        public System.Windows.Forms.ComboBox technicianOption;
        public System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Button refreshButton;
    }
}