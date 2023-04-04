using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Checker
{
    public partial class Pass_Form : Form
    {
        public Pass_Form()
        {
            InitializeComponent();
        }


        //Simple click form load
        private void Pass_Form_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Password Checker form.")
        }

        //This  method should add ☑ to the end of labelText and return it
        private string AddCheckBoxToMessage(string labelText)
        {
            //Check if labelText contains ❌, if so delete ❌
            if (labelText.Contains("❌"))
            {
                int val = labelText.IndexOf("❌");
                labelText = labelText.Remove(val);
            }



            //Check if labelText contains ☑, if not add ☑ to the end of labelText
            if (!labelText.Contains("☑"))
            {
                int var = labelText.Length;
                labelText = labelText.Insert(var, "☑");
            }

            return labelText;
        }

        //This  method should add ❌ to the end of labelText and return it
        private string AddCrossToMessage(string labelText)
        {
            //Check if labelText contains ☑, if so delete ☑          
            if (labelText.Contains("☑"))
            {
                int val = labelText.IndexOf("☑");
                labelText = labelText.Remove(val);
            }

            //Check if labelText contains ❌, if not add ❌ to the end of labelText
            if (!labelText.Contains("❌"))
            {
                int var = labelText.Length;
                labelText = labelText.Insert(var, "❌");
            }

            return labelText;
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            //CHECK THE LENGHT REQUIREMENT
            if (CheckLength(txt_password.Text) == true)
            {
                lbl_length.Text = AddCheckBoxToMessage(lbl_length.Text);
                lbl_length.ForeColor = Color.Green;

            }
            else 
            {
                lbl_length.Text = AddCrossToMessage(lbl_length.Text);
                lbl_length.ForeColor = Color.Red;
            }

            //CHECK THE UPPERCASE REQUIREMENT
            if (CheckUpperCase(txt_password.Text) == true)
            {
                lbl_upper.Text = AddCheckBoxToMessage(lbl_upper.Text);
                lbl_upper.ForeColor = Color.Green;
            }
            else
            {
                lbl_upper.Text = AddCrossToMessage(lbl_upper.Text);
                lbl_upper.ForeColor = Color.Red;
            }

            //CHECK THE LOWERCASE REQUIREMENT
            if (CheckLowerCase(txt_password.Text) == true)
            {
                lbl_lower.Text = AddCheckBoxToMessage(lbl_lower.Text);
                lbl_lower.ForeColor = Color.Green;
            }
            else
            {
                lbl_lower.Text = AddCrossToMessage(lbl_lower.Text);
                lbl_lower.ForeColor = Color.Red;

            }

            //CHECK THE NUMERIC REQUIREMENT
            if (CheckDigit(txt_password.Text) == true)
            {
                lbl_digits.Text = AddCheckBoxToMessage(lbl_digits.Text);
                lbl_digits.ForeColor = Color.Green;

            }
            else
            {
                lbl_digits.Text = AddCrossToMessage(lbl_digits.Text);
                lbl_digits.ForeColor = Color.Red;
            }


            //Once all requirements are met, do not let users enter new text.
            if (CheckDigit(txt_password.Text) == true && CheckLowerCase(txt_password.Text) == true && CheckLength(txt_password.Text) == true && CheckUpperCase(txt_password.Text) == true)
            {
                txt_password.ReadOnly = true;
            }

        }

            #region Method for Checking Requirements

        private bool CheckLength(string password)
        {
            return (password.Length >= 10);
        }

        private bool CheckUpperCase(string password)
        {
            int upperCaseCount = 0;

            foreach (char ch in password)
            {
                if (char.IsUpper(ch))
                {
                    upperCaseCount++;
                }
            }

            return (upperCaseCount >= 3);
        }

        private bool CheckLowerCase(string password)
        {
            int lowerCaseCount = 0;

            for (int x = 0; x < password.Length; x++)
            {
                if (char.IsLower(password, x))
                {
                    lowerCaseCount++;
                }
            }

            return (lowerCaseCount >= 2);
        }

        private bool CheckDigit(string password)
        {
            int digitCount = 0;

            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    digitCount++;
                }
            }

            return (digitCount >= 2);
        }
        #endregion
    }
}
