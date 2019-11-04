namespace MsCrmTools.SolutionComponentsMover.Forms
{
    partial class ComponentTypeSelector
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEntities = new System.Windows.Forms.CheckBox();
            this.chkSiteMap = new System.Windows.Forms.CheckBox();
            this.chkApplicationRibbon = new System.Windows.Forms.CheckBox();
            this.chkGlobalOptionSets = new System.Windows.Forms.CheckBox();
            this.chkPluginAssemblies = new System.Windows.Forms.CheckBox();
            this.chkSdkMessageProcessingSteps = new System.Windows.Forms.CheckBox();
            this.chkServiceEndpoints = new System.Windows.Forms.CheckBox();
            this.chkReports = new System.Windows.Forms.CheckBox();
            this.chkRoles = new System.Windows.Forms.CheckBox();
            this.chkFieldSecurityProfiles = new System.Windows.Forms.CheckBox();
            this.chkConnectionRoles = new System.Windows.Forms.CheckBox();
            this.chkWebResources = new System.Windows.Forms.CheckBox();
            this.chkWorkflows = new System.Windows.Forms.CheckBox();
            this.chkKbArticleTemplates = new System.Windows.Forms.CheckBox();
            this.chkMailMergeTemplates = new System.Windows.Forms.CheckBox();
            this.chkContractTemplates = new System.Windows.Forms.CheckBox();
            this.chkEmailTemplates = new System.Windows.Forms.CheckBox();
            this.chkDashboards = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.chkRoutingRules = new System.Windows.Forms.CheckBox();
            this.chkSLA = new System.Windows.Forms.CheckBox();
            this.chkConvertRules = new System.Windows.Forms.CheckBox();
            this.lblExtraInfo = new System.Windows.Forms.Label();
            this.lvTypes = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.llInvertSelection = new System.Windows.Forms.LinkLabel();
            this.llClearAll = new System.Windows.Forms.LinkLabel();
            this.llSelectAll = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSelection.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 94);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select components types to move to target solution(s)";
            // 
            // chkEntities
            // 
            this.chkEntities.AutoSize = true;
            this.chkEntities.Checked = true;
            this.chkEntities.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEntities.Enabled = false;
            this.chkEntities.Location = new System.Drawing.Point(13, 62);
            this.chkEntities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEntities.Name = "chkEntities";
            this.chkEntities.Size = new System.Drawing.Size(123, 29);
            this.chkEntities.TabIndex = 2;
            this.chkEntities.Tag = "1";
            this.chkEntities.Text = "Entities*";
            this.chkEntities.UseVisualStyleBackColor = true;
            // 
            // chkSiteMap
            // 
            this.chkSiteMap.AutoSize = true;
            this.chkSiteMap.Checked = true;
            this.chkSiteMap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSiteMap.Enabled = false;
            this.chkSiteMap.Location = new System.Drawing.Point(13, 147);
            this.chkSiteMap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSiteMap.Name = "chkSiteMap";
            this.chkSiteMap.Size = new System.Drawing.Size(123, 29);
            this.chkSiteMap.TabIndex = 4;
            this.chkSiteMap.Tag = "62";
            this.chkSiteMap.Text = "SiteMap";
            this.chkSiteMap.UseVisualStyleBackColor = true;
            // 
            // chkApplicationRibbon
            // 
            this.chkApplicationRibbon.AutoSize = true;
            this.chkApplicationRibbon.Checked = true;
            this.chkApplicationRibbon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkApplicationRibbon.Enabled = false;
            this.chkApplicationRibbon.Location = new System.Drawing.Point(13, 189);
            this.chkApplicationRibbon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkApplicationRibbon.Name = "chkApplicationRibbon";
            this.chkApplicationRibbon.Size = new System.Drawing.Size(224, 29);
            this.chkApplicationRibbon.TabIndex = 5;
            this.chkApplicationRibbon.Tag = "50";
            this.chkApplicationRibbon.Text = "Application Ribbon";
            this.chkApplicationRibbon.UseVisualStyleBackColor = true;
            // 
            // chkGlobalOptionSets
            // 
            this.chkGlobalOptionSets.AutoSize = true;
            this.chkGlobalOptionSets.Checked = true;
            this.chkGlobalOptionSets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGlobalOptionSets.Enabled = false;
            this.chkGlobalOptionSets.Location = new System.Drawing.Point(13, 105);
            this.chkGlobalOptionSets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkGlobalOptionSets.Name = "chkGlobalOptionSets";
            this.chkGlobalOptionSets.Size = new System.Drawing.Size(218, 29);
            this.chkGlobalOptionSets.TabIndex = 3;
            this.chkGlobalOptionSets.Tag = "9";
            this.chkGlobalOptionSets.Text = "Global OptionSets";
            this.chkGlobalOptionSets.UseVisualStyleBackColor = true;
            // 
            // chkPluginAssemblies
            // 
            this.chkPluginAssemblies.AutoSize = true;
            this.chkPluginAssemblies.Checked = true;
            this.chkPluginAssemblies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPluginAssemblies.Enabled = false;
            this.chkPluginAssemblies.Location = new System.Drawing.Point(13, 316);
            this.chkPluginAssemblies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPluginAssemblies.Name = "chkPluginAssemblies";
            this.chkPluginAssemblies.Size = new System.Drawing.Size(218, 29);
            this.chkPluginAssemblies.TabIndex = 8;
            this.chkPluginAssemblies.Tag = "91";
            this.chkPluginAssemblies.Text = "Plugin assemblies";
            this.chkPluginAssemblies.UseVisualStyleBackColor = true;
            // 
            // chkSdkMessageProcessingSteps
            // 
            this.chkSdkMessageProcessingSteps.AutoSize = true;
            this.chkSdkMessageProcessingSteps.Checked = true;
            this.chkSdkMessageProcessingSteps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSdkMessageProcessingSteps.Enabled = false;
            this.chkSdkMessageProcessingSteps.Location = new System.Drawing.Point(13, 357);
            this.chkSdkMessageProcessingSteps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSdkMessageProcessingSteps.Name = "chkSdkMessageProcessingSteps";
            this.chkSdkMessageProcessingSteps.Size = new System.Drawing.Size(349, 29);
            this.chkSdkMessageProcessingSteps.TabIndex = 9;
            this.chkSdkMessageProcessingSteps.Tag = "92";
            this.chkSdkMessageProcessingSteps.Text = "SDK message processing steps";
            this.chkSdkMessageProcessingSteps.UseVisualStyleBackColor = true;
            // 
            // chkServiceEndpoints
            // 
            this.chkServiceEndpoints.AutoSize = true;
            this.chkServiceEndpoints.Checked = true;
            this.chkServiceEndpoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkServiceEndpoints.Enabled = false;
            this.chkServiceEndpoints.Location = new System.Drawing.Point(13, 399);
            this.chkServiceEndpoints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkServiceEndpoints.Name = "chkServiceEndpoints";
            this.chkServiceEndpoints.Size = new System.Drawing.Size(216, 29);
            this.chkServiceEndpoints.TabIndex = 10;
            this.chkServiceEndpoints.Tag = "95";
            this.chkServiceEndpoints.Text = "Service endpoints";
            this.chkServiceEndpoints.UseVisualStyleBackColor = true;
            // 
            // chkReports
            // 
            this.chkReports.AutoSize = true;
            this.chkReports.Checked = true;
            this.chkReports.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReports.Enabled = false;
            this.chkReports.Location = new System.Drawing.Point(429, 105);
            this.chkReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkReports.Name = "chkReports";
            this.chkReports.Size = new System.Drawing.Size(119, 29);
            this.chkReports.TabIndex = 12;
            this.chkReports.Tag = "31";
            this.chkReports.Text = "Reports";
            this.chkReports.UseVisualStyleBackColor = true;
            // 
            // chkRoles
            // 
            this.chkRoles.AutoSize = true;
            this.chkRoles.Checked = true;
            this.chkRoles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRoles.Enabled = false;
            this.chkRoles.Location = new System.Drawing.Point(429, 357);
            this.chkRoles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRoles.Name = "chkRoles";
            this.chkRoles.Size = new System.Drawing.Size(99, 29);
            this.chkRoles.TabIndex = 18;
            this.chkRoles.Tag = "20";
            this.chkRoles.Text = "Roles";
            this.chkRoles.UseVisualStyleBackColor = true;
            // 
            // chkFieldSecurityProfiles
            // 
            this.chkFieldSecurityProfiles.AutoSize = true;
            this.chkFieldSecurityProfiles.Checked = true;
            this.chkFieldSecurityProfiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFieldSecurityProfiles.Enabled = false;
            this.chkFieldSecurityProfiles.Location = new System.Drawing.Point(429, 399);
            this.chkFieldSecurityProfiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkFieldSecurityProfiles.Name = "chkFieldSecurityProfiles";
            this.chkFieldSecurityProfiles.Size = new System.Drawing.Size(248, 29);
            this.chkFieldSecurityProfiles.TabIndex = 19;
            this.chkFieldSecurityProfiles.Tag = "70";
            this.chkFieldSecurityProfiles.Text = "Field security profiles";
            this.chkFieldSecurityProfiles.UseVisualStyleBackColor = true;
            // 
            // chkConnectionRoles
            // 
            this.chkConnectionRoles.AutoSize = true;
            this.chkConnectionRoles.Checked = true;
            this.chkConnectionRoles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConnectionRoles.Enabled = false;
            this.chkConnectionRoles.Location = new System.Drawing.Point(429, 147);
            this.chkConnectionRoles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkConnectionRoles.Name = "chkConnectionRoles";
            this.chkConnectionRoles.Size = new System.Drawing.Size(206, 29);
            this.chkConnectionRoles.TabIndex = 13;
            this.chkConnectionRoles.Tag = "63";
            this.chkConnectionRoles.Text = "Connection roles";
            this.chkConnectionRoles.UseVisualStyleBackColor = true;
            // 
            // chkWebResources
            // 
            this.chkWebResources.AutoSize = true;
            this.chkWebResources.Checked = true;
            this.chkWebResources.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWebResources.Enabled = false;
            this.chkWebResources.Location = new System.Drawing.Point(13, 231);
            this.chkWebResources.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkWebResources.Name = "chkWebResources";
            this.chkWebResources.Size = new System.Drawing.Size(189, 29);
            this.chkWebResources.TabIndex = 6;
            this.chkWebResources.Tag = "61";
            this.chkWebResources.Text = "Web resources";
            this.chkWebResources.UseVisualStyleBackColor = true;
            // 
            // chkWorkflows
            // 
            this.chkWorkflows.AutoSize = true;
            this.chkWorkflows.Checked = true;
            this.chkWorkflows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWorkflows.Enabled = false;
            this.chkWorkflows.Location = new System.Drawing.Point(13, 273);
            this.chkWorkflows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkWorkflows.Name = "chkWorkflows";
            this.chkWorkflows.Size = new System.Drawing.Size(143, 29);
            this.chkWorkflows.TabIndex = 7;
            this.chkWorkflows.Tag = "29";
            this.chkWorkflows.Text = "Workflows";
            this.chkWorkflows.UseVisualStyleBackColor = true;
            // 
            // chkKbArticleTemplates
            // 
            this.chkKbArticleTemplates.AutoSize = true;
            this.chkKbArticleTemplates.Checked = true;
            this.chkKbArticleTemplates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKbArticleTemplates.Enabled = false;
            this.chkKbArticleTemplates.Location = new System.Drawing.Point(429, 189);
            this.chkKbArticleTemplates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkKbArticleTemplates.Name = "chkKbArticleTemplates";
            this.chkKbArticleTemplates.Size = new System.Drawing.Size(235, 29);
            this.chkKbArticleTemplates.TabIndex = 14;
            this.chkKbArticleTemplates.Tag = "38";
            this.chkKbArticleTemplates.Text = "KB article templates";
            this.chkKbArticleTemplates.UseVisualStyleBackColor = true;
            // 
            // chkMailMergeTemplates
            // 
            this.chkMailMergeTemplates.AutoSize = true;
            this.chkMailMergeTemplates.Checked = true;
            this.chkMailMergeTemplates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMailMergeTemplates.Enabled = false;
            this.chkMailMergeTemplates.Location = new System.Drawing.Point(429, 316);
            this.chkMailMergeTemplates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkMailMergeTemplates.Name = "chkMailMergeTemplates";
            this.chkMailMergeTemplates.Size = new System.Drawing.Size(249, 29);
            this.chkMailMergeTemplates.TabIndex = 17;
            this.chkMailMergeTemplates.Tag = "39";
            this.chkMailMergeTemplates.Text = "Mail merge templates";
            this.chkMailMergeTemplates.UseVisualStyleBackColor = true;
            // 
            // chkContractTemplates
            // 
            this.chkContractTemplates.AutoSize = true;
            this.chkContractTemplates.Checked = true;
            this.chkContractTemplates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkContractTemplates.Enabled = false;
            this.chkContractTemplates.Location = new System.Drawing.Point(429, 231);
            this.chkContractTemplates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkContractTemplates.Name = "chkContractTemplates";
            this.chkContractTemplates.Size = new System.Drawing.Size(224, 29);
            this.chkContractTemplates.TabIndex = 15;
            this.chkContractTemplates.Tag = "37";
            this.chkContractTemplates.Text = "Contract templates";
            this.chkContractTemplates.UseVisualStyleBackColor = true;
            // 
            // chkEmailTemplates
            // 
            this.chkEmailTemplates.AutoSize = true;
            this.chkEmailTemplates.Checked = true;
            this.chkEmailTemplates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmailTemplates.Enabled = false;
            this.chkEmailTemplates.Location = new System.Drawing.Point(429, 273);
            this.chkEmailTemplates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEmailTemplates.Name = "chkEmailTemplates";
            this.chkEmailTemplates.Size = new System.Drawing.Size(196, 29);
            this.chkEmailTemplates.TabIndex = 16;
            this.chkEmailTemplates.Tag = "36";
            this.chkEmailTemplates.Text = "Email templates";
            this.chkEmailTemplates.UseVisualStyleBackColor = true;
            // 
            // chkDashboards
            // 
            this.chkDashboards.AutoSize = true;
            this.chkDashboards.Checked = true;
            this.chkDashboards.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDashboards.Enabled = false;
            this.chkDashboards.Location = new System.Drawing.Point(429, 62);
            this.chkDashboards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDashboards.Name = "chkDashboards";
            this.chkDashboards.Size = new System.Drawing.Size(160, 29);
            this.chkDashboards.TabIndex = 11;
            this.chkDashboards.Tag = "60";
            this.chkDashboards.Text = "Dashboards";
            this.chkDashboards.UseVisualStyleBackColor = true;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Checked = true;
            this.chkAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAll.Location = new System.Drawing.Point(13, 19);
            this.chkAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(68, 29);
            this.chkAll.TabIndex = 1;
            this.chkAll.Tag = "";
            this.chkAll.Text = "All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // chkRoutingRules
            // 
            this.chkRoutingRules.AutoSize = true;
            this.chkRoutingRules.Checked = true;
            this.chkRoutingRules.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRoutingRules.Enabled = false;
            this.chkRoutingRules.Location = new System.Drawing.Point(13, 439);
            this.chkRoutingRules.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRoutingRules.Name = "chkRoutingRules";
            this.chkRoutingRules.Size = new System.Drawing.Size(171, 29);
            this.chkRoutingRules.TabIndex = 22;
            this.chkRoutingRules.Tag = "150";
            this.chkRoutingRules.Text = "Routing rules";
            this.chkRoutingRules.UseVisualStyleBackColor = true;
            // 
            // chkSLA
            // 
            this.chkSLA.AutoSize = true;
            this.chkSLA.Checked = true;
            this.chkSLA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSLA.Enabled = false;
            this.chkSLA.Location = new System.Drawing.Point(13, 479);
            this.chkSLA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSLA.Name = "chkSLA";
            this.chkSLA.Size = new System.Drawing.Size(84, 29);
            this.chkSLA.TabIndex = 23;
            this.chkSLA.Tag = "152";
            this.chkSLA.Text = "SLA";
            this.chkSLA.UseVisualStyleBackColor = true;
            // 
            // chkConvertRules
            // 
            this.chkConvertRules.AutoSize = true;
            this.chkConvertRules.Checked = true;
            this.chkConvertRules.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConvertRules.Enabled = false;
            this.chkConvertRules.Location = new System.Drawing.Point(13, 519);
            this.chkConvertRules.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkConvertRules.Name = "chkConvertRules";
            this.chkConvertRules.Size = new System.Drawing.Size(172, 29);
            this.chkConvertRules.TabIndex = 24;
            this.chkConvertRules.Tag = "154";
            this.chkConvertRules.Text = "Convert rules";
            this.chkConvertRules.UseVisualStyleBackColor = true;
            // 
            // lblExtraInfo
            // 
            this.lblExtraInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraInfo.Location = new System.Drawing.Point(4, 595);
            this.lblExtraInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtraInfo.Name = "lblExtraInfo";
            this.lblExtraInfo.Size = new System.Drawing.Size(772, 85);
            this.lblExtraInfo.TabIndex = 25;
            this.lblExtraInfo.Text = "* Only entities sub components explicitely included in source solution will be mo" +
    "ved to target(s) solution(s). One exception: Business Rules are controled by Wor" +
    "kflows checkbox";
            // 
            // lvTypes
            // 
            this.lvTypes.CheckBoxes = true;
            this.lvTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName});
            this.lvTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTypes.FullRowSelect = true;
            this.lvTypes.HideSelection = false;
            this.lvTypes.Location = new System.Drawing.Point(10, 10);
            this.lvTypes.Name = "lvTypes";
            this.lvTypes.Size = new System.Drawing.Size(784, 673);
            this.lvTypes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvTypes.TabIndex = 26;
            this.lvTypes.UseCompatibleStateImageBehavior = false;
            this.lvTypes.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Component";
            this.chName.Width = 400;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkAll);
            this.panel2.Controls.Add(this.chkEntities);
            this.panel2.Controls.Add(this.lblExtraInfo);
            this.panel2.Controls.Add(this.chkSiteMap);
            this.panel2.Controls.Add(this.chkConvertRules);
            this.panel2.Controls.Add(this.chkApplicationRibbon);
            this.panel2.Controls.Add(this.chkSLA);
            this.panel2.Controls.Add(this.chkGlobalOptionSets);
            this.panel2.Controls.Add(this.chkRoutingRules);
            this.panel2.Controls.Add(this.chkPluginAssemblies);
            this.panel2.Controls.Add(this.chkSdkMessageProcessingSteps);
            this.panel2.Controls.Add(this.chkServiceEndpoints);
            this.panel2.Controls.Add(this.chkReports);
            this.panel2.Controls.Add(this.chkDashboards);
            this.panel2.Controls.Add(this.chkRoles);
            this.panel2.Controls.Add(this.chkEmailTemplates);
            this.panel2.Controls.Add(this.chkFieldSecurityProfiles);
            this.panel2.Controls.Add(this.chkContractTemplates);
            this.panel2.Controls.Add(this.chkConnectionRoles);
            this.panel2.Controls.Add(this.chkMailMergeTemplates);
            this.panel2.Controls.Add(this.chkWebResources);
            this.panel2.Controls.Add(this.chkKbArticleTemplates);
            this.panel2.Controls.Add(this.chkWorkflows);
            this.panel2.Location = new System.Drawing.Point(-266, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 192);
            this.panel2.TabIndex = 27;
            this.panel2.Visible = false;
            // 
            // pnlSelection
            // 
            this.pnlSelection.Controls.Add(this.llInvertSelection);
            this.pnlSelection.Controls.Add(this.llClearAll);
            this.pnlSelection.Controls.Add(this.llSelectAll);
            this.pnlSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelection.Location = new System.Drawing.Point(0, 94);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(804, 45);
            this.pnlSelection.TabIndex = 28;
            // 
            // llInvertSelection
            // 
            this.llInvertSelection.Dock = System.Windows.Forms.DockStyle.Right;
            this.llInvertSelection.Location = new System.Drawing.Point(424, 0);
            this.llInvertSelection.Name = "llInvertSelection";
            this.llInvertSelection.Size = new System.Drawing.Size(189, 45);
            this.llInvertSelection.TabIndex = 5;
            this.llInvertSelection.TabStop = true;
            this.llInvertSelection.Text = "Invert selection";
            this.llInvertSelection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llInvertSelection.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llInvertSelection_LinkClicked);
            // 
            // llClearAll
            // 
            this.llClearAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.llClearAll.Location = new System.Drawing.Point(613, 0);
            this.llClearAll.Name = "llClearAll";
            this.llClearAll.Size = new System.Drawing.Size(91, 45);
            this.llClearAll.TabIndex = 4;
            this.llClearAll.TabStop = true;
            this.llClearAll.Text = "Clear all";
            this.llClearAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llClearAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClearAll_LinkClicked);
            // 
            // llSelectAll
            // 
            this.llSelectAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.llSelectAll.Location = new System.Drawing.Point(704, 0);
            this.llSelectAll.Name = "llSelectAll";
            this.llSelectAll.Size = new System.Drawing.Size(100, 45);
            this.llSelectAll.TabIndex = 3;
            this.llSelectAll.TabStop = true;
            this.llSelectAll.Text = "Select all";
            this.llSelectAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSelectAll_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 832);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 74);
            this.panel3.TabIndex = 29;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(636, 16);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 44);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(477, 16);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(149, 44);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvTypes);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 139);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.Size = new System.Drawing.Size(804, 693);
            this.pnlMain.TabIndex = 30;
            // 
            // ComponentTypeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 906);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSelection);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComponentTypeSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ComponentTypeSelector_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlSelection.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkEntities;
        private System.Windows.Forms.CheckBox chkSiteMap;
        private System.Windows.Forms.CheckBox chkApplicationRibbon;
        private System.Windows.Forms.CheckBox chkGlobalOptionSets;
        private System.Windows.Forms.CheckBox chkPluginAssemblies;
        private System.Windows.Forms.CheckBox chkSdkMessageProcessingSteps;
        private System.Windows.Forms.CheckBox chkServiceEndpoints;
        private System.Windows.Forms.CheckBox chkReports;
        private System.Windows.Forms.CheckBox chkRoles;
        private System.Windows.Forms.CheckBox chkFieldSecurityProfiles;
        private System.Windows.Forms.CheckBox chkConnectionRoles;
        private System.Windows.Forms.CheckBox chkWebResources;
        private System.Windows.Forms.CheckBox chkWorkflows;
        private System.Windows.Forms.CheckBox chkKbArticleTemplates;
        private System.Windows.Forms.CheckBox chkMailMergeTemplates;
        private System.Windows.Forms.CheckBox chkContractTemplates;
        private System.Windows.Forms.CheckBox chkEmailTemplates;
        private System.Windows.Forms.CheckBox chkDashboards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.CheckBox chkRoutingRules;
        private System.Windows.Forms.CheckBox chkSLA;
        private System.Windows.Forms.CheckBox chkConvertRules;
        private System.Windows.Forms.Label lblExtraInfo;
        private System.Windows.Forms.ListView lvTypes;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlSelection;
        private System.Windows.Forms.LinkLabel llInvertSelection;
        private System.Windows.Forms.LinkLabel llClearAll;
        private System.Windows.Forms.LinkLabel llSelectAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel pnlMain;
    }
}