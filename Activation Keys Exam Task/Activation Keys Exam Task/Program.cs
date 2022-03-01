using System;

namespace Activation_Keys_Exam_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string instructions = Console.ReadLine();

            while (instructions != "Generate")
            {
                string action = instructions.Split(">>>")[0];

                if (action == "Contains")
                {
                    string substring = instructions.Split(">>>")[1];
                    if (activationKey.Contains(substring)) Console.WriteLine($"{activationKey} contains {substring}");
                    else Console.WriteLine("Substring not found!");
                }

                else if (action == "Flip")
                {
                    string direction = instructions.Split(">>>")[1];
                    int startIdx = int.Parse(instructions.Split(">>>")[2]);
                    int endIdx = int.Parse(instructions.Split(">>>")[3]);
                    string element = "";
                    if (direction == "Upper")
                    {
                        element = activationKey.Substring(startIdx, endIdx - startIdx).ToUpper();
                        
                    }
                    else if (direction == "Lower")
                    {
                        element = activationKey.Substring(startIdx, endIdx - startIdx).ToLower();
                    }
                    activationKey = activationKey.Remove(startIdx, endIdx - startIdx);
                    activationKey = activationKey.Insert(startIdx, element);
                    Console.WriteLine(activationKey);
                }

                else if (action == "Slice")
                {
                    int startIdx = int.Parse(instructions.Split(">>>")[1]);
                    int endIdx = int.Parse(instructions.Split(">>>")[2]);
                    activationKey = activationKey.Remove(startIdx, endIdx - startIdx);
                    Console.WriteLine(activationKey);
                }

                instructions = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
