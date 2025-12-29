using System.Runtime.InteropServices;

class Main_Class
{
    public static void Main(string[] args)
    {
        int option = -1;
        do
        {
            Console.WriteLine("===== Student Management System =====");
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.View All Students");
            Console.WriteLine("3.Search Student");
            Console.WriteLine("4.Update Student");
            Console.WriteLine("5.Delete Student");
            Console.WriteLine("6.Exit");
            Console.Write("Choose an option: ");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        Add add = new Add();
                        Student std = new Student();
                        add.func(std);
                        break;
                    }
                case 2:
                    {
                        View view = new View();
                        view.func();
                        break;
                    }
                case 3:
                    {
                        Search search = new Search();
                        search.func();
                        break;
                    }
                case 4:
                    {
                        Update update = new Update();
                        update.func();
                        break;
                    }
                case 5:
                    {
                        Delete delete = new Delete();
                        delete.func();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Exited...");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Option Entered!");
                        break;
                    }

            }
            Console.ReadKey();
        }
        while (option != 6);
    }
}