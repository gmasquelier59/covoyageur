using EVS.Api.Repositories;
using EVS.Core.Enums;
using EVS.Core.Models;

namespace EVS.Api.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IRepository<Reservation> _reservervationRepository;
        private readonly IRepository<Ride> _rideRepository;
        private readonly IRepository<User> _userRepository;

        public ReservationService(IRepository<Reservation> reservervationRepository, IRepository<Ride> rideRepository, IRepository<User> userRepository)
        {
            _reservervationRepository = reservervationRepository;
            _rideRepository = rideRepository;
            _userRepository = userRepository;
        }

        public async Task<Reservation?> Create(Guid rideId, Guid userId)
        {
            Ride? ride = await _rideRepository.GetById(rideId);
            if (ride == null)
                return null;


            User? user = await _userRepository.GetById(userId);
            if (user == null)
                return null;

            Reservation reservation = new Reservation()
            {
                RideId = ride.Id,
                UserId = user.Id,
                ReservationDate = DateTime.Now,
                Status = Core.Enums.ReservationStatus.Pending
            };

            return await _reservervationRepository.Add(reservation);
        }

        public async Task<List<Reservation>> GetAllByRideId(Guid rideId)
        {
            return await _reservervationRepository.GetAll(r => r.RideId == rideId);
        }

        public async Task<Reservation?> UpdateStatus(Guid id, ReservationStatus newStatus)
        {
            Reservation? reservation = await _reservervationRepository.GetById(id);

            if (reservation == null)
                return null;

            reservation.Status = newStatus;

            return await _reservervationRepository.Update(reservation);
        }
    }
}
