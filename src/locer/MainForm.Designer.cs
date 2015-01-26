using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LineCounter
{
    internal partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.countButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minimalCharCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.totalLineCountTextBox = new System.Windows.Forms.TextBox();
            this.filesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileMaskEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimalCharCountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // countButton
            // 
            this.countButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.countButton.Location = new System.Drawing.Point(738, 12);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(128, 33);
            this.countButton.TabIndex = 1;
            this.countButton.Text = "Count";
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.minimalCharCountUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.totalLineCountTextBox);
            this.groupBox1.Controls.Add(this.filesListView);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.folderTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fileMaskEdit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 489);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // minimalCharCountUpDown
            // 
            this.minimalCharCountUpDown.Location = new System.Drawing.Point(230, 129);
            this.minimalCharCountUpDown.Name = "minimalCharCountUpDown";
            this.minimalCharCountUpDown.Size = new System.Drawing.Size(77, 26);
            this.minimalCharCountUpDown.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Line Count:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLineCountTextBox
            // 
            this.totalLineCountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLineCountTextBox.Location = new System.Drawing.Point(230, 175);
            this.totalLineCountTextBox.Name = "totalLineCountTextBox";
            this.totalLineCountTextBox.ReadOnly = true;
            this.totalLineCountTextBox.Size = new System.Drawing.Size(316, 26);
            this.totalLineCountTextBox.TabIndex = 8;
            // 
            // filesListView
            // 
            this.filesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.filesListView.FullRowSelect = true;
            this.filesListView.Location = new System.Drawing.Point(13, 222);
            this.filesListView.Name = "filesListView";
            this.filesListView.Size = new System.Drawing.Size(673, 255);
            this.filesListView.TabIndex = 9;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.View = System.Windows.Forms.View.Details;
            this.filesListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.filesListView_ColumnClick);
            this.filesListView.SelectedIndexChanged += new System.EventHandler(this.filesListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Filename";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Line Count";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Path";
            this.columnHeader3.Width = 147;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.browseButton.Location = new System.Drawing.Point(558, 31);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(128, 34);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse...";
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // folderTextBox
            // 
            this.folderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.folderTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.folderTextBox.Location = new System.Drawing.Point(230, 35);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(316, 26);
            this.folderTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "File Mask:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileMaskEdit
            // 
            this.fileMaskEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileMaskEdit.Location = new System.Drawing.Point(230, 82);
            this.fileMaskEdit.Name = "fileMaskEdit";
            this.fileMaskEdit.Size = new System.Drawing.Size(316, 26);
            this.fileMaskEdit.TabIndex = 4;
            this.fileMaskEdit.Text = "*.cs;*.vb;*.bas;*.cls;*.frm;*.txt";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Minimal Char Count:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 512);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(878, 32);
            this.statusBar.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AcceptButton = this.countButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.countButton);
            this.Name = "MainForm";
            this.Text = "Line Counter";
            this.Load += new System.EventHandler(this.LineCounterForm_Load);
            this.Resize += new System.EventHandler(this.LineCounterForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimalCharCountUpDown)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private FolderBrowserDialog folderBrowserDialog;
        private Button countButton;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox totalLineCountTextBox;
        private ListView filesListView;
        private Label label1;
        private Button browseButton;
        private TextBox folderTextBox;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label3;
        private TextBox fileMaskEdit;
        private Label label4;
        private NumericUpDown minimalCharCountUpDown;
        private StatusBar statusBar;
    }
}

