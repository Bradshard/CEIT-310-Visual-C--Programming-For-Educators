
namespace Section_Divider
{
    partial class Frm_Main
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
            this.lst_section1 = new System.Windows.Forms.ListBox();
            this.lst_section2 = new System.Windows.Forms.ListBox();
            this.btn_moveToRight = new System.Windows.Forms.Button();
            this.btn_moveToLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_overlapping = new System.Windows.Forms.Label();
            this.lbl_sizeComparison = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_section1
            // 
            this.lst_section1.FormattingEnabled = true;
            this.lst_section1.ItemHeight = 15;
            this.lst_section1.Location = new System.Drawing.Point(45, 72);
            this.lst_section1.Name = "lst_section1";
            this.lst_section1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_section1.Size = new System.Drawing.Size(123, 139);
            this.lst_section1.TabIndex = 0;
            // 
            // lst_section2
            // 
            this.lst_section2.FormattingEnabled = true;
            this.lst_section2.ItemHeight = 15;
            this.lst_section2.Location = new System.Drawing.Point(267, 72);
            this.lst_section2.Name = "lst_section2";
            this.lst_section2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_section2.Size = new System.Drawing.Size(121, 139);
            this.lst_section2.TabIndex = 1;
            // 
            // btn_moveToRight
            // 
            this.btn_moveToRight.Location = new System.Drawing.Point(189, 90);
            this.btn_moveToRight.Name = "btn_moveToRight";
            this.btn_moveToRight.Size = new System.Drawing.Size(57, 23);
            this.btn_moveToRight.TabIndex = 2;
            this.btn_moveToRight.Text = ">>";
            this.btn_moveToRight.UseVisualStyleBackColor = true;
            this.btn_moveToRight.Click += new System.EventHandler(this.btn_moveToRight_Click);
            // 
            // btn_moveToLeft
            // 
            this.btn_moveToLeft.Location = new System.Drawing.Point(189, 129);
            this.btn_moveToLeft.Name = "btn_moveToLeft";
            this.btn_moveToLeft.Size = new System.Drawing.Size(57, 23);
            this.btn_moveToLeft.TabIndex = 3;
            this.btn_moveToLeft.Text = "<<";
            this.btn_moveToLeft.UseVisualStyleBackColor = true;
            this.btn_moveToLeft.Click += new System.EventHandler(this.btn_moveToLeft_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Section 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(267, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Section 2";
            // 
            // lbl_overlapping
            // 
            this.lbl_overlapping.AutoSize = true;
            this.lbl_overlapping.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_overlapping.Location = new System.Drawing.Point(45, 235);
            this.lbl_overlapping.Name = "lbl_overlapping";
            this.lbl_overlapping.Size = new System.Drawing.Size(75, 15);
            this.lbl_overlapping.TabIndex = 6;
            this.lbl_overlapping.Text = "No message.";
            this.lbl_overlapping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_sizeComparison
            // 
            this.lbl_sizeComparison.AutoSize = true;
            this.lbl_sizeComparison.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sizeComparison.Location = new System.Drawing.Point(45, 259);
            this.lbl_sizeComparison.Name = "lbl_sizeComparison";
            this.lbl_sizeComparison.Size = new System.Drawing.Size(75, 15);
            this.lbl_sizeComparison.TabIndex = 7;
            this.lbl_sizeComparison.Text = "No message.";
            this.lbl_sizeComparison.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 311);
            this.Controls.Add(this.lbl_sizeComparison);
            this.Controls.Add(this.lbl_overlapping);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_moveToLeft);
            this.Controls.Add(this.btn_moveToRight);
            this.Controls.Add(this.lst_section2);
            this.Controls.Add(this.lst_section1);
            this.Name = "Frm_Main";
            this.Text = "Course Sections";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_section1;
        private System.Windows.Forms.ListBox lst_section2;
        private System.Windows.Forms.Button btn_moveToRight;
        private System.Windows.Forms.Button btn_moveToLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_overlapping;
        private System.Windows.Forms.Label lbl_sizeComparison;
    }
}

