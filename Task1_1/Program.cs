namespace Task2_1
{
    internal class Program
    {
        /* Вводятся три числа. Обменять их местами циклически. 
         * Например, вводятся a=1, b=2, c=3. 
         * После обмена в переменных должны оказаться значения a=3, b=1, c=2.
         */
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()); // 1
            int b = Convert.ToInt32(Console.ReadLine()); // 2 
            int c = Convert.ToInt32(Console.ReadLine()); // 3
            int t = a; // a (свободно) убрали в t
            a = c; // c (свободно) убрали в a 
            c = b; // b (свободно) убрали в с
            b = t; // t (свободно) убрали в b

            Console.WriteLine("a={0}, b={1}, c={2}", a, b, c); // 3 1 2
            Console.ReadKey();
        }
    }
}
