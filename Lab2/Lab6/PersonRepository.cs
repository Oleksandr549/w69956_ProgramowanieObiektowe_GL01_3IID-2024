using Lab2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Lab6
public class PersonRepository : IPersonRepository
{
    private List<Person> people;

    public PersonRepository()
    {
        people = new List<Person>();
    }

    public void AddPerson(Person person)
    {
        people.Add(person);
    }

    public List<Book> GetBorrowedBooks(Person person)
    {
        // Sprawdzamy, czy osoba istnieje w repozytorium
        var foundPerson = people.FirstOrDefault(p => p.Equals(person));
        return foundPerson?.BorrowedBooks ?? new List<Book>();
    }

    public void BorrowBook(Person person, Book book)
    {
        // Sprawdzamy, czy osoba istnieje w repozytorium
        var foundPerson = people.FirstOrDefault(p => p.Equals(person));
        if (foundPerson != null)
        {
            foundPerson.BorrowedBooks.Add(book);
        }
    }
}
