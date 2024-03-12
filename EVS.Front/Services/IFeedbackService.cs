
using EVS.Core.Models;


namespace EVS.Front.Services
{
	public interface IFeedbackService
	{
		public Task<List<Feedback>> GetAllByRideId(Guid rideId); //async
		public Task<List<Feedback>> GetAllByUserId(Guid userId);
		public Task<Feedback?> Create(Guid rideId, FeedbackDTO feedbackDTO);
		public Task<Feedback?> Update(Guid id, FeedbackDTO feedbackDTO);
	}
}
