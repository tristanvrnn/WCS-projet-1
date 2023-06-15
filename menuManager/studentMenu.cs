using System;

namespace WCS_projet_1
{
    public void ShowStudentoMenu()
    {
        bool exitMenu = false;

        while (!exitMenu)
        {
            Console.WriteLine("--- Student menu ---");
            Console.WriteLine("1. List student");
            Console.WriteLine("2. Create student");
            Console.WriteLine("3. Consult existing student");
            Console.WriteLine("4. Add a grade and an appreciation on a course for an existing student");
            Console.WriteLine("5. Come back to main menu");
            Console.Write("Choice : ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ListStudents();
                    break;
                case "2":
                    CreateStudent();
                    break;
                case "3":
                    ViewStudent();
                    break;
                case "4":
                    AddGradeToStudent();
                    break;
                case "5":
                    exitMenu = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine();
        }
    }

    public void ListStudents()
    {
        Console.WriteLine("List of students");
    }

    public void CreateStudent()
    {
        Console.WriteLine("Creation of a new student");
    }

    public void ViewStudent()
    {
        Console.WriteLine("Consultation of an existing student");
    }

    public void AddGradeToStudent()
    {
        Console.WriteLine("Add a grade and appreciation for a course on an existing student");
    }
    
}
