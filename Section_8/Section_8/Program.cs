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
        static void SortData(List<Student> students)
        {
            students.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));
        }

        static List<Student> SearchData(List<Student> students, string name)
        {
            return students.FindAll(s => s.Name.ToLower() == name.ToLower());
        }

        static void DisplayData(List<Student> students)
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
            string fname = "C:\\Users\\Keerthana\\OneDrive\\Desktop\\job\\simpli\\Projects\\Section_8\\Section_8\\StudentData.txt";
            
            // Reading student data from the file
            List<Student> studata = ReadStudentData(fname);


            char ch;
            do
            {
                Console.WriteLine("Select\n1.Display data\n2.SortData\n3.Search for student using name");
                int choice=int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Display Data");
                        DisplayData(studata);
                        break;
                    case 2:
                        Console.WriteLine("Sort Data");
                        SortData(studata);
                        DisplayData(studata);
                        break;
                    case 3:
                        Console.WriteLine("Search for student using name\n");
                        Console.Write("Enter the name of the student to search for: ");
                        string searchName = Console.ReadLine();

                        List<Student> searchResult = SearchData(studata, searchName);
                        if (searchResult.Count > 0)
                        {
                            Console.WriteLine("Search Results:");
                            DisplayData(searchResult);
                        }
                        else
                        {
                            Console.WriteLine($"No student found with the name '{searchName}'.");
                        }

                        break;
                }
                Console.WriteLine("If you want to continue press y");
                ch = char.Parse(Console.ReadLine().ToLower());
            } while (ch == 'y');

            Console.ReadKey();
        }
    }
}
