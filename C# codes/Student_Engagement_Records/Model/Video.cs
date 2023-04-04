using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Engagement_Records.Model
{
    class Video : Engagement
    {
        public int Pauses { get; set; }
        public int Plays { get; set; }
        public int minutesSkipped { get; set; }
        public int minutesWatched { get; set; }
        public override string DisplayText { get { return EngagementId.ToString() + ". VE: " + EngagementName; } }

        public override int EngagementScore()
        {
            return (minutesWatched + Pauses + Plays) / (minutesSkipped + 1);
        }
    }
}
