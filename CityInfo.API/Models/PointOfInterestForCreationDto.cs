namespace CityInfo.API.Models
{
    public class PointOfInterestForCreationDto
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Id { get; internal set; }
    }
}
