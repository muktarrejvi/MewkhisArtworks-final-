namespace MewkhisArtwork.Models
{
    public interface IArtRepository
    {
        IEnumerable<Art> ALLArts { get; }
        IEnumerable<Art> ArtOfTheWeek {  get; }
        Art? GetArtByID(int artId);
    }
}
