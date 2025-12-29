using System.Security.Cryptography.X509Certificates;

class Search
{
    public void func()
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        string path = "stu.txt";
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
                    return;
                }
            }
        }
        else
            Console.WriteLine("File doesn't exist");
        Console.WriteLine("ID Not Found!!!");
    }
}