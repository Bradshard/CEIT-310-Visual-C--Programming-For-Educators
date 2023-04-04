using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Circle_Area_Perimeter_Create.Model;

namespace Circle_Area_Perimeter_Create
{

    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        BindingList<Circle> circles = new BindingList<Circle>();

        private void BindCirclesToListBox()
        {
            lst_circles.DataSource = circles;
            lst_circles.ValueMember = "Id";
            lst_circles.DisplayMember = "Name";
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            BindCirclesToListBox();
        }

        private void btn_createCircle_Click(object sender, EventArgs e)
        {
            Circle myCircle = new Circle();
            myCircle.Id = int.Parse(txt_id.Text);
            myCircle.Name = txt_circleName.Text;
            myCircle.Diameter = double.Parse(txt_diameter.Text);

            circles.Add(myCircle);

            //BindCirclesToListBox();
            ResetForm();
        }

        public void ResetForm()
        {
            int circleId = int.Parse(txt_id.Text);
            circleId = circleId + 1;
            txt_id.Text = circleId.ToString();

            txt_diameter.Text = "";
            txt_circleName.Text = "";
        }

        private void btn_calculatePerimeter_Click(object sender, EventArgs e)
        {
            int circleId = (int)lst_circles.SelectedValue;
            Circle selectedCircle = circles.Single(c => c.Id == circleId);

            double perimeter = selectedCircle.CalculatePerimeter();
            lbl_output.Text = "Perimeter : " + perimeter.ToString();
        }

        private void btn_calculateArea_Click(object sender, EventArgs e)
        {
            int circleId = (int)lst_circles.SelectedValue;
            Circle selectedCircle = circles.Single(c => c.Id == circleId);

            double area = selectedCircle.CalculateArea();
            lbl_output.Text = "Area : " + area.ToString();

        }
    }
}
