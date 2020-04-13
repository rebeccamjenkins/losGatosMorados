using System;

namespace backupLosGatos
{
    partial class managerDashboard
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.queryTicket = new System.Windows.Forms.TextBox();
            this.statusOption = new System.Windows.Forms.ComboBox();
            this.technicianOption = new System.Windows.Forms.ComboBox();
            this.pageOptions = new System.Windows.Forms.MenuStrip();
            this.dashboardPage = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketPage = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.welderSignatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorSignatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP6DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP6DataSet = new backupLosGatos.GROUP6DataSet();
            this.ticketsTableAdapter = new backupLosGatos.GROUP6DataSetTableAdapters.TicketsTableAdapter();
            this.btnSearch = new System.Windows.Forms.Button();
            this.viewKioskRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP6DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP6DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(517, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ticket #:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Assigned To:";
            // 
            // queryTicket
            // 
            this.queryTicket.AllowDrop = true;
            this.queryTicket.Location = new System.Drawing.Point(591, 124);
            this.queryTicket.Multiline = true;
            this.queryTicket.Name = "queryTicket";
            this.queryTicket.Size = new System.Drawing.Size(157, 25);
            this.queryTicket.TabIndex = 20;
            // 
            // statusOption
            // 
            this.statusOption.FormattingEnabled = true;
            this.statusOption.Location = new System.Drawing.Point(351, 124);
            this.statusOption.Name = "statusOption";
            this.statusOption.Size = new System.Drawing.Size(157, 24);
            this.statusOption.TabIndex = 19;
            // 
            // technicianOption
            // 
            this.technicianOption.FormattingEnabled = true;
            this.technicianOption.Location = new System.Drawing.Point(122, 124);
            this.technicianOption.Name = "technicianOption";
            this.technicianOption.Size = new System.Drawing.Size(157, 24);
            this.technicianOption.TabIndex = 18;
            // 
            // pageOptions
            // 
            this.pageOptions.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pageOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardPage,
            this.ticketPage,
            this.viewKioskRequestsToolStripMenuItem});
            this.pageOptions.Location = new System.Drawing.Point(0, 0);
            this.pageOptions.Name = "pageOptions";
            this.pageOptions.Size = new System.Drawing.Size(923, 30);
            this.pageOptions.TabIndex = 17;
            // 
            // dashboardPage
            // 
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Size = new System.Drawing.Size(104, 26);
            this.dashboardPage.Text = "Dashboard";
            this.dashboardPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardPage.Click += new System.EventHandler(this.dashboardPage_Click);
            // 
            // ticketPage
            // 
            this.ticketPage.DoubleClickEnabled = true;
            this.ticketPage.Name = "ticketPage";
            this.ticketPage.Size = new System.Drawing.Size(103, 26);
            this.ticketPage.Text = "New Ticket";
            this.ticketPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ticketPage.Click += new System.EventHandler(this.ticketPage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 49);
            this.label1.TabIndex = 14;
            this.label1.Text = "Welcome, ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.equipmentIDDataGridViewTextBoxColumn,
            this.welderSignatureDataGridViewTextBoxColumn,
            this.inspectorSignatureDataGridViewTextBoxColumn,
            this.additionalInformationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 343);
            this.dataGridView1.TabIndex = 13;
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
            // welderSignatureDataGridViewTextBoxColumn
            // 
            this.welderSignatureDataGridViewTextBoxColumn.DataPropertyName = "welderSignature";
            this.welderSignatureDataGridViewTextBoxColumn.HeaderText = "welderSignature";
            this.welderSignatureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.welderSignatureDataGridViewTextBoxColumn.Name = "welderSignatureDataGridViewTextBoxColumn";
            this.welderSignatureDataGridViewTextBoxColumn.Width = 125;
            // 
            // inspectorSignatureDataGridViewTextBoxColumn
            // 
            this.inspectorSignatureDataGridViewTextBoxColumn.DataPropertyName = "inspectorSignature";
            this.inspectorSignatureDataGridViewTextBoxColumn.HeaderText = "inspectorSignature";
            this.inspectorSignatureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inspectorSignatureDataGridViewTextBoxColumn.Name = "inspectorSignatureDataGridViewTextBoxColumn";
            this.inspectorSignatureDataGridViewTextBoxColumn.Width = 125;
            // 
            // additionalInformationDataGridViewTextBoxColumn
            // 
            this.additionalInformationDataGridViewTextBoxColumn.DataPropertyName = "additionalInformation";
            this.additionalInformationDataGridViewTextBoxColumn.HeaderText = "additionalInformation";
            this.additionalInformationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInformationDataGridViewTextBoxColumn.Name = "additionalInformationDataGridViewTextBoxColumn";
            this.additionalInformationDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.gROUP6DataSetBindingSource;
            // 
            // gROUP6DataSetBindingSource
            // 
            this.gROUP6DataSetBindingSource.DataSource = this.gROUP6DataSet;
            this.gROUP6DataSetBindingSource.Position = 0;
            // 
            // gROUP6DataSet
            // 
            this.gROUP6DataSet.DataSetName = "GROUP6DataSet";
            this.gROUP6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(757, 124);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 26);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // viewKioskRequestsToolStripMenuItem
            // 
            this.viewKioskRequestsToolStripMenuItem.Name = "viewKioskRequestsToolStripMenuItem";
            this.viewKioskRequestsToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.viewKioskRequestsToolStripMenuItem.Text = "View Kiosk Requests";
            // 
            // managerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 540);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.queryTicket);
            this.Controls.Add(this.statusOption);
            this.Controls.Add(this.technicianOption);
            this.Controls.Add(this.pageOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "managerDashboard";
            this.Text = "Manager Dashboard";
            this.Load += new System.EventHandler(this.managerDashboard_Load);
            this.pageOptions.ResumeLayout(false);
            this.pageOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP6DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP6DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox queryTicket;
        private System.Windows.Forms.ComboBox statusOption;
        private System.Windows.Forms.ComboBox technicianOption;
        private System.Windows.Forms.MenuStrip pageOptions;
        private System.Windows.Forms.ToolStripMenuItem dashboardPage;
        private System.Windows.Forms.ToolStripMenuItem ticketPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gROUP6DataSetBindingSource;
        private backupLosGatos.GROUP6DataSet gROUP6DataSet;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private backupLosGatos.GROUP6DataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn welderSignatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorSignatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem viewKioskRequestsToolStripMenuItem;
    }
}