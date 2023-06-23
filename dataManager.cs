using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using WCS_projet_1;

namespace WCS_projet_1
{
    public class dataManager
    {
        public static void WriteJsonFile()
        {
            List<Course> coursesToWrite = courseMenu.courses;
            List<Student> studentsToWrite = studentMenu.students;

            serializedJson toWrite = new serializedJson();
            toWrite.students = studentsToWrite;
            toWrite.courses = coursesToWrite;

            string json = JsonConvert.SerializeObject(toWrite);


            File.WriteAllText("datas.json", json);
        }

        public static void ReadJsonFile()
        {
            string json = File.ReadAllText("datas.json");

            serializedJson serialized = JsonConvert.DeserializeObject<serializedJson>(json);

            courseMenu.courses = serialized.courses;
            studentMenu.students = serialized.students;
        }
    }

    public class serializedJson 
    {
        public List<Student> students;
        public List<Course> courses;
    }
}
