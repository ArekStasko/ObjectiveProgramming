using NUnit.Framework;
using FluentAssertions;
using Lab_02;
using Lab_02.data;
using Lab_02.models;

namespace ObjectiveProgramming.Tests
{
    public class StudentTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTask_ShouldAdd_OneTask()
        {
            var student = new Student("TestName", 16, "C");
            student.AddTask("TestTaskName", TaskStat.Progress);
            string tasks = student.RenderTasks();
            tasks.Should().Contain("TestTaskName");
        }

        [Test]
        public void RemoveTask_ShouldRemove_OneTask()
        {
            var student = new Student("TestName", 16, "C");
            student.AddTask("TestTaskName", TaskStat.Progress);
            student.RemoveTask(0);
            string tasks = student.RenderTasks();
            tasks.Should().Be("");
        }

        [Test]
        public void UpdateTask_ShouldUpdate_OneTask()
        {
            var student = new Student("TestName", 16, "C");
            student.AddTask("TestTaskName", TaskStat.Progress);
            student.UpdateTask(0, TaskStat.Waiting);
            string tasks = student.RenderTasks();
            tasks.Should().Contain("Waiting");
        }
    }
}
