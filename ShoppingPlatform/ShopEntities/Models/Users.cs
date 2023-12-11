namespace ShoppingPlatform.ShopEntities.Models;


public class Users{
    public int Id { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get => FirstName + " " + LastName; }
    public DateTime CreatedDate { get; set; }
}