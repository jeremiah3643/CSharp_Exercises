using System;
using System.Collections.Generic;
using System.Linq;

namespace linq {
    public class Customer {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    };
    public class Bank {
        public string Symbol { get; set; }
        public string Name { get; set; }
    };
    class Program {

        static void Main (string[] args) {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string> () { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
            where fruit.StartsWith ("L")
            select fruit;

            foreach (string fruit in LFruits) {
                Console.WriteLine ($"Fruits that start with L: {fruit}");
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where (number => number % 4 == 0 || number % 6 == 0);

            foreach (int number in fourSixMultiples) { Console.WriteLine ($"{number} is divisible by 4 or 6"); };

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string> () {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };
            var descend = from name in names
            orderby name descending
            select name;

            foreach (string name in descend) {
                Console.WriteLine (name);
            }
            // Build a collection of these numbers sorted in ascending order
            List<int> numbers1 = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };
            var ascending =
                from number in numbers1
            orderby number
            select number;
            foreach (int number in ascending) {
                Console.WriteLine (number);
            }

            // Output how many numbers are in this list
            List<int> numbers2 = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };
            Console.WriteLine (
                numbers2.Count ()
            );
            // How much money have we made?
            List<double> purchases = new List<double> () {
                2340.29,
                745.31,
                21.76,
                34.03,
                4786.45,
                879.45,
                9442.85,
                2454.63,
                45.65
            };
            Console.WriteLine ($"We made a total of {purchases.Sum ().ToString("C")}");

            // What is our most expensive product?
            List<double> prices = new List<double> () {
                879.45,
                9442.85,
                2454.63,
                45.65,
                2340.29,
                34.03,
                4786.45,
                745.31,
                21.76
            };

            Console.WriteLine (
                $"Most expensive item was {prices.Max ().ToString("C")}"
            );
            /*
                Store each number in the following List until a perfect square
                is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int> () {
                66,
                12,
                8,
                27,
                82,
                34,
                7,
                50,
                19,
                46,
                81,
                23,
                30,
                4,
                68,
                14
            };
            IEnumerable<int> upToSquare = wheresSquaredo.TakeWhile (number => Math.Sqrt (number) % 2 != 0);
            foreach (int number in upToSquare) {
                Console.WriteLine ($"Square List: {number}");
            };

            // Build a collection of customers who are millionaires

            List<Customer> customers = new List<Customer> () {
                new Customer () { Name = "Bob Lesman", Balance = 80345.66, Bank = "FTB" },
                new Customer () { Name = "Joe Landy", Balance = 9284756.21, Bank = "WF" },
                new Customer () { Name = "Meg Ford", Balance = 487233.01, Bank = "BOA" },
                new Customer () { Name = "Peg Vale", Balance = 7001449.92, Bank = "BOA" },
                new Customer () { Name = "Mike Johnson", Balance = 790872.12, Bank = "WF" },
                new Customer () { Name = "Les Paul", Balance = 8374892.54, Bank = "WF" },
                new Customer () { Name = "Sid Crosby", Balance = 957436.39, Bank = "FTB" },
                new Customer () { Name = "Sarah Ng", Balance = 56562389.85, Bank = "FTB" },
                new Customer () { Name = "Tina Fey", Balance = 1000000.00, Bank = "CITI" },
                new Customer () { Name = "Sid Brown", Balance = 49582.68, Bank = "CITI" }
            };
            var results = from customer in customers
            where customer.Balance >= 1000000
            group customer.Balance by customer.Bank into g
            select new { Bank = g.Key, Balance = g.ToList () };

            foreach (var result in results) {

                Console.WriteLine ($"{result.Bank}, {result.Balance.Count()}");

            }
            /*
    Given the same customer set, display how many millionaires per bank.
    Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

    Example Output:
    WF 2
    BOA 1
    FTB 1
    CITI 1
*/
        }

        public static void Bank () {
            // Create some banks and store in a List
            List<Bank> banks = new List<Bank> () {
                new Bank () { Name = "First Tennessee", Symbol = "FTB" },
                new Bank () { Name = "Wells Fargo", Symbol = "WF" },
                new Bank () { Name = "Bank of America", Symbol = "BOA" },
                new Bank () { Name = "Citibank", Symbol = "CITI" },
            };
        }
        public class ReportItem {
            public string CustomerName { get; set; }
            public string BankName { get; set; }
        }
     
  
      


    }
}