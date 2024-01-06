using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class BookRepository
{
    public RepositoryContext _repo;

    public BookRepository(RepositoryContext repositoryContext)
    {
        _repo = repositoryContext;
    }

    public Books BookInfo(int id)
    {
        var book = _repo
            .Books
            .Include(a => a.Authors)
            .SingleOrDefault(a => a.Id.Equals(id));

        if (book is null)
            throw new Exception("Book not find!");

        return book;
    }

    public void AddBook(Books book)
    {
        _repo.Books.Add(book);
        _repo.SaveChanges();
    }

    public void Borrow(int id)
    {
        var book = BookInfo(id);
        if (book.Quantity <= 0)
            throw new Exception($"The {book.Title} is not in stock!");

        book.Quantity -= 1;
        _repo.SaveChanges();
    }

    public void Return(int id)
    {
        var book = BookInfo(id);

        book.Quantity += 1;
        _repo.SaveChanges();
    }
}