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
            //Q2:
            Console.WriteLine($"Copies in stock: {book.copiesInStock}"); // => it mprints 5 bec. internal os accessable in its scope ant the same project
            Console.WriteLine();

            //----------------------

            //Q3:
            book.Title = "Clean Code";
            Console.WriteLine($" Book Title: {book.Title}");
            Console.WriteLine();

            //----------------------

            //Q4:
            book.Genre = Genre.Science;
            Console.WriteLine($" Book Genre: {book.Genre}");
            Console.WriteLine();

            //----------------------

            //Q5:
            book.Genre = Genre.Fiction;
            Console.WriteLine($"Value of Fiction: {(int)Genre.Fiction}");
            Console.WriteLine($"Value of Non-Fiction: {(int)Genre.NonFiction}");
            Console.WriteLine($"Value of Science: {(int)Genre.Science}");
            Console.WriteLine();

            //----------------------

            //Q6:
            int genreNumber = 1;
            Genre genreValue = (Genre)genreNumber;
            Console.WriteLine($"Genre Value: {genreValue}");
            Console.WriteLine();

            //----------------------

            //Q7:
            Genre genre = Genre.Fiction;
            Console.WriteLine($"Genre: {genre.ToString()}");
            Console.WriteLine();

            //----------------------
        }
    }
}
