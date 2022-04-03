using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    internal static class Global
    {
        public static Class CurrentClass = null;
        public static string ClassesJSON = "Classes.json";
        public static string StudentsPath = String.Empty;
        public static string SubjectsPath = String.Empty;

        public static int GetStudentCount()
        {
            return Directory.GetFiles(CurrentClass.Name + "\\Students\\").Length;
        }

        public static int GetSubjectCount()
        {
            return Directory.GetFiles(CurrentClass.Name + "\\Subjects\\").Length;
        }

        public static List<Class> GetClasses()
        {
            return LoadFromJSON<Class>(ClassesJSON);
        }

        public static List<Student> GetStudents()
        {
            try
            {
                List<Student> students = new List<Student>();
                string[] JSONfiles = Directory.GetFiles(CurrentClass.Name + "\\Students\\");

                foreach (string file in JSONfiles)
                    students.Add(SingleLoadFromJSON<Student>(file));

                return students;
            }
            catch
            {
                throw;
            }
        }

        public static List<Subject> GetSubjects()
        {
            try
            {
                List<Subject> subjects = new List<Subject>();
                string[] JSONfiles = Directory.GetFiles(CurrentClass.Name + "\\Subjects\\");

                foreach (string file in JSONfiles)
                    subjects.Add(SingleLoadFromJSON<Subject>(file));

                return subjects;
            }
            catch
            {
                throw;
            }
        }

        public static bool WriteToJSON<T>(List<T> list, string file)
        {
            try
            {
                string json = JsonConvert.SerializeObject(list);
                File.WriteAllText(file, json);

                return true;
            }
            catch
            {
                return false;
                throw;
            }
        }

        public static bool WriteToJSON<T>(T obj, string file)
        {
            try
            {
                string json = JsonConvert.SerializeObject(obj);
                File.WriteAllText(file, json);

                return true;
            }
            catch
            {
                return false;
                throw;
            }
        }

        public static bool AppendJSON<T>(T obj, string file)
        {
            try
            {
                string json;
                List<T> list = new List<T>();

                if (File.Exists(file))
                    list = LoadFromJSON<T>(file);

                list.Add(obj);

                json = JsonConvert.SerializeObject(list);
                File.WriteAllText(file, json);

                return true;
            }
            catch
            {
                return false;
                throw;
            }
        }

        public static List<T> LoadFromJSON<T>(string file)
        {
            try
            {
                List<T> items = new List<T>();

                if (File.Exists(file))
                    using (StreamReader r = new StreamReader(file))
                        items = JsonConvert.DeserializeObject<List<T>>(r.ReadToEnd());

                return items;
            }
            catch
            {
                throw;
            }
        }

        public static T SingleLoadFromJSON<T>(string file)
        {
            try
            {
                T item = default(T);

                if (File.Exists(file))
                    using (StreamReader r = new StreamReader(file))
                        item = JsonConvert.DeserializeObject<T>(r.ReadToEnd());

                return item;
            }
            catch
            {
                throw;
            }
        }

        public static float GetAvgGrade(string grades)
        {
            try
            {
                float avg = 0;
                string[] gradeList = grades.Split(';');

                foreach (string s in gradeList)
                    avg += float.Parse(s);

                return avg / gradeList.Length;
            }
            catch
            {
                throw;
            }
        }

        public static float GetStudentAvgGrade(List<StudentSubjects> studentSubjects)
        {
            try
            {
                float avg = 0;
                float i = 0;

                foreach (StudentSubjects studentSubject in studentSubjects)
                {
                    if (!String.IsNullOrWhiteSpace(studentSubject._Grades))
                    {
                        avg += GetAvgGrade(studentSubject._Grades);
                        i++;
                    }
                }

                return avg / i;
            }
            catch
            {
                throw;
            }
        }
    }
}