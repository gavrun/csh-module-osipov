namespace Books2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b2 = new Book("Tolstoy L.N.", "War and Peace", "Science", 823, 2013);
            b2.Show();

            Book.SetPrice(12);
            b2.Show();

            Item item1 = new Item();
            item1.Show();
        }
    }
}
