using System;

namespace PrintNumbers
{
    public static class PrintNumbers
    {
        public static void DoYourThing()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"Number: {i} - Ansible Australia");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"Number: {i} - Ansible");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"Number: {i} - Australia");
                }
            }

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}
