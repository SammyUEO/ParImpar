namespace ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = Convert.ToInt32 (Console.ReadLine());
            if (x%2 == 0)
            {
                Console.WriteLine("par");

            }
            else
            {
                Console.WriteLine("impar");
            }
        }
    }
}