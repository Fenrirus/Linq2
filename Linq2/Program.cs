using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Comic> comics = Comic.BuildCatalog();
            Dictionary<int, decimal> values = Comic.GetPrices();
            int[] cos = new int[] { 0, 1, 2 };
            var mostExpensive =
                from comic in comics
                where values[comic.Issue] > 500
                orderby values[comic.Issue] descending
                select comic;
            foreach (Comic comic in mostExpensive)
                Console.WriteLine("{0} is worth {1:c}",
                comic.Name, values[comic.Issue]);


            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            int length = random.Next(50, 150);
            for (int i = 0; i < length; i++)
                listOfNumbers.Add(random.Next(100));
            Console.WriteLine("There are {0} numbers",
            listOfNumbers.Count());
            Console.WriteLine("The smallest is {0}",
            listOfNumbers.Min());
            Console.WriteLine("The biggest is {0}",
            listOfNumbers.Max());
            Console.WriteLine("The sum is {0}",
            listOfNumbers.Sum());
            Console.WriteLine("The average is {0:F2}",
            listOfNumbers.Average());

            var under50sorted =
                from number in listOfNumbers
                where number < 50
                orderby number descending
                select number;
            List<int> newList = under50sorted.ToList();
            var firstFive = under50sorted.Take(5);
            List<int> shortList = firstFive.ToList();
            foreach (int n in shortList)
                Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
