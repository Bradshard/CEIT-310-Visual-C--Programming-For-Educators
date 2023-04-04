
namespace Name_Registration
{
    partial class Form_Register
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
            this.label8 = new System.Windows.Forms.Label();
            this.btn_showDetails = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_filterYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_filterSurname = new System.Windows.Forms.TextBox();
            this.txt_filterName = new System.Windows.Forms.TextBox();
            this.lbl_details = new System.Windows.Forms.Label();
            this.grp_search = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.btn_addOrEdit = new System.Windows.Forms.Button();
            this.txt_place = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_users = new System.Windows.Forms.ListBox();
            this.grp_User = new System.Windows.Forms.GroupBox();
            this.grp_search.SuspendLayout();
            this.grp_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(809, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 23;
            // 
            // btn_showDetails
            // 
            this.btn_showDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_showDetails.Location = new System.Drawing.Point(550, 248);
            this.btn_showDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_showDetails.Name = "btn_showDetails";
            this.btn_showDetails.Size = new System.Drawing.Size(75, 40);
            this.btn_showDetails.TabIndex = 21;
            this.btn_showDetails.Text = "Details";
            this.btn_showDetails.UseVisualStyleBackColor = true;
            this.btn_showDetails.Click += new System.EventHandler(this.btn_showDetails_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(18, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Filter by birth year : ";
            // 
            // txt_filterYear
            // 
            this.txt_filterYear.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_filterYear.Location = new System.Drawing.Point(18, 191);
            this.txt_filterYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_filterYear.Name = "txt_filterYear";
            this.txt_filterYear.Size = new System.Drawing.Size(194, 25);
            this.txt_filterYear.TabIndex = 13;
            this.txt_filterYear.TextChanged += new System.EventHandler(this.txt_filterYear_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Filter by surname : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(18, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Filter by name : ";
            // 
            // txt_filterSurname
            // 
            this.txt_filterSurname.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_filterSurname.Location = new System.Drawing.Point(18, 124);
            this.txt_filterSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_filterSurname.Name = "txt_filterSurname";
            this.txt_filterSurname.Size = new System.Drawing.Size(194, 25);
            this.txt_filterSurname.TabIndex = 10;
            this.txt_filterSurname.TextChanged += new System.EventHandler(this.txt_filterSurname_TextChanged);
            // 
            // txt_filterName
            // 
            this.txt_filterName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_filterName.Location = new System.Drawing.Point(18, 60);
            this.txt_filterName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_filterName.Name = "txt_filterName";
            this.txt_filterName.Size = new System.Drawing.Size(194, 25);
            this.txt_filterName.TabIndex = 2;
            this.txt_filterName.TextChanged += new System.EventHandler(this.txt_filterName_TextChanged);
            // 
            // lbl_details
            // 
            this.lbl_details.AutoSize = true;
            this.lbl_details.Location = new System.Drawing.Point(375, 300);
            this.lbl_details.Name = "lbl_details";
            this.lbl_details.Size = new System.Drawing.Size(215, 20);
            this.lbl_details.TabIndex = 22;
            this.lbl_details.Text = "User details are displayed here.";
            // 
            // grp_search
            // 
            this.grp_search.Controls.Add(this.label7);
            this.grp_search.Controls.Add(this.txt_filterYear);
            this.grp_search.Controls.Add(this.label6);
            this.grp_search.Controls.Add(this.label5);
            this.grp_search.Controls.Add(this.txt_filterSurname);
            this.grp_search.Controls.Add(this.txt_filterName);
            this.grp_search.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grp_search.Location = new System.Drawing.Point(651, 72);
            this.grp_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_search.Name = "grp_search";
            this.grp_search.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_search.Size = new System.Drawing.Size(249, 256);
            this.grp_search.TabIndex = 20;
            this.grp_search.TabStop = false;
            this.grp_search.Text = "Search/filter ";
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.Location = new System.Drawing.Point(464, 248);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 40);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_edit.Location = new System.Drawing.Point(375, 248);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(78, 40);
            this.btn_edit.TabIndex = 18;
            this.btn_edit.Text = "Edit ";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(375, 28);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(148, 23);
            this.label.TabIndex = 17;
            this.label.Text = "Registered users : ";
            // 
            // btn_addOrEdit
            // 
            this.btn_addOrEdit.Location = new System.Drawing.Point(157, 231);
            this.btn_addOrEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addOrEdit.Name = "btn_addOrEdit";
            this.btn_addOrEdit.Size = new System.Drawing.Size(131, 40);
            this.btn_addOrEdit.TabIndex = 8;
            this.btn_addOrEdit.Text = "Add User";
            this.btn_addOrEdit.UseVisualStyleBackColor = true;
            this.btn_addOrEdit.Click += new System.EventHandler(this.btn_addOrEdit_Click);
            // 
            // txt_place
            // 
            this.txt_place.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_place.Location = new System.Drawing.Point(110, 180);
            this.txt_place.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_place.Name = "txt_place";
            this.txt_place.Size = new System.Drawing.Size(178, 27);
            this.txt_place.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birth Place : ";
            // 
            // txt_year
            // 
            this.txt_year.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_year.Location = new System.Drawing.Point(110, 133);
            this.txt_year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(178, 27);
            this.txt_year.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birth Year : ";
            // 
            // txt_surname
            // 
            this.txt_surname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_surname.Location = new System.Drawing.Point(110, 87);
            this.txt_surname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(178, 27);
            this.txt_surname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname : ";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_name.Location = new System.Drawing.Point(110, 40);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(178, 27);
            this.txt_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : ";
            // 
            // lst_users
            // 
            this.lst_users.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst_users.FormattingEnabled = true;
            this.lst_users.ItemHeight = 23;
            this.lst_users.Location = new System.Drawing.Point(375, 72);
            this.lst_users.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lst_users.Name = "lst_users";
            this.lst_users.Size = new System.Drawing.Size(249, 142);
            this.lst_users.TabIndex = 16;
            // 
            // grp_User
            // 
            this.grp_User.Controls.Add(this.btn_addOrEdit);
            this.grp_User.Controls.Add(this.txt_place);
            this.grp_User.Controls.Add(this.label4);
            this.grp_User.Controls.Add(this.txt_year);
            this.grp_User.Controls.Add(this.label3);
            this.grp_User.Controls.Add(this.txt_surname);
            this.grp_User.Controls.Add(this.label2);
            this.grp_User.Controls.Add(this.txt_name);
            this.grp_User.Controls.Add(this.label1);
            this.grp_User.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grp_User.Location = new System.Drawing.Point(18, 28);
            this.grp_User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_User.Name = "grp_User";
            this.grp_User.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_User.Size = new System.Drawing.Size(314, 300);
            this.grp_User.TabIndex = 15;
            this.grp_User.TabStop = false;
            this.grp_User.Text = "Register User";
            // 
            // Form_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 384);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_showDetails);
            this.Controls.Add(this.lbl_details);
            this.Controls.Add(this.grp_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lst_users);
            this.Controls.Add(this.grp_User);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Register";
            this.Text = "Form_Register";
            this.Load += new System.EventHandler(this.Form_Register_Load);
            this.grp_search.ResumeLayout(false);
            this.grp_search.PerformLayout();
            this.grp_User.ResumeLayout(false);
            this.grp_User.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_showDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_filterYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_filterSurname;
        private System.Windows.Forms.TextBox txt_filterName;
        private System.Windows.Forms.Label lbl_details;
        private System.Windows.Forms.GroupBox grp_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_addOrEdit;
        private System.Windows.Forms.TextBox txt_place;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_users;
        private System.Windows.Forms.GroupBox grp_User;
    }
}

