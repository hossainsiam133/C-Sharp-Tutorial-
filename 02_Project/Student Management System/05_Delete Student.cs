class Delete
{
    public void func()
    {
        Console.Write("ID to Delete: ");
        int id = int.Parse(Console.ReadLine());
        string path = "stu.txt";
        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);
            string str = "";
            foreach (var line in lines)
            {
                string[] data = line.Split(',');
                if (int.Parse(data[0]) == id)
                {
                    continue;
                }
                str += line + Environment.NewLine;
            }
            File.WriteAllText(path, str);
            Console.WriteLine("Deleted");
        }
        else
            Console.WriteLine("File not Exist!!!");
    }
}