using _21110765_DinhThanhDuc_HomeWork.DAO;
using _21110765_DinhThanhDuc_HomeWork.Models;
using System.Data;

namespace _21110765_DinhThanhDuc_HomeWork
{
    public partial class FStudent : Form
    {

        StudentDAO studentDAO = new StudentDAO();
        public FStudent()
        {
            InitializeComponent();
            // Subscribe to UCInfo events
            ucInfo.AddClicked += HandleAddBtn;
            ucInfo.DeleteClicked += HandleDeleteBtn;
            ucInfo.EditClicked += HandleEditBtn;
            ucInfo.lblheader.Text = "List of Student";
            RefreshData();
        }

        private void RefreshData()
        {
            DataTable dataTable = studentDAO.loadStudentData();
            ucInfo.LoadDataIntoGridView(dataTable);
            //ucInfo.ResetFields();
        }


        private void HandleAddBtn(object sender, EventArgs e)
        {
            bool isValid = ucInfo.isValid(ucInfo.DOB, ucInfo.Phone, ucInfo.Email);

            if (isValid)
            {
                Student newStudent = new Student(ucInfo.Name, ucInfo.Gender, ucInfo.Address, ucInfo.IdCard, ucInfo.DOB, ucInfo.Phone, ucInfo.Email);


                // Add the Student to the database using StudentDAO
                StudentDAO studentDao = new StudentDAO();
                studentDao.addStudent(newStudent);

                // Refresh the DataGridView with the updated data
                RefreshData();
            }
            return;

        }

        private void HandleDeleteBtn(object sender, EventArgs e)
        {
            if (ucInfo.dgvData.SelectedRows.Count > 0)
            {
                var selectedRow = ucInfo.dgvData.SelectedRows[0];
                var idCard = selectedRow.Cells["IDCard"].Value.ToString();

                // Confirm before deleting
                var confirmResult = MessageBox.Show("Are you sure to delete this student?",
                                                    "Confirm Delete!",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Use StudentDAO to delete the student
                    StudentDAO studentDao = new StudentDAO();
                    studentDao.deleteStudent(idCard);

                    // Refresh the DataGridView with the updated data
                    RefreshData();
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }


        private void HandleEditBtn(object sender, EventArgs e)
        {

            bool isValid = ucInfo.isValid(ucInfo.DOB, ucInfo.Phone, ucInfo.Email);
            if (isValid)
            {
                Student studentToUpdate = new Student(
                ucInfo.Name, ucInfo.Gender, ucInfo.Address, ucInfo.IdCard, ucInfo.DOB, ucInfo.Phone, ucInfo.Email);


                studentDAO.updateStudent(studentToUpdate);

                RefreshData(); // Refresh the grid to show the updated list of students.
            }
            return;




        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            FTeacher teacherForm = new FTeacher();

            // Hide the current form (FStudent)
            this.Hide();

            // Show the FTeacher form
            teacherForm.Show();


            teacherForm.FormClosed += (s, args) => this.Close();
        }

        
    }
}
