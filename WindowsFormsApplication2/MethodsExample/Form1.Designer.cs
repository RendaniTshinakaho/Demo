namespace MethodsExample
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
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblDisplayTax = new System.Windows.Forms.Label();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.btnCalculateUS = new System.Windows.Forms.Button();
            this.btnCalcGB = new System.Windows.Forms.Button();
            this.btnCalcCA = new System.Windows.Forms.Button();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(0, 34);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Weight";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(0, 59);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(49, 13);
            this.lblDistance.TabIndex = 1;
            this.lblDistance.Text = "Distance";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(198, 34);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 2;
            this.lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(198, 59);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(67, 27);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 4;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(67, 52);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 20);
            this.txtDistance.TabIndex = 5;
            // 
            // lblDisplayTax
            // 
            this.lblDisplayTax.AutoSize = true;
            this.lblDisplayTax.Location = new System.Drawing.Point(238, 34);
            this.lblDisplayTax.Name = "lblDisplayTax";
            this.lblDisplayTax.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayTax.TabIndex = 6;
            this.lblDisplayTax.Text = "label1";
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.AutoSize = true;
            this.lblDisplayTotal.Location = new System.Drawing.Point(238, 59);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayTotal.TabIndex = 7;
            this.lblDisplayTotal.Text = "label2";
            // 
            // btnCalculateUS
            // 
            this.btnCalculateUS.Location = new System.Drawing.Point(3, 139);
            this.btnCalculateUS.Name = "btnCalculateUS";
            this.btnCalculateUS.Size = new System.Drawing.Size(93, 23);
            this.btnCalculateUS.TabIndex = 8;
            this.btnCalculateUS.Text = "Calculate US";
            this.btnCalculateUS.UseVisualStyleBackColor = true;
            this.btnCalculateUS.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalcGB
            // 
            this.btnCalcGB.Location = new System.Drawing.Point(102, 139);
            this.btnCalcGB.Name = "btnCalcGB";
            this.btnCalcGB.Size = new System.Drawing.Size(98, 23);
            this.btnCalcGB.TabIndex = 9;
            this.btnCalcGB.Text = "Calculate GB";
            this.btnCalcGB.UseVisualStyleBackColor = true;
            this.btnCalcGB.Click += new System.EventHandler(this.btnCalcGB_Click);
            // 
            // btnCalcCA
            // 
            this.btnCalcCA.Location = new System.Drawing.Point(206, 139);
            this.btnCalcCA.Name = "btnCalcCA";
            this.btnCalcCA.Size = new System.Drawing.Size(92, 23);
            this.btnCalcCA.TabIndex = 10;
            this.btnCalcCA.Text = "Calculate CA";
            this.btnCalcCA.UseVisualStyleBackColor = true;
            this.btnCalcCA.Click += new System.EventHandler(this.btnCalcCA_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(64, 92);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(0, 13);
            this.lblSubTotal.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 184);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.btnCalcCA);
            this.Controls.Add(this.btnCalcGB);
            this.Controls.Add(this.btnCalculateUS);
            this.Controls.Add(this.lblDisplayTotal);
            this.Controls.Add(this.lblDisplayTax);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblWeight);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblDisplayTax;
        private System.Windows.Forms.Label lblDisplayTotal;
        private System.Windows.Forms.Button btnCalculateUS;
        private System.Windows.Forms.Button btnCalcGB;
        private System.Windows.Forms.Button btnCalcCA;
        private System.Windows.Forms.Label lblSubTotal;
    }
}

