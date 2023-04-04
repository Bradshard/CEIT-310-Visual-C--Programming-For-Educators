using System;
using System.Collections.Generic;
using System.Text;

namespace Sports_Score_Game_Form.Model
{
    class Football_Team : Team
    {
        public int Average
        {
            get { { return ScoresAchieved - ScoresConceded; } }
        }

        public int Draws { get; set; }

        public override int CalculateMatchesPlayed()
        {
            return Wins + Defeats + Draws;
        }

        public override int CalculatePoints()
        {
            return Wins *3 + Draws;
        }
    }
}
