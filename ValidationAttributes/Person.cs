namespace ValidationAttributes
{
    public class Person
    {
        [MyRequired]
        public string Name { get; set; }

        [MyRange(12, 90)]
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}