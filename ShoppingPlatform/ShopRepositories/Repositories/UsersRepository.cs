
using ShoppingPlatform.ShopEntities.Models;

namespace ShoppingPlatform.ShopRepositories.Repositories;

public class UsersRepository : IRepository<Users>
{   
    private List<Users> users;

    public UsersRepository(List<Users> users)
    {
        this.users = users;
    }
    public List<Users> GetAll()
    {
        return users;
    }

    public Users GetOne(int id)
    {
        return users
            .Where(b => b.Id.Equals(id))
            .SingleOrDefault();
    }

    public void Post(Users item)
    {
        if(item == null)
            return;
        users.Add(item);
    }

    public void Update(int id, Users item)
    {
        if (item == null || id == null)
            return;

        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].Id.Equals(id))
            {
                users[i] = item;
                return;
            }
        }
    }

    public void Delete()
    {
        users.Clear();    
    }

    public void DeleteOne(int id)
    {
        var entitiy = GetOne(id);
        if(entitiy == null)
            return;
        users.Remove(entitiy);
    }   

}