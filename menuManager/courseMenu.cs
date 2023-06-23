using System;
using System.Collections.Generic;
using WCS_projet_1;

namespace WCS_projet_1
{
    public class courseMenu
    {
        public static List<Course> courses = new List<Course>();
            public void ShowCourseMenu()
    {
        bool exitMenu = false;

        while (!exitMenu)
        {
            Console.WriteLine("----- Courses Menu -----");
            Console.WriteLine(" ");
            Console.WriteLine("1. List existing courses");
            Console.WriteLine("2. Add a new course to the program");
            Console.WriteLine("3. Remove a course by its identifier");
            Console.WriteLine("4. Come back to main menu");
            Console.WriteLine(" ");
            Console.Write("Choice: ");

            string choice = Console.ReadLine();
            Console.WriteLine(" ");

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

            Console.WriteLine(" ");
        }
    }


        public void ListCourses()
        {
            Console.WriteLine("List of Courses: ");
            Console.WriteLine();

            if (courses.Count > 0)
            {
                foreach (Course course in courses)
                {
                    Console.WriteLine("ID: " + course.courseID + ", Name: " + course.courseName);
                }
            }
            else
            {
                Console.WriteLine("No courses found.");
            }
        }

        public void AddCourse()
        {
            Console.WriteLine("Enter course details:");
            Console.WriteLine(" ");

                    int courseID;
                    if(courses.Count == 0)
                    {
                        courseID = 0;
                    }
                    else
                    {
                        courseID = courses[courses.Count-1].courseID + 1;
                    }

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Course course = new Course(courseID, name);
            courses.Add(course);

            dataManager.WriteJsonFile();

            Console.WriteLine("Course added successfully.");
        }

        public void RemoveCourse()
        {
            Console.Write("Enter the ID of the course to remove: ");
            int id = int.Parse(Console.ReadLine());

            Course courseToRemove = courses.Find(course => course.courseID == id);

            if (courseToRemove != null)
            {
                courses.Remove(courseToRemove);

                dataManager.WriteJsonFile();
                Console.WriteLine("Course removed successfully.");
            }
            else
            {
                Console.WriteLine("Course not found.");
            }
        }
}
}
