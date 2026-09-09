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
            Console.WriteLine("Hello, World!");
        }
    }
}
