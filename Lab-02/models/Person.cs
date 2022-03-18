

namespace Lab_02.models
{
    public class Person
    {
        protected string name;
        protected int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Person(string personName, int personAge)
        {
            Name = personName;
            Age = personAge;
        }

        public override bool Equals(object other)
        {
            Person person = other as Person;
            if (person == null) return false;
            return person.Name == Name && person.Age == Age;
        }

        public override string ToString()
        {
            return $"Name: {Name}; Age: {Age}; ";
        }

    }
}
