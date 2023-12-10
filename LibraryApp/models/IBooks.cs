namespace Week_8.models;


public interface IBooks : IComparable<LibraryItem>{
    public int Id { get; set; }
    public string Title { get; set; }
    public Author Authors { get; set; }
    public DateTime PublishYear { get; set; }
    public bool isAvailable { get; set; }

    public void SetAvailability(bool available);
}