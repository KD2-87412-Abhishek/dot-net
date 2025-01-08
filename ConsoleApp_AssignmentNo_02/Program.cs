using System;

internal struct Student
{
    
    private string name;
    private bool gender;
    private int age;
    private int std;
    private char div;
    private double marks;

    // Default constructor
    //public Student()
    //{
    //    name = "Raju";
    //    gender = true;
    //    age = 0;
    //    std = 0;
    //    div = 'A';
    //    marks = 0.0;
    //}

    
    public Student(string name, bool gender, int age, int std, char div, double marks)
    {
        this.name = name;
        this.gender = gender;
        this.age = age;
        this.std = std;
        this.div = div;
        this.marks = marks;
    }

    
    public string GetName() => name;
    public void SetName(string name) => this.name = name;

    public bool GetGender() => gender;
    public void SetGender(bool gender) => this.gender = gender;

    public int GetAge() => age;
    public void SetAge(int age) => this.age = age;

    public int GetStd() => std;
    public void SetStd(int std) => this.std = std;

    public char GetDiv() => div;
    public void SetDiv(char div) => this.div = div;

    public double GetMarks() => marks;
    public void SetMarks(double marks) => this.marks = marks;

    
    public void AcceptDetails()
    {
        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Gender (true for Male, false for Female): ");
        gender = bool.Parse(Console.ReadLine());

        Console.Write("Enter Age: ");
        age = int.Parse(Console.ReadLine());

        Console.Write("Enter Standard: ");
        std = int.Parse(Console.ReadLine());

        Console.Write("Enter Division (single character): ");
        div = char.Parse(Console.ReadLine());

        Console.Write("Enter Marks: ");
        marks = double.Parse(Console.ReadLine());
    }

    
    public void PrintDetails()
    {
        Console.WriteLine("\nStudent Details:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Gender: {(gender ? "Male" : "Female")}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Standard: {std}");
        Console.WriteLine($"Division: {div}");
        Console.WriteLine($"Marks: {marks}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students = null;

        CreateArray(ref students);
        AcceptInfo(students);
        PrintInfo(students);

        Console.WriteLine("\nReversed Array:");
        ReverseArray(students, out Student[] reversedArray);
        PrintInfo(reversedArray);
    }

    
    static void CreateArray(ref Student[] students)
    {
        Console.Write("Enter the number of students: ");
        int size = int.Parse(Console.ReadLine());
        students = new Student[size];
    }

    
    static void AcceptInfo(Student[] students)
    {
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"\nEnter details for Student {i + 1}:");
            students[i].AcceptDetails();
        }
    }

    
    static void PrintInfo(Student[] students)
    {
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"\nDetails of Student {i + 1}:");
            students[i].PrintDetails();
        }
    }

    
    static void ReverseArray(Student[] students, out Student[] reversedArray)
    {
        reversedArray = new Student[students.Length];
        for (int i = 0; i < students.Length; i++)
        {
            reversedArray[i] = students[students.Length - 1 - i];
        }
    }
}
