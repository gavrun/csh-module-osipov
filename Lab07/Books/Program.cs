namespace Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // could be much easier 

            //Book[] books;
            //books = new Book[]
            //{
            //    new Book { author = "Fyodor Dostoevsky", title = "Crime and Punishment", pages = 671, year = 1866 },
            //    new Book { author = "Leo Tolstoy", title = "War and Peace", pages = 1225, year = 1869 },
            //    new Book { author = "Alexander Pushkin", title = "Eugene Onegin", pages = 320, year = 1833 },
            //    new Book { author = "Anton Chekhov", title = "The Cherry Orchard", pages = 104, year = 1903 },
            //    new Book { author = "Nikolai Gogol", title = "Dead Souls", pages = 384, year = 1842 }
            //};

            //declare and pop 5 books by method
            Book[] books = new Book[]
            {
                new Book(),
                new Book(),
                new Book(),
                new Book(),
                new Book()
            };
            books[0].SetBook("Fyodor Dostoevsky", "Crime and Punishment", 671, 1866);
            books[1].SetBook("Leo Tolstoy", "War and Peace", 1225, 1869);
            books[2].SetBook("Alexander Pushkin", "Eugene Onegin", 320, 1833);
            books[3].SetBook("Anton Chekhov", "The Cherry Orchard", 104, 1903);
            books[4].SetBook("Nikolai Gogol", "Dead Souls", 384, 1842);

            // list books on the shelf
            foreach (var item in books)
            {
                item.Show();
            }

            // sort books
            Array.Sort(books);
            Console.WriteLine();

            // list ordered books
            foreach (var item in books)
            {
                item.Show();
            }
        }
    }
}
