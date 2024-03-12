using EVS.Core.Models;
using System.Net.Http.Json;

namespace EVS.Front.Services
{
	public class FeedbackService : IFeedbackService
	{
		private readonly HttpClient _httpClient;
		private readonly string _baseApiRoute;

		public FeedbackService(HttpClient httpClient, IConfiguration configuration)
		{
			_httpClient = httpClient;
			_baseApiRoute = configuration["http://localhost:7014/"] + "/feedback";
		}

		public async Task<List<Feedback>> GetAllByRideId(Guid rideId)
		{
			var response = await _httpClient.GetFromJsonAsync<List<Feedback>>($"{_baseApiRoute}/ride/{rideId}");
			return response ?? new List<Feedback>();
		}

		public async Task<List<Feedback>> GetAllByUserId(Guid userId)
		{
			var response = await _httpClient.GetFromJsonAsync<List<Feedback>>($"{_baseApiRoute}/user/{userId}");
			return response ?? new List<Feedback>();
		}

		public async Task<Feedback?> Create(Guid rideId, Feedback feedbackDTO)
		{
			var response = await _httpClient.PostAsJsonAsync($"{_baseApiRoute}/ride/{rideId}", feedbackDTO);
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<Feedback>();
			}
			else
			{
				return null;
			}
		}

		public async Task<Feedback?> Update(Guid id, Feedback feedbackDTO)
		{
			var response = await _httpClient.PutAsJsonAsync($"{_baseApiRoute}/{id}", feedbackDTO);
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<Feedback>();
			}
			else
			{
				return null;
			}
		}
	}
}
