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
            System.Windows.Forms.Label dateSubmittedLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label associateIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ticketDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.pageOptions = new System.Windows.Forms.MenuStrip();
            this.dashboardPage = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketPage = new System.Windows.Forms.ToolStripMenuItem();
            this.viewKioskRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.priorityText = new System.Windows.Forms.TextBox();
            this.statusText = new System.Windows.Forms.TextBox();
            this.equipText = new System.Windows.Forms.TextBox();
            this.dateText = new System.Windows.Forms.TextBox();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP6DataSet = new backupLosGatos.GROUP6DataSet();
            this.associateIDComboBox = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priorityCombo = new System.Windows.Forms.ComboBox();
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.equipmentCombo = new System.Windows.Forms.ComboBox();
            this.unitIDText = new System.Windows.Forms.TextBox();
            this.ticketIDText = new System.Windows.Forms.TextBox();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.additionalInformationText = new System.Windows.Forms.TextBox();
            this.inspectorSignatureText = new System.Windows.Forms.TextBox();
            this.welderSignatureText = new System.Windows.Forms.TextBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.submitButton = new System.Windows.Forms.Button();
            this.coordButton = new System.Windows.Forms.Button();
            this.mangButton = new System.Windows.Forms.Button();
            this.equipmentTableAdapter = new backupLosGatos.GROUP6DataSetTableAdapters.EquipmentTableAdapter();
            this.usersTableAdapter = new backupLosGatos.GROUP6DataSetTableAdapters.UsersTableAdapter();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ticketIDLabel = new System.Windows.Forms.Label();
            welderSignatureLabel = new System.Windows.Forms.Label();
            inspectorSignatureLabel = new System.Windows.Forms.Label();
            additionalInformationLabel = new System.Windows.Forms.Label();
            equipmentIDLabel = new System.Windows.Forms.Label();
            dateSubmittedLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            associateIDLabel = new System.Windows.Forms.Label();
            this.pageOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingNavigator)).BeginInit();
            this.ticketsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketIDLabel
            // 
            ticketIDLabel.AutoSize = true;
            ticketIDLabel.Location = new System.Drawing.Point(32, 32);
            ticketIDLabel.Name = "ticketIDLabel";
            ticketIDLabel.Size = new System.Drawing.Size(65, 19);
            ticketIDLabel.TabIndex = 0;
            ticketIDLabel.Text = "Ticket #:";
            // 
            // welderSignatureLabel
            // 
            welderSignatureLabel.AutoSize = true;
            welderSignatureLabel.Location = new System.Drawing.Point(32, 36);
            welderSignatureLabel.Name = "welderSignatureLabel";
            welderSignatureLabel.Size = new System.Drawing.Size(63, 19);
            welderSignatureLabel.TabIndex = 0;
            welderSignatureLabel.Text = "Welder:";
            // 
            // inspectorSignatureLabel
            // 
            inspectorSignatureLabel.AutoSize = true;
            inspectorSignatureLabel.Location = new System.Drawing.Point(357, 32);
            inspectorSignatureLabel.Name = "inspectorSignatureLabel";
            inspectorSignatureLabel.Size = new System.Drawing.Size(76, 19);
            inspectorSignatureLabel.TabIndex = 2;
            inspectorSignatureLabel.Text = "Inspector:";
            // 
            // additionalInformationLabel
            // 
            additionalInformationLabel.Location = new System.Drawing.Point(32, 71);
            additionalInformationLabel.Name = "additionalInformationLabel";
            additionalInformationLabel.Size = new System.Drawing.Size(96, 59);
            additionalInformationLabel.TabIndex = 4;
            additionalInformationLabel.Text = "Additional Information:";
            // 
            // equipmentIDLabel
            // 
            equipmentIDLabel.AutoSize = true;
            equipmentIDLabel.Location = new System.Drawing.Point(32, 112);
            equipmentIDLabel.Name = "equipmentIDLabel";
            equipmentIDLabel.Size = new System.Drawing.Size(89, 19);
            equipmentIDLabel.TabIndex = 4;
            equipmentIDLabel.Text = "Equipment:";
            // 
            // dateSubmittedLabel
            // 
            dateSubmittedLabel.AutoSize = true;
            dateSubmittedLabel.Location = new System.Drawing.Point(656, 30);
            dateSubmittedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dateSubmittedLabel.Name = "dateSubmittedLabel";
            dateSubmittedLabel.Size = new System.Drawing.Size(84, 19);
            dateSubmittedLabel.TabIndex = 7;
            dateSubmittedLabel.Text = "Submitted:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(357, 30);
            statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(54, 19);
            statusLabel.TabIndex = 8;
            statusLabel.Text = "Status:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new System.Drawing.Point(357, 73);
            priorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(57, 19);
            priorityLabel.TabIndex = 10;
            priorityLabel.Text = "Priority:";
            // 
            // associateIDLabel
            // 
            associateIDLabel.AutoSize = true;
            associateIDLabel.Location = new System.Drawing.Point(357, 112);
            associateIDLabel.Name = "associateIDLabel";
            associateIDLabel.Size = new System.Drawing.Size(71, 19);
            associateIDLabel.TabIndex = 12;
            associateIDLabel.Text = "Assign To:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 49);
            this.label1.TabIndex = 9;
            this.label1.Text = "Weld Progress Tracking System";
            // 
            // pageOptions
            // 
            this.pageOptions.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pageOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardPage,
            this.ticketPage,
            this.viewKioskRequestToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.pageOptions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.pageOptions.Location = new System.Drawing.Point(0, 0);
            this.pageOptions.Name = "pageOptions";
            this.pageOptions.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.pageOptions.Size = new System.Drawing.Size(923, 28);
            this.pageOptions.TabIndex = 11;
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
            this.ticketPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ticketPage.Click += new System.EventHandler(this.ticketPage_Click);
            // 
            // viewKioskRequestToolStripMenuItem
            // 
            this.viewKioskRequestToolStripMenuItem.Name = "viewKioskRequestToolStripMenuItem";
            this.viewKioskRequestToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.viewKioskRequestToolStripMenuItem.Text = "View Kiosk Requests";
            this.viewKioskRequestToolStripMenuItem.Click += new System.EventHandler(this.viewKioskRequestToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.priorityText);
            this.groupBox1.Controls.Add(this.statusText);
            this.groupBox1.Controls.Add(this.equipText);
            this.groupBox1.Controls.Add(this.dateText);
            this.groupBox1.Controls.Add(associateIDLabel);
            this.groupBox1.Controls.Add(this.associateIDComboBox);
            this.groupBox1.Controls.Add(priorityLabel);
            this.groupBox1.Controls.Add(this.priorityCombo);
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(this.statusCombo);
            this.groupBox1.Controls.Add(dateSubmittedLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(equipmentIDLabel);
            this.groupBox1.Controls.Add(this.equipmentCombo);
            this.groupBox1.Controls.Add(this.unitIDText);
            this.groupBox1.Controls.Add(ticketIDLabel);
            this.groupBox1.Controls.Add(this.ticketIDText);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(872, 192);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket Information";
            // 
            // priorityText
            // 
            this.priorityText.Location = new System.Drawing.Point(443, 66);
            this.priorityText.Name = "priorityText";
            this.priorityText.ReadOnly = true;
            this.priorityText.Size = new System.Drawing.Size(189, 23);
            this.priorityText.TabIndex = 16;
            // 
            // statusText
            // 
            this.statusText.Location = new System.Drawing.Point(443, 30);
            this.statusText.Name = "statusText";
            this.statusText.ReadOnly = true;
            this.statusText.Size = new System.Drawing.Size(189, 23);
            this.statusText.TabIndex = 15;
            // 
            // equipText
            // 
            this.equipText.Location = new System.Drawing.Point(148, 112);
            this.equipText.Name = "equipText";
            this.equipText.ReadOnly = true;
            this.equipText.Size = new System.Drawing.Size(185, 23);
            this.equipText.TabIndex = 14;
            // 
            // dateText
            // 
            this.dateText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "dateSubmitted", true));
            this.dateText.Location = new System.Drawing.Point(747, 27);
            this.dateText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(100, 23);
            this.dateText.TabIndex = 7;
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
            // associateIDComboBox
            // 
            this.associateIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "associateID", true));
            this.associateIDComboBox.DisplayMember = "associateID";
            this.associateIDComboBox.FormattingEnabled = true;
            this.associateIDComboBox.Items.AddRange(new object[] {
            "Rebecca",
            "Michelle",
            "Shayne",
            "Francisco",
            "Jake"});
            this.associateIDComboBox.Location = new System.Drawing.Point(443, 110);
            this.associateIDComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.associateIDComboBox.Name = "associateIDComboBox";
            this.associateIDComboBox.Size = new System.Drawing.Size(189, 25);
            this.associateIDComboBox.TabIndex = 13;
            this.associateIDComboBox.ValueMember = "associateID";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.gROUP6DataSet;
            // 
            // priorityCombo
            // 
            this.priorityCombo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "priorityLevel", true));
            this.priorityCombo.FormattingEnabled = true;
            this.priorityCombo.Location = new System.Drawing.Point(443, 66);
            this.priorityCombo.Margin = new System.Windows.Forms.Padding(4);
            this.priorityCombo.Name = "priorityCombo";
            this.priorityCombo.Size = new System.Drawing.Size(189, 25);
            this.priorityCombo.TabIndex = 11;
            // 
            // statusCombo
            // 
            this.statusCombo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "status", true));
            this.statusCombo.FormattingEnabled = true;
            this.statusCombo.Location = new System.Drawing.Point(443, 28);
            this.statusCombo.Margin = new System.Windows.Forms.Padding(4);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(189, 25);
            this.statusCombo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Unit:";
            // 
            // equipmentCombo
            // 
            this.equipmentCombo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "equipmentID", true));
            this.equipmentCombo.DisplayMember = "equipmentID";
            this.equipmentCombo.FormattingEnabled = true;
            this.equipmentCombo.Items.AddRange(new object[] {
            "Vessel",
            "Hydrotreater",
            "Condenser",
            "Pump",
            "Water Boiler",
            "Heat Exchanger",
            "Distillation Column",
            "Compressor",
            "Process Drain",
            "Hydraulic Jack"});
            this.equipmentCombo.Location = new System.Drawing.Point(148, 110);
            this.equipmentCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.equipmentCombo.Name = "equipmentCombo";
            this.equipmentCombo.Size = new System.Drawing.Size(185, 25);
            this.equipmentCombo.TabIndex = 5;
            this.equipmentCombo.ValueMember = "equipmentID";
            // 
            // unitIDText
            // 
            this.unitIDText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "unitID", true));
            this.unitIDText.Location = new System.Drawing.Point(148, 69);
            this.unitIDText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unitIDText.Name = "unitIDText";
            this.unitIDText.Size = new System.Drawing.Size(185, 23);
            this.unitIDText.TabIndex = 3;
            this.unitIDText.TextChanged += new System.EventHandler(this.unitIDText_TextChanged);
            // 
            // ticketIDText
            // 
            this.ticketIDText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "ticketID", true));
            this.ticketIDText.Location = new System.Drawing.Point(148, 30);
            this.ticketIDText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ticketIDText.Name = "ticketIDText";
            this.ticketIDText.ReadOnly = true;
            this.ticketIDText.Size = new System.Drawing.Size(185, 23);
            this.ticketIDText.TabIndex = 1;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.gROUP6DataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(additionalInformationLabel);
            this.groupBox2.Controls.Add(this.additionalInformationText);
            this.groupBox2.Controls.Add(inspectorSignatureLabel);
            this.groupBox2.Controls.Add(this.inspectorSignatureText);
            this.groupBox2.Controls.Add(welderSignatureLabel);
            this.groupBox2.Controls.Add(this.welderSignatureText);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 265);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(872, 199);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detailed Information";
            // 
            // additionalInformationText
            // 
            this.additionalInformationText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "dateSubmitted", true));
            this.additionalInformationText.Location = new System.Drawing.Point(148, 68);
            this.additionalInformationText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.additionalInformationText.Multiline = true;
            this.additionalInformationText.Name = "additionalInformationText";
            this.additionalInformationText.Size = new System.Drawing.Size(699, 112);
            this.additionalInformationText.TabIndex = 5;
            // 
            // inspectorSignatureText
            // 
            this.inspectorSignatureText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "inspectorSignature", true));
            this.inspectorSignatureText.Location = new System.Drawing.Point(443, 30);
            this.inspectorSignatureText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inspectorSignatureText.Name = "inspectorSignatureText";
            this.inspectorSignatureText.Size = new System.Drawing.Size(189, 23);
            this.inspectorSignatureText.TabIndex = 3;
            // 
            // welderSignatureText
            // 
            this.welderSignatureText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "welderSignature", true));
            this.welderSignatureText.Location = new System.Drawing.Point(148, 32);
            this.welderSignatureText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.welderSignatureText.Name = "welderSignatureText";
            this.welderSignatureText.Size = new System.Drawing.Size(185, 23);
            this.welderSignatureText.TabIndex = 1;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.KioskTableAdapter = null;
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
            this.ticketsBindingNavigator.Location = new System.Drawing.Point(0, 28);
            this.ticketsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ticketsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ticketsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ticketsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ticketsBindingNavigator.Name = "ticketsBindingNavigator";
            this.ticketsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ticketsBindingNavigator.Size = new System.Drawing.Size(923, 27);
            this.ticketsBindingNavigator.TabIndex = 14;
            this.ticketsBindingNavigator.Text = "bindingNavigator1";
            this.ticketsBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.ticketsBindingNavigatorSaveItem.Name = "ticketsBindingNavigatorSaveItem";
            this.ticketsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.ticketsBindingNavigatorSaveItem.Text = "Save Data";
            this.ticketsBindingNavigatorSaveItem.Click += new System.EventHandler(this.ticketsBindingNavigatorSaveItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(679, 4);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(168, 34);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(503, 4);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(168, 34);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Edit Ticket";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.submitButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Location = new System.Drawing.Point(23, 465);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 60);
            this.panel1.TabIndex = 18;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(327, 4);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(168, 34);
            this.submitButton.TabIndex = 18;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // coordButton
            // 
            this.coordButton.Location = new System.Drawing.Point(868, 28);
            this.coordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coordButton.Name = "coordButton";
            this.coordButton.Size = new System.Drawing.Size(55, 23);
            this.coordButton.TabIndex = 19;
            this.coordButton.Text = "coord";
            this.coordButton.UseVisualStyleBackColor = true;
            this.coordButton.Visible = false;
            // 
            // mangButton
            // 
            this.mangButton.Location = new System.Drawing.Point(868, 57);
            this.mangButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mangButton.Name = "mangButton";
            this.mangButton.Size = new System.Drawing.Size(55, 23);
            this.mangButton.TabIndex = 20;
            this.mangButton.Text = "mang";
            this.mangButton.UseVisualStyleBackColor = true;
            this.mangButton.Visible = false;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 26);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 21;
            this.dateTimePicker.Visible = false;
            // 
            // ticketDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(923, 540);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mangButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.coordButton);
            this.Controls.Add(this.ticketsBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pageOptions);
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
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingNavigator)).EndInit();
            this.ticketsBindingNavigator.ResumeLayout(false);
            this.ticketsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip pageOptions;
        private System.Windows.Forms.ToolStripMenuItem dashboardPage;
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
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox statusCombo;
        public System.Windows.Forms.ComboBox priorityCombo;
        public System.Windows.Forms.TextBox unitIDText;
        public System.Windows.Forms.TextBox ticketIDText;
        public System.Windows.Forms.ComboBox equipmentCombo;
        public System.Windows.Forms.TextBox additionalInformationText;
        public System.Windows.Forms.TextBox inspectorSignatureText;
        public System.Windows.Forms.TextBox welderSignatureText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button submitButton;
        public System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.Button updateButton;
        public System.Windows.Forms.Button coordButton;
        public System.Windows.Forms.Button mangButton;
        private System.Windows.Forms.ToolStripMenuItem viewKioskRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private GROUP6DataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private GROUP6DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ComboBox associateIDComboBox;
        public System.Windows.Forms.TextBox dateText;
        public System.Windows.Forms.ToolStripMenuItem ticketPage;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        public System.Windows.Forms.TextBox priorityText;
        public System.Windows.Forms.TextBox statusText;
        public System.Windows.Forms.TextBox equipText;
    }
}
