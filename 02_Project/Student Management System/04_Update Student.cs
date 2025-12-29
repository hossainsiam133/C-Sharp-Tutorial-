class Update
{
    public void func()
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        string path = "stu.txt";
        bool flag = true;
        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                string[] data = line.Split(',');
                if (int.Parse(data[0]) == id)
                {
                    Console.WriteLine($"ID\tName\tAge\tDepartment\tCGPA\tEmail");
                    for (int i = 0; i < 6; i++)
                    {
                        Console.Write($"{data[i]}\t");
                        if (i == 3)
                            Console.Write($"\t");
                    }
                    Console.WriteLine("");
                    flag = false;
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("File doesn't exist");
            return;
        }
        if (flag)
        {
            Console.WriteLine("ID Not Found!!!");
            return;
        }
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
        string[] liness = File.ReadAllLines(path);
        string str = "";
        foreach (var line in liness)
        {
            string[] data = line.Split(',');
            if (int.Parse(data[0]) == id)
            {
                str += $"{id},{name},{age},{dept},{cg},{mail}" + Environment.NewLine;
                continue;
            }
            str += line + Environment.NewLine;
        }
        File.WriteAllText(path, str);
        Console.WriteLine("Updated Successfully");
    }
}