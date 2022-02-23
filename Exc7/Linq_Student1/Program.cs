using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Student1
{

    internal class Program
    {

        static List<Student> students = new List<Student>
        {

            new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
            new Student {First="Claire", Last="O’Donnell", ID=112,Scores= new List<int> {75, 84, 91, 39}},
            new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
            new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
            new Student {First="Debra", Last="Garcia", ID=115, Scores=new List<int> {35, 72, 91, 70}}
        };

        static void Main(string[] args)
        {
            var studentQuery2 = from student in students
                                group student by student.Last[0];


            var studentQuery3 = from student in students
                                group student by student.Last[0];

            var studentQuery4 = from student in students
                                group student by student.Last[0] into studentGroup
                                orderby studentGroup.Key
                                select studentGroup;

            IEnumerable<Student> studentQuery = from student in students
                                               where student.Scores[0] > 70 && student.Scores[3] < 90
                                                orderby student.Scores[0] descending
                                                select student;
            
            int studentCount = (from student in students
                                where student.Scores[0] > 70 && student.Scores[3] < 90
                                select student).Count();

            int studentCountW = students.Where(st => st.Scores[0] > 70 && st.Scores[3] < 90).Count();

            var studentList = (from student in students
                                where student.Scores[0] > 70 && student.Scores[3] < 90
                                orderby student.Last ascending
                                select student).ToList();

            var studentQuery5 = from student in students
                                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                                where totalScore / 4 < student.Scores[0]
                                select student.Last + " " + student.First;

            var studentQuery6 = from student in students
                                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                                select totalScore;

            double averageScore = studentQuery6.Average();

            IEnumerable<string> studentQuery7 = from student in students
                                                where student.Last == "Garcia"
                                                select student.First;

            var studentQuery8 = from student in students
                                let x = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                                where x > averageScore
                                select new { id = student.ID, score = x };




            try
            {
                Console.WriteLine("Order By students score");
                foreach (Student student in studentQuery)
                {
                    Console.WriteLine("{0}, {1} {2}", student.Last, student.First, student.Scores[0]);
                }

                Console.WriteLine("\n Number of students: {0}, {1}", studentCount,  studentCountW);

                Console.WriteLine("\n Order By students family name");
                foreach (Student student in studentList)
                {
                    Console.WriteLine("{0}, {1}", student.Last, student.First);
                }

                 
                Console.WriteLine("\n GroupBy studentQuery2");
                foreach (var studentGroup in studentQuery2)
                {
                
                    Console.WriteLine(studentGroup.Key);
                    foreach (Student student in studentGroup)
                    {
                        Console.WriteLine("{0},  {1}", student.Last, student.First);
                    }
                }


                /*Console.WriteLine("\n GroupBy var studentQuery3");
                foreach (var groupOfStudents in studentQuery3)
                {
                    Console.WriteLine(groupOfStudents.Key);
                    foreach (var student in  groupOfStudents)
                    {
                        Console.WriteLine("     {0},  {1}", student.Last, student.First);
                    }
                };*/

                Console.WriteLine("\n GroupBy desc studentQuery4");
                foreach (var groupOfStudents in studentQuery4)
                {
                    Console.WriteLine(groupOfStudents.Key);
                    foreach (var student in groupOfStudents)
                    {
                        Console.WriteLine("     {0},  {1}", student.Last, student.First);
                    }
                };

                Console.WriteLine("\n Let studentQuery5");
                foreach (string s in studentQuery5)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("\n Class average score = {0}", averageScore);


                Console.WriteLine("\n The Garcias in the class are:");
                foreach (string s in studentQuery7)
                {
                    Console.WriteLine(s);
                }



                Console.WriteLine("\n Students with scores > average score:");
                foreach (var item in studentQuery8)
                {
                    Console.WriteLine("Student ID: {0}, Score: {1}", item.id, item.score);
                }
            }
            finally
            {
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            }
        }
    }
}
