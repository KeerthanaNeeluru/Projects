using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_8
{
    public class Program
    {
        static List<Student> ReadStudentData(string fileName)
        {
            List<Student> students = new List<Student>();

            try
            {
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        students.Add(new Student { Name = parts[0], Class = parts[1] });
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File '{fileName}' not found.");
            }

            return students;
        }
        static void SortStudentData(List<Student> students)
        {
            students.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));
        }

        static List<Student> SearchStudentByName(List<Student> students, string name)
        {
            return students.FindAll(s => s.Name.ToLower() == name.ToLower());
        }

        static void DisplayStudentData(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No student data available.");
            }
            else
            {
                Console.WriteLine("Student Data:");
                foreach (Student student in students)
                {
                    Console.WriteLine($"Name: {student.Name}, Class: {student.Class}");
                }
            }
        }

        static void Main(string[] args)
        {
            string fileName = "C:\\Users\\Keerthana\\OneDrive\\Desktop\\job\\simpli\\Projects\\Section_8\\Section_8\\StudentData.txt";
            
            // Reading student data from the file
            List<Student> studentData = ReadStudentData(fileName);

            // Sorting student data by name
            SortStudentData(studentData);

            // Displaying sorted student data
            DisplayStudentData(studentData);

            // Searching for a student by name
            Console.Write("Enter the name of the student to search for: ");
            string searchName = Console.ReadLine();

            List<Student> searchResult = SearchStudentByName(studentData, searchName);
            if (searchResult.Count > 0)
            {
                Console.WriteLine("Search Results:");
                DisplayStudentData(searchResult);
            }
            else
            {
                Console.WriteLine($"No student found with the name '{searchName}'.");
            }
            Console.ReadKey();
        }
    }
}
