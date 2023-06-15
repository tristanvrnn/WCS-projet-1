using System;

public class Student
{
    public int numericID { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public DateTime birthdate { get; set; }
    public List<Grade> grades { get; set; }
    

        public class Grade
    {
        public string subject { get; set; }
        public double value { get; set; }
        public string appreciation { get; set; }
    }
    

    public double gradeAverage() 
    {
        double sum = 0;
        foreach (Grade grade in grades)
        {
            sum += sum + grade.value;
        }
        double average = sum/grade.count;
        return Math.Round(average, 2);
    }

}