
using System;

namespace StudentManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService service = new StudentService();

            Student st1 = new Student(1, "Ahmad", 90);
            Student st2 = new Student(2, "Omar", 85);
            Student st3 = new Student(3, "Sara", 95);

            service.AddStudent(st1);
            service.AddStudent(st2);
            service.AddStudent(st3);

            while (true)
            {
                Console.WriteLine("\n===== Student Management =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            {
                                service.DisplayStudents();
                                break;
                            }

                        case "2":
                            {
                                Console.Write("Enter Student ID: ");

                                if (!int.TryParse(Console.ReadLine(), out int id))
                                {
                                    Console.WriteLine("Invalid ID!");
                                    break;
                                }

                                // Check that the ID is positive
                                if (id <= 0)
                                {
                                    Console.WriteLine("Student ID must be greater than 0!");
                                    break;
                                }

                                if (service.StudentIdExists(id))
                                {
                                    Console.WriteLine("Student ID already exists!");
                                    break;
                                }

                                Console.Write("Enter Student Name: ");
                                string name = (Console.ReadLine() ?? "").Trim();

                                if (string.IsNullOrWhiteSpace(name))
                                {
                                    Console.WriteLine("Student Name cannot be empty!");
                                    break;
                                }

                                if (service.StudentNameExists(name))
                                {
                                    Console.WriteLine("Student Name already exists!");
                                    break;
                                }

                                Console.Write("Enter Student Grade: ");

                                if (!double.TryParse(Console.ReadLine(), out double grade)
                                    || double.IsNaN(grade)
                                    || double.IsInfinity(grade))
                                {
                                    Console.WriteLine("Invalid Grade!");
                                    break;
                                }

                                if (grade < 0 || grade > 100)
                                {
                                    Console.WriteLine("Grade must be between 0 and 100!");
                                    break;
                                }

                                Student newStudent = new Student(id, name, grade);

                                service.AddStudent(newStudent);

                                Console.WriteLine("Student Added Successfully!");
                                break;
                            }

                        case "3":
                            {
                                Console.Write("Enter Student ID to search: ");

                                if (!int.TryParse(Console.ReadLine(), out int searchId))
                                {
                                    Console.WriteLine("Invalid ID!");
                                    break;
                                }

                                service.SearchStudent(searchId);
                                break;
                            }

                        case "4":
                            {
                                Console.Write("Enter Student ID to update: ");

                                if (!int.TryParse(Console.ReadLine(), out int updateId))
                                {
                                    Console.WriteLine("Invalid ID!");
                                    break;
                                }

                                Console.Write("Enter New Name: ");
                                string newName = Console.ReadLine() ?? "";

                                Console.Write("Enter New Grade: ");

                                if (!double.TryParse(Console.ReadLine(), out double newGrade)
                                    || double.IsNaN(newGrade)
                                    || double.IsInfinity(newGrade))
                                {
                                    Console.WriteLine("Invalid Grade!");
                                    break;
                                }

                                service.UpdateStudent(updateId, newName, newGrade);
                                break;
                            }

                        case "5":
                            {
                                Console.Write("Enter Student ID to delete: ");

                                if (!int.TryParse(Console.ReadLine(), out int deleteId))
                                {
                                    Console.WriteLine("Invalid ID!");
                                    break;
                                }

                                service.DeleteStudent(deleteId);
                                break;
                            }

                        case "0":
                            {
                                Console.WriteLine("Goodbye!");
                                return;
                            }

                        default:
                            {
                                Console.WriteLine("Invalid Choice!");
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred!");
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
