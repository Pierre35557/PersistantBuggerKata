using System;
using System.Linq;

namespace PersistentBuggerKata
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = 39;

            var numbers = num.ToString().ToList().ConvertAll(x => x.ToString());
            var canMultiply = numbers.Count > 1;
            var value = 0;

            while(canMultiply)
            {
                if (numbers.Count == 1)
                    break;

                var total = Convert.ToInt32(numbers[0]);

                for (int i = 1; i < numbers.Count; i++)
                {
                    total *= Convert.ToInt32(numbers[i]);
                }

                value++;
                numbers = total.ToString().ToList().ConvertAll(x => x.ToString());
            }
        }
    }
}
