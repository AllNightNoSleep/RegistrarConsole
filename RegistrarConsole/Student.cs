namespace RegistrarConsole
{
    public enum StudentType
    {
        New,Returnee,ShortTerm
    }

    public class Student : Person
    {
        public StudentType StudentType { get; set; }

        public Student()
        {
        }
    }
}