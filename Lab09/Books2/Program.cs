namespace Books2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book b2 = new Book("Tolstoy L.N.", "War and Peace", "Science", 823, 2013);
            Book b2 = new Book("Tolstoy L.N.", "War and Peace", "Science and Life", 1234, 2013, 101, false);
            b2.Show();

            Book.SetPrice(12);
            b2.Show();

            b2.TakeItem();
            b2.Show();

            //Item item1 = new Item();
            //item1.Show();

            Magazine mag1 = new Magazine("Nature", 5, "Earth and Us", 2014, 1235, false);
            mag1.Show();

            mag1.IfSubs = true;
            mag1.Subs();

            Console.WriteLine("\n Polymorphism test");
            Item it;
            it = b2;
            Console.WriteLine("\n Taking book");
            it.TakeItem();
            it.Show();
            Console.WriteLine("\n Returning book");
            b2.ReturnSrok(); // book 
            it.Return(); // base
            it.Show();
            it = mag1;
            Console.WriteLine("\n Taking magazine");
            it.TakeItem();
            it.Show();
        }
    }
}
