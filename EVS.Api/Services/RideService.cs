using EVS.Core.Models;
using EVS.Api.Repositories;
using EVS.Api.Services;

namespace EVS.Core.Services
{
    public class RideService : IRideService
    {
        private readonly RideRepository _rideRepository;

        public RideService(RideRepository rideRepository)
        {
            _rideRepository = rideRepository;
        }

        public async Task<List<Ride>> GetAll()
        {
            return await _rideRepository.GetAll();
        }

        public async Task<List<Ride>> GetAll(string startCity, string endCity, DateTime departure)
        {
            return await _rideRepository.GetAll(r => r.StartCity == startCity && r.EndCity == endCity && r.Departure == departure);
        }

        public async Task<List<Ride>> GetAll(string startCity, DateTime departure)
        {
            return await _rideRepository.GetAll(r => r.StartCity == startCity && r.Departure == departure);
        }

        public async Task<List<Ride>> GetAll(Guid userId)
        {
            return await _rideRepository.GetAll(r => r.UserId == userId);
        }

        public async Task<Ride?> GetById(Guid id)
        {
            return await _rideRepository.GetById(id);
        }

        public async Task<Ride?> Create(Ride ride)
        {
            return await _rideRepository.Add(ride);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _rideRepository.Delete(id);
        }
    }
}





