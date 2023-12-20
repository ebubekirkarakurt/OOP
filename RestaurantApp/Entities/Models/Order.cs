namespace RestaurantApp.Entities.Models;

public class Order{
    public int Id { get; set; }
    public int UserId { get; set; }
    public List<Items> OrderList { get; set; }
    public DateTime OrderDate => DateTime.Now;
}