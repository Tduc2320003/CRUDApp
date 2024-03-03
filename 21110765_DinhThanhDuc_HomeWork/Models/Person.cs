using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21110765_DinhThanhDuc_HomeWork.Models
{
    internal class Person
    {
      
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string IdCard { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

       
        public Person() { }

       
        public Person( string name, string gender, string address, string idCard, DateTime dateOfBirth, string phone, string email)
        {
            Name = name;
            Gender = gender;
            Address = address;
            IdCard = idCard;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            Email = email;
        }
    }
}
