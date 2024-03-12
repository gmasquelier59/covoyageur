
using EVS.Core.Models;


namespace EVS.Front.Services
{
	public interface IFeedbackService
	{
		public Task<List<Feedback>> GetAllByRideId(Guid rideId); //async
		public Task<List<Feedback>> GetAllByUserId(Guid userId);
		public Task<Feedback?> Create(Guid rideId, Feedback feedbackDTO); //DTO ?!
        public Task<Feedback?> Update(Guid id, Feedback feedbackDTO);
	}
}
