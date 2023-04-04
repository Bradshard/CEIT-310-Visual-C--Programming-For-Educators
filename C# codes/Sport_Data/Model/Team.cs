using System;
using System.Collections.Generic;
using System.Text;

namespace Sports_Score_Game_Form.Model
{
    class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string League { get; set; }

        public int Wins { get; set; }
        public int Defeats { get; set; }

        public int ScoresAchieved { get; set; }

        public int ScoresConceded { get; set; }

        public string DisplayText { get { return Id.ToString() + ". " + Name; } }

        public virtual int CalculateMatchesPlayed()
        {
            return 0;
        }

        public virtual int CalculatePoints()
        {
            return 0;
        }
    }
}
