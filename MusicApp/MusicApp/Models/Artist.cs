namespace MusicaApp.Models
{
    public class Artist{
        public int Id { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public String? Genre { get; set; }

        public Artist()
        {   
            
        }

        public Artist(int id, string? firstName, string? lastName, string? genre)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Genre = genre;
        }
    }
}