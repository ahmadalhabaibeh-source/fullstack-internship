Student Management System

About the Project

This is a simple Student Management System that I built using C#.

The project is a console application that allows users to manage student information. I created it to practice Object-Oriented Programming (OOP), working with classes, methods, and lists.

Features

The program allows users to:

Add a new student.

Display all students.

Search for a student by ID.

Update a student's name and grade.

Delete a student.

Exit the program.

Project Structure

The project has three main C# files:

student.cs: Contains the Student class with ID, name, grade, and a constructor.

StudentService.cs: Contains the methods for managing students using List<Student>.

Program.cs: Contains the main menu and handles user input.

How to Run

Download or clone the repository.

Open the week-02 folder.

Open studentmanagementsystem.csproj using Visual Studio.

Build the project.

Press Ctrl + F5 to run the program.

Choose an option from the menu.

Example of Using the Program

When the program starts, the following menu appears:

Student Management

Display Students

Add Student

Search Student

Update Student

Delete Student

Exit

For example, to add a student, choose option 2 and enter:

Student ID: 4

Student Name: Khaled

Student Grade: 90

The program will display:

Student Added Successfully!

You can then choose option 1 to display all students or option 3 to search for the new student.

Validation and Error Handling

I added validation to prevent invalid student information.

The program checks for duplicate student IDs and names, empty names, and grades outside the range of 0 to 100.

I also used TryParse to handle invalid number inputs and try-catch to handle unexpected errors.

Notes

The program starts with three example students: Ahmad, Omar, and Sara.

Student information is stored in a List while the application is running. The data is not saved permanently, so any changes will be lost when the program closes.

What I Learned

While building this project, I practiced creating classes, constructors, methods, and working with lists in C#.

I also learned how to organize a program into separate classes, use loops and switch statements, and handle user input and errors.