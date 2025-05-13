using CityInfo.API.Entities;

namespace CityInfo.API.Services
{
    public interface ICityInfoRepository
    {
        Task<IEnumerable<City>> GetCitiesAsyn();
        Task<City?> GetCityAsync(int cityId, bool includePointsOfInterest);
        Task<IEnumerable<PointOfInterest>> GetPointsOfInterestForCityAsyn(int cityId);
        Task<PointOfInterest> GetPointOfInterestForCityAsync(int cityId, int pointOfInterestId);
        //public interface ICityInfoRepository
        //{
        //  Task<IEnumerable<City>> GetCitiesAsyn();
        //  Task<City?> GetCityAsync(int cityId, bool includePointsOfInterest);
        //  Task<IEnumerable<PointOfInterest>> GetPointsOfInterestForCityAsyn(int cityId);
        //  Task<PointOfInterest?> GetPointOfInterestForCityAsyn(int cityId, 
        //      int pointOfInterestId);
    }
}
