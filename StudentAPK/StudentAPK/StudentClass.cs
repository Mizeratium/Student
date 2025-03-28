using StudentAPK.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPK
{
    public class StudentClass
    {
        public void NewStudent(string lastName, string firstName, string patr, string login, string password, int numberOfGroup)
        {
            try
            {
                Student student = new Student
                {
                    surname = lastName,
                    name = firstName,
                    patronymic = patr,
                    login = login,
                    password = password,
                    group_id = numberOfGroup,
                    isDelete = false,
                    role_id = 3
                };
                ClassDB.connection.Student.Add(student);
                ClassDB.connection.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
