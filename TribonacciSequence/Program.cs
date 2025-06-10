using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        var fibo = Fibonnacci(10);
        foreach(var n in fibo)
        {
            Console.WriteLine(n);
        }
    }

    public static int[] Fibonnacci(int n)
    {
        var result = new List<int>();
        var one = 0; 
        var two = 1;
        var temp = 0;
        for (int i = 0; i < n; i++) 
        {
            result.Add(one);
            temp = one;
            one = two; 
            two = one + temp; 
        }
        return result.ToArray();
    }
}