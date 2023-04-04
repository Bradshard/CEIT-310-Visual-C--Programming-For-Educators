
namespace Circle_Area_Perimeter_Create
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_circleName = new System.Windows.Forms.TextBox();
            this.txt_diameter = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_circleName = new System.Windows.Forms.Label();
            this.lbl_diameter = new System.Windows.Forms.Label();
            this.btn_createCircle = new System.Windows.Forms.Button();
            this.lst_circles = new System.Windows.Forms.ListBox();
            this.lbl_circles = new System.Windows.Forms.Label();
            this.lbl_output = new System.Windows.Forms.Label();
            this.btn_calculatePerimeter = new System.Windows.Forms.Button();
            this.btn_calculateArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(60, 79);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(224, 27);
            this.txt_id.TabIndex = 0;
            this.txt_id.Text = "0";
            // 
            // txt_circleName
            // 
            this.txt_circleName.Location = new System.Drawing.Point(60, 169);
            this.txt_circleName.Name = "txt_circleName";
            this.txt_circleName.Size = new System.Drawing.Size(224, 27);
            this.txt_circleName.TabIndex = 1;
            // 
            // txt_diameter
            // 
            this.txt_diameter.Location = new System.Drawing.Point(60, 257);
            this.txt_diameter.Name = "txt_diameter";
            this.txt_diameter.Size = new System.Drawing.Size(224, 27);
            this.txt_diameter.TabIndex = 2;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(60, 46);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(100, 20);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "Id [read-only]";
            // 
            // lbl_circleName
            // 
            this.lbl_circleName.AutoSize = true;
            this.lbl_circleName.Location = new System.Drawing.Point(60, 136);
            this.lbl_circleName.Name = "lbl_circleName";
            this.lbl_circleName.Size = new System.Drawing.Size(99, 20);
            this.lbl_circleName.TabIndex = 4;
            this.lbl_circleName.Text = "Enter a name:";
            // 
            // lbl_diameter
            // 
            this.lbl_diameter.AutoSize = true;
            this.lbl_diameter.Location = new System.Drawing.Point(60, 225);
            this.lbl_diameter.Name = "lbl_diameter";
            this.lbl_diameter.Size = new System.Drawing.Size(135, 20);
            this.lbl_diameter.TabIndex = 5;
            this.lbl_diameter.Text = "Enter the diameter:";
            // 
            // btn_createCircle
            // 
            this.btn_createCircle.Location = new System.Drawing.Point(60, 329);
            this.btn_createCircle.Name = "btn_createCircle";
            this.btn_createCircle.Size = new System.Drawing.Size(138, 29);
            this.btn_createCircle.TabIndex = 6;
            this.btn_createCircle.Text = "Create Circle";
            this.btn_createCircle.UseVisualStyleBackColor = true;
            this.btn_createCircle.Click += new System.EventHandler(this.btn_createCircle_Click);
            // 
            // lst_circles
            // 
            this.lst_circles.FormattingEnabled = true;
            this.lst_circles.ItemHeight = 20;
            this.lst_circles.Location = new System.Drawing.Point(466, 79);
            this.lst_circles.Name = "lst_circles";
            this.lst_circles.Size = new System.Drawing.Size(277, 204);
            this.lst_circles.TabIndex = 7;
            // 
            // lbl_circles
            // 
            this.lbl_circles.AutoSize = true;
            this.lbl_circles.Location = new System.Drawing.Point(466, 48);
            this.lbl_circles.Name = "lbl_circles";
            this.lbl_circles.Size = new System.Drawing.Size(52, 20);
            this.lbl_circles.TabIndex = 8;
            this.lbl_circles.Text = "Circles";
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(466, 301);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(207, 20);
            this.lbl_output.TabIndex = 9;
            this.lbl_output.Text = "Output will be displayed here.";
            // 
            // btn_calculatePerimeter
            // 
            this.btn_calculatePerimeter.Location = new System.Drawing.Point(466, 328);
            this.btn_calculatePerimeter.Name = "btn_calculatePerimeter";
            this.btn_calculatePerimeter.Size = new System.Drawing.Size(133, 29);
            this.btn_calculatePerimeter.TabIndex = 10;
            this.btn_calculatePerimeter.Text = "Perimeter";
            this.btn_calculatePerimeter.UseVisualStyleBackColor = true;
            this.btn_calculatePerimeter.Click += new System.EventHandler(this.btn_calculatePerimeter_Click);
            // 
            // btn_calculateArea
            // 
            this.btn_calculateArea.Location = new System.Drawing.Point(605, 329);
            this.btn_calculateArea.Name = "btn_calculateArea";
            this.btn_calculateArea.Size = new System.Drawing.Size(133, 29);
            this.btn_calculateArea.TabIndex = 11;
            this.btn_calculateArea.Text = "Area";
            this.btn_calculateArea.UseVisualStyleBackColor = true;
            this.btn_calculateArea.Click += new System.EventHandler(this.btn_calculateArea_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_calculateArea);
            this.Controls.Add(this.btn_calculatePerimeter);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.lbl_circles);
            this.Controls.Add(this.lst_circles);
            this.Controls.Add(this.btn_createCircle);
            this.Controls.Add(this.lbl_diameter);
            this.Controls.Add(this.lbl_circleName);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_diameter);
            this.Controls.Add(this.txt_circleName);
            this.Controls.Add(this.txt_id);
            this.Name = "Frm_Main";
            this.Text = "Circle";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_circleName;
        private System.Windows.Forms.TextBox txt_diameter;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_circleName;
        private System.Windows.Forms.Label lbl_diameter;
        private System.Windows.Forms.Button btn_createCircle;
        private System.Windows.Forms.ListBox lst_circles;
        private System.Windows.Forms.Label lbl_circles;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Button btn_calculatePerimeter;
        private System.Windows.Forms.Button btn_calculateArea;
    }
}

