class View
{
    public void func()
    {
        string path = "stu.txt";
        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);
            Console.WriteLine($"ID\tName\tAge\tDepartment\tCGPA\tEmail");
            foreach (var line in lines)
            {
                string[] data = line.Split(',');
                for (int i = 0; i < 6; i++)
                {
                    Console.Write($"{data[i]}\t");
                    if (i == 3)
                        Console.Write($"\t");
                }
                Console.WriteLine("");
            }
        }
        else
            Console.WriteLine("File doesn't exist");
    }
}