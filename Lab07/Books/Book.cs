using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class Book : IComparable
    {
        // book fields
        private string author;
        private string title;
        private int pages;
        private int year;

        // constructor could be helping a lot

        // set fields
        public void SetBook(string author, string title, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
            this.year = year;
        }

        public void Show()
        {
            Console.WriteLine("Book: Author: {0}, Title: {1}, Year: {2}, Pages: {3}", author, title, year, pages);
        }

        public int CompareTo(object obj)
        {
            //Book it = (Book)obj;
            Book currentBook = obj as Book;

            // null check 
            if (currentBook == null)
                throw new ArgumentException();

            if (this.year == currentBook.year)
            {
                return 0;
            } 
            else if (this.year > currentBook.year)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
