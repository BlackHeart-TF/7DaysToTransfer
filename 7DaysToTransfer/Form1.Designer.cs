namespace _7DaysToTransfer
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.worldHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.ImportLeft = new System.Windows.Forms.Button();
            this.ImportRight = new System.Windows.Forms.Button();
            this.ExportLeft = new System.Windows.Forms.Button();
            this.ExportRight = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(518, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "<< Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button2_Click);
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.worldHeader,
            this.nameHeader});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 12);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(497, 480);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // worldHeader
            // 
            this.worldHeader.Text = "World";
            this.worldHeader.Width = 100;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Game Name";
            this.nameHeader.Width = 146;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(504, 480);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "World";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Game Name";
            this.columnHeader2.Width = 146;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(374, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 37);
            this.button2.TabIndex = 0;
            this.button2.Text = "Copy >>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ImportLeft
            // 
            this.ImportLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImportLeft.Enabled = false;
            this.ImportLeft.Location = new System.Drawing.Point(12, 15);
            this.ImportLeft.Name = "ImportLeft";
            this.ImportLeft.Size = new System.Drawing.Size(138, 37);
            this.ImportLeft.TabIndex = 0;
            this.ImportLeft.Text = "Import";
            this.ImportLeft.UseVisualStyleBackColor = true;
            this.ImportLeft.Click += new System.EventHandler(this.Import_Click);
            // 
            // ImportRight
            // 
            this.ImportRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportRight.Enabled = false;
            this.ImportRight.Location = new System.Drawing.Point(879, 15);
            this.ImportRight.Name = "ImportRight";
            this.ImportRight.Size = new System.Drawing.Size(138, 37);
            this.ImportRight.TabIndex = 0;
            this.ImportRight.Text = "Import";
            this.ImportRight.UseVisualStyleBackColor = true;
            this.ImportRight.Click += new System.EventHandler(this.Import_Click);
            // 
            // ExportLeft
            // 
            this.ExportLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExportLeft.Enabled = false;
            this.ExportLeft.Location = new System.Drawing.Point(12, 58);
            this.ExportLeft.Name = "ExportLeft";
            this.ExportLeft.Size = new System.Drawing.Size(138, 37);
            this.ExportLeft.TabIndex = 0;
            this.ExportLeft.Text = "Export";
            this.ExportLeft.UseVisualStyleBackColor = true;
            this.ExportLeft.Click += new System.EventHandler(this.Export_Click);
            // 
            // ExportRight
            // 
            this.ExportRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportRight.Enabled = false;
            this.ExportRight.Location = new System.Drawing.Point(879, 58);
            this.ExportRight.Name = "ExportRight";
            this.ExportRight.Size = new System.Drawing.Size(138, 37);
            this.ExportRight.TabIndex = 0;
            this.ExportRight.Text = "Export";
            this.ExportRight.UseVisualStyleBackColor = true;
            this.ExportRight.Click += new System.EventHandler(this.Export_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.LeftPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1031, 604);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Layout += new System.Windows.Forms.LayoutEventHandler(this.mainPanel_Layout);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.listView2);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(519, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(512, 604);
            this.rightPanel.TabIndex = 3;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.listView1);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(1031, 604);
            this.LeftPanel.TabIndex = 2;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.button2);
            this.bottomPanel.Controls.Add(this.button1);
            this.bottomPanel.Controls.Add(this.ExportRight);
            this.bottomPanel.Controls.Add(this.ImportLeft);
            this.bottomPanel.Controls.Add(this.ImportRight);
            this.bottomPanel.Controls.Add(this.ExportLeft);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 498);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1031, 106);
            this.bottomPanel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 604);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.mainPanel);
            this.MinimumSize = new System.Drawing.Size(1057, 675);
            this.Name = "Form1";
            this.Text = "7 Days To Transfer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader worldHeader;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ImportLeft;
        private System.Windows.Forms.Button ImportRight;
        private System.Windows.Forms.Button ExportLeft;
        private System.Windows.Forms.Button ExportRight;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel LeftPanel;
    }
}

