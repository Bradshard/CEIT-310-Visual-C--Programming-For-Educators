using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports_Score_Game_Form.Model;

namespace Sports_Score_Game_Form
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        int controlId = 0;
        BindingList<Team> teams = new BindingList<Team>();
        public void ResetForm()
        {
            txt_name.Text = "";
            txt_wins.Text = "";
            txt_league.Text = "";
            txt_defeats.Text = "";
            txt_scoresAchieved.Text = "";
            txt_scoresConceded.Text = "";
            txt_totalFauls.Text = "";
            txt_draws.Text = "";
            txt_totalRebounds.Text = "";
            txt_average.Text = "";

            txt_id.Text = controlId.ToString();
        }
        private void BindData()
        {
            lst_teams.DataSource = teams;
            lst_teams.DisplayMember = "DisplayText";
            lst_teams.ValueMember = "Id";
        }


        private void SetSharedProperties(Team team)
        {
            team.Id = controlId;
            controlId++;
            team.Name = txt_name.Text;
            team.League = txt_league.Text;
            team.Wins = int.Parse(txt_wins.Text);
            team.Defeats = int.Parse(txt_defeats.Text);
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Width = 400;
            BindData();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {  
            this.Width = 840;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetForm();
            Width = 420;
        }

        private void btn_createFootballTeam_Click(object sender, EventArgs e)
        {
            //Create an empty Football Team object named myFootballTeam
            Football_Team myFootballTeam = new Football_Team();
            SetSharedProperties(myFootballTeam);

            //Set values for the distinct properties
            myFootballTeam.ScoresAchieved = int.Parse(txt_scoresAchieved.Text);
            myFootballTeam.ScoresConceded = int.Parse(txt_scoresConceded.Text);
            myFootballTeam.Draws = int.Parse(txt_draws.Text);
            //myFootballTeam.Average is read only and already saved.

            //Add the myFootballTeam object to a list of Football Teams
            teams.Add(myFootballTeam);

            //Switch to the Team List tab
            tab_teams.SelectedTab = tab_footballTeam;

            //Reset the form
            ResetForm();

            //Set average value
            txt_average.Text = myFootballTeam.Average.ToString();
        }


        private void btn_createBasketballTeam_Click(object sender, EventArgs e)
        {
            //Create an empty Football Team object named myFootballTeam
            Basketball_Team myBasketballTeam = new Basketball_Team();
            SetSharedProperties(myBasketballTeam);

            //Set values for the distinct properties
            myBasketballTeam.TotalFauls = int.Parse(txt_totalFauls.Text);
            myBasketballTeam.TotalRebounds = int.Parse(txt_totalRebounds.Text);

            //Add the myBasketballTeam object to a list of Football Teams
            teams.Add(myBasketballTeam);

            //Switch to the Team List tab
            tab_teams.SelectedTab = tab_teamList;

            //Reset the form
            ResetForm();
        }

        private void lst_teams_SelectedIndexChanged(object sender, EventArgs e)
        {
            int teamId = (int)lst_teams.SelectedValue;
            Team selectedTeam = teams.Single(t => t.Id == teamId);

            int matches_played = selectedTeam.CalculateMatchesPlayed();
            lbl_totalMatches.Text = "Total Match Count : " + matches_played.ToString();

            int total_points = selectedTeam.CalculatePoints();
            lbl_totalPoints.Text = "Total Points : " + total_points.ToString();

        }
    }
}
