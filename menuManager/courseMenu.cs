using System;
using System.Collections.Generic;

namespace WCS_projet_1
{
    public class courseMenu
    {
            private void ShowCoursesMenu()
    {
        bool exitMenu = false;

        while (!exitMenu)
        {
            Console.WriteLine("--- Courses Menu ---");
            Console.WriteLine("1. List existing courses");
            Console.WriteLine("2. Add a new course to the program");
            Console.WriteLine("3. Remove a course by its identifier");
            Console.WriteLine("4. Back to main menu");
            Console.Write("Choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ListCourses();
                    break;
                case "2":
                    AddCourse();
                    break;
                case "3":
                    RemoveCourse();
                    break;
                case "4":
                    exitMenu = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine();
        }
    }
    }

    public void ListCourses()
    {
        Console.WriteLine("List of existing course");
    }

    public void AddCourse()
    {
        Console.WriteLine("Addition of a new course to the program");
    }

    public void RemoveCourse()
    {
        Console.WriteLine("Deletition of a course by his identifier");
    }
    
    //fonction à implémenter
}
