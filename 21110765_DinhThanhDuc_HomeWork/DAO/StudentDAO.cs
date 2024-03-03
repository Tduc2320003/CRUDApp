using _21110765_DinhThanhDuc_HomeWork.Models;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21110765_DinhThanhDuc_HomeWork.DAO
{
    internal class StudentDAO : PersonDAO
    {
        private const string TableName = "Student";

        public DataTable loadStudentData() => LoadData(TableName);

        public void addStudent(Student student) => AddPerson(student, TableName);

        public void deleteStudent(string idCard) => DeletePerson(idCard, TableName);

        public void updateStudent(Student student) => UpdatePerson(student, TableName);

    }
}
