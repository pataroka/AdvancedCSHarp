using System;
using System.Collections.Generic;
using System.Linq;

namespace AllProblemsTo12
{
    class AllProblemsTo12
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Sara", "Mills", 18, 243514, "+359 88 956 45 14", "smills0@abv.bg",	new List<int>(){6, 4, 5, 6, 6, 5, 6, 6, 3, 6}, 2),
                new Student("Daniel", "Carter", 28, 253514, "+3592 976 85 75", "dcarter1@buzzfeed.com",	new List<int>(){3, 2, 5, 3, 4}, 1),
                new Student("Aaron", "Gray", 32, 244513, "088 337 45 97", "agray62@abv.bg",	new List<int>(){6, 6, 5, 6, 6, 5, 6, 6, 6, 6}, 3),
                new Student("William", "Gibson", 19, 245512, "02 337 45 45", "wgibson@buzzfeed.com",	new List<int>(){3, 2, 5, 3, 2, 5, 3, 4, 6}, 2),
                new Student("Mildred", "Mills", 57, 246511, "+3592 956 14 87", "mmills@skype.com",	new List<int>(){5, 4, 2, 3, 2, 5, 3, 3, 2}, 2),
                new Student("Craig", "Mills", 48, 243510, "+3592 337 75 87", "cmills10@abv.bg",	new List<int>(){6, 4, 5, 3, 6, 6, 6, 5, 6, 6}, 3),
                new Student("Cheryl", "Gray", 26, 243508, "+35988 976 97 45", "cgray6@yahoo.com",	new List<int>(){4, 5, 3, 3, 6, 3, 2, 5, 3}, 1),
                new Student("Craig", "King", 28, 243509, "+359 2 279 45 75", "cking7@cyberchimps.com",	new List<int>(){3, 4, 2, 2, 5, 3}, 4),
                new Student("Craig", "Carter", 19, 243610, "+3592 279 97 14", "ccarter6@yahoo.com",	new List<int>(){6, 4, 5, 6, 6, 5, 3, 6}, 1),
                new Student("Andrea", "Mills", 19, 243810, "088 279 45 87", "amills6@marketwatch.com",	new List<int>(){4, 5, 5, 3, 2, 4, 5, 3, 2}, 4),
                new Student("William", "Boyd", 48, 243904, "+359 88 310 97 75", "smills0@cyberchimps.com",	new List<int>(){4, 2, 2, 5, 3, 2, 5, 3, 4, 5}, 4)
            };

            List<StudentSpecialty> specialties = new List<StudentSpecialty>()
            {
                new StudentSpecialty("Web Developer", 243904),
                new StudentSpecialty("Web Developer", 253514),
                new StudentSpecialty("PHP Developer", 243510),
                new StudentSpecialty("QA Engineer", 244513),
                new StudentSpecialty("Java Developer", 246511),
                new StudentSpecialty("Web Developer", 243514),
                new StudentSpecialty("C/C++ Developer", 245512),
                new StudentSpecialty("C/C++ Developer", 246511),
                new StudentSpecialty("Python Developer", 243509),
                new StudentSpecialty("DP Specialist", 243514),
                new StudentSpecialty("System Administrator", 243510),
                new StudentSpecialty("DP Specialist", 243508),
                new StudentSpecialty("QA Engineer", 243508),
                new StudentSpecialty("DP Specialist", 243610),
                new StudentSpecialty("Python Developer", 243610),
                new StudentSpecialty("Java Developer", 243904),
                new StudentSpecialty("Java Developer", 253514),
                new StudentSpecialty("Python Developer", 243810),
                new StudentSpecialty("System Administrator", 243810),
            };

            Problem2StudentsByGroup(students);
            Problem3StudentsByFirstAndLastName(students);
            Problem4StudentsByAge(students);
            Problem5SortStudents1(students);
            Problem5SortStudents2(students);
            Problem6FilterStudentsByEmailDomain(students);
            Problem7FilterStudentsByPhone(students);
            Problem8ExcellentStudents(students);
            Problem9WeakStudents(students);
            Problem10StudentsEnrolledIn2014(students);
            Problem11StudentsByGroups(students);
            Problem12StudentsJoinedToSpecialties(students, specialties);

        }

        private static void Problem2StudentsByGroup(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Problem 2 output:");
            Console.ResetColor();
            var studentsQuery = from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;
            foreach (var st in studentsQuery)
            {
                Console.WriteLine("{0} {1}: {2}", st.FirstName, st.LastName, st.GroupNumber);
            }
        }

        private static void Problem3StudentsByFirstAndLastName(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Problem 3 output:");
            Console.ResetColor();
            var studentsQuery = from student in students
                                where student.FirstName.CompareTo(student.LastName) < 0
                                select student;
            foreach (var st in studentsQuery)
            {
                Console.WriteLine("{0} {1}", st.FirstName, st.LastName);
            }
        }

        private static void Problem4StudentsByAge(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Problem 4 output:");
            Console.ResetColor();
            var studentsQuery = from student in students
                where student.Age >= 18 && student.Age <= 24
                select new {student.FirstName, student.LastName, student.Age};
            foreach (var st in studentsQuery)
            {
                Console.WriteLine("{0} {1} {2}", st.FirstName, st.LastName, st.Age);
            }
        }

        private static void Problem5SortStudents1(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Problem 5 output1:");
            Console.ResetColor();
            var studentsQuery = from student in students
                                orderby student.FirstName descending, student.LastName descending
                                select student;
            foreach (var st in studentsQuery)
            {
                Console.WriteLine("{0} {1}", st.FirstName, st.LastName);
            }
        }

        private static void Problem5SortStudents2(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Problem 5 output2:");
            Console.ResetColor();
            var studentsQuery =
                students.OrderByDescending(st => st.FirstName)
                    .ThenByDescending(st => st.LastName);
            foreach (var st in studentsQuery)
            {
                Console.WriteLine("{0} {1}", st.FirstName, st.LastName);
            }
        }

        private static void Problem6FilterStudentsByEmailDomain(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Problem 6 output:");
            Console.ResetColor();
            var studentsQuery = from student in students 
                                where student.Email.Contains("@abv.bg")
                                select student;
            foreach (var st in studentsQuery)
            {
                Console.WriteLine("{0} {1} {2}", st.FirstName, st.LastName, st.Email);
            }
        }

        private static void Problem7FilterStudentsByPhone(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Problem 7 output:");
            Console.ResetColor();
            var studentsQuery = from student in students
                                where student.Phone.Contains("02 ") || student.Phone.Contains("+3592") || student.Phone.Contains("+359 2 ")
                                select student;
            foreach (var st in studentsQuery)
            {
                Console.WriteLine("{0} {1} {2}", st.FirstName, st.LastName, st.Phone);
            }
        }

        private static void Problem8ExcellentStudents(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Problem 8 output:");
            Console.ResetColor();
            var studentsQuery = from student in students
                                where student.Marks.Contains(6)
                                select new { FullName = student.FirstName + " " + student.LastName, student.Marks };
            foreach (var st in studentsQuery)
            {
                Console.WriteLine(st.FullName + ": " + string.Join(", ", st.Marks));
            }
        }

        private static void Problem9WeakStudents(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Problem 9 output:");
            Console.ResetColor();
            var studentsQuery = students
                .Where(student => student.Marks.Count(mark => mark == 2) == 2)
                .Select(student => new { FullName = student.FirstName + " " + student.LastName, student.Marks });
            foreach (var st in studentsQuery)
            {
                Console.WriteLine(st.FullName + ": " + string.Join(", ", st.Marks));
            }
        }

        private static void Problem10StudentsEnrolledIn2014(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Problem 10 output:");
            Console.ResetColor();
            var studentsQuery = from student in students
                                where student.FacultyNumber % 100 == 14
                                select student;
            foreach (var st in studentsQuery)
            {
                Console.WriteLine("{0} {1} FN: {2} Marks: {3}", st.FirstName, st.LastName, st.FacultyNumber, string.Join(", ", st.Marks));
            }
        }

        private static void Problem11StudentsByGroups(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Problem 11 output:");
            Console.ResetColor();
            var studentsWithGroupName = new List<Student11>();

            foreach (Student st in students)
            {
                string groupName;
                switch (st.GroupNumber)
                {
                    case 1:
                        groupName = "Basic";
                        break;
                    case 2:
                        groupName = "Fundamentals";
                        break;
                    case 3:
                        groupName = "Front-End";
                        break;
                    case 4:
                        groupName = "Back-End";
                        break;
                    default:
                        groupName = "Alumni";
                        break;

                }
                studentsWithGroupName.Add(new Student11(st, groupName));
            }

            var studentsQuery = from student in studentsWithGroupName
                                group student by student.GroupName;
            foreach (var pair in studentsQuery)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(pair.Key);
                Console.ResetColor();
                foreach (var st in pair)
                {
                    Console.WriteLine("{0} {1}: {2}", st.FirstName, st.LastName, st.GroupName);
                }
                
            }
        }

        private static void Problem12StudentsJoinedToSpecialties(List<Student> students, List<StudentSpecialty> specialties)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Problem 12 output:");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("| {0, -15} | {1, -15} | {2, -20} |", " ", " ", " ");
            Console.WriteLine("| {0, -15} | {1, -15} | {2, -20} |", "Name", "Faculty Number", "Specialty");
            Console.WriteLine("| {0, -15} | {1, -15} | {2, -20} |", " ", " ", " ");
            var studentsQuery = from student in students
                                join specialty in specialties on student.FacultyNumber equals specialty.FacultyNumber
                                select new{student.FirstName, student.LastName, student.FacultyNumber, specialty.Specialty};
            int counter = 1;
            foreach (var st in studentsQuery)
            {
                if (counter % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("| {0,-15} | {1, -15} | {2, -20} |", st.FirstName + " " + st.LastName, st.FacultyNumber, st.Specialty);
                counter++;
            }
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("| {0, -15} | {1, -15} | {2, -20} |", " ", " ", " ");
            Console.ResetColor();
        }
    }
}
