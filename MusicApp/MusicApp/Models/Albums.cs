namespace MusicaApp.Models
{   
    public class Albums{
        public int Id { get; set; }
        public String? Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        public String? Genre { get; set; }

        public Albums()
        {
            
        }

        public Albums(int id, string? title, DateTime releaseYear, string? genre)
        {
            Id = id;
            Title = title;
            ReleaseYear = releaseYear;
            Genre = genre;
        }
    }
}