
using System;
using System.Collections.Generic;

namespace StudentManagementApp
{
    class StudentService
    {
        List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DisplayStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found!");
                return;
            }

            foreach (Student st in students)
            {
                Console.WriteLine("ID: " + st.Id);
                Console.WriteLine("Name: " + st.Name);
                Console.WriteLine("Grade: " + st.Grade);
                Console.WriteLine("----------------");
            }
        }

        public void SearchStudent(int id)
        {
            foreach (Student st in students)
            {
                if (st.Id == id)
                {
                    Console.WriteLine("ID: " + st.Id);
                    Console.WriteLine("Name: " + st.Name);
                    Console.WriteLine("Grade: " + st.Grade);
                    return;
                }
            }

            Console.WriteLine("Student Not Found!");
        }

        public void UpdateStudent(int id, string newName, double newGrade)
        {
            Student studentToUpdate = students.Find(st => st.Id == id);

            if (studentToUpdate == null)
            {
                Console.WriteLine("Student Not Found!");
                return;
            }

            if (string.IsNullOrWhiteSpace(newName))
            {
                Console.WriteLine("Student Name cannot be empty!");
                return;
            }

            newName = newName.Trim();

            if (newGrade < 0 || newGrade > 100 ||
                double.IsNaN(newGrade) || double.IsInfinity(newGrade))
            {
                Console.WriteLine("Grade must be between 0 and 100!");
                return;
            }

            foreach (Student st in students)
            {
                if (st.Id != id &&
                    string.Equals(st.Name.Trim(), newName,
                    StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Student Name already exists!");
                    return;
                }
            }

            studentToUpdate.Name = newName;
            studentToUpdate.Grade = newGrade;

            Console.WriteLine("Student Updated Successfully!");
        }

        public void DeleteStudent(int id)
        {
            Student studentToDelete = students.Find(st => st.Id == id);

            if (studentToDelete != null)
            {
                students.Remove(studentToDelete);
                Console.WriteLine("Student Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("Student Not Found!");
            }
        }

        public bool StudentIdExists(int id)
        {
            foreach (Student st in students)
            {
                if (st.Id == id)
                {
                    return true;
                }
            }

            return false;
        }

        public bool StudentNameExists(string name)
        {
            foreach (Student st in students)
            {
                if (string.Equals(st.Name.Trim(), name.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
