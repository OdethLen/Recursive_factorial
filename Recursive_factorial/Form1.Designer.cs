namespace Recursive_factorial
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
            label1 = new Label();
            txtNumber = new TextBox();
            txtFactorial = new TextBox();
            btnCalculateFactorial = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 79);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Number";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(118, 76);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 1;
            // 
            // txtFactorial
            // 
            txtFactorial.Location = new Point(52, 129);
            txtFactorial.Name = "txtFactorial";
            txtFactorial.Size = new Size(100, 23);
            txtFactorial.TabIndex = 2;
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(94, 176);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(133, 29);
            btnCalculateFactorial.TabIndex = 3;
            btnCalculateFactorial.Text = "Calculate factorial";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 246);
            Controls.Add(btnCalculateFactorial);
            Controls.Add(txtFactorial);
            Controls.Add(txtNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumber;
        private TextBox txtFactorial;
        private Button btnCalculateFactorial;
    }
}
