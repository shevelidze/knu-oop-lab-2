using System;
using System.Linq;

namespace KnuOopLab2
{
    class Prompt
    {
        public static string ReadString(
            string prompt, 
            System.Collections.Generic.IEnumerable<string> variants,
            string failMessage
            )
        {
            string result = null;

            while (result == null)
            {
                Console.Write(String.Format("{0} ({1}): ", prompt, String.Join('|', variants)));

                var possibleResult = Console.ReadLine();

                if (variants.Contains(possibleResult))
                {
                    result = possibleResult;
                } else
                {
                    Console.WriteLine(failMessage);
                }
            }

            return result;
        }
    }
}
