
Bookstore bookstore = new Bookstore();
bookstore.AddBook("ChatGpt", "prograning company", 100);
bookstore.AddBook("C#", "prograning company", 122);
bookstore.AddBook("Java", "prograning company", 150);


public class Book
{
    public string Title { get; private set ; }
    public string Author { get;private set; }
    public decimal Price { get;private set; }

    public Book(string title, string author, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

}

public class Bookstore
{
    private List<Book> books;

    public Bookstore()
    {
        books = new List<Book>();
    }
    public void AddBook (string title,string author, decimal price)
    {
        Book book = new Book(title, author, price);
        books.Add(book);

    }

    public List<Book> GetBooks ()
    {
        return books;
    }


}
