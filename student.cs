using System;

public class Student
{
    private int numericID;
    private string firstName;
    private string lastName;
    private int birthdate;
    private class Grade;
    
    public double gradeAverage(double[] grades) 
    {
        double sum = 0;
        foreach (double grade in grades)
        {
            sum += sum + grade;
        }
        double average = sum/grade.count;
        return Math.Round(average,2);
    }
}

public class Grade 
{
    private string subject;
    private double[] grades;
    private string[] appreciation;
}