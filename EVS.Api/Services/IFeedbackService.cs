using EVS.Core.Models;
using EVS.Api.DTOs;

namespace EVS.Api.Services
{
    public interface IFeedbackService
    {
        public Task<List<Feedback>> GetAllByRideId(Guid rideId);
        public Task<List<Feedback>> GetAllByUserId(Guid userId);
        public Task<Feedback?> Create(Guid rideId, FeedbackDTO feedbackDTO);
        public Task<Feedback?> Update(Guid id, FeedbackDTO feedbackDTO);
    }
}