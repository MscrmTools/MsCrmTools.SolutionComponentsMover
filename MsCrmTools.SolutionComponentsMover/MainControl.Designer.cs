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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCloseThisTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLoadSolutions = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCopyComponents = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbSource = new System.Windows.Forms.GroupBox();
            this.sourceSolutionPicker = new MsCrmTools.SolutionComponentsMover.UserControls.SolutionPicker();
            this.gbTarget = new System.Windows.Forms.GroupBox();
            this.targetSolutionPicker = new MsCrmTools.SolutionComponentsMover.UserControls.SolutionPicker();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbSource.SuspendLayout();
            this.gbTarget.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCloseThisTab,
            this.toolStripSeparator2,
            this.tsbLoadSolutions,
            this.toolStripSeparator1,
            this.tsbCopyComponents});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1079, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCloseThisTab
            // 
            this.tsbCloseThisTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCloseThisTab.Image = ((System.Drawing.Image)(resources.GetObject("tsbCloseThisTab.Image")));
            this.tsbCloseThisTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCloseThisTab.Name = "tsbCloseThisTab";
            this.tsbCloseThisTab.Size = new System.Drawing.Size(28, 29);
            this.tsbCloseThisTab.Text = "Close this tab";
            this.tsbCloseThisTab.Click += new System.EventHandler(this.tsbCloseThisTab_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbLoadSolutions
            // 
            this.tsbLoadSolutions.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadSolutions.Image")));
            this.tsbLoadSolutions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadSolutions.Name = "tsbLoadSolutions";
            this.tsbLoadSolutions.Size = new System.Drawing.Size(156, 29);
            this.tsbLoadSolutions.Text = "Load solutions";
            this.tsbLoadSolutions.Click += new System.EventHandler(this.tsbLoadSolutions_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbCopyComponents
            // 
            this.tsbCopyComponents.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopyComponents.Image")));
            this.tsbCopyComponents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopyComponents.Name = "tsbCopyComponents";
            this.tsbCopyComponents.Size = new System.Drawing.Size(187, 29);
            this.tsbCopyComponents.Text = "Copy components";
            this.tsbCopyComponents.ToolTipText = "Copy components from selected source solution(s) to selected target solution(s)";
            this.tsbCopyComponents.Click += new System.EventHandler(this.tsbCopyComponents_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 38);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbSource);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbTarget);
            this.splitContainer2.Size = new System.Drawing.Size(1079, 662);
            this.splitContainer2.SplitterDistance = 534;
            this.splitContainer2.TabIndex = 1;
            // 
            // gbSource
            // 
            this.gbSource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbSource.Controls.Add(this.sourceSolutionPicker);
            this.gbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSource.Location = new System.Drawing.Point(0, 0);
            this.gbSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSource.Name = "gbSource";
            this.gbSource.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSource.Size = new System.Drawing.Size(534, 662);
            this.gbSource.TabIndex = 2;
            this.gbSource.TabStop = false;
            this.gbSource.Text = "Source solutions";
            // 
            // sourceSolutionPicker
            // 
            this.sourceSolutionPicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sourceSolutionPicker.CanDisplayManagedSolutions = true;
            this.sourceSolutionPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceSolutionPicker.Location = new System.Drawing.Point(3, 23);
            this.sourceSolutionPicker.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.sourceSolutionPicker.Name = "sourceSolutionPicker";
            this.sourceSolutionPicker.Size = new System.Drawing.Size(528, 635);
            this.sourceSolutionPicker.TabIndex = 1;
            // 
            // gbTarget
            // 
            this.gbTarget.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbTarget.Controls.Add(this.targetSolutionPicker);
            this.gbTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTarget.Location = new System.Drawing.Point(0, 0);
            this.gbTarget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTarget.Name = "gbTarget";
            this.gbTarget.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTarget.Size = new System.Drawing.Size(541, 662);
            this.gbTarget.TabIndex = 3;
            this.gbTarget.TabStop = false;
            this.gbTarget.Text = "Target solutions";
            // 
            // targetSolutionPicker
            // 
            this.targetSolutionPicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.targetSolutionPicker.CanDisplayManagedSolutions = false;
            this.targetSolutionPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetSolutionPicker.Location = new System.Drawing.Point(3, 23);
            this.targetSolutionPicker.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.targetSolutionPicker.Name = "targetSolutionPicker";
            this.targetSolutionPicker.Size = new System.Drawing.Size(535, 635);
            this.targetSolutionPicker.TabIndex = 2;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1079, 700);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbSource.ResumeLayout(false);
            this.gbTarget.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
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
    }
}
