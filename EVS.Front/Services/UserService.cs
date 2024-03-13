using EVS.Core.Models;
using System.Net.Http.Json;

namespace EVS.Front.Services
{
	public class UserService : IUserService
	{
		private readonly HttpClient _httpClient;
		private readonly string _baseApiRoute;

		public UserService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		
		}

		public async Task<List<User>> GetAll()
		{
			var response = await _httpClient.GetFromJsonAsync<List<User>>(_baseApiRoute);
			return response ?? new List<User>();
		}

		public async Task<User?> GetById(Guid id)
		{
			var response = await _httpClient.GetFromJsonAsync<User>($"{_baseApiRoute}/{id}");
			return response;
		}

		public async Task<User?> Get()
		{
			var response = await _httpClient.GetFromJsonAsync<User>(_baseApiRoute);
			return response;
		}

		public async Task<User?> Create(User user)
		{
			var response = await _httpClient.PostAsJsonAsync("/register", user);
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<User>();
			}
			else
			{
				return null;
			}
		}



		public async Task<User?> Login(string email, string password)
		{
			var response = await _httpClient.PostAsJsonAsync($"{_baseApiRoute}/login", new { Email = email, Password = password });
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<User>();
			}
			else
			{
				return null;
			}
		}

		public async Task<User?> Update(Guid id, User user) //DTO
		{
			var response = await _httpClient.PutAsJsonAsync($"{_baseApiRoute}/{id}", user);
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<User>();
			}
			else
			{
				return null;
			}
		}

		public async Task<bool> Delete(Guid id)
		{
			var response = await _httpClient.DeleteAsync($"{_baseApiRoute}/{id}");
			return response.IsSuccessStatusCode;
		}
	}
}
