using System;

namespace StudentGradeandEnrollmentSystem
{
    class Student
    {
        public string studentID;
        public string name;
        public double prelimGrade;
        public double midtermGrade;
        public double finalGrade;

        public double CalculateAverage()
        {
            return (prelimGrade + midtermGrade + finalGrade) / 3;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("STUDENT INFORMATION");
            Console.WriteLine("Student ID: " + studentID);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Prelim Grade: " + prelimGrade);
            Console.WriteLine("Midterm Grade: " + midtermGrade);
            Console.WriteLine("Final Grade: " + finalGrade);
            Console.WriteLine("Average Grade: " + CalculateAverage());

            if (CalculateAverage() >= 75)
            {
                Console.WriteLine("Status: Passed");
            }
            else
            {
                Console.WriteLine("Status: Failed");
            }
        }
    }

    class Course
    {
        public string courseCode;
        public string courseName;
        public int units;
        public double priceperUnit;

        public double calculateTotalTuition()
        {
            return units * priceperUnit;
        }

        public void displayCourseInfo()
        {
            Console.WriteLine("COURSE INFORMATION");
            Console.WriteLine("Course Code: " + courseCode);
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Units: " + units);
            Console.WriteLine("Price per Unit: " + priceperUnit);
            Console.WriteLine("Total Tuition Fee: " + calculateTotalTuition());
        }
    }

    class Teacher
    {
        public string teacherID;
        public string teacherName;
        public int hoursWorked;
        public double ratePerHour;

        public double calculateSalary()
        {
            return hoursWorked * ratePerHour;
        }
        public void displayTeacherInfo()
        {
            Console.WriteLine("TEACHER INFORMATION");
            Console.WriteLine("Teacher ID: " + teacherID);
            Console.WriteLine("Teacher Name: " + teacherName);
            Console.WriteLine("Hours Worked: " + hoursWorked);
            Console.WriteLine("Rate per Hour: " + ratePerHour);
            Console.WriteLine("Total Salary: " + calculateSalary());
        }
    }
    
    class SchoolSystem
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Course course = new Course();
            Teacher teacher = new Teacher();

            student.studentID = "2026-001";
            student.name = "Nica Tuazon";
            student.prelimGrade = 85;
            student.midtermGrade = 90;
            student.finalGrade = 88;

            course.courseCode = "CS101";
            course.courseName = "Object Oriented Programming";
            course.units = 3;
            course.priceperUnit = 1500.0;

            teacher.teacherID = "T-100";
            teacher.teacherName = "Abel Bucad";
            teacher.hoursWorked = 40;
            teacher.ratePerHour = 500;

            Console.WriteLine("=====================================");
            Console.WriteLine("STUDENT GRADE AND ENROLLMENT SYSTEM");
            Console.WriteLine("=====================================");

            Console.WriteLine();
            student.DisplayStudentInfo();

            Console.WriteLine();
            course.displayCourseInfo();

            Console.WriteLine();
            teacher.displayTeacherInfo();
        }
    }
}