using System;

namespace MyNewGitProject {
    class Program {
        static void Main(string[] args) {
            string str = "Hello World!";
            foreach (char c in str) {
                Console.Write(c);
            }
            Console.WriteLine();

            Console.WriteLine("Вывод нечётных чисел");
            
            OddNumbers numbers = new OddNumbers(10);
            Console.WriteLine(numbers.ToString());

            Console.WriteLine("Вывод чётных чисел");
            
            Class1.EvenNumbers();

        }
    }
}