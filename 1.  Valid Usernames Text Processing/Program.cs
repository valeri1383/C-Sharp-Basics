using System;
using System.Linq;

namespace _1.__Valid_Usernames_Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(", ");
            

            for (int i = 0; i < text.Length; i++)
            {
                string currentUser = text[i];
                if (currentUser.Length > 3 && currentUser.Length <= 16)
                {
                    bool valid = true;
                    foreach (var x in currentUser)
                    {
                        if (!(char.IsLetterOrDigit(x) || x == '-' || x == '_'))
                        {
                            valid = false;
                            break;
                        }
                    }
                    if (valid)
                    {
                        Console.WriteLine(currentUser);
                    }
                }
            }
        }
    }
}
