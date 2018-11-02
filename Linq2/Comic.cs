using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class Comic
    {
        public string Name { get; set; }
        public int Issue { get; set; }
        public int Issue2 { get; set; }

        public static IEnumerable<Comic> BuildCatalog()
        {
            return new List<Comic> {
                new Comic { Name = "Johnny America vs. the Pinko", Issue = 6, Issue2 = 6 },
                new Comic { Name = "Rock and Roll (limited edition)", Issue = 19, Issue2 = 6  },
                new Comic { Name = "Woman’s Work", Issue = 36, Issue2 = 19  },
                new Comic { Name = "Hippie Madness (misprinted)", Issue = 57, Issue2 = 6 },
                new Comic { Name = "Revenge of the New Wave Freak (damaged)", Issue = 68, Issue2 = 6  },
                new Comic { Name = "Black Monday", Issue = 74, Issue2 = 6  },
                new Comic { Name = "Tribal Tattoo Madness", Issue = 83, Issue2 = 6  },
                new Comic { Name = "The Death of an Object", Issue = 97, Issue2 = 6  },
            };
        }

        public static Dictionary<int, decimal> GetPrices()
        {
            return new Dictionary<int, decimal> {
                { 57, 13525M },
                { 6, 3600M },
                { 19, 500M },
                { 36, 650M },
                { 68, 250M },
                { 74, 75M },
                { 83, 25.75M },
                { 97, 35.25M },
            };
        }
    }
}
