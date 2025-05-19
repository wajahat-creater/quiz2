namespace CGPACalculatorApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrevCgpa = new System.Windows.Forms.TextBox();
            this.txtPrevCrHrs = new System.Windows.Forms.TextBox();
            this.txtNewSgpa = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewCrHrs = new System.Windows.Forms.TextBox();
            this.txtResultCgpa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Previous CGPA\t";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Previous Credit Hrs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "New SGPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Credit Hrs";
            // 
            // txtPrevCgpa
            // 
            this.txtPrevCgpa.Location = new System.Drawing.Point(270, 66);
            this.txtPrevCgpa.Name = "txtPrevCgpa";
            this.txtPrevCgpa.Size = new System.Drawing.Size(100, 22);
            this.txtPrevCgpa.TabIndex = 4;
            // 
            // txtPrevCrHrs
            // 
            this.txtPrevCrHrs.Location = new System.Drawing.Point(270, 138);
            this.txtPrevCrHrs.Name = "txtPrevCrHrs";
            this.txtPrevCrHrs.Size = new System.Drawing.Size(100, 22);
            this.txtPrevCrHrs.TabIndex = 5;
            // 
            // txtNewSgpa
            // 
            this.txtNewSgpa.Location = new System.Drawing.Point(270, 224);
            this.txtNewSgpa.Name = "txtNewSgpa";
            this.txtNewSgpa.Size = new System.Drawing.Size(100, 22);
            this.txtNewSgpa.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(73, 364);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(84, 49);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate CGPA\t";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "CGPA";
            // 
            // txtNewCrHrs
            // 
            this.txtNewCrHrs.Location = new System.Drawing.Point(270, 307);
            this.txtNewCrHrs.Name = "txtNewCrHrs";
            this.txtNewCrHrs.Size = new System.Drawing.Size(100, 22);
            this.txtNewCrHrs.TabIndex = 11;
            // 
            // txtResultCgpa
            // 
            this.txtResultCgpa.CausesValidation = false;
            this.txtResultCgpa.Location = new System.Drawing.Point(270, 452);
            this.txtResultCgpa.Name = "txtResultCgpa";
            this.txtResultCgpa.Size = new System.Drawing.Size(100, 22);
            this.txtResultCgpa.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 504);
            this.Controls.Add(this.txtResultCgpa);
            this.Controls.Add(this.txtNewCrHrs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNewSgpa);
            this.Controls.Add(this.txtPrevCrHrs);
            this.Controls.Add(this.txtPrevCgpa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrevCgpa;
        private System.Windows.Forms.TextBox txtPrevCrHrs;
        private System.Windows.Forms.TextBox txtNewSgpa;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewCrHrs;
        private System.Windows.Forms.TextBox txtResultCgpa;
    }
}

