using System;

namespace BookShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string author = Console.ReadLine();
            string title = Console.ReadLine();
            decimal price = decimal.Parse(Console.ReadLine());

            try
            {
                Book book = new Book(title, author, price);
                Console.WriteLine(book.ToString() + Environment.NewLine);

                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(title, author, price);
                Console.WriteLine(goldenEditionBook.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }
    }
}
