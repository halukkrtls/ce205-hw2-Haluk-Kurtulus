namespace CE205_HW3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRandomGraphGenerate = new System.Windows.Forms.Button();
            this.btnResetGraph = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnBfsAlgorithm = new System.Windows.Forms.RadioButton();
            this.rdBtnDfsAlgorithm = new System.Windows.Forms.RadioButton();
            this.rdBtnMstAlgorithm = new System.Windows.Forms.RadioButton();
            this.rdBtnSccAlgorithm = new System.Windows.Forms.RadioButton();
            this.btnPreviousStep = new System.Windows.Forms.Button();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.chkBoxClearNodes = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 28);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1345, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // btnRandomGraphGenerate
            // 
            this.btnRandomGraphGenerate.BackColor = System.Drawing.Color.Red;
            this.btnRandomGraphGenerate.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRandomGraphGenerate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRandomGraphGenerate.Location = new System.Drawing.Point(0, 281);
            this.btnRandomGraphGenerate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRandomGraphGenerate.Name = "btnRandomGraphGenerate";
            this.btnRandomGraphGenerate.Size = new System.Drawing.Size(146, 64);
            this.btnRandomGraphGenerate.TabIndex = 4;
            this.btnRandomGraphGenerate.Text = "Random Graph Generation";
            this.btnRandomGraphGenerate.UseVisualStyleBackColor = false;
            this.btnRandomGraphGenerate.Click += new System.EventHandler(this.btnRandomGraphGenerate_Click);
            // 
            // btnResetGraph
            // 
            this.btnResetGraph.BackColor = System.Drawing.Color.Red;
            this.btnResetGraph.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResetGraph.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnResetGraph.Location = new System.Drawing.Point(0, 353);
            this.btnResetGraph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResetGraph.Name = "btnResetGraph";
            this.btnResetGraph.Size = new System.Drawing.Size(146, 64);
            this.btnResetGraph.TabIndex = 5;
            this.btnResetGraph.Text = "Reset Graph";
            this.btnResetGraph.UseVisualStyleBackColor = false;
            this.btnResetGraph.Click += new System.EventHandler(this.btnResetGraph_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnBfsAlgorithm);
            this.groupBox1.Controls.Add(this.rdBtnDfsAlgorithm);
            this.groupBox1.Controls.Add(this.rdBtnMstAlgorithm);
            this.groupBox1.Controls.Add(this.rdBtnSccAlgorithm);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(14, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(118, 183);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm";
            // 
            // rdBtnBfsAlgorithm
            // 
            this.rdBtnBfsAlgorithm.AutoSize = true;
            this.rdBtnBfsAlgorithm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rdBtnBfsAlgorithm.Location = new System.Drawing.Point(8, 141);
            this.rdBtnBfsAlgorithm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdBtnBfsAlgorithm.Name = "rdBtnBfsAlgorithm";
            this.rdBtnBfsAlgorithm.Size = new System.Drawing.Size(64, 28);
            this.rdBtnBfsAlgorithm.TabIndex = 3;
            this.rdBtnBfsAlgorithm.Text = "BFS";
            this.rdBtnBfsAlgorithm.UseVisualStyleBackColor = false;
            // 
            // rdBtnDfsAlgorithm
            // 
            this.rdBtnDfsAlgorithm.AutoSize = true;
            this.rdBtnDfsAlgorithm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rdBtnDfsAlgorithm.Location = new System.Drawing.Point(6, 105);
            this.rdBtnDfsAlgorithm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdBtnDfsAlgorithm.Name = "rdBtnDfsAlgorithm";
            this.rdBtnDfsAlgorithm.Size = new System.Drawing.Size(66, 28);
            this.rdBtnDfsAlgorithm.TabIndex = 2;
            this.rdBtnDfsAlgorithm.Text = "DFS";
            this.rdBtnDfsAlgorithm.UseVisualStyleBackColor = false;
            // 
            // rdBtnMstAlgorithm
            // 
            this.rdBtnMstAlgorithm.AutoSize = true;
            this.rdBtnMstAlgorithm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rdBtnMstAlgorithm.Checked = true;
            this.rdBtnMstAlgorithm.ForeColor = System.Drawing.SystemColors.Info;
            this.rdBtnMstAlgorithm.Location = new System.Drawing.Point(6, 30);
            this.rdBtnMstAlgorithm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdBtnMstAlgorithm.Name = "rdBtnMstAlgorithm";
            this.rdBtnMstAlgorithm.Size = new System.Drawing.Size(71, 28);
            this.rdBtnMstAlgorithm.TabIndex = 1;
            this.rdBtnMstAlgorithm.TabStop = true;
            this.rdBtnMstAlgorithm.Text = "MST";
            this.rdBtnMstAlgorithm.UseVisualStyleBackColor = false;
            // 
            // rdBtnSccAlgorithm
            // 
            this.rdBtnSccAlgorithm.AutoSize = true;
            this.rdBtnSccAlgorithm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rdBtnSccAlgorithm.Location = new System.Drawing.Point(6, 69);
            this.rdBtnSccAlgorithm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdBtnSccAlgorithm.Name = "rdBtnSccAlgorithm";
            this.rdBtnSccAlgorithm.Size = new System.Drawing.Size(68, 28);
            this.rdBtnSccAlgorithm.TabIndex = 0;
            this.rdBtnSccAlgorithm.Text = "SCC";
            this.rdBtnSccAlgorithm.UseVisualStyleBackColor = false;
            // 
            // btnPreviousStep
            // 
            this.btnPreviousStep.BackColor = System.Drawing.Color.Red;
            this.btnPreviousStep.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPreviousStep.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPreviousStep.Location = new System.Drawing.Point(0, 497);
            this.btnPreviousStep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPreviousStep.Name = "btnPreviousStep";
            this.btnPreviousStep.Size = new System.Drawing.Size(146, 64);
            this.btnPreviousStep.TabIndex = 7;
            this.btnPreviousStep.Text = "<<Previous Step";
            this.btnPreviousStep.UseVisualStyleBackColor = false;
            // 
            // btnNextStep
            // 
            this.btnNextStep.BackColor = System.Drawing.Color.Red;
            this.btnNextStep.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextStep.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNextStep.Location = new System.Drawing.Point(0, 569);
            this.btnNextStep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(146, 64);
            this.btnNextStep.TabIndex = 8;
            this.btnNextStep.Text = "Next Step>>";
            this.btnNextStep.UseVisualStyleBackColor = false;
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.Red;
            this.btnSolve.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSolve.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSolve.Location = new System.Drawing.Point(0, 425);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(146, 64);
            this.btnSolve.TabIndex = 9;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // chkBoxClearNodes
            // 
            this.chkBoxClearNodes.AutoSize = true;
            this.chkBoxClearNodes.Location = new System.Drawing.Point(12, 234);
            this.chkBoxClearNodes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBoxClearNodes.Name = "chkBoxClearNodes";
            this.chkBoxClearNodes.Size = new System.Drawing.Size(109, 24);
            this.chkBoxClearNodes.TabIndex = 11;
            this.chkBoxClearNodes.Text = "Clear Edges";
            this.chkBoxClearNodes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(162, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 418);
            this.panel1.TabIndex = 12;
            // 
            // gViewer1
            // 
            this.gViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gViewer1.ArrowheadLength = 10D;
            this.gViewer1.AsyncLayout = false;
            this.gViewer1.AutoScroll = true;
            this.gViewer1.BackColor = System.Drawing.Color.White;
            this.gViewer1.BackwardEnabled = false;
            this.gViewer1.BuildHitTree = true;
            this.gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer1.EdgeInsertButtonVisible = false;
            this.gViewer1.FileName = "";
            this.gViewer1.ForwardEnabled = false;
            this.gViewer1.Graph = null;
            this.gViewer1.InsertingEdge = false;
            this.gViewer1.LayoutAlgorithmSettingsButtonVisible = false;
            this.gViewer1.LayoutEditingEnabled = true;
            this.gViewer1.Location = new System.Drawing.Point(162, 73);
            this.gViewer1.LooseOffsetForRouting = 0.25D;
            this.gViewer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gViewer1.MouseHitDistance = 0.05D;
            this.gViewer1.Name = "gViewer1";
            this.gViewer1.NavigationVisible = true;
            this.gViewer1.NeedToCalculateLayout = true;
            this.gViewer1.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer1.PaddingForEdgeRouting = 8D;
            this.gViewer1.PanButtonPressed = false;
            this.gViewer1.SaveAsImageEnabled = true;
            this.gViewer1.SaveAsMsaglEnabled = true;
            this.gViewer1.SaveButtonVisible = false;
            this.gViewer1.SaveGraphButtonVisible = false;
            this.gViewer1.SaveInVectorFormatEnabled = true;
            this.gViewer1.Size = new System.Drawing.Size(1171, 344);
            this.gViewer1.TabIndex = 3;
            this.gViewer1.TightOffsetForRouting = 0.125D;
            this.gViewer1.ToolBarIsVisible = true;
            this.gViewer1.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gViewer1.Transform")));
            this.gViewer1.UndoRedoButtonsVisible = false;
            this.gViewer1.WindowZoomButtonPressed = false;
            this.gViewer1.ZoomF = 1D;
            this.gViewer1.ZoomWindowThreshold = 0.05D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 865);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkBoxClearNodes);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.btnPreviousStep);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResetGraph);
            this.Controls.Add(this.btnRandomGraphGenerate);
            this.Controls.Add(this.gViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "CE205 HW3 2021-2022";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Button btnRandomGraphGenerate;
        private Button btnResetGraph;
        private GroupBox groupBox1;
        private RadioButton rdBtnBfsAlgorithm;
        private RadioButton rdBtnDfsAlgorithm;
        private RadioButton rdBtnMstAlgorithm;
        private RadioButton rdBtnSccAlgorithm;
        private Button btnPreviousStep;
        private Button btnNextStep;
        private Button btnSolve;
        private CheckBox chkBoxClearNodes;
        private Panel panel1;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
    }
}