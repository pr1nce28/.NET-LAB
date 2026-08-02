using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class student
    {
        private string studentName;
        private int age;
        private string phone;
        private string email;
        public string Course { get; set; }
        public string EnrollmentNo { get; set; }



        public student(string studentName, int age, string course, string phone, string email)
        {
            this.studentName = studentName;
            this.age = age;
            this.phone = phone;
            this.email = email;
            Course = course;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Course: " + Course);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Enrollment No: " + EnrollmentNo);
        }
    }

    class uniAdmin
    {
        private double AdmissionFee;

        public void DisplayCourses()
        {
            Console.WriteLine("\n----- Courses Offered -----");
            Console.WriteLine("1. BCA      - Rs.45000");
            Console.WriteLine("2. BBA      - Rs.40000");
            Console.WriteLine("3. B.Sc IT  - Rs.50000");
            Console.WriteLine("4. B.Tech   - Rs.70000");
        }

        public int GetCourseFee(string course)
        {
            switch (course.ToUpper())
            {
                case "BCA":
                    return 45000;

                case "BBA":
                    return 40000;

                case "B.SC IT":
                    return 50000;

                case "B.TECH":
                    return 70000;

                default:
                    return 0;
            }
        }

        public string GenerateEnrollmentNo()
        {
            Random random = new Random();
            return "ENR" + random.Next(1000, 9999).ToString();
        }

        public void ConfirmAdmission(student student)
        {
            student.EnrollmentNo = GenerateEnrollmentNo();
            int fee = GetCourseFee(student.Course);

            Console.WriteLine("Admission confirmed for " + student.EnrollmentNo);

            Console.WriteLine("Admission Successfully Completed!");
            Console.WriteLine("Course Fees : Rs." + fee);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            uniAdmin admin = new uniAdmin();
            Console.WriteLine("==== Student Admission Management System ====");

            admin.DisplayCourses();

            Console.WriteLine("\nEnter Preferred Course (BCA, BBA, B.Sc IT, B.Tech):");
            string course = Console.ReadLine();

            Console.WriteLine("\nEnter Student Name:");
            string name = Console.ReadLine();

            Console.WriteLine("\nEnter Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Phone Number:");
            string phone = Console.ReadLine();

            Console.WriteLine("\nEnter Email:");
            string email = Console.ReadLine();

            student student = new student(name, age, course, phone, email);

            admin.ConfirmAdmission(student);

            student.DisplayStudentInfo();

            Console.WriteLine("\nThank you for using the Student Admission Management System!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

    }
}
