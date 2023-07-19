using System;
using System.Collections.Generic;
using demo_1.Models;
using System.Linq;

namespace demo_1.Services
{
    public class StudentService
    {
        private List<Student> students;

        public StudentService()
        {
            students = new();
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public void AddStudent(string name, string surname, double grade)
        {

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                throw new ArgumentException("Name or Surname cannot be empty.");
            }

            if (grade < 0)
            {
                throw new ArgumentException("Cannot be a negative value.");
            }


            var student = new Student(name, surname, grade);

            students.Add(student);
        }

        public void RemoveStudent(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("ID cannot be a negative value.");
            }

            var existingStudent = students.FirstOrDefault(x => x.Id == id);

            if (existingStudent == null) throw new Exception("Not found!");

            students = students.Where(x => x.Id != id).ToList();
        }
    }
}

