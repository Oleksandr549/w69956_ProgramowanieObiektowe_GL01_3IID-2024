using Lab2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Lab6
public class BookRepository : IBookRepository
{
    private List<Book> books;

    public BookRepository()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public List<Book> GetBooksByAuthor(string author)
    {
        return books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Book> GetBooksByYear(int year)
    {
        return books.Where(b => b.Year == year).ToList();
    }
}
