using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses
{
    public partial class frmStudentCoursesDetails : Form
    {
        public frmStudentCoursesDetails()
        {
            InitializeComponent();
        }

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Service_based_Database1DataSet);

        }



        //frmStudentCoursesDetails

        private void btnSet_Click(object sender, EventArgs e)
        {
            hideGetterComponents();
            try
            {
                if (txtFirstName.Text.Trim()=="" )
                {
                    MessageBox.Show("First Name is mandatory field", "Entry Error");
                    txtFirstName.Focus();
                    return;
                }
                if ( txtSecondName.Text.Trim() == ""  )
                {
                    MessageBox.Show("Last Name is mandatory field", "Entry Error");
                    txtSecondName.Focus();
                    return;
                }
                if (Int32.Parse(txtNumberCourses.Text) > 0 && Int32.Parse(txtNumberCourses.Text) <= 3)
                {
                    students.setStudentsNumberOfCourses(Int32.Parse(txtNumberCourses.Text));

                    txtNumberCourses.Focus();
                    btnGet.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Number of courses should be minimum of 1 and maximum of 3 ", "Entry Error");
                    txtNumberCourses.Focus();
                    return;
                }
                if ( cmbCourseNumber.Text.Trim() == "")
                {
                    MessageBox.Show("Course Number is mandatory field", "Entry Error");
                    cmbCourseNumber.Focus();
                    return;
                }
                

                students.setFirstName(txtFirstName.Text);
                students.setLastName(txtSecondName.Text);
                students.setStudentsCourseNumber(cmbCourseNumber.Text);

                MessageBox.Show("Validation successful. Click Get button to retrieve the data set ","Confirm");

            }
            catch (Exception )
              {
                MessageBox.Show("Number of course should be an integer","Entry Error");
                btnGet.Enabled = false;
            }
            if (rdHybrid.Checked) {
                students.setStudentCourseType("Hybrid");
            } else
            {
                students.setStudentCourseType("Online");
            }
            //students.setStudentCourseType()
            students.SetStudentDate(txtCourseStartDate.Text);
        }

        //  Display data in all the Get fields 

        private void btnGet_Click(object sender, EventArgs e)
        {
            txtStudentFullName.Text = students.getStudentsFirstName() + students.getStudentsSecondName();

            txtNumberOfCourses.Text = students.getStudentsNumberOfcourses().ToString();
            showGetterComponents();
            txtCourseNumber.Text = students.getStudentsCourseNumber();
            
            txtCourseType.Text = students.getStudentsCourseType();
            txtStartDate.Text = students.getStartDate(); ;

        }

         
        // Hide all the  getfields if the  all the set fields are not entered .
        private void hideGetterComponents()
        {
            pnlDataComponents.Visible = false;
            lblStudentFullName.Visible = false;
            lblNumberOfCourses.Visible = false;
            lblCourseNumber.Visible = false;
            lblCourseType.Visible = false;
            lblStartDate.Visible = false;

            txtStudentFullName.Visible = false;
            txtNumberOfCourses.Visible = false;
            txtCourseNumber.Visible = false;
            txtCourseType.Visible = false;
            txtStartDate.Visible = false;

        }
        // Display all the get fields
        private void showGetterComponents()
        {
            pnlDataComponents.Visible = true;
            lblStudentFullName.Visible = true;
            lblNumberOfCourses.Visible = true;
            lblCourseNumber.Visible = true;
            lblCourseType.Visible = true;
            lblStartDate.Visible = true;

            txtStudentFullName.Visible = true;
            txtNumberOfCourses.Visible = true;
            txtCourseNumber.Visible = true;
            txtCourseType.Visible = true;
            txtStartDate.Visible = true;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtSecondName.Clear();
            txtNumberCourses.Clear();
            // ComboBox default should be blank
            cmbCourseNumber.SelectedIndex = -1;
            rdHybrid.Checked = true;
            hideGetterComponents();
            btnGet.Enabled = false;
        }

        private void frmStudentCoursesDetails_Load(object sender, EventArgs e)
        {
            this.coursesTableAdapter.Fill(this._Service_based_Database1DataSet.courses);
            btnGet.Enabled = false;
            hideGetterComponents();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            
                this.Close();


        }
    }
}
