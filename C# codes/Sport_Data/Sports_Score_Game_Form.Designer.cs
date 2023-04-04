
namespace Sports_Score_Game_Form
{
    partial class Frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_league = new System.Windows.Forms.TextBox();
            this.grp_createaTeam = new System.Windows.Forms.GroupBox();
            this.lbl_defeats = new System.Windows.Forms.Label();
            this.lbl_wins = new System.Windows.Forms.Label();
            this.lbl_league = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_scoresAchieved = new System.Windows.Forms.TextBox();
            this.lbl_scoresConceded = new System.Windows.Forms.Label();
            this.btn_continue = new System.Windows.Forms.Button();
            this.lbl_scoresAchieved = new System.Windows.Forms.Label();
            this.txt_scoresConceded = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_defeats = new System.Windows.Forms.TextBox();
            this.txt_wins = new System.Windows.Forms.TextBox();
            this.tab_teams = new System.Windows.Forms.TabControl();
            this.tab_footballTeam = new System.Windows.Forms.TabPage();
            this.btn_createFootballTeam = new System.Windows.Forms.Button();
            this.txt_draws = new System.Windows.Forms.TextBox();
            this.lbl_draws = new System.Windows.Forms.Label();
            this.txt_average = new System.Windows.Forms.TextBox();
            this.lbl_average = new System.Windows.Forms.Label();
            this.tab_basketballTeam = new System.Windows.Forms.TabPage();
            this.btn_createBasketballTeam = new System.Windows.Forms.Button();
            this.txt_totalRebounds = new System.Windows.Forms.TextBox();
            this.txt_totalFauls = new System.Windows.Forms.TextBox();
            this.lbl_totalRebounds = new System.Windows.Forms.Label();
            this.lbl_totalFauls = new System.Windows.Forms.Label();
            this.tab_teamList = new System.Windows.Forms.TabPage();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_totalPoints = new System.Windows.Forms.Label();
            this.lbl_totalMatches = new System.Windows.Forms.Label();
            this.lst_teams = new System.Windows.Forms.ListBox();
            this.grp_createaTeam.SuspendLayout();
            this.tab_teams.SuspendLayout();
            this.tab_footballTeam.SuspendLayout();
            this.tab_basketballTeam.SuspendLayout();
            this.tab_teamList.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(154, 43);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(168, 31);
            this.txt_id.TabIndex = 0;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(154, 94);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(168, 31);
            this.txt_name.TabIndex = 1;
            // 
            // txt_league
            // 
            this.txt_league.Location = new System.Drawing.Point(154, 150);
            this.txt_league.Name = "txt_league";
            this.txt_league.Size = new System.Drawing.Size(168, 31);
            this.txt_league.TabIndex = 2;
            // 
            // grp_createaTeam
            // 
            this.grp_createaTeam.Controls.Add(this.lbl_defeats);
            this.grp_createaTeam.Controls.Add(this.lbl_wins);
            this.grp_createaTeam.Controls.Add(this.lbl_league);
            this.grp_createaTeam.Controls.Add(this.lbl_name);
            this.grp_createaTeam.Controls.Add(this.btn_continue);
            this.grp_createaTeam.Controls.Add(this.lbl_id);
            this.grp_createaTeam.Controls.Add(this.txt_defeats);
            this.grp_createaTeam.Controls.Add(this.txt_wins);
            this.grp_createaTeam.Controls.Add(this.txt_id);
            this.grp_createaTeam.Controls.Add(this.txt_league);
            this.grp_createaTeam.Controls.Add(this.txt_name);
            this.grp_createaTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grp_createaTeam.Location = new System.Drawing.Point(43, 39);
            this.grp_createaTeam.Name = "grp_createaTeam";
            this.grp_createaTeam.Size = new System.Drawing.Size(352, 376);
            this.grp_createaTeam.TabIndex = 3;
            this.grp_createaTeam.TabStop = false;
            this.grp_createaTeam.Text = "Create a Team";
            // 
            // lbl_defeats
            // 
            this.lbl_defeats.AutoSize = true;
            this.lbl_defeats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_defeats.Location = new System.Drawing.Point(24, 267);
            this.lbl_defeats.Name = "lbl_defeats";
            this.lbl_defeats.Size = new System.Drawing.Size(67, 20);
            this.lbl_defeats.TabIndex = 10;
            this.lbl_defeats.Text = "Defeats :";
            // 
            // lbl_wins
            // 
            this.lbl_wins.AutoSize = true;
            this.lbl_wins.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_wins.Location = new System.Drawing.Point(24, 210);
            this.lbl_wins.Name = "lbl_wins";
            this.lbl_wins.Size = new System.Drawing.Size(52, 20);
            this.lbl_wins.TabIndex = 9;
            this.lbl_wins.Text = "Wins : ";
            // 
            // lbl_league
            // 
            this.lbl_league.AutoSize = true;
            this.lbl_league.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_league.Location = new System.Drawing.Point(24, 157);
            this.lbl_league.Name = "lbl_league";
            this.lbl_league.Size = new System.Drawing.Size(64, 20);
            this.lbl_league.TabIndex = 8;
            this.lbl_league.Text = "League :";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(24, 101);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(56, 20);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Name :";
            // 
            // txt_scoresAchieved
            // 
            this.txt_scoresAchieved.Location = new System.Drawing.Point(155, 31);
            this.txt_scoresAchieved.Name = "txt_scoresAchieved";
            this.txt_scoresAchieved.Size = new System.Drawing.Size(168, 27);
            this.txt_scoresAchieved.TabIndex = 3;
            // 
            // lbl_scoresConceded
            // 
            this.lbl_scoresConceded.AutoSize = true;
            this.lbl_scoresConceded.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_scoresConceded.Location = new System.Drawing.Point(19, 88);
            this.lbl_scoresConceded.Name = "lbl_scoresConceded";
            this.lbl_scoresConceded.Size = new System.Drawing.Size(130, 20);
            this.lbl_scoresConceded.TabIndex = 1;
            this.lbl_scoresConceded.Text = "Scores Conceded :";
            // 
            // btn_continue
            // 
            this.btn_continue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_continue.Location = new System.Drawing.Point(229, 318);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(93, 32);
            this.btn_continue.TabIndex = 5;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // lbl_scoresAchieved
            // 
            this.lbl_scoresAchieved.AutoSize = true;
            this.lbl_scoresAchieved.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_scoresAchieved.Location = new System.Drawing.Point(19, 34);
            this.lbl_scoresAchieved.Name = "lbl_scoresAchieved";
            this.lbl_scoresAchieved.Size = new System.Drawing.Size(124, 20);
            this.lbl_scoresAchieved.TabIndex = 0;
            this.lbl_scoresAchieved.Text = "Scores Achieved :";
            // 
            // txt_scoresConceded
            // 
            this.txt_scoresConceded.Location = new System.Drawing.Point(155, 85);
            this.txt_scoresConceded.Name = "txt_scoresConceded";
            this.txt_scoresConceded.Size = new System.Drawing.Size(168, 27);
            this.txt_scoresConceded.TabIndex = 4;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_id.Location = new System.Drawing.Point(24, 50);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(29, 20);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.Text = "Id :";
            // 
            // txt_defeats
            // 
            this.txt_defeats.Location = new System.Drawing.Point(154, 260);
            this.txt_defeats.Name = "txt_defeats";
            this.txt_defeats.Size = new System.Drawing.Size(168, 31);
            this.txt_defeats.TabIndex = 4;
            // 
            // txt_wins
            // 
            this.txt_wins.Location = new System.Drawing.Point(154, 203);
            this.txt_wins.Name = "txt_wins";
            this.txt_wins.Size = new System.Drawing.Size(168, 31);
            this.txt_wins.TabIndex = 3;
            // 
            // tab_teams
            // 
            this.tab_teams.Controls.Add(this.tab_footballTeam);
            this.tab_teams.Controls.Add(this.tab_basketballTeam);
            this.tab_teams.Controls.Add(this.tab_teamList);
            this.tab_teams.Location = new System.Drawing.Point(412, 39);
            this.tab_teams.Name = "tab_teams";
            this.tab_teams.SelectedIndex = 0;
            this.tab_teams.Size = new System.Drawing.Size(354, 376);
            this.tab_teams.TabIndex = 4;
            // 
            // tab_footballTeam
            // 
            this.tab_footballTeam.Controls.Add(this.btn_createFootballTeam);
            this.tab_footballTeam.Controls.Add(this.txt_draws);
            this.tab_footballTeam.Controls.Add(this.lbl_draws);
            this.tab_footballTeam.Controls.Add(this.txt_average);
            this.tab_footballTeam.Controls.Add(this.txt_scoresAchieved);
            this.tab_footballTeam.Controls.Add(this.lbl_scoresAchieved);
            this.tab_footballTeam.Controls.Add(this.lbl_average);
            this.tab_footballTeam.Controls.Add(this.lbl_scoresConceded);
            this.tab_footballTeam.Controls.Add(this.txt_scoresConceded);
            this.tab_footballTeam.Location = new System.Drawing.Point(4, 29);
            this.tab_footballTeam.Name = "tab_footballTeam";
            this.tab_footballTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tab_footballTeam.Size = new System.Drawing.Size(346, 343);
            this.tab_footballTeam.TabIndex = 0;
            this.tab_footballTeam.Text = "Football Team";
            this.tab_footballTeam.UseVisualStyleBackColor = true;
            // 
            // btn_createFootballTeam
            // 
            this.btn_createFootballTeam.Location = new System.Drawing.Point(155, 279);
            this.btn_createFootballTeam.Name = "btn_createFootballTeam";
            this.btn_createFootballTeam.Size = new System.Drawing.Size(171, 42);
            this.btn_createFootballTeam.TabIndex = 8;
            this.btn_createFootballTeam.Text = "Create Football Team";
            this.btn_createFootballTeam.UseVisualStyleBackColor = true;
            this.btn_createFootballTeam.Click += new System.EventHandler(this.btn_createFootballTeam_Click);
            // 
            // txt_draws
            // 
            this.txt_draws.Location = new System.Drawing.Point(155, 199);
            this.txt_draws.Name = "txt_draws";
            this.txt_draws.Size = new System.Drawing.Size(171, 27);
            this.txt_draws.TabIndex = 7;
            // 
            // lbl_draws
            // 
            this.lbl_draws.AutoSize = true;
            this.lbl_draws.Location = new System.Drawing.Point(19, 202);
            this.lbl_draws.Name = "lbl_draws";
            this.lbl_draws.Size = new System.Drawing.Size(57, 20);
            this.lbl_draws.TabIndex = 6;
            this.lbl_draws.Text = "Draws :";
            // 
            // txt_average
            // 
            this.txt_average.Location = new System.Drawing.Point(155, 144);
            this.txt_average.Name = "txt_average";
            this.txt_average.ReadOnly = true;
            this.txt_average.Size = new System.Drawing.Size(171, 27);
            this.txt_average.TabIndex = 5;
            // 
            // lbl_average
            // 
            this.lbl_average.AutoSize = true;
            this.lbl_average.Location = new System.Drawing.Point(19, 147);
            this.lbl_average.Name = "lbl_average";
            this.lbl_average.Size = new System.Drawing.Size(71, 20);
            this.lbl_average.TabIndex = 2;
            this.lbl_average.Text = "Average :";
            // 
            // tab_basketballTeam
            // 
            this.tab_basketballTeam.Controls.Add(this.btn_createBasketballTeam);
            this.tab_basketballTeam.Controls.Add(this.txt_totalRebounds);
            this.tab_basketballTeam.Controls.Add(this.txt_totalFauls);
            this.tab_basketballTeam.Controls.Add(this.lbl_totalRebounds);
            this.tab_basketballTeam.Controls.Add(this.lbl_totalFauls);
            this.tab_basketballTeam.Location = new System.Drawing.Point(4, 29);
            this.tab_basketballTeam.Name = "tab_basketballTeam";
            this.tab_basketballTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tab_basketballTeam.Size = new System.Drawing.Size(346, 343);
            this.tab_basketballTeam.TabIndex = 1;
            this.tab_basketballTeam.Text = "Basketball Team";
            this.tab_basketballTeam.UseVisualStyleBackColor = true;
            // 
            // btn_createBasketballTeam
            // 
            this.btn_createBasketballTeam.Location = new System.Drawing.Point(142, 277);
            this.btn_createBasketballTeam.Name = "btn_createBasketballTeam";
            this.btn_createBasketballTeam.Size = new System.Drawing.Size(175, 44);
            this.btn_createBasketballTeam.TabIndex = 4;
            this.btn_createBasketballTeam.Text = "Create Basketball Team";
            this.btn_createBasketballTeam.UseVisualStyleBackColor = true;
            this.btn_createBasketballTeam.Click += new System.EventHandler(this.btn_createBasketballTeam_Click);
            // 
            // txt_totalRebounds
            // 
            this.txt_totalRebounds.Location = new System.Drawing.Point(147, 128);
            this.txt_totalRebounds.Name = "txt_totalRebounds";
            this.txt_totalRebounds.Size = new System.Drawing.Size(170, 27);
            this.txt_totalRebounds.TabIndex = 3;
            // 
            // txt_totalFauls
            // 
            this.txt_totalFauls.Location = new System.Drawing.Point(147, 54);
            this.txt_totalFauls.Name = "txt_totalFauls";
            this.txt_totalFauls.Size = new System.Drawing.Size(168, 27);
            this.txt_totalFauls.TabIndex = 2;
            // 
            // lbl_totalRebounds
            // 
            this.lbl_totalRebounds.AutoSize = true;
            this.lbl_totalRebounds.Location = new System.Drawing.Point(22, 131);
            this.lbl_totalRebounds.Name = "lbl_totalRebounds";
            this.lbl_totalRebounds.Size = new System.Drawing.Size(119, 20);
            this.lbl_totalRebounds.TabIndex = 1;
            this.lbl_totalRebounds.Text = "Total Rebounds :";
            // 
            // lbl_totalFauls
            // 
            this.lbl_totalFauls.AutoSize = true;
            this.lbl_totalFauls.Location = new System.Drawing.Point(22, 57);
            this.lbl_totalFauls.Name = "lbl_totalFauls";
            this.lbl_totalFauls.Size = new System.Drawing.Size(85, 20);
            this.lbl_totalFauls.TabIndex = 0;
            this.lbl_totalFauls.Text = "Total Fauls :";
            // 
            // tab_teamList
            // 
            this.tab_teamList.Controls.Add(this.btn_reset);
            this.tab_teamList.Controls.Add(this.lbl_totalPoints);
            this.tab_teamList.Controls.Add(this.lbl_totalMatches);
            this.tab_teamList.Controls.Add(this.lst_teams);
            this.tab_teamList.Location = new System.Drawing.Point(4, 29);
            this.tab_teamList.Name = "tab_teamList";
            this.tab_teamList.Padding = new System.Windows.Forms.Padding(3);
            this.tab_teamList.Size = new System.Drawing.Size(346, 343);
            this.tab_teamList.TabIndex = 2;
            this.tab_teamList.Text = "Mixed Team List";
            this.tab_teamList.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(223, 291);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(94, 29);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lbl_totalPoints
            // 
            this.lbl_totalPoints.AutoSize = true;
            this.lbl_totalPoints.Location = new System.Drawing.Point(37, 259);
            this.lbl_totalPoints.Name = "lbl_totalPoints";
            this.lbl_totalPoints.Size = new System.Drawing.Size(217, 20);
            this.lbl_totalPoints.TabIndex = 2;
            this.lbl_totalPoints.Text = "Total points will be shown here.";
            // 
            // lbl_totalMatches
            // 
            this.lbl_totalMatches.AutoSize = true;
            this.lbl_totalMatches.Location = new System.Drawing.Point(37, 224);
            this.lbl_totalMatches.Name = "lbl_totalMatches";
            this.lbl_totalMatches.Size = new System.Drawing.Size(280, 20);
            this.lbl_totalMatches.TabIndex = 1;
            this.lbl_totalMatches.Text = "Total matches played will be shown here.";
            // 
            // lst_teams
            // 
            this.lst_teams.FormattingEnabled = true;
            this.lst_teams.ItemHeight = 20;
            this.lst_teams.Location = new System.Drawing.Point(39, 25);
            this.lst_teams.Name = "lst_teams";
            this.lst_teams.Size = new System.Drawing.Size(267, 184);
            this.lst_teams.TabIndex = 0;
            this.lst_teams.SelectedIndexChanged += new System.EventHandler(this.lst_teams_SelectedIndexChanged);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_teams);
            this.Controls.Add(this.grp_createaTeam);
            this.Name = "Frm_Main";
            this.Text = "Sports Data Form ";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.grp_createaTeam.ResumeLayout(false);
            this.grp_createaTeam.PerformLayout();
            this.tab_teams.ResumeLayout(false);
            this.tab_footballTeam.ResumeLayout(false);
            this.tab_footballTeam.PerformLayout();
            this.tab_basketballTeam.ResumeLayout(false);
            this.tab_basketballTeam.PerformLayout();
            this.tab_teamList.ResumeLayout(false);
            this.tab_teamList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_league;
        private System.Windows.Forms.GroupBox grp_createaTeam;
        private System.Windows.Forms.TabControl tab_teams;
        private System.Windows.Forms.TabPage tab_footballTeam;
        private System.Windows.Forms.TabPage tab_basketballTeam;
        private System.Windows.Forms.Label lbl_defeats;
        private System.Windows.Forms.Label lbl_wins;
        private System.Windows.Forms.Label lbl_league;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.TextBox txt_defeats;
        private System.Windows.Forms.TextBox txt_wins;
        private System.Windows.Forms.TabPage tab_teamList;
        private System.Windows.Forms.Label lbl_scoresConceded;
        private System.Windows.Forms.Label lbl_scoresAchieved;
        private System.Windows.Forms.Label lbl_average;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_totalPoints;
        private System.Windows.Forms.Label lbl_totalMatches;
        private System.Windows.Forms.ListBox lst_teams;
        private System.Windows.Forms.TextBox txt_average;
        private System.Windows.Forms.TextBox txt_scoresConceded;
        private System.Windows.Forms.TextBox txt_scoresAchieved;
        private System.Windows.Forms.TextBox txt_draws;
        private System.Windows.Forms.Label lbl_draws;
        private System.Windows.Forms.Button btn_createFootballTeam;
        private System.Windows.Forms.TextBox txt_totalRebounds;
        private System.Windows.Forms.TextBox txt_totalFauls;
        private System.Windows.Forms.Label lbl_totalRebounds;
        private System.Windows.Forms.Label lbl_totalFauls;
        private System.Windows.Forms.Button btn_createBasketballTeam;
    }
}

