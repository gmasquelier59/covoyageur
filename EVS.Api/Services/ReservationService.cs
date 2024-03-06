using System;
using System.Linq;
using EVS.Core.Models;

namespace Api.Services
{
    public class ReservationService
    {
        private readonly ApplicationDbContext _context;

        private ReservationService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Méthode pour créer une nouvelle réservation
        public Reservation CreateReservation(Guid rideId, Guid userId)
        {
            // Vérifier si l'offre de trajet existe
            var ride = _context.Ride.FirstOrDefault(t => t.RideId == rideId);
            if (ride == null)
            {
                return null;
            }

            // Vérifier si le passager existe
            var user = _context.User.FirstOrDefault(u => u.UserId == userId);
            if (user == null)
            {
                return null;
            }

            // Vérifier si des places sont disponibles
            if (ride.Seats <= 0)
            {
                return null;
            }

            // Créer la réservation
            var reservation = new Reservation //initialiser avec les paramètres de notre projet
            {
                RideId = rideId,
                UserId = userId,
                Status = "Pending"
            };

            // Mettre à jour le nombre de places disponibles sur l'offre de trajet
            ride.AvailableSeats--;

            // Sauvegarder les modifications dans la base de données
            _context.Reservation.Add(reservation);
            _context.SaveChanges();

            return reservation;
        }

        // Méthode pour mettre à jour le statut d'une réservation
        public Reservation UpdateReservationStatus(int reservationId, string status)
        {
            var reservation = _context.Reservation.Find(reservationId);
            if (reservation == null)
            {
                return null;
            }

            reservation.Status = status;

            _context.SaveChanges();
            return reservation;
        }

        // Méthode pour annuler une réservation
        public bool CancelReservation(int reservationId)
        {
            var reservation = _context.Reservations.Find(reservationId);
            if (reservation == null)
            {
                return false;
            }

            // Récupérer l'offre de trajet associée à la réservation
            var ride = _context.Ride.FirstOrDefault(t => t.RideId == reservation.RideId);
            if (ride != null)
            {
                // Augmenter le nombre de places disponibles sur l'offre de trajet
                ride.Seats++;
            }

            _context.Reservation.Remove(reservation);
            _context.SaveChanges();
            return true;
        }
    }

    
}
