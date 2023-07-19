using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using demo_1.Services;
using Microsoft.VisualBasic.FileIO;

namespace demo_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            int option;

            do
            {
                Console.WriteLine("1. Show students");
                Console.WriteLine("2. Add student");
                Console.WriteLine("3. Update student");
                Console.WriteLine("4. Remove student");
                Console.WriteLine("5. Find student by name");
                Console.WriteLine("0. Exit");
                Console.WriteLine("------------------------");
                Console.WriteLine("Please, select an option:");
                Console.WriteLine("------------------------");


                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Please, enter a valid option:");
                    Console.WriteLine("------------------------");
                }

                switch (option)
                {
                    case 1:
                        MenuService.MenuShowStudents();
                        break;
                    case 2:
                        MenuService.MenuAddStudent();
                        break;
                    case 3:
                        MenuService.MenuUpdateStudent();
                        break;
                    case 4:
                        MenuService.MenuRemoveStudent();
                        break;
                    case 5:
                        MenuService.MenuFindStudentByName();
                        break;
                    case 0:
                        Console.WriteLine("Bye");
                        break;
                    default:
                        Console.WriteLine("No such option!");
                        break;
                }

            } while (option != 0);
        }
    }
}
