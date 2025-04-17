using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore() 
        {
            //init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto(){
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited park" },                            
                        new PointOfInterestDto(){
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "Located midtown Manhattan" },
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwrep",
                    Description = "The one with that big cathedral",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto(){
                            Id = 3,
                            Name = "Cathadrel of Our Lady",
                            Description = "Gothic style Cathadrel" },
                        new PointOfInterestDto(){
                            Id = 4,
                            Name = "Antwrep Central Station",
                            Description = "Center station" },
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto(){
                            Id = 5,
                            Name = "Eiffel Tower",
                            Description = "Tower in paris" },
                        new PointOfInterestDto(){
                            Id = 6,
                            Name = "The Louvre",
                            Description = "Largest museum" },
                    }
                }
            };
        }
    }
}
