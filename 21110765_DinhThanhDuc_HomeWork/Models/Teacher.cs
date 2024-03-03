using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21110765_DinhThanhDuc_HomeWork.Models
{
    internal class Teacher : Person
    {
        public Teacher( string name, string gender, string address, string idCard, DateTime dateOfBirth, string phone, string email)
        : base( name, gender, address, idCard, dateOfBirth, phone, email)
        {
        }
    }
}
