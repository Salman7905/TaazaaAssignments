using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MovieManagement.Models
{
    public class MovieMapper
    {
        public MovieMapper(EntityTypeBuilder<Movie> movies)
        {
            movies.HasKey(e =>e.movieID);
            movies.Property(e =>e.movieName).IsRequired().HasMaxLength(100);
            movies.Property(e =>e.moviePrice).IsRequired().HasMaxLength(3);
        }
    }
}