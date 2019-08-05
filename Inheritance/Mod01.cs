namespace Inheritance
{
    class Mod01
    {
        public int Age { get; }
        private readonly string _name;
        private readonly string _surname;

        public Mod01(string name, string surname, int age)
        {
            Age = age;
            _name = name;
            _surname = surname;
        }
    }
}
