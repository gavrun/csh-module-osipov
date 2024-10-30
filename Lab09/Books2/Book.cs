using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books2
{
    internal class Book
    {
        private string author;
        private string title;
        private string publisher;
        private int pages;
        private int year;

        private static double price = 9;

        public Book() // default ctor
        { }

        static Book() // static ctor
        {
            price = 10;
        }

        public Book(string author, string title, string publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        public void Show()
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\nГод издания: { 2}\n {3}стр.\n Стоимость аренды: {4}", author, title, year, pages, Book.price);
        }

        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }

    }
}
