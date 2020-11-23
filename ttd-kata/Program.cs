
using System;
using System.Collections.Generic;
using System.Linq;

namespace ttd_kata
{
    public class Program
    {

        public double GetPrice(List<int> books)
        {
            List<double> discounts = new List<double> { 0.95, 0.90, 0.80, 0.75 };
            int booksDistinctCount = books.Distinct().Count();
            if (booksDistinctCount > 1)
            {
                int sum = 8 * booksDistinctCount;
                int similarBooksCount = books.Count - booksDistinctCount;
                return sum * discounts[booksDistinctCount - 2] + 8 * similarBooksCount;
            }
            return 8 * books.Count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
