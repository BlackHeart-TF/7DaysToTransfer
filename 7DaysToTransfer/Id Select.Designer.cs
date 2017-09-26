namespace _7DaysToTransfer
{
    partial class Id_Select
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
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromlistBox = new System.Windows.Forms.ListBox();
            this.TolistBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(12, 9);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(114, 25);
            this.FromLabel.TabIndex = 0;
            this.FromLabel.Text = "FromLabel";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(337, 9);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(90, 25);
            this.ToLabel.TabIndex = 0;
            this.ToLabel.Text = "ToLabel";
            // 
            // FromlistBox
            // 
            this.FromlistBox.FormattingEnabled = true;
            this.FromlistBox.ItemHeight = 25;
            this.FromlistBox.Location = new System.Drawing.Point(13, 38);
            this.FromlistBox.Name = "FromlistBox";
            this.FromlistBox.Size = new System.Drawing.Size(323, 204);
            this.FromlistBox.TabIndex = 1;
            // 
            // TolistBox
            // 
            this.TolistBox.FormattingEnabled = true;
            this.TolistBox.ItemHeight = 25;
            this.TolistBox.Location = new System.Drawing.Point(342, 38);
            this.TolistBox.Name = "TolistBox";
            this.TolistBox.Size = new System.Drawing.Size(323, 204);
            this.TolistBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(379, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Id_Select
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(683, 304);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TolistBox);
            this.Controls.Add(this.FromlistBox);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Name = "Id_Select";
            this.Text = "Select ID to move";
            this.Load += new System.EventHandler(this.Id_Select_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.ListBox FromlistBox;
        private System.Windows.Forms.ListBox TolistBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}