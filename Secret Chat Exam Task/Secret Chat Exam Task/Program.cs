using System;

namespace Secret_Chat_Exam_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string action = command.Split(":|:")[0];
                if (action == "InsertSpace")
                {
                    int index = int.Parse(command.Split(":|:")[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (action == "Reverse")
                {
                    string substring = command.Split(":|:")[1];
                    if (message.Contains(substring))
                    {
                        char[] reversed = substring.ToCharArray();
                        Array.Reverse(reversed);
                        int idxToRemove = message.IndexOf(substring);
                        int lengthToRemove = substring.Length;
                        message = message.Remove(idxToRemove, lengthToRemove);
                        message += new string(reversed);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (action == "ChangeAll")
                {
                    string substring = command.Split(":|:")[1];
                    string replacement = command.Split(":|:")[2];
                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }
                
                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
