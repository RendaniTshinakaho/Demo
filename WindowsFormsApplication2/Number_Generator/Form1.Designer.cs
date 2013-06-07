namespace Number_Generator
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
            this.txtGenerate = new System.Windows.Forms.TextBox();
            this.btnGenerateNumbers = new System.Windows.Forms.Button();
            this.lblGenerateNumbers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGenerate
            // 
            this.txtGenerate.Location = new System.Drawing.Point(592, 387);
            this.txtGenerate.Name = "txtGenerate";
            this.txtGenerate.Size = new System.Drawing.Size(298, 20);
            this.txtGenerate.TabIndex = 0;
            // 
            // btnGenerateNumbers
            // 
            this.btnGenerateNumbers.Location = new System.Drawing.Point(592, 413);
            this.btnGenerateNumbers.Name = "btnGenerateNumbers";
            this.btnGenerateNumbers.Size = new System.Drawing.Size(298, 23);
            this.btnGenerateNumbers.TabIndex = 1;
            this.btnGenerateNumbers.Text = "Generate!";
            this.btnGenerateNumbers.UseVisualStyleBackColor = true;
            this.btnGenerateNumbers.Click += new System.EventHandler(this.btnGenerateNumbers_Click);
            // 
            // lblGenerateNumbers
            // 
            this.lblGenerateNumbers.AutoSize = true;
            this.lblGenerateNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateNumbers.Location = new System.Drawing.Point(589, 361);
            this.lblGenerateNumbers.Name = "lblGenerateNumbers";
            this.lblGenerateNumbers.Size = new System.Drawing.Size(112, 13);
            this.lblGenerateNumbers.TabIndex = 2;
            this.lblGenerateNumbers.Text = "Generate Numbers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Number_Generator.Properties.Resources.Eclectus_roratus__parrot_flying;
            this.ClientSize = new System.Drawing.Size(920, 473);
            this.Controls.Add(this.lblGenerateNumbers);
            this.Controls.Add(this.btnGenerateNumbers);
            this.Controls.Add(this.txtGenerate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGenerate;
        private System.Windows.Forms.Button btnGenerateNumbers;
        private System.Windows.Forms.Label lblGenerateNumbers;
    }
}

