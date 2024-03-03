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
    public partial class UCInfo : UserControl

    {
        // Define events
        public event EventHandler AddClicked;
        public event EventHandler DeleteClicked;
        public event EventHandler EditClicked;

        public string Name
        {
            get { return txtName.Text.Trim(); }
            set { txtName.Text = value; }
        }

        public string Gender
        {
            get
            {
                if (rbMale.Checked) return "Male";
                if (rbFemale.Checked) return "Female";
                if (rbOther.Checked) return "Other";
                return null;
            }
            set
            {
                switch (value)
                {
                    case "Male":
                        rbMale.Checked = true;
                        break;
                    case "Female":
                        rbFemale.Checked = true;
                        break;
                    case "Other":
                        rbOther.Checked = true;
                        break;
                    default:
                        rbMale.Checked = rbFemale.Checked = rbOther.Checked = false;
                        break;
                }
            }
        }

        public string Address
        {
            get { return txtAddress.Text.Trim(); }
            set { txtAddress.Text = value; }
        }

        public string IdCard
        {
            get { return txtIdCard.Text.Trim(); }
            set { txtIdCard.Text = value; }
        }

        public string Phone
        {
            get { return txtPhone.Text.Trim(); }
            set { txtPhone.Text = value; }
        }

        public string Email
        {
            get { return txtEmail.Text.Trim(); }
            set { txtEmail.Text = value; }
        }

        public DateTime DOB
        {
            get { return dtpDob.Value; }
            set { dtpDob.Value = value; }
        }
        public UCInfo()
        {
            InitializeComponent();
            // Hook up internal event handlers to raise public events
            btnAdd.Click += (s, e) => AddClicked?.Invoke(this, e);
            btnDelete.Click += (s, e) => DeleteClicked?.Invoke(this, e);
            btnEdit.Click += (s, e) => EditClicked?.Invoke(this, e);
            dgvData.SelectionChanged += new EventHandler(dgvDataSelectionChanged);
          
        }

        public void LoadDataIntoGridView(DataTable dataTable)
        {
            // Set the DataGridView DataSource to the DataTable
            dgvData.DataSource = dataTable;
            dgvData.AutoResizeColumns();           
            dgvData.AllowUserToAddRows = false;     // Prevent user from adding new rows
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ResetFields();
        }

        public void ResetFields()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtIdCard.Clear();
            txtPhone.Clear();
            txtEmail.Clear();         
            rbMale.Checked = true;
            rbFemale.Checked = false;
            rbOther.Checked = false;      
            dtpDob.Value = DateTime.Now;
    
        }
        private void dgvDataSelectionChanged(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvData.SelectedRows[0];
                // Set the fields with the values from the selected row
                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtAddress.Text = row.Cells["Address"].Value?.ToString();
                txtIdCard.Text = row.Cells["IDCard"].Value?.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();

                // Handle the DateOfBirth
                if (DateTime.TryParse(row.Cells["DateOfBirth"].Value?.ToString(), out DateTime dob))
                {
                    dtpDob.Value = dob;
                }
                else
                {
                    dtpDob.Value = DateTime.Now; // Or some default value
                }

                // Handle the Gender
                string gender = row.Cells["Gender"].Value?.ToString();
                rbMale.Checked = (gender == "Male");
                rbFemale.Checked = (gender == "Female");
                rbOther.Checked = (gender == "Other");
            }
        }
        

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhone(string phone)
        {
            // Regular expression to match the phone format xxx-xxxx-xxx
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{3}-\d{4}-\d{3}$");


        }
        public bool isValid(DateTime dob, string phone, string email)
        {

            if (DateTime.Now.Year - dob.Year < 17)
            {
                MessageBox.Show("Age must be at least 17 years old.");
                return false;
            }
            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Phone must be in the format: xxx-xxxx-xxx.");
                return false;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email is not in a valid format.");
                return false;
            }
          

            return true;
        }










    }
}
