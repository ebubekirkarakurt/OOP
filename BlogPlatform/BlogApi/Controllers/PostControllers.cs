using BlogPlatform.BlogEntities.Models;
using BlogPlatform.BlogEntities.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlogPlatform.BlogApi.Controllers;


[ApiController]
[Route("api/posts")]
public class PostsController : ControllerBase
{
    [HttpPost]
    public void AddPost(Posts post)
    {
        PostRepositories.AddPost(post);
    }

    [HttpPost("{id:int}")]
    public void AddComment([FromRoute] int id, [FromBody] Comments comment)
    {
        PostRepositories.AddComment(id, comment);
    }

    [HttpGet]
    public List<Posts> GetAllPosts()
    {
        return PostRepositories.GetAllPosts();
    }

    [HttpGet("{id:int}")]
    public List<Posts> GetAllPostsByAuthor([FromRoute] int id)
    {
        return PostRepositories.GetAllPostsByAuthor(id);
    }

    [HttpGet("{postId:int}, {userId:int}")]
    public Posts? GetOnePostByAuthor([FromRoute] int postId, [FromRoute] int userId)
    {
        return PostRepositories.GetOnePostByAuthor(postId, userId);
    }
}