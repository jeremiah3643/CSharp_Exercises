using System;
using System.Collections.Generic;

namespace dictionaries {
    class Program {
        static void Main (string[] args) {

            Dictionary<string, string> stocks = new Dictionary<string, string> ();
            stocks.Add ("GM", "General Motors");
            stocks.Add ("CAT", "Caterpillar");
            stocks.Add ("AMD", "Advanced Micro Devices");
            stocks.Add ("NAT", "Nordic American Tankers Limited");

            List < (string ticker, int shares, double price) > purchases = new List < (string, int, double) > ();
            purchases.Add ((ticker: "GE", shares : 150, price : 23.21));
            purchases.Add ((ticker: "GE", shares : 32, price : 17.87));
            purchases.Add ((ticker: "GE", shares : 80, price : 19.02));
            purchases.Add ((ticker: "CAT", shares : 34, price : 117.58));
            purchases.Add ((ticker: "CAT", shares : 32, price : 87.98));
            purchases.Add ((ticker: "AMD", shares : 78, price : 387.21));
            purchases.Add ((ticker: "AMD", shares : 93, price : 578.35));
            purchases.Add ((ticker: "NAT", shares : 145, price : 143.87));
            purchases.Add ((ticker: "NAT", shares : 67, price : 246.09));

            Dictionary<string, double> stockReports = new Dictionary<string, double> () { { "General Electric", 0.0 }, { "Caterpillar", 0.0 }, { "Advanced Micro Devices", 0.0 }, { "Nordic American Tankers Limited", 0.0 }
            };
            /*
                Define a new Dictionary to hold the aggregated purchase information.
                - The key should be a string that is the full company name.
                - The value will be the valuation of each stock (price*amount)

                {
                    "General Electric": 35900,
                    "AAPL": 8445,
                    ...
                }
            */

            // Iterate over the purchases and update the valuation for each stock
            foreach ((string ticker, int shares, double price) purchase in purchases) {
                // Does the company name key already exist in the report dictionary?
                foreach (KeyValuePair<string, string> stock in stocks) {
                    if (purchase.ticker == stock.Key) {
                        stockReports[stock.Value].Add (purchase.shares * purchase.price)
                    }
                }
                // If it does, update the total valuation

                // If not, add the new key and set its value
            }

        }
    }
}