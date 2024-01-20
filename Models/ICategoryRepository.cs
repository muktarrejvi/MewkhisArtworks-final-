namespace MewkhisArtwork.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
        
    }
}
