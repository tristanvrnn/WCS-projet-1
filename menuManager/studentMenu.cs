using System;
using System.Collections.Generic;
using WCS_projet_1;

namespace WCS_projet_1
{
    public class studentMenu
    {
        public static List<Student> students = new List<Student>();
    public void ShowStudentMenu()
    {
        bool exitMenu = false;

        while (!exitMenu)
        {
            Console.WriteLine("----- Student menu -----");
            Console.WriteLine(" ");
            Console.WriteLine("1. List student");
            Console.WriteLine("2. Create student");
            Console.WriteLine("3. Consult existing student");
            Console.WriteLine("4. Add a grade and an appreciation on a course for an existing student");
            Console.WriteLine("5. Come back to main menu");
            Console.WriteLine(" ");
            Console.WriteLine("Choice : ");

            string choice = Console.ReadLine();
            Console.WriteLine(" ");

            switch (choice)
            {
                case "1":
                    ListStudents();
                    break;
                case "2":
                    AddStudent();
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

            Console.WriteLine(" ");
        }
    }
    
    public static void ListStudents()
    {
        Console.WriteLine("List of Students:");
        Console.WriteLine(" ");

        if(students != null)
        foreach (Student student in students)
        {
            Console.WriteLine("ID: " + student.studentID + ", " + "Name: " + student.firstName  + " " +  student.lastName + ".");
            Console.WriteLine(" ");
        }
        else 
        {
            Console.WriteLine("List is empty.");
            Console.WriteLine(" ");
        }
    }

    public static void AddStudent() 
    {
        Console.WriteLine("Enter student infos:");
        Console.WriteLine(" ");

        Console.Write("studentID: ");
        int studentID;
        if(students.Count == 0)
                    {
                        studentID = 0;
                    }
                    else
                    {
                        studentID = students[students.Count-1].studentID + 1;
                    }


        Console.Write("first Name: ");
        string firstName = Console.ReadLine();

        Console.Write("last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("birthdate (yyyy/MM/dd): ");
        DateTime birthdate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(" ");

            Student student = new Student
    {
        studentID = studentID,
        firstName = firstName,
        lastName = lastName,
        birthdate = birthdate
    };
        students.Add(student);

        Console.WriteLine("Student " + firstName + " " + lastName + " added successfully.");
        Console.WriteLine(" ");
    }

    public static void ViewStudent()
    {
        Console.Write("Enter student ID: ");
        int studentID = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");

        Student student = students.Find(item=>item.studentID==studentID);
        if (student != null)
        {
            Console.WriteLine("ID: " + student.studentID);
            Console.WriteLine("Name: " + student.firstName + " " + student.lastName);
            Console.WriteLine("Birthdate: " + student.birthdate);
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine("No student");
            Console.WriteLine(" ");
        }
    }

    public static void AddGradeToStudent() 
    {
        Console.Write("Enter student ID: ");
        int studentID = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");

        Student student = students.Find(item=>item.studentID==studentID);
        if (student != null)
        {
            Console.Write("Enter course name: ");
            string subject = Console.ReadLine();
            Console.Write("Enter grade: ");
            double value = double.Parse(Console.ReadLine());
            Console.Write("Enter appreciation: ");
            string appreciation = Console.ReadLine();
            Console.WriteLine(" ");

            Grade newGrade = new Grade();
            student.grades.Add(newGrade);

            Console.WriteLine("Grade added successfully.");
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine("No student found");
            Console.WriteLine(" ");
        }
    }
}
}