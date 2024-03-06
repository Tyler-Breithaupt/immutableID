namespace immutableID;

class Program
{
    class Student
    {
        // auto-implemented properties
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // default constructor
        public Student()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
        }
        // parameterized constructor
        public Student(int i, string First, string Last)
        {
            Id = i;
            FirstName = First;
            LastName = Last;
        }

        public Student(int id)
        {
            Id = id;
            FirstName = "";
            LastName = "";
        }

        public int GetId()
        {
            return Id;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetLastName()
        {
            return LastName;
        }
    }
    static void Main()
    {
        Student student1 = new Student(123);

        student1.FirstName = "Alex";
        student1.LastName = "Smith";

        Console.WriteLine("First Student:");
        Console.WriteLine($"Student ID: {student1.GetId()}");
        Console.WriteLine($"First Name: {student1.GetFirstName()}");
        Console.WriteLine($"Last Name: {student1.GetLastName()}\n");

        Student student2 = new Student(456, "Amanda", "Wheeler");

        Console.WriteLine("Second Student:");
        Console.WriteLine($"Student ID: {student2.GetId()}");
        Console.WriteLine($"First Name: {student2.GetFirstName()}");
        Console.WriteLine($"Last Name: {student2.GetLastName()}");
    }
}