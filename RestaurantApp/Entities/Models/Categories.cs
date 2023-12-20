namespace RestaurantApp.Entities.Models;

public class Categories{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Items> Items { get; set; }

    public Categories()
    {
        Items = new List<Items>();
    }
}