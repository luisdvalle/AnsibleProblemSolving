using System;

namespace AnsibleProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string message = $"Number: {i}";
                PrintNumbers.PrintNumbers processor = new PrintNumbers.PrintNumbers();

                PrintNumbers.TypeNumber type = processor.ProcessNumber(i);

                if (type == PrintNumbers.TypeNumber.Ansible)
                {
                    message += $" | Ansible";
                }
                else if (type == PrintNumbers.TypeNumber.AnsibleAustralia)
                {
                    message += $" | Ansible Australia";
                }
                else if (type == PrintNumbers.TypeNumber.Australia)
                {
                    message += $" | Australia";
                }

                Console.WriteLine(message);
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
