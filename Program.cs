namespace discreteprefect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Starting Number: ");
            int startNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Ending Number: ");
            int endNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Below are the perfect number between " + startNumber + " and " + endNumber);

            for (int i = startNumber; i <= endNumber; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum = sum + j;
                }
                if (sum == i)
                    Console.WriteLine(i);
            }
        }
    }
}