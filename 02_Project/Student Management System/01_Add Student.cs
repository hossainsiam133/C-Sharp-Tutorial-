class Add
{
    public void func(Student std)
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Department: ");
        string dept = Console.ReadLine();
        Console.Write("CGPA: ");
        double cg = double.Parse(Console.ReadLine());
        Console.Write("Email: ");
        string mail = Console.ReadLine();
        string path = "stu.txt";
        std.Setter(id, name, age, dept, cg, mail, 1010);
        string line = $"{std.id},{std.name},{std.age},{std.department},{std.cgpa},{std.email}";
        File.AppendAllText(path, line + Environment.NewLine);
        Console.WriteLine("Student saved successfully!");
    }
}