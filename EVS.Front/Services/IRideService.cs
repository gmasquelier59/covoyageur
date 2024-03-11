using EVS.Core.Models;

namespace EVS.Front.Services
{
	public class IRideService
	{
		public Task<Ride?> Create(Ride ride);
		public Task<bool> Delete(Guid id);
		public Task<List<Ride>> GetAll();
		public Task<List<Ride>> GetAll(string startCity, DateTime departure);
		public Task<List<Ride>> GetAll(string startCity, string endCity, DateTime departure);
		public Task<List<Ride>> GetAll(Guid userId);
		public Task<Ride?> GetById(Guid id);
	}
}
