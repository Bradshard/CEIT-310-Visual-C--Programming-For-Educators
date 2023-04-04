using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module5_lab_assignment_burkan_bereketoglu
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }


        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void grp_discussions_Enter(object sender, EventArgs e)
        {

        }

        private void btn_calculateEngagementScore_Click(object sender, EventArgs e)
        {
            double video_score = 0.0;
            double reading_score = 0.0;
            double discussion_score = 0.0;
            double quiz_score = 0.0;

            // reading var
            int pgv;
            int hgl;
            int ups;
            //discussion var
            int qts;
            int cmts;
            int unp;
            // video var
            int amn;
            int pps;
            int skp;
            // quiz var
            int faq;
            int aqs;
            int anoa;

            // reading part
            if (int.TryParse(txt_numberofPageViews.Text, out int page_view))
            {
                if (int.TryParse(txt_numberofHighlights.Text, out int highlights))
                {
                    if (int.TryParse(txt_numberofUnreadPages.Text, out int unread_pages))
                    {
                        pgv = page_view;
                        hgl = highlights;
                        ups = unread_pages;

                        reading_score = Math.Round((double)((pgv + hgl) / ups), 2);
                        lbl_readingEngagement.ForeColor = Color.Blue;
                        lbl_readingEngagement.Text = ("Reading score is: " + reading_score);

                    }

                    else
                    {
                        lbl_readingEngagement.ForeColor = Color.Red;
                        lbl_readingEngagement.Text = ("Invalid entry in the Unread Pages box.");
                    }
                }
                else
                {
                    lbl_readingEngagement.ForeColor = Color.Red;
                    lbl_readingEngagement.Text = ("Invalid entry in the Highlights box.");
                }
            }
            else
            {
                lbl_readingEngagement.ForeColor = Color.Red;
                lbl_readingEngagement.Text = ("Invalid entry in the Page Views box.");
            }

            // discussion part
            if (int.TryParse(txt_numberofQuestions.Text, out int Questions))
            {
                if (int.TryParse(txt_numberofComments.Text, out int Comments))
                {
                    if (int.TryParse(txt_numberofUnreadPosts.Text, out int UnreadPosts))
                    {
                        qts = Questions;
                        cmts = Comments;
                        unp = UnreadPosts;

                        discussion_score = Math.Round((double)((qts + cmts) / unp), 2);
                        lbl_discussionEngagement.ForeColor = Color.Blue;
                        lbl_discussionEngagement.Text = ("Discussion score is: " + discussion_score);


                    }

                    else
                    {
                        lbl_discussionEngagement.ForeColor = Color.Red;
                        lbl_discussionEngagement.Text = ("Invalid entry in the Unread Posts box.");
                    }
                }
                else
                {
                    lbl_discussionEngagement.ForeColor = Color.Red;
                    lbl_discussionEngagement.Text = ("Invalid entry in the Comments box.");
                }
            }
            else
            {
                lbl_discussionEngagement.ForeColor = Color.Red;
                lbl_discussionEngagement.Text = ("Invalid entry in the Questions box.");
            }

            // videos part
            if (int.TryParse(txt_avgMinutesWatched.Text, out int averageMin))
            {
                if (int.TryParse(txt_numberofPlayPause.Text, out int Playpause))
                {
                    if (int.TryParse(txt_minutesSkipped.Text, out int Skipped))
                    {
                        amn = averageMin;
                        pps = Playpause;
                        skp = Skipped;

                        video_score = Math.Round((double)((amn + pps) / skp), 2);
                        lbl_videoEngagement.ForeColor = Color.Blue;
                        lbl_videoEngagement.Text = ("Video score is: " + video_score);


                    }

                    else
                    {
                        lbl_videoEngagement.ForeColor = Color.Red;
                        lbl_videoEngagement.Text = ("Invalid entry in the Skipped box.");
                    }
                }
                else
                {
                    lbl_videoEngagement.ForeColor = Color.Red;
                    lbl_videoEngagement.Text = ("Invalid entry in the Play/Pause box.");
                }
            }
            else
            {
                lbl_videoEngagement.ForeColor = Color.Red;
                lbl_videoEngagement.Text = ("Invalid entry in the Average Minutes box.");
            }

            // quizzes part

            if (int.TryParse(txt_numberofFailedQuestions.Text, out int FailedQ))
            {
                if (int.TryParse(txt_avgQuizScore.Text, out int avgQuizScore))
                {
                    if (int.TryParse(txt_avgNumberOfAttempts.Text, out int avgAttempts))
                    {
                        faq = FailedQ;
                        aqs = avgQuizScore;
                        anoa = avgAttempts;

                        quiz_score = Math.Round((double)((faq + aqs) / anoa), 2);
                        lbl_quizEngagement.ForeColor = Color.Blue;
                        lbl_quizEngagement.Text = ("Quiz score is: " + quiz_score);


                    }

                    else
                    {
                        lbl_quizEngagement.ForeColor = Color.Red;
                        lbl_quizEngagement.Text = ("Invalid entry in the Average Attempt box.");
                    }
                }
                else
                {
                    lbl_quizEngagement.ForeColor = Color.Red;
                    lbl_quizEngagement.Text = ("Invalid entry in the Average Quiz Score box.");
                }
            }
            else
            {
                lbl_quizEngagement.ForeColor = Color.Red;
                lbl_quizEngagement.Text = ("Invalid entry in the Failed Question box.");
            }
            // overall soln
            double overall_score = reading_score + quiz_score + video_score + discussion_score;
            lbl_overallEngagement.Text = ("General engagement score is: " + overall_score);
        }
    }
}
