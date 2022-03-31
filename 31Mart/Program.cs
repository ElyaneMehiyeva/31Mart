using System;

namespace _31Mart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------Group 1------------------------");
            Student student1 = new Student()
            { FullName = "Carli Caplin", };
            Student student2 = new Student()
            { FullName = "Mr Bean" };
            Student student3 = new Student()
            { FullName = "Reza Deqathi" };
            Group group = new Group(GroupType.Programming)
            { Students = new Student[3], };
            group.Students[0] = student1;
            group.Students[1] = student2;
            group.Students[2] = student3;
            foreach (Student student in group.Students)
            { Console.WriteLine($"FullName : {student.FullName} -*- Group No : {group.No} -*- No : {student.No}"); }
            Console.WriteLine("-----------------------Group 2------------------------");
            Student student4 = new Student()
            { FullName = "Ilham Eliyev", };
            Student student5 = new Student()
            { FullName = "Firdovsi Pasayev" };
            Student student6 = new Student()
            { FullName = "Mubariz Ibrahimov" };
            Group group2 = new Group(GroupType.Design)
            { Students = new Student[3] };
            group2.Students[0] = student4;
            group2.Students[1] = student5;
            group2.Students[2] = student6;
            foreach (Student student in group2.Students)
            { Console.WriteLine($"FullName : {student.FullName} -*- Group No : {group2.No} -*- No : {student.No}"); }
        }
    }
}