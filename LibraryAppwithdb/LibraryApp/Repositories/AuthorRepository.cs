using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class AuthorRepository
{
    public RepositoryContext _repo;

    public AuthorRepository(RepositoryContext repositoryContext)
    {
        _repo = repositoryContext;
    }

    public Authors AuthorInfo(int id)
    {
        var author = _repo
            .Authors
            .Include(a => a.Books)
            .SingleOrDefault(a => a.Id.Equals(id));

        if (author is null)
            throw new Exception("Author not find!");

        return author;
    }

    public void AddAuthor(Authors author)
    {
        _repo.Authors.Add(author);
        _repo.SaveChanges();
    }
}