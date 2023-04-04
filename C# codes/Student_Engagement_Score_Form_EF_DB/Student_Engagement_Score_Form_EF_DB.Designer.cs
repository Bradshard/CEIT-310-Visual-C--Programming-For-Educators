
namespace Student_Engagement_Score_Form_EF_DB
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
            this.groupBox_createStudent = new System.Windows.Forms.GroupBox();
            this.btn_createStudent = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_selectStudents = new System.Windows.Forms.Label();
            this.lst_students = new System.Windows.Forms.ListBox();
            this.comboBox_selectStudent = new System.Windows.Forms.ComboBox();
            this.btn_createEngagement = new System.Windows.Forms.Button();
            this.btn_engagementRecords = new System.Windows.Forms.Button();
            this.lbl_students = new System.Windows.Forms.Label();
            this.tab_engagements = new System.Windows.Forms.TabControl();
            this.tab_createEngagement = new System.Windows.Forms.TabPage();
            this.btn_createEngagementRecord = new System.Windows.Forms.Button();
            this.txt_pageView = new System.Windows.Forms.TextBox();
            this.txt_videoView = new System.Windows.Forms.TextBox();
            this.txt_engagementName = new System.Windows.Forms.TextBox();
            this.lbl_pageView = new System.Windows.Forms.Label();
            this.lbl_videoView = new System.Windows.Forms.Label();
            this.lbl_engagementName = new System.Windows.Forms.Label();
            this.tab_viewEngagementRecord = new System.Windows.Forms.TabPage();
            this.lbl_engagementScoreShow = new System.Windows.Forms.Label();
            this.lst_engagementOfData = new System.Windows.Forms.ListBox();
            this.groupBox_createStudent.SuspendLayout();
            this.tab_engagements.SuspendLayout();
            this.tab_createEngagement.SuspendLayout();
            this.tab_viewEngagementRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_createStudent
            // 
            this.groupBox_createStudent.Controls.Add(this.btn_createStudent);
            this.groupBox_createStudent.Controls.Add(this.txt_email);
            this.groupBox_createStudent.Controls.Add(this.txt_surname);
            this.groupBox_createStudent.Controls.Add(this.lbl_message);
            this.groupBox_createStudent.Controls.Add(this.lbl_email);
            this.groupBox_createStudent.Controls.Add(this.lbl_surname);
            this.groupBox_createStudent.Controls.Add(this.lbl_name);
            this.groupBox_createStudent.Controls.Add(this.txt_name);
            this.groupBox_createStudent.Location = new System.Drawing.Point(30, 33);
            this.groupBox_createStudent.Name = "groupBox_createStudent";
            this.groupBox_createStudent.Size = new System.Drawing.Size(342, 244);
            this.groupBox_createStudent.TabIndex = 0;
            this.groupBox_createStudent.TabStop = false;
            this.groupBox_createStudent.Text = "Create Student";
            // 
            // btn_createStudent
            // 
            this.btn_createStudent.Location = new System.Drawing.Point(224, 150);
            this.btn_createStudent.Name = "btn_createStudent";
            this.btn_createStudent.Size = new System.Drawing.Size(94, 29);
            this.btn_createStudent.TabIndex = 7;
            this.btn_createStudent.Text = "Create";
            this.btn_createStudent.UseVisualStyleBackColor = true;
            this.btn_createStudent.Click += new System.EventHandler(this.btn_createStudent_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(138, 117);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(180, 27);
            this.txt_email.TabIndex = 6;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(138, 74);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(180, 27);
            this.txt_surname.TabIndex = 5;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(6, 206);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(136, 20);
            this.lbl_message.TabIndex = 4;
            this.lbl_message.Text = "Please fill the form.";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(23, 120);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(49, 20);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(23, 77);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(70, 20);
            this.lbl_surname.TabIndex = 2;
            this.lbl_surname.Text = "Surname:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(23, 30);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(52, 20);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(138, 27);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(180, 27);
            this.txt_name.TabIndex = 0;
            // 
            // lbl_selectStudents
            // 
            this.lbl_selectStudents.AutoSize = true;
            this.lbl_selectStudents.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_selectStudents.Location = new System.Drawing.Point(428, 60);
            this.lbl_selectStudents.Name = "lbl_selectStudents";
            this.lbl_selectStudents.Size = new System.Drawing.Size(123, 23);
            this.lbl_selectStudents.TabIndex = 1;
            this.lbl_selectStudents.Text = "Select Student:";
            // 
            // lst_students
            // 
            this.lst_students.FormattingEnabled = true;
            this.lst_students.ItemHeight = 20;
            this.lst_students.Location = new System.Drawing.Point(30, 311);
            this.lst_students.Name = "lst_students";
            this.lst_students.Size = new System.Drawing.Size(342, 124);
            this.lst_students.TabIndex = 2;
            // 
            // comboBox_selectStudent
            // 
            this.comboBox_selectStudent.FormattingEnabled = true;
            this.comboBox_selectStudent.Location = new System.Drawing.Point(557, 59);
            this.comboBox_selectStudent.Name = "comboBox_selectStudent";
            this.comboBox_selectStudent.Size = new System.Drawing.Size(212, 28);
            this.comboBox_selectStudent.TabIndex = 3;
            // 
            // btn_createEngagement
            // 
            this.btn_createEngagement.Location = new System.Drawing.Point(428, 107);
            this.btn_createEngagement.Name = "btn_createEngagement";
            this.btn_createEngagement.Size = new System.Drawing.Size(159, 29);
            this.btn_createEngagement.TabIndex = 4;
            this.btn_createEngagement.Text = "Create Engagement";
            this.btn_createEngagement.UseVisualStyleBackColor = true;
            this.btn_createEngagement.Click += new System.EventHandler(this.btn_createEngagement_Click);
            // 
            // btn_engagementRecords
            // 
            this.btn_engagementRecords.Location = new System.Drawing.Point(593, 107);
            this.btn_engagementRecords.Name = "btn_engagementRecords";
            this.btn_engagementRecords.Size = new System.Drawing.Size(176, 29);
            this.btn_engagementRecords.TabIndex = 5;
            this.btn_engagementRecords.Text = "Engagement Records";
            this.btn_engagementRecords.UseVisualStyleBackColor = true;
            this.btn_engagementRecords.Click += new System.EventHandler(this.btn_engagementRecords_Click);
            // 
            // lbl_students
            // 
            this.lbl_students.AutoSize = true;
            this.lbl_students.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_students.Location = new System.Drawing.Point(30, 284);
            this.lbl_students.Name = "lbl_students";
            this.lbl_students.Size = new System.Drawing.Size(76, 23);
            this.lbl_students.TabIndex = 6;
            this.lbl_students.Text = "Students";
            // 
            // tab_engagements
            // 
            this.tab_engagements.Controls.Add(this.tab_createEngagement);
            this.tab_engagements.Controls.Add(this.tab_viewEngagementRecord);
            this.tab_engagements.Location = new System.Drawing.Point(428, 167);
            this.tab_engagements.Name = "tab_engagements";
            this.tab_engagements.SelectedIndex = 0;
            this.tab_engagements.Size = new System.Drawing.Size(348, 268);
            this.tab_engagements.TabIndex = 7;
            // 
            // tab_createEngagement
            // 
            this.tab_createEngagement.Controls.Add(this.btn_createEngagementRecord);
            this.tab_createEngagement.Controls.Add(this.txt_pageView);
            this.tab_createEngagement.Controls.Add(this.txt_videoView);
            this.tab_createEngagement.Controls.Add(this.txt_engagementName);
            this.tab_createEngagement.Controls.Add(this.lbl_pageView);
            this.tab_createEngagement.Controls.Add(this.lbl_videoView);
            this.tab_createEngagement.Controls.Add(this.lbl_engagementName);
            this.tab_createEngagement.Location = new System.Drawing.Point(4, 29);
            this.tab_createEngagement.Name = "tab_createEngagement";
            this.tab_createEngagement.Padding = new System.Windows.Forms.Padding(3);
            this.tab_createEngagement.Size = new System.Drawing.Size(340, 235);
            this.tab_createEngagement.TabIndex = 0;
            this.tab_createEngagement.Text = "Create Engagement";
            this.tab_createEngagement.UseVisualStyleBackColor = true;
            // 
            // btn_createEngagementRecord
            // 
            this.btn_createEngagementRecord.Location = new System.Drawing.Point(224, 179);
            this.btn_createEngagementRecord.Name = "btn_createEngagementRecord";
            this.btn_createEngagementRecord.Size = new System.Drawing.Size(94, 29);
            this.btn_createEngagementRecord.TabIndex = 6;
            this.btn_createEngagementRecord.Text = "Create";
            this.btn_createEngagementRecord.UseVisualStyleBackColor = true;
            this.btn_createEngagementRecord.Click += new System.EventHandler(this.btn_createEngagementRecord_Click);
            // 
            // txt_pageView
            // 
            this.txt_pageView.Location = new System.Drawing.Point(150, 132);
            this.txt_pageView.Name = "txt_pageView";
            this.txt_pageView.Size = new System.Drawing.Size(168, 27);
            this.txt_pageView.TabIndex = 5;
            // 
            // txt_videoView
            // 
            this.txt_videoView.Location = new System.Drawing.Point(150, 84);
            this.txt_videoView.Name = "txt_videoView";
            this.txt_videoView.Size = new System.Drawing.Size(168, 27);
            this.txt_videoView.TabIndex = 4;
            // 
            // txt_engagementName
            // 
            this.txt_engagementName.Location = new System.Drawing.Point(150, 34);
            this.txt_engagementName.Name = "txt_engagementName";
            this.txt_engagementName.Size = new System.Drawing.Size(168, 27);
            this.txt_engagementName.TabIndex = 3;
            // 
            // lbl_pageView
            // 
            this.lbl_pageView.AutoSize = true;
            this.lbl_pageView.Location = new System.Drawing.Point(7, 135);
            this.lbl_pageView.Name = "lbl_pageView";
            this.lbl_pageView.Size = new System.Drawing.Size(117, 20);
            this.lbl_pageView.TabIndex = 2;
            this.lbl_pageView.Text = "# of page views:";
            // 
            // lbl_videoView
            // 
            this.lbl_videoView.AutoSize = true;
            this.lbl_videoView.Location = new System.Drawing.Point(7, 87);
            this.lbl_videoView.Name = "lbl_videoView";
            this.lbl_videoView.Size = new System.Drawing.Size(120, 20);
            this.lbl_videoView.TabIndex = 1;
            this.lbl_videoView.Text = "# of video views:";
            // 
            // lbl_engagementName
            // 
            this.lbl_engagementName.AutoSize = true;
            this.lbl_engagementName.Location = new System.Drawing.Point(7, 37);
            this.lbl_engagementName.Name = "lbl_engagementName";
            this.lbl_engagementName.Size = new System.Drawing.Size(137, 20);
            this.lbl_engagementName.TabIndex = 0;
            this.lbl_engagementName.Text = "Engagement name:";
            // 
            // tab_viewEngagementRecord
            // 
            this.tab_viewEngagementRecord.Controls.Add(this.lbl_engagementScoreShow);
            this.tab_viewEngagementRecord.Controls.Add(this.lst_engagementOfData);
            this.tab_viewEngagementRecord.Location = new System.Drawing.Point(4, 29);
            this.tab_viewEngagementRecord.Name = "tab_viewEngagementRecord";
            this.tab_viewEngagementRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tab_viewEngagementRecord.Size = new System.Drawing.Size(340, 235);
            this.tab_viewEngagementRecord.TabIndex = 1;
            this.tab_viewEngagementRecord.Text = "View Engagement Records";
            this.tab_viewEngagementRecord.UseVisualStyleBackColor = true;
            // 
            // lbl_engagementScoreShow
            // 
            this.lbl_engagementScoreShow.AutoSize = true;
            this.lbl_engagementScoreShow.Location = new System.Drawing.Point(18, 182);
            this.lbl_engagementScoreShow.Name = "lbl_engagementScoreShow";
            this.lbl_engagementScoreShow.Size = new System.Drawing.Size(250, 20);
            this.lbl_engagementScoreShow.TabIndex = 1;
            this.lbl_engagementScoreShow.Text = "Engagement score is displayed here.";
            // 
            // lst_engagementOfData
            // 
            this.lst_engagementOfData.FormattingEnabled = true;
            this.lst_engagementOfData.ItemHeight = 20;
            this.lst_engagementOfData.Location = new System.Drawing.Point(18, 20);
            this.lst_engagementOfData.Name = "lst_engagementOfData";
            this.lst_engagementOfData.Size = new System.Drawing.Size(301, 144);
            this.lst_engagementOfData.TabIndex = 0;
            this.lst_engagementOfData.SelectedIndexChanged += new System.EventHandler(this.lst_engagementOfData_SelectedIndexChanged);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_engagements);
            this.Controls.Add(this.lbl_students);
            this.Controls.Add(this.btn_engagementRecords);
            this.Controls.Add(this.btn_createEngagement);
            this.Controls.Add(this.comboBox_selectStudent);
            this.Controls.Add(this.lst_students);
            this.Controls.Add(this.lbl_selectStudents);
            this.Controls.Add(this.groupBox_createStudent);
            this.Name = "Frm_Main";
            this.Text = "Student_Engagement_Score_Form_EF_DB";
            this.groupBox_createStudent.ResumeLayout(false);
            this.groupBox_createStudent.PerformLayout();
            this.tab_engagements.ResumeLayout(false);
            this.tab_createEngagement.ResumeLayout(false);
            this.tab_createEngagement.PerformLayout();
            this.tab_viewEngagementRecord.ResumeLayout(false);
            this.tab_viewEngagementRecord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_createStudent;
        private System.Windows.Forms.Button btn_createStudent;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_selectStudents;
        private System.Windows.Forms.ListBox lst_students;
        private System.Windows.Forms.ComboBox comboBox_selectStudent;
        private System.Windows.Forms.Button btn_createEngagement;
        private System.Windows.Forms.Button btn_engagementRecords;
        private System.Windows.Forms.Label lbl_students;
        private System.Windows.Forms.TabControl tab_engagements;
        private System.Windows.Forms.TabPage tab_createEngagement;
        private System.Windows.Forms.TabPage tab_viewEngagementRecord;
        private System.Windows.Forms.Button btn_createEngagementRecord;
        private System.Windows.Forms.TextBox txt_pageView;
        private System.Windows.Forms.TextBox txt_videoView;
        private System.Windows.Forms.TextBox txt_engagementName;
        private System.Windows.Forms.Label lbl_pageView;
        private System.Windows.Forms.Label lbl_videoView;
        private System.Windows.Forms.Label lbl_engagementName;
        private System.Windows.Forms.Label lbl_engagementScoreShow;
        private System.Windows.Forms.ListBox lst_engagementOfData;
    }
}

