using System;
using System.Collections.Generic;
using WCS_projet_1 ;

public class Student
{
    public int studentID { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public DateTime birthdate { get; set; }
    public List<Grade> grades { get; set; }

    public double gradeAverage() 
    {
        double sum = 0;
        double gradeAmount = 0;
        foreach (Grade value in grades)
        {
            sum += sum + value.value;
            gradeAmount ++;
        }
        double average = sum/gradeAmount;
        return Math.Round(average, 2);
    }
}