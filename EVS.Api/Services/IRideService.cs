using EVS.Core.Models;

namespace EVS.Api.Services
{
    public interface IRideService
    {
        Task<Ride?> Create(Ride ride);
        Task<bool> Delete(Guid id);
        Task<List<Ride>> GetAll();
        Task<List<Ride>> GetAll(string startCity, DateTime departure);
        Task<List<Ride>> GetAll(string startCity, string endCity, DateTime departure);
        Task<List<Ride>> GetAll(Guid userId);
        Task<Ride?> GetById(Guid id);
    }
}