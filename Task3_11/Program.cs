namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры участка (a b):");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите размеры первого дома (p q):");
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите размеры второго дома (r s):");
            int r = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());

            bool canFit = false;

            if ((p + r <= a && Math.Max(q, s) <= b) ||
                (p + r <= b && Math.Max(q, s) <= a))
            {
                canFit = true;
            }
            else if ((q + s <= a && Math.Max(p, r) <= b) ||
                     (q + s <= b && Math.Max(p, r) <= a))
            {
                canFit = true;
            }
            else if ((p + s <= a && Math.Max(q, r) <= b) ||
                     (p + s <= b && Math.Max(q, r) <= a))
            {
                canFit = true;
            }

            else if ((q + r <= a && Math.Max(p, s) <= b) ||
                     (q + r <= b && Math.Max(p, s) <= a))
            {
                canFit = true;
            }

            if (canFit)
            {
                Console.WriteLine("Да, дома можно разместить на участке.");
            }
            else
            {
                Console.WriteLine("Нет, дома нельзя разместить на участке.");
            }
        }
    }
}
