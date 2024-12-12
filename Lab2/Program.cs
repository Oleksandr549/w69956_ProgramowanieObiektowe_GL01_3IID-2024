// See https://aka.ms/new-console-template for more information
/*
using Lab2.Models;

Console.WriteLine("Hello, World!");


Person os = new Person();

os.Welcome();
os.Welcome("DD");

var n = new User { UserName = "Test" };
n.UserName = "Test2";


var os2 = Person.MapUser(n);


Console.WriteLine(os2.Name);

var sum = new Sumartor(new[] { 10, 20, 30, 40 });

Console.WriteLine(sum.Count());
Console.WriteLine(sum.SumDiv3());
Console.WriteLine(sum.Sum());
sum.Display(1, 2);

*/


/*
Shape rec = new Rectangle();
var rec2 = new Rectangle();


var shapes = new List<Shape>()
{
    rec,
    rec2,
    new Shape()
};
*//*shapes.Add(rec);
shapes.Add(rec2);
shapes.Add(new Shape());*//*

foreach (var shape in shapes)
{
    shape.Draw();
}
*/

/*
using Lab2.Models;

var person = new Person();

person.SetName("name");
person.SetSurname("name");
person.SetPesel("02261072763");

Console.WriteLine(person.GetGender());
Console.WriteLine(person.GetAge());*/





//Shape shape = new Shape();
//Shape shape = new Square() {X = 5 };

//Console.WriteLine(shape.CalulateArea());


//IVehicle car = new Car();

//try
//{

//    car.Start();

//    car.Stop();
//}
//catch(NotImplementedException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//var book = new Book();

//Helper.SetCreationUser(book);

// Ten kod zrobilem przez chat GPT!
using Lab2;
using Lab2.Lab5;
using Lab2.Lab6;

class Program
{
    static void Main(string[] args)
    {
        // Tworzenie książek
        Book book1 = new Book("C# for Beginners", "John Doe", 2020);
        Book book2 = new Book("Advanced C#", "Jane Doe", 2021);

        // Tworzenie osób
        Person person1 = new Person("Alice", "Smith");
        Person person2 = new Person("Bob", "Johnson");

        // Tworzenie repozytoriów
        IPersonRepository personRepo = new PersonRepository();
        IBookRepository bookRepo = new BookRepository();

        // Dodawanie książek do repozytorium
        bookRepo.AddBook(book1);
        bookRepo.AddBook(book2);

        // Dodawanie osób do repozytorium
        personRepo.AddPerson(person1);
        personRepo.AddPerson(person2);

        // Wypożyczanie książek przez osoby
        personRepo.BorrowBook(person1, book1);
        personRepo.BorrowBook(person2, book2);

        // Zwracanie listy wypożyczonych książek przez osobę
        List<Book> borrowedBooks = personRepo.GetBorrowedBooks(person1);
        Console.WriteLine($"{person1.Name} borrowed:");
        foreach (var book in borrowedBooks)
        {
            Console.WriteLine(book.Title);
        }

        // Zwracanie książek autora
        List<Book> booksByAuthor = bookRepo.GetBooksByAuthor("John Doe");
        Console.WriteLine("Books by John Doe:");
        foreach (var book in booksByAuthor)
        {
            Console.WriteLine(book.Title);
        }

        // Zwracanie książek wydanych w roku 2021
        List<Book> booksByYear = bookRepo.GetBooksByYear(2021);
        Console.WriteLine("Books published in 2021:");
        foreach (var book in booksByYear)
        {
            Console.WriteLine(book.Title);
        }
    }
}
