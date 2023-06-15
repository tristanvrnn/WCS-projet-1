using System;

namespace WCS_projet_1
{
    public class MenuManager
{
    public void ShowMainMenu()
    {
        bool exitMenu = false;

        while (!exitMenu)
        {
            Console.WriteLine("--- Main menu ---");
            Console.WriteLine("1. Student menu");
            Console.WriteLine("2. Course menu");
            Console.WriteLine("3. Exit");
            Console.Write("Choice : ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowStudentMenu();
                    break;
                case "2":
                    ShowCourseMenu();
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

