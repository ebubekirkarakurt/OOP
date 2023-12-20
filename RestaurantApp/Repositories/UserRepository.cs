using RestaurantApp.Entities.Models;
using RestaurantApp.Repositories.Interfaces;
using RestaurantApp.Repositories.Services;

namespace RestaurantApp.Repositories;

public class UserRepository : IRepository<User>
{
    private List<User> users;

    public UserRepository(List<User> users)
    {
        this.users = users;
    }

    public User GetData(string email, string password)
    {
        var user = users.SingleOrDefault(user => user.Email.Equals(email));
        if (user is null)
            return null;

        if (user.Password.Equals(password.Encoder(user.Salt)))
            return user;
        return null;
    }

    public void Delete(int id)
    {
        var entity = GetOne(id);
        users.Remove(entity);
    }

    public User GetOne(int id)
    {
        return users.Where(b => b.Id.Equals(id)).SingleOrDefault();
    }

    public void Post(User item)
    {
        if (item is null)
            return;
        var pass = item.Password.Encoder(item.Salt);
        item.Password = pass;
        users.Add(item);
    }
}