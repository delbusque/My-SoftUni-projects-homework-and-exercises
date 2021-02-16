using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }

        public int Capacity { get; set; }
        public int Count => students.Count;

        public string RegisterStudent(Student student)
        {
            if (Capacity <= students.Count)
            {
                return "No seats in the classroom";
            }
            else
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student studentToDismiss = students
                .Find(x => x.FirstName == firstName && x.LastName == lastName);

            if (students.Contains(studentToDismiss))
            {
                return $"Dismissed student {studentToDismiss.FirstName} {studentToDismiss.LastName}";

            }
            else
            {
                return "Student not found";

            }

            //if (studentToDismiss == null)
            //{
            //    return "Student not found";
            //}
            //else
            //{
            //    return $"Dismissed student {studentToDismiss.FirstName} {studentToDismiss.LastName}";
            //}
        }

        public string GetSubjectInfo(string subject)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Subject: {subject}");
            result.AppendLine("Students:");
            int nonCounter = 0;

            foreach (var student in students)
            {
                if (student.Subject == subject)
                {
                    result.AppendLine($"{student.FirstName} {student.LastName}");
                    nonCounter++;
                }                
            }

            if (nonCounter == 0)
            {
                return "No students enrolled for the subject";
            }
            else
            {
                return result.ToString().TrimEnd();
            }
        }

        public int GetStudentsCount()
        {
            return students.Count;
        }

        public string GetStudent(string firstName, string lastName)
        {
            Student studentToGet = students
                .Find(s => s.FirstName == firstName && s.LastName == lastName);

            if (students.Contains(studentToGet))
            {
                return studentToGet.ToString();
            }

            else
            {
                throw new Exception ("No such student");
            }
        }
    }
}
