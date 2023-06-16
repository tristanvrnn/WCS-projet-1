using System;

public class Course 
{
    public int numericID { get; set; }
    public string courseName { get; set; }

        public Course(int id, string name)
    {
        numericID = id;
        courseName = name;
    }
    
}