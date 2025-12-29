using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

class BIF
{
    public void bif()
    {
        int[] arr = { 3, 6, 5, 2, 8, 1, 3, 2 };
        Console.Write("Original Array: ");
        print(arr);
        int n = arr.Length;
        // Console.WriteLine($"n = {n}");

        // Array.Sort(arr);
        // print(arr);

        // Array.Reverse(arr);
        // print(arr);

        // int idx = Array.IndexOf(arr,3);
        // int last = Array.LastIndexOf(arr,3);
        // Console.WriteLine($"idx = {idx}");
        // Console.WriteLine($"last = {last}");

        // bool ok = Array.Exists(arr,x => x == 0);
        // Console.WriteLine($"ok = {ok}");

        // int first = Array.Find(arr, x => x % 2 == 0);
        // Console.WriteLine($"first = {first}");
        // int[] evens = Array.FindAll(arr, x => x % 2 == 0);
        // print(evens);

        // int[] b = new int[n]; \\ By Value copy
        // Array.Copy(arr,b,n);
        // b[0] = -1;
        // print(arr);

        // int[] c = new int[n];
        // Array.Fill(c,-1);
        // print(c);
        // Array.Clear(c,0,n);
        // print(c);
        // Array.Resize(ref c,n+5);
        // print(c);

        // int pos = Array.BinarySearch(arr,1);
        // Console.WriteLine($"pos = {pos}");

        // int mn = arr.Min();
        // int mx = arr.Max();
        // int sum = arr.Sum();
        // Console.WriteLine($"mn = {mn}");
        // Console.WriteLine($"mx = {mx}");
        // Console.WriteLine($"sum = {sum}");

        // string s = "0101010001100";
        // int cnt = s.Count(ch => ch == '0');
        // Console.WriteLine($"cnt = {cnt}");

        // int[] uni = arr.Distinct().ToArray();
        // print(uni);

        // int[] take = arr.Take(2).ToArray();
        // print(take);
        // int[] skip = arr.Skip(3).ToArray();
        // print(skip);

        // int[,] grid = new int[3, 3];
        //  for (int i = 0; i < 3; i++)
        // {
        //     string[] s = Console.ReadLine().Split();
        //     for (int j = 0; j < 3; j++)
        //     {
        //         grid[i,j] = int.Parse(s[j]);
        //     }            
        // }
        // Console.WriteLine("");

        // for (int i = 0; i < 3; i++)
        // {
        //     for (int j = 0; j < 3; j++)
        //     {
        //         Console.Write($"grid[{i},{j}] = {grid[i, j]} ");
        //     }
        //     Console.WriteLine("");

        // }

    }
    public void print(int[] a)
    {
        Console.WriteLine(string.Join(" ", a));
    }
}