using System.Globalization;

namespace MusicaApp.Models
{
    public class Song : IFormattable, IComparable // T -> Type, Generics, <Song> --> (Method2), Iformattable -- For Multi lenguages
    {
        public int Id { get; set; }
        public String? Title { get; set; }
        public Artist Artist { get; set; }
        public Albums Albums { get; set; }
        public String? Genre { get; set; }
        public float Duration { get; set; }

        public Song()
        {
            Artist = new Artist();
        
        }

        public Song(int id, string? title, Artist artist, Albums albums, string? genre, float duration)
        {
            Id = id;
            Title = title;
            Artist = artist;
            Albums = albums;
            Genre = genre;
            Duration = duration;
        }

        public int CompareTo(object? obj)
        {   
            var other = obj as Song; //Type Casting
            return this.Title.CompareTo(other.Title);
        }

        public string ToString(string? format="id", IFormatProvider? formatProvider=null)
        {
            if (String.IsNullOrEmpty(format)) format = "id";
            if (formatProvider == null) formatProvider = CultureInfo.CurrentCulture;

            switch (format.ToLowerInvariant())
            {
                case "id":
                    return $"{Id} {Title} {Duration}";
                case "title":
                     return $"{Title} {Id} {Duration}";
                case "duration":
                     return $"{Duration} {Title} {Id}";
                default:
                    throw new FormatException(String.Format("The {0} format string is not supported.", format));
            }
        }

       /* public int CompareTo(Song? other) --> For Method 2
        {
            return this.Title.CompareTo(other.Title);
        }*/
    }
}