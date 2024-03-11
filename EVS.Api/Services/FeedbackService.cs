using EVS.Api.Repositories;
using EVS.Core.Models;
using EVS.Api.DTOs;


namespace EVS.Api.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IRepository<Feedback> _feedbackRepository;
        private readonly IRepository<Ride> _rideRepository;
        private readonly IRepository<User> _userRepository;

        public FeedbackService(IRepository<Feedback> feedbackRepository, IRepository<Ride> rideRepository, IRepository<User> userRepository)
        {
            _feedbackRepository = feedbackRepository;
            _rideRepository = rideRepository;
            _userRepository = userRepository;
        }

        public async Task<List<Feedback>> GetAllByRideId(Guid rideId)
        {
            return await _feedbackRepository.GetAll(f => f.RideId == rideId);
        }

        public async Task<List<Feedback>> GetAllByUserId(Guid userId)
        {
            return await _feedbackRepository.GetAll(f => f.UserId == userId);
        }

        public async Task<Feedback?> Create(Guid rideId, FeedbackDTO feedbackDTO)
            {
            var rideFromDb = await _rideRepository.GetById(rideId);

            if (rideFromDb == null)
                return null;

            Feedback feedback = new Feedback();
            feedback.RideId = rideId;
            feedback.Note = feedbackDTO.Note;
            feedback.Comments = feedbackDTO.Comments;
            ///TODO Utilisation de ID Admin pour les tests
            feedback.UserId = Guid.Parse("54823d83-934f-4735-b4ea-06d9b3a283ac");            

            var feedbackCreated = await _feedbackRepository.Add(feedback);
                return feedbackCreated;
        }

        public async Task<Feedback?> Update(Guid id, FeedbackDTO feedbackDTO)
        {
            Feedback? feedback = await _feedbackRepository.GetById(id);

            if (feedback == null)
                return null;

            feedback.Note = feedbackDTO.Note;
            feedback.Comments = feedbackDTO.Comments;            

            return await _feedbackRepository.Update(feedback);
        }
    }
}
