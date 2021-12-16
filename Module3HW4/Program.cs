using System;
using System.Collections.Generic;
using System.Linq;
using Module3HW4.Helpers;
using Module3HW4.Models;

namespace Module3HW4
{
    public class Program
    {
        private static double _sumTotal = 0;
        public event Action<Func<int, int, int>, int, int> EventSum;

        public static void Main()
        {
            var contacns = new List<Person>();
            HelperPerson.FillListPersons(contacns);
            var result0 = contacns.OrderByDescending(o => o.FirstName).ThenBy(t => t.LastName);
            foreach (var item in result0)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }

            var result = contacns.FirstOrDefault();
            var result2 = contacns.Where(w => w.FirstName.StartsWith('D')).Select(s => s.FirstName);

            Console.WriteLine();
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            var program = new Program();

            program.EventSum += program.TryCatch;
            program.EventSum += program.TryCatch;

            program.EventSum?.Invoke(program.Sum, 2, 3);

            Console.WriteLine($"Sum={_sumTotal}");
        }

        public int Sum(int x, int y)
        {
            int result = x + y;
            _sumTotal += result;
            return result;
        }

        public void TryCatch(Func<int, int, int> func, int x, int y)
        {
            try
            {
                func?.Invoke(x, y);
            }
            catch (Exception)
            {
            }
        }
    }
}
