using EVS.Core.Models;
using System.Net.Http.Json;

namespace EVS.Front.Services
{
	public class RideService : IRideService
	{
		private readonly HttpClient _httpClient;
		private readonly string _baseApiRoute;

		public RideService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<Ride?> Create(Ride ride)
		{
			var response = await _httpClient.PostAsJsonAsync("/create", ride);
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<Ride>();
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

		public async Task<List<Ride>> GetAll()
		{
			var response = await _httpClient.GetFromJsonAsync<List<Ride>>("/rides");
			return response ?? new List<Ride>();
		}


		public async Task<List<Ride>> GetAll(string startCity, DateTime departure)
		{
			var response = await _httpClient.GetFromJsonAsync<List<Ride>>(
				$"{_baseApiRoute}?startCity={startCity}&departure={departure.ToString("yyyy-MM-dd")}");
			return response ?? new List<Ride>();
		}

		public async Task<List<Ride>> GetAll(string startCity, string endCity, DateTime departure)
		{
			var response = await _httpClient.GetFromJsonAsync<List<Ride>>(
				$"{_baseApiRoute}?startCity={startCity}&endCity={endCity}&departure={departure.ToString("yyyy-MM-dd")}");
			return response ?? new List<Ride>();
		}

		public async Task<List<Ride>> GetAll(Guid userId)
		{
			var response = await _httpClient.GetFromJsonAsync<List<Ride>>(
				$"{_baseApiRoute}?userId={userId}");
			return response ?? new List<Ride>();
		}

		public async Task<Ride?> GetById(Guid id)
		{
			var response = await _httpClient.GetFromJsonAsync<Ride>($"{_baseApiRoute}/{id}");
			return response;
		}
	}
}
