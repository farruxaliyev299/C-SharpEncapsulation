using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Samir";
            student.Surname = "Aliyev";
            student.Id = 10;

            Student student2 = new Student();
            student2.Name = "Ferrux";
            student2.Surname = "Aliyev";
            student2.Id = 20;

            Group group = new Group();
            group.GroupName = "BP201";
            group.MaxStuCount = 100;

            group.AddStudents(student);
            group.AddStudents(student2);


            Console.WriteLine(group.Students[0].Name);
            Console.WriteLine(group.Students[1].Id);
            







        }
    }
}
