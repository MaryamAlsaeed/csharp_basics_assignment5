namespace csharp_basics_assignment5
{
    class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string Title;
        public Genre Genre { get; set; }
    }
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1:
            Book book = new Book();
            //Console.WriteLine(book.password); => error bec password it is private and accessable in its scope only

            //----------------------
        }
    }
}
