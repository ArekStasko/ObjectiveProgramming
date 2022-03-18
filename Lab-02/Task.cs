using Lab_02.data;

namespace Lab_02
{
    public class Task
    {
        private string _name;
        private TaskStat _taskStatus;

        public string Name { get => _name; set => _name = value; }
        public TaskStat Status { get => _taskStatus; set => _taskStatus = value; }

        public Task(string name, TaskStat status)
        {
            Name = name;
            Status = status;
        }

        public override string ToString()
        {
            return $"Name: {Name}; Status: {Status}";
        }

        public override bool Equals(object other)
        {
            Task task = other as Task;
            if (task == null) return false;
            return task.Name == Name && task.Status == Status;
        }
    }
}
