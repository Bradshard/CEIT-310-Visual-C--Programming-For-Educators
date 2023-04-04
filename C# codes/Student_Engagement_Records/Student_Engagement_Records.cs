using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Engagement_Records.Model;

namespace Student_Engagement_Records
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        int controlId = 0;
        BindingList<Engagement> engagements = new BindingList<Engagement>();

        public void ResetForm()
        {
            txt_engagementName.Text = "";
            txt_highlights.Text = "";
            txt_bookmarks.Text = "";
            txt_pagesSkipped.Text = "";
            txt_pagesRead.Text = "";
            txt_pauses.Text = "";
            txt_plays.Text = "";
            txt_minutesSkipped.Text = "";
            txt_minutesWatched.Text = "";

            txt_id.Text = controlId.ToString();
        }
        //Please fill the form to create engagement record.
        private void BindData()
        {
            lst_engagementRecords.DataSource = engagements;
            lst_engagementRecords.DisplayMember = "DisplayText";
            lst_engagementRecords.ValueMember = "EngagementId";
        }

        private void SetSharedProperties(Engagement engagement)
        {
            engagement.EngagementId = controlId;
            controlId++;
            engagement.EngagementName = txt_engagementName.Text;
        }

        private void btn_createReadingEngagement_Click(object sender, EventArgs e)
        {
            Reading myReading = new Reading();

            //Set values for the common properties
            SetSharedProperties(myReading);

            //Set values for the distinct properties
            if (int.TryParse(txt_highlights.Text, out int highlights))
            {
                if (int.TryParse(txt_bookmarks.Text, out int bookmarks))
                {
                    if (int.TryParse(txt_pagesSkipped.Text, out int pages_skipped))
                    {
                        if (int.TryParse(txt_pagesRead.Text, out int pages_read))
                        {
                            myReading.pagesRead = pages_read;
                            myReading.Highlights = highlights;
                            myReading.pagesSkipped = pages_skipped;
                            myReading.Bookmarks = bookmarks;

                            // Add the myReading object to a list of engagements
                            engagements.Add(myReading);

                            lbl_message.ForeColor = Color.DarkOliveGreen;
                            lbl_message.Text = "Reading engagement record is added.";

                            ResetForm();

                        }
                        else
                        {
                            lbl_message.ForeColor = Color.Red;
                            lbl_message.Text = "Invalid entry in the Pages Read entry.";

                        }

                    }

                    else
                    {
                        lbl_message.ForeColor = Color.Red;
                        lbl_message.Text = "Invalid entry in the Pages Skipped entry.";
                    }
                }
                else
                {
                    lbl_message.ForeColor = Color.Red;
                    lbl_message.Text = ("Invalid entry in the Bookmarks box.");
                }
            }
            else
            {
                lbl_message.ForeColor = Color.Red;
                lbl_message.Text = ("Invalid entry in the Highlights box.");
            }
        }

        private void btn_createVideoEngagement_Click(object sender, EventArgs e)
        {
            Video myVideo = new Video();

            //Set values for the common properties
            SetSharedProperties(myVideo);

            //Set values for the distinct properties
            if (int.TryParse(txt_pauses.Text, out int pauses))
            {
                if (int.TryParse(txt_plays.Text, out int plays))
                {
                    if (int.TryParse(txt_minutesSkipped.Text, out int minutes_skipped))
                    {
                        if (int.TryParse(txt_minutesWatched.Text, out int minutes_watched))
                        {
                            myVideo.Pauses = pauses;
                            myVideo.Plays = plays;
                            myVideo.minutesSkipped = minutes_skipped;
                            myVideo.minutesWatched = minutes_watched;

                            // Add the myReading object to a list of engagements
                            engagements.Add(myVideo);

                            lbl_message.ForeColor = Color.DarkOliveGreen;
                            lbl_message.Text = "Video engagement record is added.";

                            ResetForm();

                        }
                        else
                        {
                            lbl_message.ForeColor = Color.Red;
                            lbl_message.Text = "Invalid entry in the Minutes Watched entry.";

                        }

                    }

                    else
                    {
                        lbl_message.ForeColor = Color.Red;
                        lbl_message.Text = "Invalid entry in the Minutes Skipped entry.";
                    }
                }
                else
                {
                    lbl_message.ForeColor = Color.Red;
                    lbl_message.Text = ("Invalid entry in the Plays box.");
                }
            }
            else
            {
                lbl_message.ForeColor = Color.Red;
                lbl_message.Text = ("Invalid entry in the Pauses box.");
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void lst_engagementRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            int engagementsId = (int)lst_engagementRecords.SelectedValue;
            Engagement selectedEngagement = engagements.Single(s => s.EngagementId == engagementsId);

            double engagementScore = Math.Round((double) selectedEngagement.EngagementScore(), 2);
            lbl_average.Text = "Engagement score: " + engagementScore.ToString();
        }
    }
}
