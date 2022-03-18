using Lab_02.data;
using Lab_02;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Lab_02.models
{
    public class Student : Person
    {
        protected string group;
        protected List<Task> tasks;

        public string Group { get => group; set => group = value; }

        public Student(string name, int age, string group) : base(name, age)
        {
            this.group = group;
        }

        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            this.group = group;
            this.tasks = tasks;
        }

        public void AddTask(string taskName, TaskStat taskStatus)
        {
            var task = new Task(taskName, taskStatus);
            tasks.Add(task);
        }

        public void RemoveTask(int index) => tasks.RemoveAt(index);
        

        public void UpdateTask(int index, TaskStat taskStatus)
        {
            var taskToUpdate = tasks[index];
            taskToUpdate.Status = taskStatus;
            tasks[index] = taskToUpdate;
        }

        public string RenderTasks(string prefix = "\t")
        {
            StringBuilder renderedTasks = new StringBuilder();
            foreach (var task in tasks)
            {
                renderedTasks.AppendFormat(prefix, task.ToString());
            }
            return renderedTasks.ToString();
        }

        public override string ToString()
        {
            return base.ToString() + $"Group: {Group}";
        }

        public override bool Equals(object other)
        {
            return base.Equals(other);
        }

    }
}
