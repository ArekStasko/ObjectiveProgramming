using Lab_02.data;
using Lab_02.models;

namespace Lab_02
{
    public class Program
    {
        public static void Main()
        {
            Teacher treacher = new Teacher("Maria Skłodowska", 50);

            Student student1 = new Student("Jan Kowaslski", 21, "LAB-01");
            Student student2 = new Student("Jan Kowaslski", 21, "LAB-01");
            Student student3 = new Student("Jaś Fasola", 23, "LAB-02");

            student1.AddTask("Taks A", TaskStat.Waiting);
            student1.AddTask("Taks B", TaskStat.Waiting);
            student1.AddTask("Taks C", TaskStat.Rejected);

            student2.AddTask("Taks A", TaskStat.Waiting);
            student2.AddTask("Taks B", TaskStat.Waiting);
            student2.AddTask("Taks C", TaskStat.Rejected);

            student3.AddTask("Taks D", TaskStat.Done);
            student3.AddTask("Taks E", TaskStat.Waiting);
            student3.AddTask("Taks F", TaskStat.Waiting);

            student3.UpdateTask(1, TaskStat.Done);
            student3.UpdateTask(2, TaskStat.Progress);

            Person[] persons = { treacher, student1, student2, student3 };
            Classroom classroom = new Classroom("Sala Komputerowa", persons);

            Console.WriteLine(classroom);

            Console.WriteLine("student1 == student2: " + student1.Equals(student2)); // Output: student1 == student2: true
            Console.WriteLine("student1 == student3: " + student1.Equals(student3)); // Output: student1 == student3: false
        }
    }
}