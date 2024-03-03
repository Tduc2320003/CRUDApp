using _21110765_DinhThanhDuc_HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21110765_DinhThanhDuc_HomeWork.DAO
{
    internal class TeacherDAO : PersonDAO
    {
        private const string TableName = "Teacher";

        public DataTable loadTeacherData() => LoadData(TableName);

        public void addTeacher(Teacher teacher) => AddPerson(teacher, TableName);

        public void deleteTeacher(string idCard) => DeletePerson(idCard, TableName);

        public void updateTeacher(Teacher teacher) => UpdatePerson(teacher, TableName);

    }
}
