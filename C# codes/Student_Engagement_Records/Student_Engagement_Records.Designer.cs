
namespace Student_Engagement_Records
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
            this.lbl_average = new System.Windows.Forms.Label();
            this.lst_engagementRecords = new System.Windows.Forms.ListBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.txt_engagementName = new System.Windows.Forms.TextBox();
            this.lbl_engagementName = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_engagementID = new System.Windows.Forms.Label();
            this.lbl_studentEngagementRecords = new System.Windows.Forms.Label();
            this.groupBox_studentEngagement = new System.Windows.Forms.GroupBox();
            this.btn_createVideoEngagement = new System.Windows.Forms.Button();
            this.txt_minutesWatched = new System.Windows.Forms.TextBox();
            this.lbl_minutesWatched = new System.Windows.Forms.Label();
            this.tab_allEngagements = new System.Windows.Forms.TabControl();
            this.tabPage_readingEngagement = new System.Windows.Forms.TabPage();
            this.btn_createReadingEngagement = new System.Windows.Forms.Button();
            this.txt_pagesRead = new System.Windows.Forms.TextBox();
            this.lbl_pageReadNumber = new System.Windows.Forms.Label();
            this.txt_pagesSkipped = new System.Windows.Forms.TextBox();
            this.lbl_pagesSkipped = new System.Windows.Forms.Label();
            this.txt_bookmarks = new System.Windows.Forms.TextBox();
            this.lbl_bookmarksNumber = new System.Windows.Forms.Label();
            this.txt_highlights = new System.Windows.Forms.TextBox();
            this.lbl_numberHighlights = new System.Windows.Forms.Label();
            this.tabPage_videoEngagement = new System.Windows.Forms.TabPage();
            this.txt_minutesSkipped = new System.Windows.Forms.TextBox();
            this.lbl_minutesSkipped = new System.Windows.Forms.Label();
            this.txt_plays = new System.Windows.Forms.TextBox();
            this.lbl_numberPlays = new System.Windows.Forms.Label();
            this.txt_pauses = new System.Windows.Forms.TextBox();
            this.lbl_numberofPauses = new System.Windows.Forms.Label();
            this.groupBox_studentEngagement.SuspendLayout();
            this.tab_allEngagements.SuspendLayout();
            this.tabPage_readingEngagement.SuspendLayout();
            this.tabPage_videoEngagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_average
            // 
            this.lbl_average.AutoSize = true;
            this.lbl_average.Location = new System.Drawing.Point(379, 455);
            this.lbl_average.Name = "lbl_average";
            this.lbl_average.Size = new System.Drawing.Size(250, 20);
            this.lbl_average.TabIndex = 12;
            this.lbl_average.Text = "Engagement score is displayed here.";
            // 
            // lst_engagementRecords
            // 
            this.lst_engagementRecords.FormattingEnabled = true;
            this.lst_engagementRecords.ItemHeight = 20;
            this.lst_engagementRecords.Location = new System.Drawing.Point(379, 83);
            this.lst_engagementRecords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lst_engagementRecords.Name = "lst_engagementRecords";
            this.lst_engagementRecords.Size = new System.Drawing.Size(254, 364);
            this.lst_engagementRecords.TabIndex = 10;
            this.lst_engagementRecords.SelectedIndexChanged += new System.EventHandler(this.lst_engagementRecords_SelectedIndexChanged);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(43, 455);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(334, 20);
            this.lbl_message.TabIndex = 9;
            this.lbl_message.Text = "Please fill the form to create engagement record.";
            // 
            // txt_engagementName
            // 
            this.txt_engagementName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_engagementName.Location = new System.Drawing.Point(154, 76);
            this.txt_engagementName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_engagementName.Name = "txt_engagementName";
            this.txt_engagementName.Size = new System.Drawing.Size(130, 27);
            this.txt_engagementName.TabIndex = 3;
            // 
            // lbl_engagementName
            // 
            this.lbl_engagementName.AutoSize = true;
            this.lbl_engagementName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_engagementName.Location = new System.Drawing.Point(25, 80);
            this.lbl_engagementName.Name = "lbl_engagementName";
            this.lbl_engagementName.Size = new System.Drawing.Size(145, 20);
            this.lbl_engagementName.TabIndex = 2;
            this.lbl_engagementName.Text = "Engagement name : ";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_id.Location = new System.Drawing.Point(154, 37);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(130, 27);
            this.txt_id.TabIndex = 1;
            this.txt_id.Text = "0";
            // 
            // lbl_engagementID
            // 
            this.lbl_engagementID.AutoSize = true;
            this.lbl_engagementID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_engagementID.Location = new System.Drawing.Point(25, 41);
            this.lbl_engagementID.Name = "lbl_engagementID";
            this.lbl_engagementID.Size = new System.Drawing.Size(121, 20);
            this.lbl_engagementID.TabIndex = 0;
            this.lbl_engagementID.Text = "Engagement Id : ";
            // 
            // lbl_studentEngagementRecords
            // 
            this.lbl_studentEngagementRecords.AutoSize = true;
            this.lbl_studentEngagementRecords.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_studentEngagementRecords.Location = new System.Drawing.Point(374, 39);
            this.lbl_studentEngagementRecords.Name = "lbl_studentEngagementRecords";
            this.lbl_studentEngagementRecords.Size = new System.Drawing.Size(263, 25);
            this.lbl_studentEngagementRecords.TabIndex = 11;
            this.lbl_studentEngagementRecords.Text = "Student Engagement Records ";
            // 
            // groupBox_studentEngagement
            // 
            this.groupBox_studentEngagement.Controls.Add(this.txt_engagementName);
            this.groupBox_studentEngagement.Controls.Add(this.lbl_engagementName);
            this.groupBox_studentEngagement.Controls.Add(this.txt_id);
            this.groupBox_studentEngagement.Controls.Add(this.lbl_engagementID);
            this.groupBox_studentEngagement.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_studentEngagement.Location = new System.Drawing.Point(39, 39);
            this.groupBox_studentEngagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_studentEngagement.Name = "groupBox_studentEngagement";
            this.groupBox_studentEngagement.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_studentEngagement.Size = new System.Drawing.Size(312, 128);
            this.groupBox_studentEngagement.TabIndex = 8;
            this.groupBox_studentEngagement.TabStop = false;
            this.groupBox_studentEngagement.Text = "Student Engagement";
            // 
            // btn_createVideoEngagement
            // 
            this.btn_createVideoEngagement.Location = new System.Drawing.Point(198, 184);
            this.btn_createVideoEngagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_createVideoEngagement.Name = "btn_createVideoEngagement";
            this.btn_createVideoEngagement.Size = new System.Drawing.Size(86, 31);
            this.btn_createVideoEngagement.TabIndex = 21;
            this.btn_createVideoEngagement.Text = "Create";
            this.btn_createVideoEngagement.UseVisualStyleBackColor = true;
            this.btn_createVideoEngagement.Click += new System.EventHandler(this.btn_createVideoEngagement_Click);
            // 
            // txt_minutesWatched
            // 
            this.txt_minutesWatched.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_minutesWatched.Location = new System.Drawing.Point(153, 133);
            this.txt_minutesWatched.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_minutesWatched.Name = "txt_minutesWatched";
            this.txt_minutesWatched.Size = new System.Drawing.Size(130, 27);
            this.txt_minutesWatched.TabIndex = 20;
            // 
            // lbl_minutesWatched
            // 
            this.lbl_minutesWatched.AutoSize = true;
            this.lbl_minutesWatched.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_minutesWatched.Location = new System.Drawing.Point(27, 141);
            this.lbl_minutesWatched.Name = "lbl_minutesWatched";
            this.lbl_minutesWatched.Size = new System.Drawing.Size(132, 20);
            this.lbl_minutesWatched.TabIndex = 19;
            this.lbl_minutesWatched.Text = "Minutes watched : ";
            // 
            // tab_allEngagements
            // 
            this.tab_allEngagements.Controls.Add(this.tabPage_readingEngagement);
            this.tab_allEngagements.Controls.Add(this.tabPage_videoEngagement);
            this.tab_allEngagements.Location = new System.Drawing.Point(39, 177);
            this.tab_allEngagements.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_allEngagements.Name = "tab_allEngagements";
            this.tab_allEngagements.SelectedIndex = 0;
            this.tab_allEngagements.Size = new System.Drawing.Size(317, 271);
            this.tab_allEngagements.TabIndex = 7;
            // 
            // tabPage_readingEngagement
            // 
            this.tabPage_readingEngagement.Controls.Add(this.btn_createReadingEngagement);
            this.tabPage_readingEngagement.Controls.Add(this.txt_pagesRead);
            this.tabPage_readingEngagement.Controls.Add(this.lbl_pageReadNumber);
            this.tabPage_readingEngagement.Controls.Add(this.txt_pagesSkipped);
            this.tabPage_readingEngagement.Controls.Add(this.lbl_pagesSkipped);
            this.tabPage_readingEngagement.Controls.Add(this.txt_bookmarks);
            this.tabPage_readingEngagement.Controls.Add(this.lbl_bookmarksNumber);
            this.tabPage_readingEngagement.Controls.Add(this.txt_highlights);
            this.tabPage_readingEngagement.Controls.Add(this.lbl_numberHighlights);
            this.tabPage_readingEngagement.Location = new System.Drawing.Point(4, 29);
            this.tabPage_readingEngagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_readingEngagement.Name = "tabPage_readingEngagement";
            this.tabPage_readingEngagement.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_readingEngagement.Size = new System.Drawing.Size(309, 238);
            this.tabPage_readingEngagement.TabIndex = 0;
            this.tabPage_readingEngagement.Text = "Reading Engagement";
            this.tabPage_readingEngagement.UseVisualStyleBackColor = true;
            // 
            // btn_createReadingEngagement
            // 
            this.btn_createReadingEngagement.Location = new System.Drawing.Point(194, 189);
            this.btn_createReadingEngagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_createReadingEngagement.Name = "btn_createReadingEngagement";
            this.btn_createReadingEngagement.Size = new System.Drawing.Size(86, 31);
            this.btn_createReadingEngagement.TabIndex = 12;
            this.btn_createReadingEngagement.Text = "Create";
            this.btn_createReadingEngagement.UseVisualStyleBackColor = true;
            this.btn_createReadingEngagement.Click += new System.EventHandler(this.btn_createReadingEngagement_Click);
            // 
            // txt_pagesRead
            // 
            this.txt_pagesRead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pagesRead.Location = new System.Drawing.Point(150, 139);
            this.txt_pagesRead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pagesRead.Name = "txt_pagesRead";
            this.txt_pagesRead.Size = new System.Drawing.Size(130, 27);
            this.txt_pagesRead.TabIndex = 11;
            // 
            // lbl_pageReadNumber
            // 
            this.lbl_pageReadNumber.AutoSize = true;
            this.lbl_pageReadNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pageReadNumber.Location = new System.Drawing.Point(24, 147);
            this.lbl_pageReadNumber.Name = "lbl_pageReadNumber";
            this.lbl_pageReadNumber.Size = new System.Drawing.Size(125, 20);
            this.lbl_pageReadNumber.TabIndex = 10;
            this.lbl_pageReadNumber.Text = "# of pages read : ";
            // 
            // txt_pagesSkipped
            // 
            this.txt_pagesSkipped.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pagesSkipped.Location = new System.Drawing.Point(150, 100);
            this.txt_pagesSkipped.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pagesSkipped.Name = "txt_pagesSkipped";
            this.txt_pagesSkipped.Size = new System.Drawing.Size(130, 27);
            this.txt_pagesSkipped.TabIndex = 9;
            // 
            // lbl_pagesSkipped
            // 
            this.lbl_pagesSkipped.AutoSize = true;
            this.lbl_pagesSkipped.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pagesSkipped.Location = new System.Drawing.Point(24, 108);
            this.lbl_pagesSkipped.Name = "lbl_pagesSkipped";
            this.lbl_pagesSkipped.Size = new System.Drawing.Size(147, 20);
            this.lbl_pagesSkipped.TabIndex = 8;
            this.lbl_pagesSkipped.Text = "# of pages skipped : ";
            // 
            // txt_bookmarks
            // 
            this.txt_bookmarks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_bookmarks.Location = new System.Drawing.Point(150, 61);
            this.txt_bookmarks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_bookmarks.Name = "txt_bookmarks";
            this.txt_bookmarks.Size = new System.Drawing.Size(130, 27);
            this.txt_bookmarks.TabIndex = 7;
            // 
            // lbl_bookmarksNumber
            // 
            this.lbl_bookmarksNumber.AutoSize = true;
            this.lbl_bookmarksNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_bookmarksNumber.Location = new System.Drawing.Point(24, 69);
            this.lbl_bookmarksNumber.Name = "lbl_bookmarksNumber";
            this.lbl_bookmarksNumber.Size = new System.Drawing.Size(124, 20);
            this.lbl_bookmarksNumber.TabIndex = 6;
            this.lbl_bookmarksNumber.Text = "# of bookmarks : ";
            // 
            // txt_highlights
            // 
            this.txt_highlights.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_highlights.Location = new System.Drawing.Point(150, 23);
            this.txt_highlights.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_highlights.Name = "txt_highlights";
            this.txt_highlights.Size = new System.Drawing.Size(130, 27);
            this.txt_highlights.TabIndex = 5;
            // 
            // lbl_numberHighlights
            // 
            this.lbl_numberHighlights.AutoSize = true;
            this.lbl_numberHighlights.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_numberHighlights.Location = new System.Drawing.Point(24, 31);
            this.lbl_numberHighlights.Name = "lbl_numberHighlights";
            this.lbl_numberHighlights.Size = new System.Drawing.Size(116, 20);
            this.lbl_numberHighlights.TabIndex = 4;
            this.lbl_numberHighlights.Text = "# of highlights : ";
            // 
            // tabPage_videoEngagement
            // 
            this.tabPage_videoEngagement.Controls.Add(this.btn_createVideoEngagement);
            this.tabPage_videoEngagement.Controls.Add(this.txt_minutesWatched);
            this.tabPage_videoEngagement.Controls.Add(this.lbl_minutesWatched);
            this.tabPage_videoEngagement.Controls.Add(this.txt_minutesSkipped);
            this.tabPage_videoEngagement.Controls.Add(this.lbl_minutesSkipped);
            this.tabPage_videoEngagement.Controls.Add(this.txt_plays);
            this.tabPage_videoEngagement.Controls.Add(this.lbl_numberPlays);
            this.tabPage_videoEngagement.Controls.Add(this.txt_pauses);
            this.tabPage_videoEngagement.Controls.Add(this.lbl_numberofPauses);
            this.tabPage_videoEngagement.Location = new System.Drawing.Point(4, 29);
            this.tabPage_videoEngagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_videoEngagement.Name = "tabPage_videoEngagement";
            this.tabPage_videoEngagement.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_videoEngagement.Size = new System.Drawing.Size(309, 238);
            this.tabPage_videoEngagement.TabIndex = 1;
            this.tabPage_videoEngagement.Text = "Video Engagement";
            this.tabPage_videoEngagement.UseVisualStyleBackColor = true;
            // 
            // txt_minutesSkipped
            // 
            this.txt_minutesSkipped.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_minutesSkipped.Location = new System.Drawing.Point(153, 95);
            this.txt_minutesSkipped.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_minutesSkipped.Name = "txt_minutesSkipped";
            this.txt_minutesSkipped.Size = new System.Drawing.Size(130, 27);
            this.txt_minutesSkipped.TabIndex = 18;
            // 
            // lbl_minutesSkipped
            // 
            this.lbl_minutesSkipped.AutoSize = true;
            this.lbl_minutesSkipped.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_minutesSkipped.Location = new System.Drawing.Point(27, 103);
            this.lbl_minutesSkipped.Name = "lbl_minutesSkipped";
            this.lbl_minutesSkipped.Size = new System.Drawing.Size(128, 20);
            this.lbl_minutesSkipped.TabIndex = 17;
            this.lbl_minutesSkipped.Text = "Minutes skipped : ";
            // 
            // txt_plays
            // 
            this.txt_plays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_plays.Location = new System.Drawing.Point(153, 56);
            this.txt_plays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_plays.Name = "txt_plays";
            this.txt_plays.Size = new System.Drawing.Size(130, 27);
            this.txt_plays.TabIndex = 16;
            // 
            // lbl_numberPlays
            // 
            this.lbl_numberPlays.AutoSize = true;
            this.lbl_numberPlays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_numberPlays.Location = new System.Drawing.Point(27, 64);
            this.lbl_numberPlays.Name = "lbl_numberPlays";
            this.lbl_numberPlays.Size = new System.Drawing.Size(85, 20);
            this.lbl_numberPlays.TabIndex = 15;
            this.lbl_numberPlays.Text = "# of plays : ";
            // 
            // txt_pauses
            // 
            this.txt_pauses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pauses.Location = new System.Drawing.Point(153, 17);
            this.txt_pauses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pauses.Name = "txt_pauses";
            this.txt_pauses.Size = new System.Drawing.Size(130, 27);
            this.txt_pauses.TabIndex = 14;
            // 
            // lbl_numberofPauses
            // 
            this.lbl_numberofPauses.AutoSize = true;
            this.lbl_numberofPauses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_numberofPauses.Location = new System.Drawing.Point(27, 25);
            this.lbl_numberofPauses.Name = "lbl_numberofPauses";
            this.lbl_numberofPauses.Size = new System.Drawing.Size(96, 20);
            this.lbl_numberofPauses.TabIndex = 13;
            this.lbl_numberofPauses.Text = "# of pauses : ";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 512);
            this.Controls.Add(this.lbl_average);
            this.Controls.Add(this.lst_engagementRecords);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.lbl_studentEngagementRecords);
            this.Controls.Add(this.groupBox_studentEngagement);
            this.Controls.Add(this.tab_allEngagements);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Main";
            this.Text = "Student_Engagement_Records";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.groupBox_studentEngagement.ResumeLayout(false);
            this.groupBox_studentEngagement.PerformLayout();
            this.tab_allEngagements.ResumeLayout(false);
            this.tabPage_readingEngagement.ResumeLayout(false);
            this.tabPage_readingEngagement.PerformLayout();
            this.tabPage_videoEngagement.ResumeLayout(false);
            this.tabPage_videoEngagement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_average;
        private System.Windows.Forms.ListBox lst_engagementRecords;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.TextBox txt_engagementName;
        private System.Windows.Forms.Label lbl_engagementName;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_engagementID;
        private System.Windows.Forms.Label lbl_studentEngagementRecords;
        private System.Windows.Forms.GroupBox groupBox_studentEngagement;
        private System.Windows.Forms.Button btn_createVideoEngagement;
        private System.Windows.Forms.TextBox txt_minutesWatched;
        private System.Windows.Forms.Label lbl_minutesWatched;
        private System.Windows.Forms.TabControl tab_allEngagements;
        private System.Windows.Forms.TabPage tabPage_readingEngagement;
        private System.Windows.Forms.Button btn_createReadingEngagement;
        private System.Windows.Forms.TextBox txt_pagesRead;
        private System.Windows.Forms.Label lbl_pageReadNumber;
        private System.Windows.Forms.TextBox txt_pagesSkipped;
        private System.Windows.Forms.Label lbl_pagesSkipped;
        private System.Windows.Forms.TextBox txt_bookmarks;
        private System.Windows.Forms.Label lbl_bookmarksNumber;
        private System.Windows.Forms.TextBox txt_highlights;
        private System.Windows.Forms.Label lbl_numberHighlights;
        private System.Windows.Forms.TabPage tabPage_videoEngagement;
        private System.Windows.Forms.TextBox txt_minutesSkipped;
        private System.Windows.Forms.Label lbl_minutesSkipped;
        private System.Windows.Forms.TextBox txt_plays;
        private System.Windows.Forms.Label lbl_numberPlays;
        private System.Windows.Forms.TextBox txt_pauses;
        private System.Windows.Forms.Label lbl_numberofPauses;
    }
}

