using EVS.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EVS.Api.Data.Seeds
{
    public class FeedbackSeed
    {
        public static List<Feedback> Seed(ModelBuilder modelBuilder, List<User> users, List<Ride> rides)
        {
            Ride? expiredRide = null;
            foreach (Ride ride in rides)
                if (ride.Departure <= DateTime.Today)
                {
                    expiredRide = ride;
                    break;
                }

            if (expiredRide == null)
                return new();

            List<Feedback> feedbacks = new()
            {
                new Feedback()
                {
                    Id = Guid.NewGuid(),
                    RideId = expiredRide.Id,
                    UserId = users[1].Id,
                    Note = 4,
                    Comments = "J'ai pris un EVS à cause de la grève sncf. Au bout de dix minutes de discussion, il y a un passager qui dit \"Eh ca vous dis pas un covoiturage où tout le monde ferme sa gueule ?\"\r\nGrand silence depuis, plus personne ose parler."
                },
                new Feedback()
                {
                    Id = Guid.NewGuid(),
                    RideId = expiredRide.Id,
                    UserId = users[2].Id,
                    Note = 5,
                    Comments = "En Voiture Simone qui m'envoie une notif pour me dire que je suis éligible à la prime de l'Etat de 100€ pour encourager le convoiturage mdrrr ok il me manque juste le permis mais sinon ok je suis éligible 😭"
                },
                new Feedback()
                {
                    Id = Guid.NewGuid(),
                    RideId = expiredRide.Id,
                    UserId = users[4].Id,
                    Note = 3,
                    Comments = "suis dans mon EVS il a fermé les fenetres j’ose pas dire que j’ai des cheveux coincés dedans je peux pas bouger omg"
                }
            };

            foreach (Feedback feedback in feedbacks)
                modelBuilder.Entity<Feedback>().HasData(feedback);

            return feedbacks;
        }
    }
}