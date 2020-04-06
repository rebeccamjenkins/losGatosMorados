using System;

namespace backupLosGatos
{
    partial class ticketDetails
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
            System.Windows.Forms.Label ticketIDLabel;
            System.Windows.Forms.Label welderSignatureLabel;
            System.Windows.Forms.Label inspectorSignatureLabel;
            System.Windows.Forms.Label additionalInformationLabel;
            System.Windows.Forms.Label equipmentIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ticketDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pageOptions = new System.Windows.Forms.MenuStrip();
            this.dashboardPage = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketPage = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.equipmentID = new System.Windows.Forms.TextBox();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP6DataSet = new backupLosGatos.GROUP6DataSet();
            this.unitID = new System.Windows.Forms.TextBox();
            this.ticketID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.additionalInformationTextBox = new System.Windows.Forms.TextBox();
            this.inspectorSignature = new System.Windows.Forms.TextBox();
            this.welderSignature = new System.Windows.Forms.TextBox();
            this.ticketsTableAdapter = new backupLosGatos.GROUP6DataSetTableAdapters.TicketsTableAdapter();
            this.tableAdapterManager = new backupLosGatos.GROUP6DataSetTableAdapters.TableAdapterManager();
            this.ticketsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ticketsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.updateButton = new System.Windows.Forms.Button();
            ticketIDLabel = new System.Windows.Forms.Label();
            welderSignatureLabel = new System.Windows.Forms.Label();
            inspectorSignatureLabel = new System.Windows.Forms.Label();
            additionalInformationLabel = new System.Windows.Forms.Label();
            equipmentIDLabel = new System.Windows.Forms.Label();
            this.pageOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP6DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingNavigator)).BeginInit();
            this.ticketsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketIDLabel
            // 
            ticketIDLabel.AutoSize = true;
            ticketIDLabel.Location = new System.Drawing.Point(32, 58);
            ticketIDLabel.Name = "ticketIDLabel";
            ticketIDLabel.Size = new System.Drawing.Size(65, 19);
            ticketIDLabel.TabIndex = 0;
            ticketIDLabel.Text = "Ticket #:";
            // 
            // welderSignatureLabel
            // 
            welderSignatureLabel.AutoSize = true;
            welderSignatureLabel.Location = new System.Drawing.Point(32, 54);
            welderSignatureLabel.Name = "welderSignatureLabel";
            welderSignatureLabel.Size = new System.Drawing.Size(63, 19);
            welderSignatureLabel.TabIndex = 0;
            welderSignatureLabel.Text = "Welder:";
            // 
            // inspectorSignatureLabel
            // 
            inspectorSignatureLabel.AutoSize = true;
            inspectorSignatureLabel.Location = new System.Drawing.Point(451, 53);
            inspectorSignatureLabel.Name = "inspectorSignatureLabel";
            inspectorSignatureLabel.Size = new System.Drawing.Size(76, 19);
            inspectorSignatureLabel.TabIndex = 2;
            inspectorSignatureLabel.Text = "Inspector:";
            // 
            // additionalInformationLabel
            // 
            additionalInformationLabel.Location = new System.Drawing.Point(32, 107);
            additionalInformationLabel.Name = "additionalInformationLabel";
            additionalInformationLabel.Size = new System.Drawing.Size(96, 59);
            additionalInformationLabel.TabIndex = 4;
            additionalInformationLabel.Text = "Additional Information:";
            // 
            // equipmentIDLabel
            // 
            equipmentIDLabel.AutoSize = true;
            equipmentIDLabel.Location = new System.Drawing.Point(32, 138);
            equipmentIDLabel.Name = "equipmentIDLabel";
            equipmentIDLabel.Size = new System.Drawing.Size(89, 19);
            equipmentIDLabel.TabIndex = 4;
            equipmentIDLabel.Text = "Equipment:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 49);
            this.label1.TabIndex = 9;
            this.label1.Text = "Weld Progress Tracking System";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(529, 54);
            this.label3.TabIndex = 10;
            this.label3.Text = "Wildcat Refinery\'s centralized service catalog for management of trouble tickets " +
    "by management and technician personnel";
            // 
            // pageOptions
            // 
            this.pageOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pageOptions.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pageOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardPage,
            this.ticketPage});
            this.pageOptions.Location = new System.Drawing.Point(0, 0);
            this.pageOptions.Name = "pageOptions";
            this.pageOptions.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.pageOptions.Size = new System.Drawing.Size(109, 622);
            this.pageOptions.TabIndex = 11;
            // 
            // dashboardPage
            // 
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Size = new System.Drawing.Size(98, 24);
            this.dashboardPage.Text = "Dashboard";
            this.dashboardPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ticketPage
            // 
            this.ticketPage.Name = "ticketPage";
            this.ticketPage.Size = new System.Drawing.Size(98, 24);
            this.ticketPage.Text = "Ticket";
            this.ticketPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(equipmentIDLabel);
            this.groupBox1.Controls.Add(this.equipmentID);
            this.groupBox1.Controls.Add(this.unitID);
            this.groupBox1.Controls.Add(ticketIDLabel);
            this.groupBox1.Controls.Add(this.ticketID);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(171, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(803, 203);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Unit:";
            // 
            // equipmentID
            // 
            this.equipmentID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "equipmentID", true));
            this.equipmentID.Location = new System.Drawing.Point(148, 135);
            this.equipmentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.equipmentID.Name = "equipmentID";
            this.equipmentID.Size = new System.Drawing.Size(185, 23);
            this.equipmentID.TabIndex = 5;
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
            // unitID
            // 
            this.unitID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "unitID", true));
            this.unitID.Location = new System.Drawing.Point(148, 95);
            this.unitID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unitID.Name = "unitID";
            this.unitID.Size = new System.Drawing.Size(185, 23);
            this.unitID.TabIndex = 3;
            // 
            // ticketID
            // 
            this.ticketID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "ticketID", true));
            this.ticketID.Location = new System.Drawing.Point(148, 55);
            this.ticketID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ticketID.Name = "ticketID";
            this.ticketID.Size = new System.Drawing.Size(185, 23);
            this.ticketID.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(additionalInformationLabel);
            this.groupBox2.Controls.Add(this.additionalInformationTextBox);
            this.groupBox2.Controls.Add(inspectorSignatureLabel);
            this.groupBox2.Controls.Add(this.inspectorSignature);
            this.groupBox2.Controls.Add(welderSignatureLabel);
            this.groupBox2.Controls.Add(this.welderSignature);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(171, 320);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(803, 240);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detailed Information";
            // 
            // additionalInformationTextBox
            // 
            this.additionalInformationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "additionalInformation", true));
            this.additionalInformationTextBox.Location = new System.Drawing.Point(148, 103);
            this.additionalInformationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.additionalInformationTextBox.Multiline = true;
            this.additionalInformationTextBox.Name = "additionalInformationTextBox";
            this.additionalInformationTextBox.Size = new System.Drawing.Size(604, 112);
            this.additionalInformationTextBox.TabIndex = 5;
            // 
            // inspectorSignature
            // 
            this.inspectorSignature.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "inspectorSignature", true));
            this.inspectorSignature.Location = new System.Drawing.Point(567, 50);
            this.inspectorSignature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inspectorSignature.Name = "inspectorSignature";
            this.inspectorSignature.Size = new System.Drawing.Size(185, 23);
            this.inspectorSignature.TabIndex = 3;
            // 
            // welderSignature
            // 
            this.welderSignature.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "welderSignature", true));
            this.welderSignature.Location = new System.Drawing.Point(148, 50);
            this.welderSignature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.welderSignature.Name = "welderSignature";
            this.welderSignature.Size = new System.Drawing.Size(185, 23);
            this.welderSignature.TabIndex = 1;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TicketsTableAdapter = this.ticketsTableAdapter;
            this.tableAdapterManager.UpdateOrder = backupLosGatos.GROUP6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // ticketsBindingNavigator
            // 
            this.ticketsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ticketsBindingNavigator.BindingSource = this.ticketsBindingSource;
            this.ticketsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ticketsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ticketsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ticketsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ticketsBindingNavigatorSaveItem});
            this.ticketsBindingNavigator.Location = new System.Drawing.Point(109, 0);
            this.ticketsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ticketsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ticketsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ticketsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ticketsBindingNavigator.Name = "ticketsBindingNavigator";
            this.ticketsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ticketsBindingNavigator.Size = new System.Drawing.Size(921, 27);
            this.ticketsBindingNavigator.TabIndex = 14;
            this.ticketsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // ticketsBindingNavigatorSaveItem
            // 
            this.ticketsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ticketsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ticketsBindingNavigatorSaveItem.Image")));
            this.ticketsBindingNavigatorSaveItem.Name = "ticketsBindingNavigatorSaveItem";
            this.ticketsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.ticketsBindingNavigatorSaveItem.Text = "Save Data";
            this.ticketsBindingNavigatorSaveItem.Click += new System.EventHandler(this.ticketsBindingNavigatorSaveItem_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(1056, 714);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(129, 30);
            this.updateButton.TabIndex = 22;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // ticketDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 622);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.ticketsBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pageOptions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ticketDetails";
            this.Text = "Los Gatos Morados: Weld Progress Tracking System - Ticket Details";
            this.Load += new System.EventHandler(this.ticketDetails_Load);
            this.pageOptions.ResumeLayout(false);
            this.pageOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP6DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingNavigator)).EndInit();
            this.ticketsBindingNavigator.ResumeLayout(false);
            this.ticketsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PerformLayout()
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip pageOptions;
        private System.Windows.Forms.ToolStripMenuItem dashboardPage;
        private System.Windows.Forms.ToolStripMenuItem ticketPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private backupLosGatos.GROUP6DataSet gROUP6DataSet;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private backupLosGatos.GROUP6DataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private backupLosGatos.GROUP6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ticketsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ticketsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox unitID;
        private System.Windows.Forms.TextBox ticketID;
        private System.Windows.Forms.TextBox equipmentID;
        private System.Windows.Forms.TextBox additionalInformationTextBox;
        private System.Windows.Forms.TextBox inspectorSignature;
        private System.Windows.Forms.TextBox welderSignature;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateButton;
    }
}