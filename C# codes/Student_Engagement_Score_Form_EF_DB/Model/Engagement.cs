using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Student_Engagement_Score_Form_EF_DB.Model
{
    public class Engagement
    {
        public int Id { get; set; }

        public string EngagementName { get; set; }

        public int VideoView { get; set; }
        public int PageView { get; set; }

        public int EngagementScoreCalc { get { return VideoView + PageView; } }

        //Defining the foreign key
        [ForeignKey("ParentStudent")]
        public int StudentId { get; set; }
    }
}
