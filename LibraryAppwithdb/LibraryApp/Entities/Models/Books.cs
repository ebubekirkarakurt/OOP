using System.Security.Cryptography.X509Certificates;

namespace Entities.Models;

public class Books
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public DateTime PublishYear { get; set; }
    public int Quantity { get; set; }
    public ICollection<Authors> Authors { get; set; }
}