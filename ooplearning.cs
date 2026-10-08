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
                Console.WriteLine("Status: PASSED");
            }
            else
            {
                Console.WriteLine("Status: FAILED");
            }
        }

        // Default constructor
        public Student()
        {
            studentID = "UNDEFINED";
            name = "UNDEFINED";
            prelimGrade = 0;
            midtermGrade = 0;
            finalGrade = 0;
        }

        // Parameterized constructor
        public Student(string studentID, string name, double prelimGrade, double midtermGrade, double finalGrade)
        {
            this.studentID = studentID;
            this.name = name;
            this.prelimGrade = prelimGrade;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
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

        // Default constructor
        public Course()
        {
            courseCode = "UNDEFINED";
            courseName = "UNDEFINED";
            units = 0;
            priceperUnit = 0;
        }

        // Parameterized constructor
        public Course(string courseCode, string courseName, int units, double priceperUnit)
        {
            this.courseCode = courseCode;
            this.courseName = courseName;
            this.units = units;
            this.priceperUnit = priceperUnit;
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

        // Default constructor
        public Teacher()
        {
            teacherID = "UNDEFINED";
            teacherName = "UNDEFINED";
            hoursWorked = 0;
            ratePerHour = 0;
        }

        // Parameterized constructor
        public Teacher(string teacherID, string teacherName, int hoursWorked, double ratePerHour)
        {
            this.teacherID = teacherID;
            this.teacherName = teacherName;
            this.hoursWorked = hoursWorked;
            this.ratePerHour = ratePerHour;
        }
    }

    class SchoolSystem
    {
        static void Main(string[] args)
        {
            // STUDENTS

            Student student = new Student();

            Student student2 = new Student();
            student2.studentID = "2026-001";
            student2.name = "Nica Tuazon";
            student2.prelimGrade = 85;
            student2.midtermGrade = 90;
            student2.finalGrade = 88;

            Student student3 = new Student(
                "2026-002",
                "Sherwin Cari",
                85,
                90,
                88
            );

            Student student4 = new Student(
                "2024-003",
                "Hezekaiah Apolonio",
                95,
                96,
                98
            );

            Student student5 = new Student(
                "2024-004",
                "John Doe",
                75,
                80,
                70
            );

            // COURSES

            Course course1 = new Course();
            course1.courseCode = "CS1012";
            course1.courseName = "Object Oriented Programming";
            course1.units = 3;
            course1.priceperUnit = 1500.0;

            Course course2 = new Course();

            Course course3 = new Course(
                "CS1020",
                "Data Structures and Algorithms",
                4,
                2000.0
            );

            // TEACHERS

            Teacher teacher = new Teacher();

            Teacher teacher2 = new Teacher();

            teacher.teacherID = "T-100";
            teacher.teacherName = "Abel Bucad";
            teacher.hoursWorked = 40;
            teacher.ratePerHour = 500;

            Teacher teacher3 = new Teacher();

            teacher3.teacherID = "T-101";
            teacher3.teacherName = "Jane Smith";
            teacher3.hoursWorked = 35;
            teacher3.ratePerHour = 450;

            // DISPLAY INFORMATION

            Console.WriteLine("STUDENT GRADE AND ENROLLMENT SYSTEM");
            Console.WriteLine();

            student.DisplayStudentInfo();
            Console.WriteLine();

            student2.DisplayStudentInfo();
            Console.WriteLine();

            student3.DisplayStudentInfo();
            Console.WriteLine();

            student4.DisplayStudentInfo();
            Console.WriteLine();

            student5.DisplayStudentInfo();
            Console.WriteLine();

            course1.displayCourseInfo();
            Console.WriteLine();

            course2.displayCourseInfo();
            Console.WriteLine();

            course3.displayCourseInfo();
            Console.WriteLine();

            teacher.displayTeacherInfo();
            Console.WriteLine();

            teacher2.displayTeacherInfo();
            Console.WriteLine();

            teacher3.displayTeacherInfo();
        }
    }
}