using EVS.Core.Models;

namespace EVS.Front.Services
{
	public interface IUserService
	{
		public Task<List<User>> GetAll();
		public Task<User?> GetById(Guid id);
		public Task<User?> Get();
		public Task<User?> Create(User user);
		public Task<User?> Login(string email, string password);
		public Task<User?> Update(Guid id, User user);
		public Task<bool> Delete(Guid id);
	}
}
