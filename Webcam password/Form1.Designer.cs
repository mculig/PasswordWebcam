namespace Webcam_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.camBox = new System.Windows.Forms.ComboBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.pathButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // camBox
            // 
            this.camBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.camBox.FormattingEnabled = true;
            this.camBox.Location = new System.Drawing.Point(29, 12);
            this.camBox.Name = "camBox";
            this.camBox.Size = new System.Drawing.Size(512, 28);
            this.camBox.TabIndex = 0;
            this.camBox.SelectedIndexChanged += new System.EventHandler(this.camBox_SelectedIndexChanged);
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.Location = new System.Drawing.Point(29, 173);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(512, 288);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // pathBox
            // 
            this.pathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathBox.BackColor = System.Drawing.SystemColors.Window;
            this.pathBox.Location = new System.Drawing.Point(29, 58);
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(512, 26);
            this.pathBox.TabIndex = 2;
            // 
            // pathButton
            // 
            this.pathButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pathButton.Location = new System.Drawing.Point(216, 102);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(150, 45);
            this.pathButton.TabIndex = 3;
            this.pathButton.Text = "Select Folder";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 491);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.camBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WebcamPassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox camBox;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button pathButton;
    }
}

