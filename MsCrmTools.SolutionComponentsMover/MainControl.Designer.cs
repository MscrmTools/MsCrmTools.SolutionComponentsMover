namespace MsCrmTools.SolutionComponentsMover
{
    partial class MainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbCloseThisTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLoadSolutions = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCopyComponents = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbLogs = new System.Windows.Forms.ToolStripDropDownButton();
            this.exportLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbSource = new System.Windows.Forms.GroupBox();
            this.sourceSolutionPicker = new MsCrmTools.SolutionComponentsMover.UserControls.SolutionPicker();
            this.gbTarget = new System.Windows.Forms.GroupBox();
            this.targetSolutionPicker = new MsCrmTools.SolutionComponentsMover.UserControls.SolutionPicker();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.gbLogs = new System.Windows.Forms.GroupBox();
            this.lvLogs = new System.Windows.Forms.ListView();
            this.chMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.chkCheckBestPractice = new System.Windows.Forms.CheckBox();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbSource.SuspendLayout();
            this.gbTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.gbLogs.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCloseThisTab,
            this.toolStripSeparator2,
            this.tsbLoadSolutions,
            this.toolStripSeparator1,
            this.tsbCopyComponents,
            this.toolStripSeparator3,
            this.tsddbLogs,
            this.toolStripSeparator4,
            this.toolStripLabel1});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1439, 39);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "tsMain";
            // 
            // tsbCloseThisTab
            // 
            this.tsbCloseThisTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCloseThisTab.Image = ((System.Drawing.Image)(resources.GetObject("tsbCloseThisTab.Image")));
            this.tsbCloseThisTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCloseThisTab.Name = "tsbCloseThisTab";
            this.tsbCloseThisTab.Size = new System.Drawing.Size(36, 36);
            this.tsbCloseThisTab.Text = "Close this tab";
            this.tsbCloseThisTab.Click += new System.EventHandler(this.tsbCloseThisTab_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbLoadSolutions
            // 
            this.tsbLoadSolutions.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadSolutions.Image")));
            this.tsbLoadSolutions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadSolutions.Name = "tsbLoadSolutions";
            this.tsbLoadSolutions.Size = new System.Drawing.Size(205, 36);
            this.tsbLoadSolutions.Text = "Load solutions";
            this.tsbLoadSolutions.Click += new System.EventHandler(this.tsbLoadSolutions_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbCopyComponents
            // 
            this.tsbCopyComponents.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopyComponents.Image")));
            this.tsbCopyComponents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopyComponents.Name = "tsbCopyComponents";
            this.tsbCopyComponents.Size = new System.Drawing.Size(246, 36);
            this.tsbCopyComponents.Text = "Copy components";
            this.tsbCopyComponents.ToolTipText = "Copy components from selected source solution(s) to selected target solution(s)";
            this.tsbCopyComponents.Click += new System.EventHandler(this.tsbCopyComponents_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsddbLogs
            // 
            this.tsddbLogs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportLogsToolStripMenuItem,
            this.clearLogsToolStripMenuItem});
            this.tsddbLogs.Image = ((System.Drawing.Image)(resources.GetObject("tsddbLogs.Image")));
            this.tsddbLogs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbLogs.Name = "tsddbLogs";
            this.tsddbLogs.Size = new System.Drawing.Size(118, 36);
            this.tsddbLogs.Text = "Logs";
            // 
            // exportLogsToolStripMenuItem
            // 
            this.exportLogsToolStripMenuItem.Name = "exportLogsToolStripMenuItem";
            this.exportLogsToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.exportLogsToolStripMenuItem.Text = "Export logs";
            this.exportLogsToolStripMenuItem.Click += new System.EventHandler(this.exportLogsToolStripMenuItem_Click);
            // 
            // clearLogsToolStripMenuItem
            // 
            this.clearLogsToolStripMenuItem.Name = "clearLogsToolStripMenuItem";
            this.clearLogsToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.clearLogsToolStripMenuItem.Text = "Clear logs";
            this.clearLogsToolStripMenuItem.Click += new System.EventHandler(this.clearLogsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(405, 36);
            this.toolStripLabel1.Text = "Double click on a solution to open it";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbSource);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbTarget);
            this.splitContainer2.Size = new System.Drawing.Size(1439, 518);
            this.splitContainer2.SplitterDistance = 712;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 1;
            // 
            // gbSource
            // 
            this.gbSource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbSource.Controls.Add(this.sourceSolutionPicker);
            this.gbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSource.Location = new System.Drawing.Point(0, 0);
            this.gbSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSource.Name = "gbSource";
            this.gbSource.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSource.Size = new System.Drawing.Size(712, 518);
            this.gbSource.TabIndex = 2;
            this.gbSource.TabStop = false;
            this.gbSource.Text = "Source solutions";
            // 
            // sourceSolutionPicker
            // 
            this.sourceSolutionPicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sourceSolutionPicker.CanDisplayManagedSolutions = true;
            this.sourceSolutionPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceSolutionPicker.Location = new System.Drawing.Point(4, 29);
            this.sourceSolutionPicker.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sourceSolutionPicker.Name = "sourceSolutionPicker";
            this.sourceSolutionPicker.Size = new System.Drawing.Size(704, 484);
            this.sourceSolutionPicker.TabIndex = 1;
            this.sourceSolutionPicker.OnSolutionSelected += new System.EventHandler<MsCrmTools.SolutionComponentsMover.AppCode.SolutionSelectedEventArgs>(this.SolutionSelected);
            // 
            // gbTarget
            // 
            this.gbTarget.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbTarget.Controls.Add(this.targetSolutionPicker);
            this.gbTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTarget.Location = new System.Drawing.Point(0, 0);
            this.gbTarget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTarget.Name = "gbTarget";
            this.gbTarget.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTarget.Size = new System.Drawing.Size(722, 518);
            this.gbTarget.TabIndex = 3;
            this.gbTarget.TabStop = false;
            this.gbTarget.Text = "Target solutions";
            // 
            // targetSolutionPicker
            // 
            this.targetSolutionPicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.targetSolutionPicker.CanDisplayManagedSolutions = false;
            this.targetSolutionPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetSolutionPicker.Location = new System.Drawing.Point(4, 29);
            this.targetSolutionPicker.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.targetSolutionPicker.Name = "targetSolutionPicker";
            this.targetSolutionPicker.Size = new System.Drawing.Size(714, 484);
            this.targetSolutionPicker.TabIndex = 2;
            this.targetSolutionPicker.OnSolutionSelected += new System.EventHandler<MsCrmTools.SolutionComponentsMover.AppCode.SolutionSelectedEventArgs>(this.SolutionSelected);
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 79);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.splitContainer2);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.gbLogs);
            this.scMain.Size = new System.Drawing.Size(1439, 796);
            this.scMain.SplitterDistance = 518;
            this.scMain.TabIndex = 2;
            // 
            // gbLogs
            // 
            this.gbLogs.Controls.Add(this.lvLogs);
            this.gbLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLogs.Location = new System.Drawing.Point(0, 0);
            this.gbLogs.Name = "gbLogs";
            this.gbLogs.Size = new System.Drawing.Size(1439, 274);
            this.gbLogs.TabIndex = 0;
            this.gbLogs.TabStop = false;
            this.gbLogs.Text = "Logs";
            // 
            // lvLogs
            // 
            this.lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMessage});
            this.lvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLogs.HideSelection = false;
            this.lvLogs.Location = new System.Drawing.Point(3, 27);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(1433, 244);
            this.lvLogs.TabIndex = 0;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            this.lvLogs.View = System.Windows.Forms.View.Details;
            this.lvLogs.Resize += new System.EventHandler(this.lvLogs_Resize);
            // 
            // chMessage
            // 
            this.chMessage.Text = "Message";
            this.chMessage.Width = 800;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.chkCheckBestPractice);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOptions.Location = new System.Drawing.Point(0, 39);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(1439, 40);
            this.pnlOptions.TabIndex = 3;
            // 
            // chkCheckBestPractice
            // 
            this.chkCheckBestPractice.AutoSize = true;
            this.chkCheckBestPractice.Checked = true;
            this.chkCheckBestPractice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCheckBestPractice.Location = new System.Drawing.Point(4, 4);
            this.chkCheckBestPractice.Name = "chkCheckBestPractice";
            this.chkCheckBestPractice.Size = new System.Drawing.Size(499, 29);
            this.chkCheckBestPractice.TabIndex = 0;
            this.chkCheckBestPractice.Text = "Check best practice before moving components";
            this.chkCheckBestPractice.UseVisualStyleBackColor = true;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.tsMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1439, 875);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbSource.ResumeLayout(false);
            this.gbTarget.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.gbLogs.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbLoadSolutions;
        private System.Windows.Forms.ToolStripButton tsbCloseThisTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbCopyComponents;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gbSource;
        private UserControls.SolutionPicker sourceSolutionPicker;
        private System.Windows.Forms.GroupBox gbTarget;
        private UserControls.SolutionPicker targetSolutionPicker;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.GroupBox gbLogs;
        private System.Windows.Forms.ListView lvLogs;
        private System.Windows.Forms.ColumnHeader chMessage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.CheckBox chkCheckBestPractice;
        private System.Windows.Forms.ToolStripDropDownButton tsddbLogs;
        private System.Windows.Forms.ToolStripMenuItem exportLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}
