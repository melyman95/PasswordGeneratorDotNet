namespace PasswordGeneratorCSharp
{
    partial class PasswordGenForm
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
            this.PasswordGenButton = new System.Windows.Forms.Button();
            this.PasswordLengthBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordOutputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PasswordGenButton
            // 
            this.PasswordGenButton.Location = new System.Drawing.Point(163, 234);
            this.PasswordGenButton.Name = "PasswordGenButton";
            this.PasswordGenButton.Size = new System.Drawing.Size(238, 56);
            this.PasswordGenButton.TabIndex = 0;
            this.PasswordGenButton.Text = "Generate";
            this.PasswordGenButton.UseVisualStyleBackColor = true;
            this.PasswordGenButton.Click += new System.EventHandler(this.PasswordGenButton_Click);
            // 
            // PasswordLengthBox
            // 
            this.PasswordLengthBox.Location = new System.Drawing.Point(163, 188);
            this.PasswordLengthBox.Name = "PasswordLengthBox";
            this.PasswordLengthBox.Size = new System.Drawing.Size(238, 31);
            this.PasswordLengthBox.TabIndex = 1;
            this.PasswordLengthBox.TextChanged += new System.EventHandler(this.PasswordLengthBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter desired length here";
            // 
            // PasswordOutputBox
            // 
            this.PasswordOutputBox.Location = new System.Drawing.Point(163, 368);
            this.PasswordOutputBox.Name = "PasswordOutputBox";
            this.PasswordOutputBox.Size = new System.Drawing.Size(238, 31);
            this.PasswordOutputBox.TabIndex = 3;
            this.PasswordOutputBox.TextChanged += new System.EventHandler(this.PasswordOutputBox_TextChanged);
            // 
            // PasswordGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 486);
            this.Controls.Add(this.PasswordOutputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordLengthBox);
            this.Controls.Add(this.PasswordGenButton);
            this.Name = "PasswordGenForm";
            this.Text = "Password Gen";
            this.Load += new System.EventHandler(this.PasswordGenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PasswordGenButton;
        private TextBox PasswordLengthBox;
        private Label label1;
        private TextBox PasswordOutputBox;
    }
}