using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Engagement_Records.Model
{
    class Engagement
    {
        public int EngagementId { get; set; }

        public string EngagementName { get; set; }

        public virtual string DisplayText { get { return EngagementId.ToString() + ". " + EngagementName; } }

        public virtual int EngagementScore()
        {
            return 0;
        }
    }
}
