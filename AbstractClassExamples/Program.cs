using System;

namespace lesson8
{
    public abstract class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public abstract void sayHello();

        public int getAge()
        {
            return this.age;
        }
    }

    public class Teacher : Person
    {
        string subject;

        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            setSubject(subject);
        }

        public void setSubject(string subject)
        {
            this.subject = subject;
        }

        public override void sayHello()
        {
            Console.WriteLine("Hello, my name is " + this.name + ", and I teach " + this.subject);
        }
    }

    class Program
    {
        static void Main()
        {
            Teacher teacher = new Teacher("Tim Boyd", 35, "Math");
            teacher.sayHello(); // Hello, my name is Tim Boyd, and I teach English
        }
    }
}