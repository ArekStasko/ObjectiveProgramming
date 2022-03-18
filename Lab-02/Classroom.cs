using Lab_02.models;

namespace Lab_02
{
    public class Classroom
    {
        private string _name;
        private Person[] _persons;
        public string Name { get => _name; set => _name = value; }
        public Person[] Persons { get => _persons; set => _persons = value; }

        public Classroom(string name, Person[] persons)
        {
            Name = name;
            Persons = persons;
        }

        public override string ToString()
        {
            return $"ClassName: {Name}";
        }
    }
}
