using System;

namespace _1._Reverse_Strings_Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "end")
            {
                char[] result = command.ToCharArray();
                Array.Reverse(result);
                string reversed = new string(result);
                Console.WriteLine($"{command} = {reversed}");
                command = Console.ReadLine();
            }
        }
    }
}
