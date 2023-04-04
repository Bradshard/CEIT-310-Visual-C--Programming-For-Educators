using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module4_2_burkan_bereketoglu
{
    public partial class frm_numericVariables : Form
    {
        public frm_numericVariables()
        {
            InitializeComponent();
        }

        private void frm_numericVariables_Load(object sender, EventArgs e)
        {
            int yearEstablished = 1955;
            int averageRanking = (int) 25.3;
            int budget = (int) 130.5m;

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            try 
            {
                int mc = int.Parse(txt_missedClasses.Text);
                double rm = double.Parse(txt_readingsMade.Text);
                double qa = double.Parse(txt_avgQuizAttempts.Text);
                double qs = double.Parse(txt_avgQuizScore.Text);
                int dp = int.Parse(txt_discussionPosts.Text);

                double numerator = rm * 60 + qa * 10 + qs * 15 + (double)dp * 15;
                double denominator = mc * 100;

                double engagementLevel = numerator / denominator;

                MessageBox.Show(engagementLevel.ToString());

            }

            catch (Exception ex)
            {
                StringBuilder sb_error = new StringBuilder();

                sb_error.AppendLine("Please enter a valid numeric value in all fields.");
                sb_error.AppendLine();
                sb_error.AppendLine("More info:");
                sb_error.AppendLine(ex.Message);

                MessageBox.Show(sb_error.ToString());
            }


        }
    }
}
