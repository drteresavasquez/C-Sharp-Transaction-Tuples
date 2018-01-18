using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            //In Main method, create a list of value tuples that will hold individual transactions for a hardware business. Each tuple will store the product, the total amount of the transaction, and the quantity of the product.
            List<Tuple<string, double, int>> transactions = new List<Tuple<string, double, int>>();

            //Add 5, or more, transactions to the list.
            transactions.Add(new Tuple<string, double, int>("Cabbage", 23.45, 50));
            transactions.Add(new Tuple<string, double, int>("Brocolli", 13.45, 20));
            transactions.Add(new Tuple<string, double, int>("Beets", 3.45, 10));
            transactions.Add(new Tuple<string, double, int>("Carrots", 43.45, 30));
            transactions.Add(new Tuple<string, double, int>("Onions", 63.45, 40));

            //Iterate over the list of tuples and calculate how many total products you sold today, and what your total revenue was.
            var totalSold = 0;
            var totalRevenue = 0.00;
            foreach(var t in transactions)
            {
                // Logic goes here to look up quantity and amount in each transaction
                totalSold += t.Item3;
                totalRevenue += t.Item2;
            }
            Console.WriteLine(value: $"Total Sold: {totalSold}\nTotal revenue: ${totalRevenue}");
        }
    }
}
