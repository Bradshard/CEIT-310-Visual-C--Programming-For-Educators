using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Engagement_Records.Model
{
    class Reading : Engagement
    {
        public int Highlights { get; set; }
        public int Bookmarks { get; set; }
        public int pagesSkipped { get; set; }
        public int pagesRead { get; set; }

        public override string DisplayText { get { return EngagementId.ToString() + ". RE: " + EngagementName; } }

        public override int EngagementScore()
        {
            return (Highlights + pagesRead + Bookmarks) / (pagesSkipped + 1);
        }
    }
}
