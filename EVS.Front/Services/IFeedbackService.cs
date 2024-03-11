using EVS.Core.Models;
using EVS.Api.Repositories;

namespace EVS.Front.Services
{
	public class IFeedbackService
	{
		public  Task<List<Feedback>> GetAllByRideId(Guid rideId); //async
		public Task<List<Feedback>> GetAllByUserId(Guid userId);
		public Task<Feedback?> Create(Guid rideId, FeedbackDTO feedbackDTO);
		public Task<Feedback?> Update(Guid id, FeedbackDTO feedbackDTO);
	}
}
