
namespace Password_Checker
{
    partial class Pass_Form
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
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.lbl_length = new System.Windows.Forms.Label();
            this.lbl_upper = new System.Windows.Forms.Label();
            this.lbl_lower = new System.Windows.Forms.Label();
            this.lbl_digits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(49, 51);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(155, 27);
            this.txt_password.TabIndex = 5;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(53, 120);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(165, 20);
            this.lbl_message.TabIndex = 3;
            this.lbl_message.Text = "Password Requirements";
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Location = new System.Drawing.Point(73, 151);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(209, 20);
            this.lbl_length.TabIndex = 6;
            this.lbl_length.Text = "Password length is at least 10. ";
            // 
            // lbl_upper
            // 
            this.lbl_upper.AutoSize = true;
            this.lbl_upper.Location = new System.Drawing.Point(73, 176);
            this.lbl_upper.Name = "lbl_upper";
            this.lbl_upper.Size = new System.Drawing.Size(304, 20);
            this.lbl_upper.TabIndex = 7;
            this.lbl_upper.Text = "The number of uppercase letters is at least 3.";
            // 
            // lbl_lower
            // 
            this.lbl_lower.AutoSize = true;
            this.lbl_lower.Location = new System.Drawing.Point(73, 201);
            this.lbl_lower.Name = "lbl_lower";
            this.lbl_lower.Size = new System.Drawing.Size(294, 20);
            this.lbl_lower.TabIndex = 8;
            this.lbl_lower.Text = "The number of lowercase letters is at lest 2.";
            // 
            // lbl_digits
            // 
            this.lbl_digits.AutoSize = true;
            this.lbl_digits.Location = new System.Drawing.Point(73, 227);
            this.lbl_digits.Name = "lbl_digits";
            this.lbl_digits.Size = new System.Drawing.Size(285, 20);
            this.lbl_digits.TabIndex = 9;
            this.lbl_digits.Text = "The number of numeric digits is at least 2.";
            // 
            // Pass_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 295);
            this.Controls.Add(this.lbl_digits);
            this.Controls.Add(this.lbl_lower);
            this.Controls.Add(this.lbl_upper);
            this.Controls.Add(this.lbl_length);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_message);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Pass_Form";
            this.Text = "Pass_Form";
            this.Load += new System.EventHandler(this.Pass_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.Label lbl_upper;
        private System.Windows.Forms.Label lbl_lower;
        private System.Windows.Forms.Label lbl_digits;
    }
}

