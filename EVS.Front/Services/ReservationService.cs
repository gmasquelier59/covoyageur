using EVS.Core.Enums;
using EVS.Core.Models;
using System.Net.Http.Json;

namespace EVS.Front.Services
{
	public class ReservationService : IReservationService
	{
		private readonly HttpClient _httpClient;
		private readonly string _baseApiRoute;

		public ReservationService(HttpClient httpClient, IConfiguration configuration)
		{
			_httpClient = httpClient;
			_baseApiRoute = configuration["http://localhost:7014/"] + "/reservation";
		}

		public async Task<List<Reservation>> GetAllByRideId(Guid rideId)
		{
			var response = await _httpClient.GetFromJsonAsync<List<Reservation>>($"{_baseApiRoute}/ride/{rideId}");
			return response ?? new List<Reservation>();
		}

		public async Task<Reservation?> Create(Guid rideId, Guid userId)
		{
			var response = await _httpClient.PostAsJsonAsync($"{_baseApiRoute}", new { RideId = rideId, UserId = userId });
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<Reservation>();
			}
			else
			{
				return null;
			}
		}

		public async Task<Reservation?> UpdateStatus(Guid id, ReservationStatus newStatus)
		{
			var response = await _httpClient.PutAsJsonAsync($"{_baseApiRoute}/{id}/status/{newStatus}", null);
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<Reservation>();
			}
			else
			{
				return null;
			}
		}
	}
}
