using _21110765_DinhThanhDuc_HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21110765_DinhThanhDuc_HomeWork.DAO
{
    internal class PersonDAO
    {
        protected DBConnector dBConnector = new DBConnector();

        protected DataTable LoadData(string tableName)
        {
            string query = $"SELECT Name, Gender, Address, IDCard, DateOfBirth, Phone, Email FROM {tableName}";
            return dBConnector.loadData(query);
        }

        protected void AddPerson(Person person, string tableName)
        {
            string query = $"INSERT INTO {tableName} (Name, Gender, Address, IDCard, DateOfBirth, Phone, Email) VALUES (@Name, @Gender, @Address, @IDCard, @DOB, @Phone, @Email)";

            dBConnector.excecuteSqlCommand(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@Name", person.Name);
                cmd.Parameters.AddWithValue("@Gender", person.Gender);
                cmd.Parameters.AddWithValue("@Address", person.Address);
                cmd.Parameters.AddWithValue("@IDCard", person.IdCard);
                cmd.Parameters.AddWithValue("@DOB", person.DateOfBirth);
                cmd.Parameters.AddWithValue("@Phone", person.Phone);
                cmd.Parameters.AddWithValue("@Email", person.Email);
            });
        }

        protected void DeletePerson(string idCard, string tableName)
        {
            string query = $"DELETE FROM {tableName} WHERE IDCard = @IDCard";
            dBConnector.excecuteSqlCommand(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@IDCard", idCard);
            });
        }

        protected void UpdatePerson(Person person, string tableName)
        {
            string query = $"UPDATE {tableName} SET Name = @Name, Gender = @Gender, Address = @Address, DateOfBirth = @DOB, Phone = @Phone, Email = @Email WHERE IDCard = @IDCard";

            dBConnector.excecuteSqlCommand(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@IDCard", person.IdCard);
                cmd.Parameters.AddWithValue("@Name", person.Name);
                cmd.Parameters.AddWithValue("@Gender", person.Gender);
                cmd.Parameters.AddWithValue("@Address", person.Address);
                cmd.Parameters.AddWithValue("@DOB", person.DateOfBirth);
                cmd.Parameters.AddWithValue("@Phone", person.Phone);
                cmd.Parameters.AddWithValue("@Email", person.Email);
            });
        }
    }
}
