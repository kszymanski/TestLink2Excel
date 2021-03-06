﻿namespace TestLink2Excel
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainSplit = new System.Windows.Forms.SplitContainer();
			this.testSuiteTreeView = new TestLink2Excel.Controls.TestSuiteTreeView();
			this.testCaseDetailsForm = new TestLink2Excel.TestCaseDetailsForm();
			this.testSuiteDetailsForm = new TestLink2Excel.Controls.TestSuiteDetailsForm();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.excelSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.testLinkXlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.xlsxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.xmlSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.mainSplit)).BeginInit();
			this.mainSplit.Panel1.SuspendLayout();
			this.mainSplit.Panel2.SuspendLayout();
			this.mainSplit.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainSplit
			// 
			this.mainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainSplit.Location = new System.Drawing.Point(0, 24);
			this.mainSplit.Name = "mainSplit";
			// 
			// mainSplit.Panel1
			// 
			this.mainSplit.Panel1.Controls.Add(this.testSuiteTreeView);
			// 
			// mainSplit.Panel2
			// 
			this.mainSplit.Panel2.Controls.Add(this.testCaseDetailsForm);
			this.mainSplit.Panel2.Controls.Add(this.testSuiteDetailsForm);
			this.mainSplit.Size = new System.Drawing.Size(922, 451);
			this.mainSplit.SplitterDistance = 245;
			this.mainSplit.TabIndex = 1;
			// 
			// testSuiteTreeView
			// 
			this.testSuiteTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.testSuiteTreeView.Location = new System.Drawing.Point(0, 0);
			this.testSuiteTreeView.Name = "testSuiteTreeView";
			this.testSuiteTreeView.Size = new System.Drawing.Size(245, 451);
			this.testSuiteTreeView.TabIndex = 0;
			// 
			// testCaseDetailsForm
			// 
			this.testCaseDetailsForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.testCaseDetailsForm.Location = new System.Drawing.Point(0, 0);
			this.testCaseDetailsForm.Name = "testCaseDetailsForm";
			this.testCaseDetailsForm.ShowExtraButtons = false;
			this.testCaseDetailsForm.Size = new System.Drawing.Size(673, 451);
			this.testCaseDetailsForm.TabIndex = 1;
			this.testCaseDetailsForm.Visible = false;
			// 
			// testSuiteDetailsForm
			// 
			this.testSuiteDetailsForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.testSuiteDetailsForm.Location = new System.Drawing.Point(0, 0);
			this.testSuiteDetailsForm.Name = "testSuiteDetailsForm";
			this.testSuiteDetailsForm.Size = new System.Drawing.Size(673, 451);
			this.testSuiteDetailsForm.TabIndex = 0;
			this.testSuiteDetailsForm.Visible = false;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 475);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(922, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItemClick);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = global::TestLink2Excel.Properties.Resources.open_folder_ico;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.openToolStripMenuItem.Text = "&Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelSheetToolStripMenuItem,
            this.testLinkXlsToolStripMenuItem});
			this.saveAsToolStripMenuItem.Image = global::TestLink2Excel.Properties.Resources.save_ico;
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.saveAsToolStripMenuItem.Text = "Save As...";
			// 
			// excelSheetToolStripMenuItem
			// 
			this.excelSheetToolStripMenuItem.Image = global::TestLink2Excel.Properties.Resources.excel_ico;
			this.excelSheetToolStripMenuItem.Name = "excelSheetToolStripMenuItem";
			this.excelSheetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.excelSheetToolStripMenuItem.Text = "Excel sheet...";
			this.excelSheetToolStripMenuItem.Click += new System.EventHandler(this.ExcelSheetToolStripMenuItemClick);
			// 
			// testLinkXlsToolStripMenuItem
			// 
			this.testLinkXlsToolStripMenuItem.Image = global::TestLink2Excel.Properties.Resources.testlink;
			this.testLinkXlsToolStripMenuItem.Name = "testLinkXlsToolStripMenuItem";
			this.testLinkXlsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.testLinkXlsToolStripMenuItem.Text = "Test link xml...";
			this.testLinkXlsToolStripMenuItem.Click += new System.EventHandler(this.TestLinkXlsToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = global::TestLink2Excel.Properties.Resources.delete_co;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "&About..";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(922, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "XML suite file (*.xml)|*.xml|All files (*.*)|*.*";
			// 
			// xlsxSaveFileDialog
			// 
			this.xlsxSaveFileDialog.Filter = "Microsoft Excel Worksheet (*.xlsx)|*.xlsx|All files (*.*)|*.*";
			// 
			// xmlSaveFileDialog
			// 
			this.xmlSaveFileDialog.Filter = "XML File (*.xml)|*.xml|All files (*.*)|*.*";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(922, 497);
			this.Controls.Add(this.mainSplit);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "TestLink 2 Excel";
			this.mainSplit.Panel1.ResumeLayout(false);
			this.mainSplit.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mainSplit)).EndInit();
			this.mainSplit.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplit;
		private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testLinkXlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Controls.TestSuiteTreeView testSuiteTreeView;
        private Controls.TestSuiteDetailsForm testSuiteDetailsForm;
        private TestCaseDetailsForm testCaseDetailsForm;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog xlsxSaveFileDialog;
        private System.Windows.Forms.SaveFileDialog xmlSaveFileDialog;
        
    }
}

