using BlogPlatform.BlogEntities.Models;

namespace BlogPlatform.BlogEntities.Repositories;

public static class PostRepositories{
    private static List<Posts> posts { get; set; }

    static PostRepositories()
    {
        posts = new List<Posts>();
    }

    public static void AddPost(Posts post){
        if(posts.Equals(null))
            return;
        posts.Add(post);
    }
    
    public static void AddComment(int postId, Comments comment){
        if(comment.Equals(null) || postId.Equals(null))
            return;

        for (int i = 0; i < posts.Count; i++)
        {
            var element = posts[i];
            element.CommentList.Add(comment);
            return;
        }
    }

    public static List<Posts> GetAllPosts(){
        return posts;
    }

    public static List<Posts> GetAllPostsByAuthor(int userId){
        //LINQ
        return posts
        .Where(b=> b.Author.UserId.Equals(userId))
        .ToList();
    }

   public static Posts? GetOnePostByAuthor(int postId, int userId)
    {
        return posts
        .Where(post => post.PostId.Equals(postId) && post.Author.UserId.Equals(userId))
        .SingleOrDefault();
    }

}