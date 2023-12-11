using Microsoft.AspNetCore.Mvc;
using ShoppingPlatform.ShopEntities.Models;
using ShoppingPlatform.ShopRepositories.Repositories;

namespace ShoppingPlatform.ShopApi.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase{

    private UsersRepository repo;

    public UsersController(UsersRepository repository)
    {
        this.repo = repository;
    }

    [HttpGet]
    public List<Users> GetAll(){
        return repo.GetAll();
    }

    [HttpGet("{id:int}")]
    public Users GetOne(int id){
        return repo.GetOne(id);
    }

    [HttpPost]
    public void Post(Users item)
    {
        repo.Post(item);
    }

    [HttpPut("{id:int}")]
    public void Update(int id, Users item)
    {
        repo.Update(id, item);
    }

    [HttpDelete]
    public void Delete()
    {
        repo.Delete();
    }

    [HttpDelete("{id:int}")]
    public void DeleteOne(int id)
    {
        repo.DeleteOne(id);
    }

}