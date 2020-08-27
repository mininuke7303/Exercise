using System.Linq;
using System;
using System.Collections.Generic;

namespace BirdWatcher {
    class Program {
        static void Main(string[] args) {

            var Sparrow = new Bird { Name = "Sparrow", Color = "Black", Sightings = 11 };
            Console.WriteLine(Sparrow.Name);



            var numbers = new List<int> { 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Count: " + numbers.Count);

            var numbers2 = numbers.Where(n => n % 2 == 0);
            foreach (var v in numbers2) {
                Console.WriteLine(v);

            }

            Console.WriteLine(numbers.First());
            Console.WriteLine(numbers.Last());
        }
    }



    class Bird {
        public string Name { get; set; }

        public string Color { get; set; }

        public int Sightings { get; set; }
    }
}
