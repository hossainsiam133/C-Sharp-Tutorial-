using System;
using System.Runtime.InteropServices;
class Test
{
    public static void Main(string[] args)
    {
        // string name = "Siam Hossain";
        // int age = 23;
        // string pro = ".Net Dev";
        // printFunc_01(name, age, pro);
        // UserInput_02();
        // Assignment_03();
        // Assignment_04();
        // Unary_05();
    }
    public static void Unary_05()
    {
        int num = 10;
        Console.WriteLine(++num);
        Console.WriteLine(num++);
        Console.WriteLine(num--);
        Console.WriteLine(--num);

    }
    public static void Assignment_04()
    {
        Console.WriteLine("Enter Temp in Celcius: ");
        double c = Convert.ToDouble(Console.ReadLine());
        double f = (9 * c) / 5 + 32;
        Console.Write("Temp in Fahrenhite: " + f.ToString("F2"));
    }
    public static void Assignment_03()
    {
        Console.WriteLine("Enter your Name: ");
        string? name = Console.ReadLine();

        Console.WriteLine("Enter your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your GPA: ");
        double gpa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Are you registered?");
        bool registered = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(gpa);
        Console.WriteLine(registered);
    }
    public static void UserInput_02()
    {
        // string? s = Console.ReadLine();
        // Console.WriteLine(s);
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a);
    }
    public static void printFunc_01(string n, int a, string p)
    {
        Console.WriteLine("Name: " + n);
        Console.Write("Age: " + a + "\n");
        Console.WriteLine("Profession: " + p);
    }
}