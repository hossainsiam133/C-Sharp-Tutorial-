class Test_001
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());
        for (int i = 0; i < tc; i++)
        {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            Console.WriteLine(a * b + 1);
        }
    }
}