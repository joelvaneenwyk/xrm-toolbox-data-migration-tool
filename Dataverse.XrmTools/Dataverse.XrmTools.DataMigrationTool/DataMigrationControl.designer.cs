﻿namespace Dataverse.XrmTools.DataMigrationTool
{
    partial class DataMigrationControl
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataMigrationControl));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbRefreshTables = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPreview = new System.Windows.Forms.ToolStripButton();
            this.tsmiExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExportData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExportSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExportWithSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImportData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImportSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImportLastFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAbort = new System.Windows.Forms.ToolStripButton();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSettings = new System.Windows.Forms.TableLayoutPanel();
            this.gbEnvironments = new System.Windows.Forms.GroupBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblSourceValue = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblTargetValue = new System.Windows.Forms.Label();
            this.btnSelectTarget = new System.Windows.Forms.Button();
            this.gbViewSettings = new System.Windows.Forms.GroupBox();
            this.cbHideInvalid = new System.Windows.Forms.CheckBox();
            this.gbMappingSettings = new System.Windows.Forms.GroupBox();
            this.rbMapOnImport = new System.Windows.Forms.RadioButton();
            this.rbMapOnExport = new System.Windows.Forms.RadioButton();
            this.lblApplyMappingsOn = new System.Windows.Forms.Label();
            this.cbMapUsers = new System.Windows.Forms.CheckBox();
            this.cbMapTeams = new System.Windows.Forms.CheckBox();
            this.cbMapBu = new System.Windows.Forms.CheckBox();
            this.btnMappings = new System.Windows.Forms.Button();
            this.gbOpSettings = new System.Windows.Forms.GroupBox();
            this.cbCreate = new System.Windows.Forms.CheckBox();
            this.cbUpdate = new System.Windows.Forms.CheckBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.lblBatchCount = new System.Windows.Forms.Label();
            this.nudBatchCount = new System.Windows.Forms.NumericUpDown();
            this.pnlBody = new System.Windows.Forms.TableLayoutPanel();
            this.gbTables = new System.Windows.Forms.GroupBox();
            this.lblTableFilter = new System.Windows.Forms.Label();
            this.txtTableFilter = new System.Windows.Forms.TextBox();
            this.lvTables = new System.Windows.Forms.ListView();
            this.chTblLogicalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTblDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbAttributes = new System.Windows.Forms.GroupBox();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.lvAttributes = new System.Windows.Forms.ListView();
            this.chAttrLogicalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAttrDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAttrType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAttrDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.lblFetchDescription = new System.Windows.Forms.Label();
            this.btnFetchXmlBuilder = new System.Windows.Forms.Button();
            this.rtbFilter = new System.Windows.Forms.RichTextBox();
            this.tsMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.gbEnvironments.SuspendLayout();
            this.gbViewSettings.SuspendLayout();
            this.gbMappingSettings.SuspendLayout();
            this.gbOpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBatchCount)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.gbTables.SuspendLayout();
            this.gbAttributes.SuspendLayout();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.AutoSize = false;
            this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRefreshTables,
            this.tsSeparator1,
            this.tsbPreview,
            this.tsmiExport,
            this.tsmiImport,
            this.tsbAbort});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(2147, 31);
            this.tsMain.TabIndex = 90;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbRefreshTables
            // 
            this.tsbRefreshTables.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tsbRefreshTables.Image = global::Dataverse.XrmTools.DataMigrationTool.Properties.Resources.database;
            this.tsbRefreshTables.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefreshTables.Name = "tsbRefreshTables";
            this.tsbRefreshTables.Size = new System.Drawing.Size(103, 28);
            this.tsbRefreshTables.Text = "Load Tables";
            this.tsbRefreshTables.Click += new System.EventHandler(this.tsbRefreshTables_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbPreview
            // 
            this.tsbPreview.Enabled = false;
            this.tsbPreview.Image = global::Dataverse.XrmTools.DataMigrationTool.Properties.Resources.preview;
            this.tsbPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPreview.Name = "tsbPreview";
            this.tsbPreview.Size = new System.Drawing.Size(84, 28);
            this.tsbPreview.Text = "Preview";
            this.tsbPreview.Click += new System.EventHandler(this.tsbPreview_Click);
            // 
            // tsmiExport
            // 
            this.tsmiExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExportData,
            this.tsmiExportSettings,
            this.tsmiExportWithSettings});
            this.tsmiExport.Enabled = false;
            this.tsmiExport.Image = global::Dataverse.XrmTools.DataMigrationTool.Properties.Resources.export;
            this.tsmiExport.Name = "tsmiExport";
            this.tsmiExport.Size = new System.Drawing.Size(86, 31);
            this.tsmiExport.Text = "Export";
            // 
            // tsmiExportData
            // 
            this.tsmiExportData.Enabled = false;
            this.tsmiExportData.Name = "tsmiExportData";
            this.tsmiExportData.Size = new System.Drawing.Size(249, 26);
            this.tsmiExportData.Text = "Data";
            this.tsmiExportData.Click += new System.EventHandler(this.tsmiExportData_Click);
            // 
            // tsmiExportSettings
            // 
            this.tsmiExportSettings.Enabled = false;
            this.tsmiExportSettings.Name = "tsmiExportSettings";
            this.tsmiExportSettings.Size = new System.Drawing.Size(249, 26);
            this.tsmiExportSettings.Text = "Table Settings";
            this.tsmiExportSettings.Click += new System.EventHandler(this.tsmiExportSettings_Click);
            // 
            // tsmiExportWithSettings
            // 
            this.tsmiExportWithSettings.Enabled = false;
            this.tsmiExportWithSettings.Name = "tsmiExportWithSettings";
            this.tsmiExportWithSettings.Size = new System.Drawing.Size(249, 26);
            this.tsmiExportWithSettings.Text = "Data and Table Settings";
            this.tsmiExportWithSettings.Click += new System.EventHandler(this.tsmiExportWithSettings_Click);
            // 
            // tsmiImport
            // 
            this.tsmiImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiImportData,
            this.tsmiImportSettings,
            this.tsmiImportLastFile});
            this.tsmiImport.Image = global::Dataverse.XrmTools.DataMigrationTool.Properties.Resources.import;
            this.tsmiImport.Name = "tsmiImport";
            this.tsmiImport.Size = new System.Drawing.Size(88, 31);
            this.tsmiImport.Text = "Import";
            // 
            // tsmiImportData
            // 
            this.tsmiImportData.Enabled = false;
            this.tsmiImportData.Name = "tsmiImportData";
            this.tsmiImportData.Size = new System.Drawing.Size(217, 26);
            this.tsmiImportData.Text = "Data";
            this.tsmiImportData.Click += new System.EventHandler(this.tsmiImportData_Click);
            // 
            // tsmiImportSettings
            // 
            this.tsmiImportSettings.Name = "tsmiImportSettings";
            this.tsmiImportSettings.Size = new System.Drawing.Size(217, 26);
            this.tsmiImportSettings.Text = "Settings from file";
            this.tsmiImportSettings.Click += new System.EventHandler(this.tsmiImportSettings_Click);
            // 
            // tsmiImportLastFile
            // 
            this.tsmiImportLastFile.Enabled = false;
            this.tsmiImportLastFile.Name = "tsmiImportLastFile";
            this.tsmiImportLastFile.Size = new System.Drawing.Size(217, 26);
            this.tsmiImportLastFile.Text = "From last exported";
            this.tsmiImportLastFile.Click += new System.EventHandler(this.tsmiImportLastFile_Click);
            // 
            // tsbAbort
            // 
            this.tsbAbort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAbort.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbort.Image")));
            this.tsbAbort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbort.Name = "tsbAbort";
            this.tsbAbort.Size = new System.Drawing.Size(51, 28);
            this.tsbAbort.Text = "Abort";
            this.tsbAbort.Visible = false;
            this.tsbAbort.Click += new System.EventHandler(this.tsbAbort_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.ColumnCount = 2;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.pnlMain.Controls.Add(this.pnlSettings, 0, 0);
            this.pnlMain.Controls.Add(this.pnlBody, 1, 0);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 31);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 1;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMain.Size = new System.Drawing.Size(2147, 939);
            this.pnlMain.TabIndex = 91;
            // 
            // pnlSettings
            // 
            this.pnlSettings.ColumnCount = 1;
            this.pnlSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSettings.Controls.Add(this.gbEnvironments, 0, 0);
            this.pnlSettings.Controls.Add(this.gbMappingSettings, 0, 1);
            this.pnlSettings.Controls.Add(this.gbOpSettings, 0, 2);
            this.pnlSettings.Controls.Add(this.gbViewSettings, 0, 3);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettings.Location = new System.Drawing.Point(3, 2);
            this.pnlSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.RowCount = 4;
            this.pnlSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSettings.Size = new System.Drawing.Size(316, 935);
            this.pnlSettings.TabIndex = 0;
            // 
            // gbEnvironments
            // 
            this.gbEnvironments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEnvironments.Controls.Add(this.lblSource);
            this.gbEnvironments.Controls.Add(this.lblSourceValue);
            this.gbEnvironments.Controls.Add(this.lblTarget);
            this.gbEnvironments.Controls.Add(this.lblTargetValue);
            this.gbEnvironments.Controls.Add(this.btnSelectTarget);
            this.gbEnvironments.Location = new System.Drawing.Point(3, 2);
            this.gbEnvironments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEnvironments.Name = "gbEnvironments";
            this.gbEnvironments.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEnvironments.Size = new System.Drawing.Size(310, 135);
            this.gbEnvironments.TabIndex = 0;
            this.gbEnvironments.TabStop = false;
            this.gbEnvironments.Text = "Environments";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(5, 30);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(50, 16);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source";
            // 
            // lblSourceValue
            // 
            this.lblSourceValue.AutoSize = true;
            this.lblSourceValue.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSourceValue.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSourceValue.Location = new System.Drawing.Point(81, 27);
            this.lblSourceValue.Name = "lblSourceValue";
            this.lblSourceValue.Size = new System.Drawing.Size(91, 19);
            this.lblSourceValue.TabIndex = 1;
            this.lblSourceValue.Text = "Disconnected";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(5, 59);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(47, 16);
            this.lblTarget.TabIndex = 2;
            this.lblTarget.Text = "Target";
            // 
            // lblTargetValue
            // 
            this.lblTargetValue.AutoSize = true;
            this.lblTargetValue.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTargetValue.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTargetValue.Location = new System.Drawing.Point(81, 57);
            this.lblTargetValue.Name = "lblTargetValue";
            this.lblTargetValue.Size = new System.Drawing.Size(91, 19);
            this.lblTargetValue.TabIndex = 3;
            this.lblTargetValue.Text = "Disconnected";
            // 
            // btnSelectTarget
            // 
            this.btnSelectTarget.FlatAppearance.BorderSize = 0;
            this.btnSelectTarget.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectTarget.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelectTarget.Image = global::Dataverse.XrmTools.DataMigrationTool.Properties.Resources.connect16_colorful;
            this.btnSelectTarget.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectTarget.Location = new System.Drawing.Point(9, 92);
            this.btnSelectTarget.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectTarget.Name = "btnSelectTarget";
            this.btnSelectTarget.Size = new System.Drawing.Size(235, 34);
            this.btnSelectTarget.TabIndex = 4;
            this.btnSelectTarget.Text = "Connect Target";
            this.btnSelectTarget.UseVisualStyleBackColor = true;
            this.btnSelectTarget.Click += new System.EventHandler(this.btnSelectTarget_Click);
            // 
            // gbViewSettings
            // 
            this.gbViewSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbViewSettings.Controls.Add(this.cbHideInvalid);
            this.gbViewSettings.Location = new System.Drawing.Point(3, 141);
            this.gbViewSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbViewSettings.Name = "gbViewSettings";
            this.gbViewSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbViewSettings.Size = new System.Drawing.Size(310, 68);
            this.gbViewSettings.TabIndex = 0;
            this.gbViewSettings.TabStop = false;
            this.gbViewSettings.Text = "View Settings";
            // 
            // cbHideInvalid
            // 
            this.cbHideInvalid.AutoSize = true;
            this.cbHideInvalid.Checked = true;
            this.cbHideInvalid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHideInvalid.Location = new System.Drawing.Point(7, 26);
            this.cbHideInvalid.Margin = new System.Windows.Forms.Padding(4);
            this.cbHideInvalid.Name = "cbHideInvalid";
            this.cbHideInvalid.Size = new System.Drawing.Size(158, 20);
            this.cbHideInvalid.TabIndex = 0;
            this.cbHideInvalid.Text = "Hide Invalid Attributes";
            this.cbHideInvalid.UseVisualStyleBackColor = true;
            this.cbHideInvalid.CheckedChanged += new System.EventHandler(this.cbHideInvalid_CheckedChanged);
            // 
            // gbMappingSettings
            // 
            this.gbMappingSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMappingSettings.Controls.Add(this.rbMapOnImport);
            this.gbMappingSettings.Controls.Add(this.rbMapOnExport);
            this.gbMappingSettings.Controls.Add(this.lblApplyMappingsOn);
            this.gbMappingSettings.Controls.Add(this.cbMapUsers);
            this.gbMappingSettings.Controls.Add(this.cbMapTeams);
            this.gbMappingSettings.Controls.Add(this.cbMapBu);
            this.gbMappingSettings.Controls.Add(this.btnMappings);
            this.gbMappingSettings.Enabled = false;
            this.gbMappingSettings.Location = new System.Drawing.Point(3, 213);
            this.gbMappingSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMappingSettings.Name = "gbMappingSettings";
            this.gbMappingSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMappingSettings.Size = new System.Drawing.Size(310, 254);
            this.gbMappingSettings.TabIndex = 0;
            this.gbMappingSettings.TabStop = false;
            this.gbMappingSettings.Text = "Mapping Settings";
            // 
            // rbMapOnImport
            // 
            this.rbMapOnImport.AutoSize = true;
            this.rbMapOnImport.Location = new System.Drawing.Point(83, 130);
            this.rbMapOnImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMapOnImport.Name = "rbMapOnImport";
            this.rbMapOnImport.Size = new System.Drawing.Size(65, 20);
            this.rbMapOnImport.TabIndex = 105;
            this.rbMapOnImport.Text = "Import";
            this.rbMapOnImport.UseVisualStyleBackColor = true;
            // 
            // rbMapOnExport
            // 
            this.rbMapOnExport.AutoSize = true;
            this.rbMapOnExport.Checked = true;
            this.rbMapOnExport.Location = new System.Drawing.Point(8, 130);
            this.rbMapOnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMapOnExport.Name = "rbMapOnExport";
            this.rbMapOnExport.Size = new System.Drawing.Size(66, 20);
            this.rbMapOnExport.TabIndex = 104;
            this.rbMapOnExport.TabStop = true;
            this.rbMapOnExport.Text = "Export";
            this.rbMapOnExport.UseVisualStyleBackColor = true;
            // 
            // lblApplyMappingsOn
            // 
            this.lblApplyMappingsOn.AutoSize = true;
            this.lblApplyMappingsOn.Location = new System.Drawing.Point(5, 111);
            this.lblApplyMappingsOn.Name = "lblApplyMappingsOn";
            this.lblApplyMappingsOn.Size = new System.Drawing.Size(126, 16);
            this.lblApplyMappingsOn.TabIndex = 103;
            this.lblApplyMappingsOn.Text = "Apply Mappings on:";
            // 
            // cbMapUsers
            // 
            this.cbMapUsers.AutoSize = true;
            this.cbMapUsers.Location = new System.Drawing.Point(8, 26);
            this.cbMapUsers.Margin = new System.Windows.Forms.Padding(4);
            this.cbMapUsers.Name = "cbMapUsers";
            this.cbMapUsers.Size = new System.Drawing.Size(185, 20);
            this.cbMapUsers.TabIndex = 1;
            this.cbMapUsers.Text = "Map Users by User Name";
            this.cbMapUsers.UseVisualStyleBackColor = true;
            this.cbMapUsers.CheckedChanged += new System.EventHandler(this.cbMapOption_CheckedChanged);
            // 
            // cbMapTeams
            // 
            this.cbMapTeams.AutoSize = true;
            this.cbMapTeams.Location = new System.Drawing.Point(8, 54);
            this.cbMapTeams.Margin = new System.Windows.Forms.Padding(4);
            this.cbMapTeams.Name = "cbMapTeams";
            this.cbMapTeams.Size = new System.Drawing.Size(160, 20);
            this.cbMapTeams.TabIndex = 2;
            this.cbMapTeams.Text = "Map Teams by Name";
            this.cbMapTeams.UseVisualStyleBackColor = true;
            this.cbMapTeams.CheckedChanged += new System.EventHandler(this.cbMapOption_CheckedChanged);
            // 
            // cbMapBu
            // 
            this.cbMapBu.AutoSize = true;
            this.cbMapBu.Checked = true;
            this.cbMapBu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMapBu.Location = new System.Drawing.Point(8, 82);
            this.cbMapBu.Margin = new System.Windows.Forms.Padding(4);
            this.cbMapBu.Name = "cbMapBu";
            this.cbMapBu.Size = new System.Drawing.Size(172, 20);
            this.cbMapBu.TabIndex = 3;
            this.cbMapBu.Text = "Map Root Business Unit";
            this.cbMapBu.UseVisualStyleBackColor = true;
            this.cbMapBu.CheckedChanged += new System.EventHandler(this.cbMapOption_CheckedChanged);
            // 
            // btnMappings
            // 
            this.btnMappings.FlatAppearance.BorderSize = 0;
            this.btnMappings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMappings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMappings.Image = global::Dataverse.XrmTools.DataMigrationTool.Properties.Resources.mapping20_colorful;
            this.btnMappings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMappings.Location = new System.Drawing.Point(9, 178);
            this.btnMappings.Margin = new System.Windows.Forms.Padding(4);
            this.btnMappings.Name = "btnMappings";
            this.btnMappings.Size = new System.Drawing.Size(235, 34);
            this.btnMappings.TabIndex = 102;
            this.btnMappings.Text = "Mappings";
            this.btnMappings.UseVisualStyleBackColor = true;
            this.btnMappings.Click += new System.EventHandler(this.btnMappings_Click);
            // 
            // gbOpSettings
            // 
            this.gbOpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOpSettings.Controls.Add(this.cbCreate);
            this.gbOpSettings.Controls.Add(this.cbUpdate);
            this.gbOpSettings.Controls.Add(this.cbDelete);
            this.gbOpSettings.Controls.Add(this.lblBatchCount);
            this.gbOpSettings.Controls.Add(this.nudBatchCount);
            this.gbOpSettings.Enabled = false;
            this.gbOpSettings.Location = new System.Drawing.Point(4, 589);
            this.gbOpSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOpSettings.Name = "gbOpSettings";
            this.gbOpSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOpSettings.Size = new System.Drawing.Size(310, 169);
            this.gbOpSettings.TabIndex = 2;
            this.gbOpSettings.TabStop = false;
            this.gbOpSettings.Text = "Operation Settings";
            // 
            // cbCreate
            // 
            this.cbCreate.AutoSize = true;
            this.cbCreate.Checked = true;
            this.cbCreate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCreate.Location = new System.Drawing.Point(7, 26);
            this.cbCreate.Margin = new System.Windows.Forms.Padding(4);
            this.cbCreate.Name = "cbCreate";
            this.cbCreate.Size = new System.Drawing.Size(69, 20);
            this.cbCreate.TabIndex = 0;
            this.cbCreate.Text = "Create";
            this.cbCreate.UseVisualStyleBackColor = true;
            // 
            // cbUpdate
            // 
            this.cbUpdate.AutoSize = true;
            this.cbUpdate.Checked = true;
            this.cbUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpdate.Location = new System.Drawing.Point(7, 55);
            this.cbUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(74, 20);
            this.cbUpdate.TabIndex = 1;
            this.cbUpdate.Text = "Update";
            this.cbUpdate.UseVisualStyleBackColor = true;
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Enabled = false;
            this.cbDelete.Location = new System.Drawing.Point(7, 84);
            this.cbDelete.Margin = new System.Windows.Forms.Padding(4);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(83, 20);
            this.cbDelete.TabIndex = 2;
            this.cbDelete.Text = "Delete (!)";
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // lblBatchCount
            // 
            this.lblBatchCount.AutoSize = true;
            this.lblBatchCount.Location = new System.Drawing.Point(5, 121);
            this.lblBatchCount.Name = "lblBatchCount";
            this.lblBatchCount.Size = new System.Drawing.Size(71, 16);
            this.lblBatchCount.TabIndex = 3;
            this.lblBatchCount.Text = "Batch size:";
            // 
            // nudBatchCount
            // 
            this.nudBatchCount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudBatchCount.Location = new System.Drawing.Point(99, 119);
            this.nudBatchCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudBatchCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudBatchCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudBatchCount.Name = "nudBatchCount";
            this.nudBatchCount.Size = new System.Drawing.Size(100, 22);
            this.nudBatchCount.TabIndex = 4;
            this.nudBatchCount.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // pnlBody
            // 
            this.pnlBody.ColumnCount = 1;
            this.pnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlBody.Controls.Add(this.gbTables, 0, 0);
            this.pnlBody.Controls.Add(this.gbAttributes, 0, 1);
            this.pnlBody.Controls.Add(this.gbFilters, 0, 2);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(325, 2);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.RowCount = 3;
            this.pnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlBody.Size = new System.Drawing.Size(1819, 935);
            this.pnlBody.TabIndex = 1;
            // 
            // gbTables
            // 
            this.gbTables.Controls.Add(this.lblTableFilter);
            this.gbTables.Controls.Add(this.txtTableFilter);
            this.gbTables.Controls.Add(this.lvTables);
            this.gbTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTables.Enabled = false;
            this.gbTables.Location = new System.Drawing.Point(3, 2);
            this.gbTables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTables.Name = "gbTables";
            this.gbTables.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTables.Size = new System.Drawing.Size(1813, 370);
            this.gbTables.TabIndex = 0;
            this.gbTables.TabStop = false;
            this.gbTables.Text = "Tables";
            // 
            // lblTableFilter
            // 
            this.lblTableFilter.AutoSize = true;
            this.lblTableFilter.Location = new System.Drawing.Point(7, 25);
            this.lblTableFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableFilter.Name = "lblTableFilter";
            this.lblTableFilter.Size = new System.Drawing.Size(39, 16);
            this.lblTableFilter.TabIndex = 0;
            this.lblTableFilter.Text = "Filter:";
            // 
            // txtTableFilter
            // 
            this.txtTableFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTableFilter.Location = new System.Drawing.Point(64, 21);
            this.txtTableFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtTableFilter.Name = "txtTableFilter";
            this.txtTableFilter.Size = new System.Drawing.Size(1742, 22);
            this.txtTableFilter.TabIndex = 1;
            this.txtTableFilter.TextChanged += new System.EventHandler(this.txtTableFilter_TextChanged);
            // 
            // lvTables
            // 
            this.lvTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTblLogicalName,
            this.chTblDisplayName});
            this.lvTables.FullRowSelect = true;
            this.lvTables.HideSelection = false;
            this.lvTables.Location = new System.Drawing.Point(9, 54);
            this.lvTables.Margin = new System.Windows.Forms.Padding(4);
            this.lvTables.MultiSelect = false;
            this.lvTables.Name = "lvTables";
            this.lvTables.Size = new System.Drawing.Size(1797, 309);
            this.lvTables.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvTables.TabIndex = 2;
            this.lvTables.UseCompatibleStateImageBehavior = false;
            this.lvTables.View = System.Windows.Forms.View.Details;
            this.lvTables.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.lvTables.SelectedIndexChanged += new System.EventHandler(this.lvTables_SelectedIndexChanged);
            this.lvTables.Resize += new System.EventHandler(this.lvTables_Resize);
            // 
            // chTblLogicalName
            // 
            this.chTblLogicalName.Text = "Logical Name";
            this.chTblLogicalName.Width = 200;
            // 
            // chTblDisplayName
            // 
            this.chTblDisplayName.Text = "Display Name";
            this.chTblDisplayName.Width = 200;
            // 
            // gbAttributes
            // 
            this.gbAttributes.Controls.Add(this.cbSelectAll);
            this.gbAttributes.Controls.Add(this.lvAttributes);
            this.gbAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAttributes.Location = new System.Drawing.Point(3, 376);
            this.gbAttributes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAttributes.Name = "gbAttributes";
            this.gbAttributes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAttributes.Size = new System.Drawing.Size(1813, 370);
            this.gbAttributes.TabIndex = 1;
            this.gbAttributes.TabStop = false;
            this.gbAttributes.Text = "Attributes";
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.Checked = true;
            this.cbSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSelectAll.Location = new System.Drawing.Point(8, 26);
            this.cbSelectAll.Margin = new System.Windows.Forms.Padding(4);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(142, 20);
            this.cbSelectAll.TabIndex = 0;
            this.cbSelectAll.Text = "Select/Unselect All";
            this.cbSelectAll.UseVisualStyleBackColor = true;
            this.cbSelectAll.CheckedChanged += new System.EventHandler(this.cbAllAttributes_CheckedChanged);
            // 
            // lvAttributes
            // 
            this.lvAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAttributes.CheckBoxes = true;
            this.lvAttributes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAttrLogicalName,
            this.chAttrDisplayName,
            this.chAttrType,
            this.chAttrDescription});
            this.lvAttributes.FullRowSelect = true;
            this.lvAttributes.HideSelection = false;
            this.lvAttributes.Location = new System.Drawing.Point(8, 54);
            this.lvAttributes.Margin = new System.Windows.Forms.Padding(4);
            this.lvAttributes.Name = "lvAttributes";
            this.lvAttributes.Size = new System.Drawing.Size(1798, 309);
            this.lvAttributes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAttributes.TabIndex = 3;
            this.lvAttributes.UseCompatibleStateImageBehavior = false;
            this.lvAttributes.View = System.Windows.Forms.View.Details;
            this.lvAttributes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.lvAttributes.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvAttributes_ItemChecked);
            this.lvAttributes.Resize += new System.EventHandler(this.lvAttributes_Resize);
            // 
            // chAttrLogicalName
            // 
            this.chAttrLogicalName.Text = "Logical Name";
            this.chAttrLogicalName.Width = 200;
            // 
            // chAttrDisplayName
            // 
            this.chAttrDisplayName.Text = "Display Name";
            this.chAttrDisplayName.Width = 200;
            // 
            // chAttrType
            // 
            this.chAttrType.Text = "Type";
            this.chAttrType.Width = 160;
            // 
            // chAttrDescription
            // 
            this.chAttrDescription.Text = "Description";
            this.chAttrDescription.Width = 300;
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.lblFetchDescription);
            this.gbFilters.Controls.Add(this.btnFetchXmlBuilder);
            this.gbFilters.Controls.Add(this.rtbFilter);
            this.gbFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFilters.Location = new System.Drawing.Point(3, 750);
            this.gbFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFilters.Size = new System.Drawing.Size(1813, 183);
            this.gbFilters.TabIndex = 2;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // lblFetchDescription
            // 
            this.lblFetchDescription.AutoSize = true;
            this.lblFetchDescription.Location = new System.Drawing.Point(8, 23);
            this.lblFetchDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFetchDescription.Name = "lblFetchDescription";
            this.lblFetchDescription.Size = new System.Drawing.Size(292, 16);
            this.lblFetchDescription.TabIndex = 0;
            this.lblFetchDescription.Text = "Records will be filtered using query defined here";
            // 
            // btnFetchXmlBuilder
            // 
            this.btnFetchXmlBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFetchXmlBuilder.FlatAppearance.BorderSize = 0;
            this.btnFetchXmlBuilder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFetchXmlBuilder.Image = global::Dataverse.XrmTools.DataMigrationTool.Properties.Resources.fetchXmlBuilder20;
            this.btnFetchXmlBuilder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFetchXmlBuilder.Location = new System.Drawing.Point(1546, 14);
            this.btnFetchXmlBuilder.Margin = new System.Windows.Forms.Padding(4);
            this.btnFetchXmlBuilder.Name = "btnFetchXmlBuilder";
            this.btnFetchXmlBuilder.Size = new System.Drawing.Size(259, 34);
            this.btnFetchXmlBuilder.TabIndex = 1;
            this.btnFetchXmlBuilder.Text = "Edit in FetchXML Builder";
            this.btnFetchXmlBuilder.UseVisualStyleBackColor = true;
            this.btnFetchXmlBuilder.Click += new System.EventHandler(this.btnFetchXmlBuilder_Click);
            // 
            // rtbFilter
            // 
            this.rtbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFilter.Location = new System.Drawing.Point(8, 52);
            this.rtbFilter.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.rtbFilter.Name = "rtbFilter";
            this.rtbFilter.Size = new System.Drawing.Size(1795, 120);
            this.rtbFilter.TabIndex = 2;
            this.rtbFilter.Text = "";
            this.rtbFilter.TextChanged += new System.EventHandler(this.rtbFilter_TextChanged);
            // 
            // DataMigrationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.tsMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "DataMigrationControl";
            this.Size = new System.Drawing.Size(2147, 970);
            this.Load += new System.EventHandler(this.DataMigrationControl_Load);
            this.Resize += new System.EventHandler(this.DataMigrationControl_Resize);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.gbEnvironments.ResumeLayout(false);
            this.gbEnvironments.PerformLayout();
            this.gbViewSettings.ResumeLayout(false);
            this.gbViewSettings.PerformLayout();
            this.gbMappingSettings.ResumeLayout(false);
            this.gbMappingSettings.PerformLayout();
            this.gbOpSettings.ResumeLayout(false);
            this.gbOpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBatchCount)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.gbTables.ResumeLayout(false);
            this.gbTables.PerformLayout();
            this.gbAttributes.ResumeLayout(false);
            this.gbAttributes.PerformLayout();
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        // Main Tool Strip
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbRefreshTables;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripButton tsbPreview;
        private System.Windows.Forms.ToolStripMenuItem tsmiExport;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportData;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportWithSettings;
        private System.Windows.Forms.ToolStripButton tsbAbort;

        // Main panel
        private System.Windows.Forms.TableLayoutPanel pnlMain;

        // Settings
        private System.Windows.Forms.TableLayoutPanel pnlSettings;

        // Environment settings group
        private System.Windows.Forms.GroupBox gbEnvironments;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblSourceValue;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblTargetValue;
        private System.Windows.Forms.Button btnSelectTarget;

        // View settings group
        private System.Windows.Forms.GroupBox gbViewSettings;
        private System.Windows.Forms.CheckBox cbHideInvalid;

        // Organization settings group
        private System.Windows.Forms.GroupBox gbMappingSettings;
        private System.Windows.Forms.CheckBox cbMapUsers;
        private System.Windows.Forms.CheckBox cbMapTeams;
        private System.Windows.Forms.CheckBox cbMapBu;
        private System.Windows.Forms.Button btnMappings;

        // Operation settings group
        private System.Windows.Forms.GroupBox gbOpSettings;
        private System.Windows.Forms.CheckBox cbCreate;
        private System.Windows.Forms.CheckBox cbUpdate;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.Label lblBatchCount;
        private System.Windows.Forms.NumericUpDown nudBatchCount;

        // Body
        private System.Windows.Forms.TableLayoutPanel pnlBody;

        // Tables Group
        private System.Windows.Forms.GroupBox gbTables;
        private System.Windows.Forms.Label lblTableFilter;
        private System.Windows.Forms.TextBox txtTableFilter;
        private System.Windows.Forms.ListView lvTables;
        private System.Windows.Forms.ColumnHeader chTblLogicalName;
        private System.Windows.Forms.ColumnHeader chTblDisplayName;

        // Attributes Group
        private System.Windows.Forms.GroupBox gbAttributes;
        private System.Windows.Forms.CheckBox cbSelectAll;
        private System.Windows.Forms.ListView lvAttributes;
        private System.Windows.Forms.ColumnHeader chAttrLogicalName;
        private System.Windows.Forms.ColumnHeader chAttrDisplayName;
        private System.Windows.Forms.ColumnHeader chAttrType;
        private System.Windows.Forms.ColumnHeader chAttrDescription;

        // Filters Group
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Label lblFetchDescription;
        private System.Windows.Forms.Button btnFetchXmlBuilder;
        private System.Windows.Forms.RichTextBox rtbFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiImport;
        private System.Windows.Forms.ToolStripMenuItem tsmiImportData;
        private System.Windows.Forms.ToolStripMenuItem tsmiImportSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiImportLastFile;
        private System.Windows.Forms.Label lblApplyMappingsOn;
        private System.Windows.Forms.RadioButton rbMapOnExport;
        private System.Windows.Forms.RadioButton rbMapOnImport;
    }
}
