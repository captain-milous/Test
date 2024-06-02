namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(i + ". Hello, World!");
            }
        }
    }
}
