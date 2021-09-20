using FluentValidation;
namespace MovieManagement.Models
{
    public class MovieValidator:AbstractValidator<Movie>
    {
        public MovieValidator()
        {
             RuleFor(e =>e.movieID).NotNull();
             RuleFor(e =>e.movieName).NotNull();
             RuleFor(e =>e.moviePrice).GreaterThan(299);    
        }
    }
}