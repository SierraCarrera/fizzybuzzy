using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzUI {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter a number up to 100");
            var max = Convert.ToInt32(Console.ReadLine());

            var fizzBuzz = new FizzBuzz(max);

            foreach(var item in fizzBuzz.Results) {
                Console.WriteLine(item);
            }
        }
    }
}
