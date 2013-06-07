namespace MonitoringSoftware
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
            this.btnSystemInformation = new System.Windows.Forms.Button();
            this.lblMonitorSize = new System.Windows.Forms.Label();
            this.lblComputerName = new System.Windows.Forms.Label();
            this.lblDomainName = new System.Windows.Forms.Label();
            this.lblMaximumSize = new System.Windows.Forms.Label();
            this.txtMonitorSize = new System.Windows.Forms.TextBox();
            this.txtComputerName = new System.Windows.Forms.TextBox();
            this.txtDomainName = new System.Windows.Forms.TextBox();
            this.txtMonitorMaximumSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSystemInformation
            // 
            this.btnSystemInformation.Location = new System.Drawing.Point(146, 153);
            this.btnSystemInformation.Name = "btnSystemInformation";
            this.btnSystemInformation.Size = new System.Drawing.Size(182, 23);
            this.btnSystemInformation.TabIndex = 0;
            this.btnSystemInformation.Text = "Get System Information";
            this.btnSystemInformation.UseVisualStyleBackColor = true;
            this.btnSystemInformation.Click += new System.EventHandler(this.btnSystemInformation_Click);
            // 
            // lblMonitorSize
            // 
            this.lblMonitorSize.AutoSize = true;
            this.lblMonitorSize.Location = new System.Drawing.Point(12, 27);
            this.lblMonitorSize.Name = "lblMonitorSize";
            this.lblMonitorSize.Size = new System.Drawing.Size(65, 13);
            this.lblMonitorSize.TabIndex = 1;
            this.lblMonitorSize.Text = "Monitor Size";
            // 
            // lblComputerName
            // 
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Location = new System.Drawing.Point(12, 56);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(83, 13);
            this.lblComputerName.TabIndex = 2;
            this.lblComputerName.Text = "Computer Name";
            // 
            // lblDomainName
            // 
            this.lblDomainName.AutoSize = true;
            this.lblDomainName.Location = new System.Drawing.Point(12, 85);
            this.lblDomainName.Name = "lblDomainName";
            this.lblDomainName.Size = new System.Drawing.Size(74, 13);
            this.lblDomainName.TabIndex = 3;
            this.lblDomainName.Text = "Domain Name";
            // 
            // lblMaximumSize
            // 
            this.lblMaximumSize.AutoSize = true;
            this.lblMaximumSize.Location = new System.Drawing.Point(12, 117);
            this.lblMaximumSize.Name = "lblMaximumSize";
            this.lblMaximumSize.Size = new System.Drawing.Size(112, 13);
            this.lblMaximumSize.TabIndex = 4;
            this.lblMaximumSize.Text = "Monitor Maximum Size";
            // 
            // txtMonitorSize
            // 
            this.txtMonitorSize.Location = new System.Drawing.Point(146, 20);
            this.txtMonitorSize.Name = "txtMonitorSize";
            this.txtMonitorSize.Size = new System.Drawing.Size(257, 20);
            this.txtMonitorSize.TabIndex = 5;
            // 
            // txtComputerName
            // 
            this.txtComputerName.Location = new System.Drawing.Point(146, 49);
            this.txtComputerName.Name = "txtComputerName";
            this.txtComputerName.Size = new System.Drawing.Size(257, 20);
            this.txtComputerName.TabIndex = 6;
            // 
            // txtDomainName
            // 
            this.txtDomainName.Location = new System.Drawing.Point(146, 78);
            this.txtDomainName.Name = "txtDomainName";
            this.txtDomainName.Size = new System.Drawing.Size(257, 20);
            this.txtDomainName.TabIndex = 7;
            // 
            // txtMonitorMaximumSize
            // 
            this.txtMonitorMaximumSize.Location = new System.Drawing.Point(146, 110);
            this.txtMonitorMaximumSize.Name = "txtMonitorMaximumSize";
            this.txtMonitorMaximumSize.Size = new System.Drawing.Size(257, 20);
            this.txtMonitorMaximumSize.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 193);
            this.Controls.Add(this.txtMonitorMaximumSize);
            this.Controls.Add(this.txtDomainName);
            this.Controls.Add(this.txtComputerName);
            this.Controls.Add(this.txtMonitorSize);
            this.Controls.Add(this.lblMaximumSize);
            this.Controls.Add(this.lblDomainName);
            this.Controls.Add(this.lblComputerName);
            this.Controls.Add(this.lblMonitorSize);
            this.Controls.Add(this.btnSystemInformation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSystemInformation;
        private System.Windows.Forms.Label lblMonitorSize;
        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.Label lblDomainName;
        private System.Windows.Forms.Label lblMaximumSize;
        private System.Windows.Forms.TextBox txtMonitorSize;
        private System.Windows.Forms.TextBox txtComputerName;
        private System.Windows.Forms.TextBox txtDomainName;
        private System.Windows.Forms.TextBox txtMonitorMaximumSize;
    }
}

