using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section_Divider
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }


        private void Frm_Main_Load(object sender, EventArgs e)
        {
            
            CopyArraysToLists();//Creates the section1 and section2 lists based on the arrays
            BindSectionData();//Binds section1 and section2 lists to lst_section1 and lst_section2 list controls
            CheckOverlappingItems();//Checks if lst_section1 and lst_section2 have an overlapping item.
            CompareListSize();//Checks if lst_section1 and lst_section2 have the same number of items
        }


        #region PART1 : CREATING AND INITIALIZING VARIABLES

        string[] section1_array = { "Ahmet", "David", "Sara", "Rodrigo", "Fatma", "Ilkem" };

        string[] section2_array = {"Onur", "Nehir", "Gustavo", "Ahmet", "Sara", "Fatma", "Deniz", "Eduardo", "Paulo"};

        
        List<string> section1 = new List<string> ();
        List<string> section2 = new List<string> ();

        #endregion


        #region PART2 : COPYING ARRAYS TO LISTS

        
        private void CopyArraysToLists()
        {
            
            foreach (string es in section1_array)
            {
                section1.Add(es);
            }

            foreach (string ele in section2_array)
            {
                section2.Add(ele);
            }
        }
        #endregion


        #region PART3: POPULATING THE LISTBOXES

        private void BindSectionData()
        {

            lst_section1.Items.Clear();
            lst_section2.Items.Clear();


            foreach (string els in section1)
            {
                lst_section1.Items.Add(els);
            }


            foreach (string elms in section2)
            {
                lst_section2.Items.Add(elms);
            }


        }

        #endregion


        #region PART4: CHECKING IF SECTIONS HAVE OVERLAPS



        private void CheckOverlappingItems()
        {
            //This variable will be set to true if there is any overlap
            bool overlaps = false;

            for (int i = 0; i < lst_section1.Items.Count; i++)//outer loop will traverse lst_section1
            {
                //MessageBox.Show(lst_section1.Items[i].ToString());
                for (int i1 = 0; i1 < lst_section2.Items.Count; i1++)//inner loop will traverse lst_section1
                {
                    //Check if the traversed items matches 
                    if (lst_section1.Items[i].ToString() == lst_section2.Items[i1].ToString())
                    {
                        overlaps = true;
                        break;
                    }
                }
            }
            if (overlaps)
            {

                lbl_overlapping.ForeColor = Color.Red;
                lbl_overlapping.Text = ("There are overlapping items.");
            }
            else
            {

                lbl_overlapping.ForeColor = Color.Blue;
                lbl_overlapping.Text = ("No overlapping items.");
            }

        }

        #endregion


        #region PART5: CHECKING IF SECTIONS HAVE THE SAME NUMBER OF STUDENTS


        private void CompareListSize()
        {

            if (lst_section1.Items.Count == lst_section2.Items.Count)
            {
                lbl_sizeComparison.ForeColor = Color.Blue;
                lbl_sizeComparison.Text = ("Lists contains the same number of items.");
            }
            else
            {
                lbl_sizeComparison.ForeColor = Color.Red;
                lbl_sizeComparison.Text = ("Lists have a different number of items.");
            }
        }

        #endregion


        #region PART6: MOVING STUDENTS BETWEEN SECTIONS

        private void btn_moveToRight_Click(object sender, EventArgs e)
        {

            foreach (int x in lst_section1.SelectedIndices)
            {

                string itemToBemoved = lst_section1.Items[x].ToString();


                if (section2.Contains(itemToBemoved))
                {
                    section1.Remove(itemToBemoved);
                }
                else
                {
                    section2.Insert(0, itemToBemoved);
                    section1.Remove(itemToBemoved);
                }
            }

            BindSectionData();
            CheckOverlappingItems();
            CompareListSize();
        }


        private void btn_moveToLeft_Click(object sender, EventArgs e)
        {

            foreach (int x in lst_section2.SelectedIndices)
            {
                
                string itemToBemoved = lst_section2.Items[x].ToString();

                

                if (section1.Contains(itemToBemoved))
                {
                    section2.Remove(itemToBemoved);
                }
                else
                {
                    section1.Insert(0, itemToBemoved);
                    section2.Remove(itemToBemoved);
                }
            }

            
            BindSectionData();
            CheckOverlappingItems();
            CompareListSize();
            
        }

        #endregion
    }
}
