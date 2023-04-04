using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Engagement_Score_Form_EF_DB.Model;

namespace Student_Engagement_Score_Form_EF_DB
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            BindData();
        }
        EngagementToDatabase dbContext = new EngagementToDatabase();

        private void BindData()
        {

            lst_students.DisplayMember = "StudentFullName";
            lst_students.ValueMember = "StudentId";
            lst_students.DataSource = dbContext.Students.ToList();

            comboBox_selectStudent.DisplayMember = "StudentFullName";
            comboBox_selectStudent.ValueMember = "StudentId";
            comboBox_selectStudent.DataSource = dbContext.Students.ToList();

            lst_engagementOfData.DisplayMember = "EngagementName";
            lst_engagementOfData.ValueMember = "Id";
            lst_engagementOfData.DataSource = dbContext.Engagements.ToList();

        }

        private void btn_createStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student();
                if ((txt_name.Text != "") && (!int.TryParse(txt_name.Text, out int nameval)))
                {
                    student.StudentName = txt_name.Text;
                    if ((txt_surname.Text != "") && (!int.TryParse(txt_surname.Text, out int surnameval)))
                    {
                        student.StudentSurname = txt_surname.Text;

                        if (txt_email.Text.Contains('@'))
                        {
                            student.Email = txt_email.Text;
                            dbContext.Students.Add(student);
                            dbContext.SaveChanges();

                            lbl_message.Text = "Student record is added.";
                            lbl_message.ForeColor = Color.DarkOliveGreen;
                            txt_name.Text = "";
                            txt_surname.Text = "";
                            txt_email.Text = "";

                            BindData();
                        }
                        else
                        {
                            lbl_message.ForeColor = Color.Red;
                            lbl_message.Text = "Enter a valid email address.";
                        }
                    }
                    else
                    {
                        lbl_message.ForeColor = Color.Red;
                        lbl_message.Text = "Please enter a surname.";
                    }
                }
                else
                {
                    lbl_message.ForeColor = Color.Red;
                    lbl_message.Text = "Please enter a name.";
                }

            }
            catch (Exception ex)
            {
               lbl_message.Text = "An error has occured. More info: " + ex.Message;
            }
        }

        private void btn_createEngagement_Click(object sender, EventArgs e)
        {
            tab_engagements.SelectedTab = tab_createEngagement;
        }

        private void btn_createEngagementRecord_Click(object sender, EventArgs e)
        {
            Engagement engagements = new Engagement();

            engagements.EngagementName = txt_engagementName.Text;
            engagements.VideoView = int.Parse(txt_videoView.Text);
            engagements.PageView = int.Parse(txt_pageView.Text);
            engagements.StudentId = (int)comboBox_selectStudent.SelectedValue;

            //Add the engagement instance to the database
            dbContext.Engagements.Add(engagements);
            dbContext.SaveChanges();

            //Reset the fields
            txt_engagementName.Text = "";
            txt_pageView.Text = "";
            txt_videoView.Text = "";

            //Tab change
            tab_engagements.SelectedTab = tab_viewEngagementRecord;

            //Bind
            BindData();
        }
        private void btn_engagementRecords_Click(object sender, EventArgs e)
        {

            tab_engagements.SelectedTab = tab_viewEngagementRecord;

            int selectedStudentId = (int)comboBox_selectStudent.SelectedValue;

            List<Engagement> filteredStudent = dbContext.Engagements.Where(s => s.StudentId == selectedStudentId).ToList();

            lst_engagementOfData.DisplayMember = "EngagementName";
            lst_engagementOfData.ValueMember = "Id";
            lst_engagementOfData.DataSource = filteredStudent;

        }
        private void lst_engagementOfData_SelectedIndexChanged(object sender, EventArgs e)
        {

            object selectedStudentId = lst_engagementOfData.SelectedItem;
            Engagement engagements = dbContext.Engagements.Single(s => s == selectedStudentId);

            int EngagementScorer = engagements.PageView + engagements.VideoView;
            lbl_engagementScoreShow.Text = "Engagement Score: " + EngagementScorer.ToString();

            
        }
    }
}
