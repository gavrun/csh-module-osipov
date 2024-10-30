namespace Books2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука", 823, 2013);
            b2.Show();

            Book.SetPrice(12);
            b2.Show();

        }
    }
}
