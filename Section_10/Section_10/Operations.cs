using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_10
{
    public class Operations
    {
      private  List<Student> students;
       private List<Teachers> teachers;
       private  List<Subject> subjects ;
        public Operations()
        {
            students = new List<Student>();
            teachers = new List<Teachers>();
            subjects = new List<Subject>();
        }
         public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Student Added sucessfully");
        }
        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
            Console.WriteLine("Subject Added Successfully");
        }
        public void AddTeacher(Teachers teacher)
        {
            teachers.Add(teacher);
            Console.WriteLine("Teacher Added Successfully");
        }
        public void ViewStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
        public void ViewTeachers()
        {
            foreach (Teachers t in teachers)
            {
                Console.WriteLine($"Name : {t.TName}  Class : {t.TClass}   section : {t.TSection} ");
            }
        }
        public void ViewSubjects()
        {
            foreach (Subject sub in subjects)
            {
                Console.WriteLine($"SubjectName : {sub.Sub_Name}   SubjectCode : {sub.Sub_Code}  SubjectTeacher : {sub.Sub_Teacher}");
            }
        }

        public List<Student> GetStudentsinClass(int target_Class) {
        return students.FindAll(s=>s.Class == target_Class);
        }
        public List<Subject> GetSubjectByTeacher(string Teacher_name)
        {
            return subjects.FindAll(sub=>sub.Sub_Teacher == Teacher_name);
        }
    }
}
