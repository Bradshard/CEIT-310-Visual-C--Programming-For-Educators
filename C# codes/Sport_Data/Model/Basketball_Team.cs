using System;
using System.Collections.Generic;
using System.Text;

namespace Sports_Score_Game_Form.Model
{
    class Basketball_Team : Team
    {
        public int TotalFauls { get; set; }

        public int TotalRebounds { get; set; }

        public override int CalculateMatchesPlayed()
        {
            return Wins + Defeats;
        }

        public override int CalculatePoints()
        {
            return Wins * 2 + Defeats;
        }
    }
}
