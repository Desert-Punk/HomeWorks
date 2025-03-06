namespace Task3_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            int max = a;

            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;

            Console.WriteLine(max);
        }
    }
}
