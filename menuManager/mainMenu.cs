using System;
using WCS_projet_1;

namespace WCS_projet_1
{
    public class MenuManager
{
    public void ShowMainMenu()
    {
        bool exitMenu = false;

        courseMenu courses = new courseMenu();
        studentMenu students = new studentMenu();
        while (!exitMenu)
        {
            Console.WriteLine("----- Main menu -----");
            Console.WriteLine(" ");
            Console.WriteLine("1. Student menu");
            Console.WriteLine("2. Course menu");
            Console.WriteLine("3. Exit");
            Console.WriteLine(" ");
            Console.Write("Choice : ");

            string choice = Console.ReadLine();
            Console.WriteLine(" ");

            switch (choice)
            {
                case "1":
                    students.ShowStudentMenu();
                    break;
                case "2":
                    courses.ShowCourseMenu();
                    break;
                case "3":
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

}

