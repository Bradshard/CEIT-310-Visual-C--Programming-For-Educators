using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Name_Registration.Model;

namespace Name_Registration
{
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }
        int id_val = 0;
        BindingList<Name_to_listbox> personas = new BindingList<Name_to_listbox>();
        BindingList<Name_to_listbox> filteredBlist = new BindingList<Name_to_listbox>();
        private void BindData(BindingList<Name_to_listbox> data)
        {
            lst_users.DataSource = data;
            lst_users.ValueMember = "Id";
            lst_users.DisplayMember = "Name";
        }
        private void BindPersonsToListBox()
        {
            lst_users.DataSource = personas;
            lst_users.ValueMember = "Id";
            lst_users.DisplayMember = "Name";
        }

        private void btn_addOrEdit_Click(object sender, EventArgs e)
        {
            //add part
            if (btn_addOrEdit.Text == "Add User")
            {
                Name_to_listbox myNameBox = new Name_to_listbox();
                myNameBox.Id = id_val;
                myNameBox.Name = txt_name.Text;
                myNameBox.Surname = txt_surname.Text;
                myNameBox.BirthYear = int.Parse(txt_year.Text);
                myNameBox.BirthPlace = txt_place.Text;

                personas.Add(myNameBox);

                //BindPersonsToListBox();
                ResetForm();
            }

            // Edit part
            else
            {
                if (string.IsNullOrEmpty(txt_filterName.Text) == false | string.IsNullOrEmpty(txt_filterSurname.Text) == false | string.IsNullOrEmpty(txt_filterYear.Text) == false)
                {
                    int id_pick = (int)lst_users.SelectedValue;
                    Name_to_listbox selectedName = filteredBlist.Single(c => c.Id == id_pick);

                    Name_to_listbox myNameBox = new Name_to_listbox();
                    myNameBox.Id = id_val;
                    myNameBox.Name = txt_name.Text;
                    myNameBox.Surname = txt_surname.Text;
                    myNameBox.BirthYear = int.Parse(txt_year.Text);
                    myNameBox.BirthPlace = txt_place.Text;

                    filteredBlist[id_pick] = myNameBox;

                    //BindPersonsToListBox();
                    ResetForm();

                }
                else
                {
                    int id_pick = (int)lst_users.SelectedValue;
                    Name_to_listbox selectedName = personas.Single(c => c.Id == id_pick);

                    Name_to_listbox myNameBox = new Name_to_listbox();
                    myNameBox.Id = id_val;
                    myNameBox.Name = txt_name.Text;
                    myNameBox.Surname = txt_surname.Text;
                    myNameBox.BirthYear = int.Parse(txt_year.Text);
                    myNameBox.BirthPlace = txt_place.Text;

                    personas[id_pick] = myNameBox;

                    //BindPersonsToListBox();
                    ResetForm();

                }
            }
        }

        public void ResetForm()
        {
            if (btn_addOrEdit.Text == "Add User")
            {
                id_val++;

                txt_name.Text = "";
                txt_surname.Text = "";
                txt_place.Text = "";
                txt_year.Text = "";
            }

            // Edit part
            else
            {
                txt_name.Text = "";
                txt_surname.Text = "";
                txt_place.Text = "";
                txt_year.Text = "";

                btn_addOrEdit.Text = "Add User";
            }

        }
        private void Form_Register_Load(object sender, EventArgs e)
        {
            BindPersonsToListBox();
        }

        private void btn_showDetails_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_filterName.Text) == false | string.IsNullOrEmpty(txt_filterSurname.Text) == false | string.IsNullOrEmpty(txt_filterYear.Text) == false)
            {
                int id_pick = (int)lst_users.SelectedValue;
                Name_to_listbox selectedName = personas.Single(c => c.Id == id_pick);
                lbl_details.Text = selectedName.Name.ToString() + " " + selectedName.Surname.ToString() +
                    " was born in " + selectedName.BirthPlace.ToString() + " " + "in " + selectedName.BirthYear.ToString();
            }
            else
            {
                int id_pick = (int)lst_users.SelectedValue;
                Name_to_listbox selectedName = personas.Single(c => c.Id == id_pick);
                lbl_details.Text = selectedName.Name.ToString() + " " + selectedName.Surname.ToString() +
                    " was born in " + selectedName.BirthPlace.ToString() + " " + "in " + selectedName.BirthYear.ToString();

            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_filterName.Text) == false | string.IsNullOrEmpty(txt_filterSurname.Text) == false | string.IsNullOrEmpty(txt_filterYear.Text) == false)
            {
                int id_pick = (int)lst_users.SelectedValue;
                Name_to_listbox selectedName = personas.Single(c => c.Id == id_pick);
                personas.Remove(selectedName);
                txt_filterName.Text = "";
                txt_filterSurname.Text = "";
                txt_filterYear.Text = "";

            }
            else
            {
                int id_pick = (int)lst_users.SelectedValue;
                Name_to_listbox selectedName = personas.Single(c => c.Id == id_pick);
                personas.Remove(selectedName);

            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_filterName.Text) == false | string.IsNullOrEmpty(txt_filterSurname.Text) == false | string.IsNullOrEmpty(txt_filterYear.Text) == false)
            {
                btn_addOrEdit.Text = "Apply Changes";
                int id_pick = (int)lst_users.SelectedValue;
                Name_to_listbox selectedName = personas.Single(c => c.Id == id_pick);
                txt_name.Text = selectedName.Name;
                txt_surname.Text = selectedName.Surname;
                txt_year.Text = selectedName.BirthYear.ToString();
                txt_place.Text = selectedName.BirthPlace;
                txt_filterName.Text = "";
                txt_filterSurname.Text = "";
                txt_filterYear.Text = "";

            }
            else
            {
                btn_addOrEdit.Text = "Apply Changes";
                int id_pick = (int)lst_users.SelectedValue;
                Name_to_listbox selectedName = personas.Single(c => c.Id == id_pick);
                txt_name.Text = selectedName.Name;
                txt_surname.Text = selectedName.Surname;
                txt_year.Text = selectedName.BirthYear.ToString();
                txt_place.Text = selectedName.BirthPlace;

            }


        }

        // Now you can filter by name, surname, year but only one by one.
        // You can even edit, delete, and look at the details of the filtered items. 
        // Learned a lot from this last part.
        private void txt_filterName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_filterName.Text) == false)
            {
                txt_filterSurname.ReadOnly = true;
                txt_filterYear.ReadOnly = true;

                List<Name_to_listbox> filteredList = personas.Where(x => x.Name.Contains(txt_filterName.Text)).ToList();

                //then convert the List to a BindingList using a new variable
                BindingList<Name_to_listbox> filteredBlist = new BindingList<Name_to_listbox>(filteredList);
                BindData(filteredBlist);
            }
            else
            {
                txt_filterSurname.ReadOnly = false;
                txt_filterYear.ReadOnly = false;
                BindData(personas);
            }    
        }

        private void txt_filterSurname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_filterSurname.Text) == false)
            {
                txt_filterName.ReadOnly = true;
                txt_filterYear.ReadOnly = true;

                List<Name_to_listbox> filteredList = personas.Where(x => x.Surname.Contains(txt_filterSurname.Text)).ToList();

                //then convert the List to a BindingList using a new variable
                BindingList<Name_to_listbox> filteredBlist = new BindingList<Name_to_listbox>(filteredList);
                BindData(filteredBlist);
            }
            else
            {
                txt_filterName.ReadOnly = false;
                txt_filterYear.ReadOnly = false;
                BindData(personas);
            }

        }

        private void txt_filterYear_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_filterYear.Text) == false)
            {
                txt_filterSurname.ReadOnly = true;
                txt_filterName.ReadOnly = true;

                List<Name_to_listbox> filteredList = personas.Where(x => x.BirthYear.ToString().Contains(txt_filterYear.Text)).ToList();

                //then convert the List to a BindingList using a new variable
                BindingList<Name_to_listbox> filteredBlist = new BindingList<Name_to_listbox>(filteredList);
                BindData(filteredBlist);
            }
            else
            {
                txt_filterName.ReadOnly = false;
                txt_filterSurname.ReadOnly = false;
                BindData(personas);
            }
        }
    }
}
