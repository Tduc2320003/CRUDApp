using _21110765_DinhThanhDuc_HomeWork.DAO;
using _21110765_DinhThanhDuc_HomeWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21110765_DinhThanhDuc_HomeWork
{
    public partial class FTeacher : Form
    {
        TeacherDAO teacherDAO = new TeacherDAO();
        public FTeacher()
        {
            InitializeComponent();
            // Subscribe to UCInfo events
            ucInfo1.AddClicked += HandleAddBtn;
            ucInfo1.DeleteClicked += HandleDeleteBtn;
            ucInfo1.EditClicked += HandleEditBtn;
            ucInfo1.lblheader.Text = "List of Teachers";
            RefreshData();
        }
        private void RefreshData()
        {
            DataTable dataTable = teacherDAO.loadTeacherData();
            ucInfo1.LoadDataIntoGridView(dataTable);
            //ucInfo.ResetFields();
        }
        private void HandleAddBtn(object sender, EventArgs e)
        {
            bool isValid = ucInfo1.isValid(ucInfo1.DOB, ucInfo1.Phone, ucInfo1.Email);

            if (isValid)
            {
                Teacher newTeacher = new Teacher(ucInfo1.Name, ucInfo1.Gender, ucInfo1.Address, ucInfo1.IdCard, ucInfo1.DOB, ucInfo1.Phone, ucInfo1.Email);
                teacherDAO.addTeacher(newTeacher);
                // Refresh the DataGridView with the updated data
                RefreshData();
            }
            return;

        }

        private void HandleDeleteBtn(object sender, EventArgs e)
        {
            if (ucInfo1.dgvData.SelectedRows.Count > 0)
            {
                var selectedRow = ucInfo1.dgvData.SelectedRows[0];
                var idCard = selectedRow.Cells["IDCard"].Value.ToString();

                // Confirm before deleting
                var confirmResult = MessageBox.Show("Are you sure to delete this teacher?",
                                                    "Confirm Delete!",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    teacherDAO.deleteTeacher(idCard);

                    // Refresh the DataGridView with the updated data
                    RefreshData();
                }
            }
            else
            {
                MessageBox.Show("Please select a teacher to delete.");
            }
        }


        private void HandleEditBtn(object sender, EventArgs e)
        {

            bool isValid = ucInfo1.isValid(ucInfo1.DOB, ucInfo1.Phone, ucInfo1.Email);

            if(isValid)
            {
                Teacher teacherToUpdate = new Teacher(
              ucInfo1.Name, ucInfo1.Gender, ucInfo1.Address, ucInfo1.IdCard, ucInfo1.DOB, ucInfo1.Phone, ucInfo1.Email);


                teacherDAO.updateTeacher(teacherToUpdate);

                RefreshData(); 

            }
            return;

        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            // Create an instance of the FStudent form if it's not already open
            FStudent studentForm = new FStudent();

            // Hide the current form (FTeacher)
            this.Hide();

            // Show the FStudent form
            studentForm.Show();

            // Optionally, you could also close the current form when the FStudent form is closed
            studentForm.FormClosed += (s, args) => this.Close();
        }
    }
}
