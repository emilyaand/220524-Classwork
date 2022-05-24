using System;

namespace _220524_Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Emilya",
                Surname = "And"

             };

            Student student = new Student
            {
                Name = "Ali",
                Surname = "Aliyev"

            }; student.GetFullName();
  
        }
    }
}
