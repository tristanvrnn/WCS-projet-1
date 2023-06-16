using System;

namespace WCS_projet_1 
{
public class Course 
{
    public int courseID { get; set; }
    public string courseName { get; set; }

        public Course(int id, string name)
    {
        courseID = id;
        courseName = name;
    }
    
}
}