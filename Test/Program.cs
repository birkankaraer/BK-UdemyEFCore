namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 15;
            for (int i = 0; i < 100; i++)
            {
                b = i;
                if (i % 2 == 0)
                {
                    Console.WriteLine(i * i);
                }
            }
        }
    }
}
