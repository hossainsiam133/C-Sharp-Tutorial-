using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
class Test
{
    public static void Main(string[] args)
    {
        // string name = "Siam Hossain";
        // int age = 23;
        // string pro = ".Net Dev";
        // Testing t = new Testing();
        // t.Testing_01();

        // printFunc_01(name, age, pro);
        // UserInput_02();
        // Assignment_03();
        // Assignment_04();
        // Unary_05();
        // Switch_Case_06();
        // tempConv_07();
        // Test_OOP oops_08 = new Test_OOP();
        // oops_08.oop();
        // arrays_09();
        // list_10();
        // Read_Multiple_Integers_11();
        BIF built_in_func_12 = new BIF();
        built_in_func_12.bif();
        Console.ReadKey();
    }
    public static void Read_Multiple_Integers_11()
    {
        string[] s = Console.ReadLine().Split();
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
    }
    public static void list_10()
    {
        List<int> li = new List<int> { };
        li.Add(1);
        Console.WriteLine($"li[0] = {li[0]}");

        // foreach (var x in li)
        // {
        //     Console.WriteLine($"x = {x}");

        // }
    }
    public static void arrays_09()
    {
        int[] ar = [1, 2, 3];
        foreach (var x in ar)
        {
            Console.WriteLine($"x = {x}");
        }
        int[][] arr = [[1, 2], [2, 3]];
        foreach (var x in arr)
        {
            foreach (var y in x)
            {
                Console.WriteLine($"y = {y}");
            }
        }

    }
    public static void tempConv_07()
    {
        Console.WriteLine("1. C -> F");
        Console.WriteLine("2. F -> C");
        int choise = Convert.ToInt32(Console.ReadLine());
        switch (choise)
        {
            case 1:
                Console.Write("Enter your Celcius scale temparature: ");
                double temp = Convert.ToDouble(Console.ReadLine());
                double f = (9 * temp) / 5 + 32;
                Console.WriteLine($"Temparature in Fahrenhite: {f.ToString("F2")}");
                break;
            case 2:
                Console.Write("Enter your Fahrenhite scale temparature: ");
                temp = Convert.ToDouble(Console.ReadLine());
                double c = (5 / 9) * (temp - 32);
                Console.WriteLine($"Temparature in Fahrenhite: {c.ToString("F2")}");
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
    public static void Switch_Case_06()
    {
        int num = 2;
        switch (num)
        {
            case int nums when nums % 2 == 0:
                Console.WriteLine("Even");
                break;
            default:
                Console.WriteLine("Odd");
                break;
        }
        // string msg = num switch
        // {
        //     1 => "One",
        //     2 => "Two",
        //     3 => "Three"
        // };
        // Console.WriteLine(msg);
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