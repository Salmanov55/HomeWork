using demo_1.Models;
using System;
namespace demo_1.Services
{
    public class MenuService
    {
        private static StudentService studentService = new StudentService();

        public static void MenuShowStudents()
        {
            var students = studentService.GetStudents();

            if (students.Count == 0)
            {
                Console.WriteLine("No students yet.");
                return;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id} | Name: {student.Name} | Surname: {student.Surname} | Grade: {student.Grade}");
            }
        }

        public static void MenuAddStudent()
        {
            try
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter surname:");
                string surname = Console.ReadLine();

                Console.WriteLine("Enter grade:");
                double grade = double.Parse(Console.ReadLine());

                studentService.AddStudent(name, surname, grade);

                Console.WriteLine("Added student successfuly!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuUpdateStudent()
        {
            Console.WriteLine("Enter the student's ID to update: ");
            int id = int.Parse(Console.ReadLine());

            var students = studentService.GetStudents();


            var existingStudent = students.FirstOrDefault(x => x.Id == id);


        }

        public static void MenuRemoveStudent()
        {
            try
            {
                Console.WriteLine("Enter student's ID:");
                int id = int.Parse(Console.ReadLine());

                studentService.RemoveStudent(id);

                Console.WriteLine("Deleted student successfuly!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuFindStudentByName()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            var students = studentService.GetStudents();

            var matchingStudents = students.Where(x => x.Name.Equals(name)).ToList();

            if (matchingStudents.Count == 0)
            {
                Console.WriteLine("Student not found.");
            }
            else if (matchingStudents.Count == 1)
            {
                Console.WriteLine("Student Found:");
                foreach (var student in matchingStudents)
                {
                    Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Grade: {student.Grade}");
                }
            }
            else
            {
                Console.WriteLine("More than one student found:");
                foreach (var student in matchingStudents)
                {
                    Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Grade: {student.Grade}");
                }
            }

        }
    }
}

