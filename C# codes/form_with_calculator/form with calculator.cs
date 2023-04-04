using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_With_Calculator
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        int number1 = 0;
        int number2 = 0;
        int result = 0;


        #region PART1: CHECKING AGAINST INVALID ENTRIES
        private void txt_number1_TextChanged(object sender, EventArgs e)
        {
            if (IsValidInteger(txt_number1.Text,out int numberone))
            {
                number1 = numberone;
            }
            else
            {
                MessageBox.Show("User entry on First Number is invalid," +
                    " need to enter an integer. ");
            }
        }

        private void txt_number2_TextChanged(object sender, EventArgs e)
        {

            if (IsValidInteger(txt_number2.Text, out int numbertwo))
            {
                number2 = numbertwo;
            }
            else
            {
                MessageBox.Show("User entry on Second Number is invalid," +
                    " need to enter an integer. ");
            }
        }
        private bool IsValidInteger(string strValue, out int intValue)
        {
            try
            {
                intValue = int.Parse(strValue);
                return true;
            }

            catch
            {
                intValue = 0;
                return false;
            }
        }
        #endregion


        #region PART2: MAKING THE CALCULATION
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            if (cmb_operation.Text == "+")
            {
                result = number1 + number2;
            }
            else if (cmb_operation.Text == "-")
            {
                result = number1 - number2;
            }
            else if (cmb_operation.Text == "/")
            {
                result = number1 / number2;
            }
            else if (cmb_operation.Text == "*")
            {
                result = number1 * number2;
            }
            else
            {
                MessageBox.Show("Please select an operation. ");
            }
            
            txt_result.Text = result.ToString();
        }
        #endregion


        #region PART3: INCREMENTING THE RESULT

        private void Increment(int amount)
        {

            result = result + amount;
        }
        // text markers are important.
        private void btn_increment1_Click(object sender, EventArgs e)
        {
            Increment(int.Parse(btn_increment1.Text));
            txt_result.Text = result.ToString();
        }

        private void btn_increment5_Click(object sender, EventArgs e)
        {
            Increment(int.Parse(btn_increment5.Text));
            txt_result.Text = result.ToString();
        }

        private void btn_increment10_Click(object sender, EventArgs e)
        {
            Increment(int.Parse(btn_increment10.Text));
            txt_result.Text = result.ToString();
        }
        #endregion


        #region PART4: DECREMENTING THE RESULT
        private void Decrement(int amounts)
        {

            result = result + amounts; 
            // since values are negative no need to put minus sign.
        }


        private void btn_decrement1_Click(object sender, EventArgs e)
        {
            Decrement(int.Parse(btn_decrement1.Text)); 
            txt_result.Text = result.ToString();
        }

        private void btn_decrement5_Click(object sender, EventArgs e)
        {
            Decrement(int.Parse(btn_decrement5.Text));
            txt_result.Text = result.ToString();
        }

        private void btn_decrement10_Click(object sender, EventArgs e)
        {
            Decrement(int.Parse(btn_decrement10.Text));
            txt_result.Text = result.ToString();
        }
        #endregion

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
