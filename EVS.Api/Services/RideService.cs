using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using EVS.Core.Models;
using System.ComponentModel.DataAnnotations;
using EVS.Api.Repositories;


namespace EVS.Api.Services
{
    public class RideService
    {
        
       public List<Ride>? GetAll()
            {
                return  null;
            }

        // Méthode pour récupérer une offre de trajet par ID
        
        public Guid GetRideById(Ride ride, User user)
        {
            // Supposons que Ride soit une liste ou une collection de rides
            // et que chaque ride ait une propriété Id de type Guid
            return ride.FirstOrDefault(t => t.Id == user.Id)?.Id ?? Guid.Empty;
        }



        // Méthode pour créer une nouvelle offre de trajet
        public Ride CreateRide(Ride ride)
            {
                Ride.Add(ride);
                SaveChanges();
                return ride;
            }

            // Méthode pour mettre à jour une offre de trajet existante
            public Ride UpdateRide(Guid rideId, Ride updatedRide)
            {
                var ride = Ride.Find(rideId);
                if (ride == null)
                {
                    return null;
                }

                ride.StartCity = updatedRide.StartCity;
                ride.StartLatitude = updatedRide.StartLatitude;
                ride.StartLongitude = updatedRide.StartLongitude;
                ride.EndCity = updatedRide.EndCity;
                ride.EndLatitude = updatedRide.EndLatitude;
                ride.EndtLongitude = updatedRide.EndtLongitude;
                ride.Distance = updatedRide.Distance;
                ride.Departure = updatedRide.Departure;
                ride.Price = updatedRide.Price;
                ride.Seats = updatedRide.Seats;





                SaveChanges();
                return ride;
            }

        private void SaveChanges()
        {
            throw new NotImplementedException();
        }

        // Méthode pour supprimer une offre de trajet
        public bool DeleteRide(Guid rideId)
            {
                var ride = Ride.Find(rideId);
                if (ride == null)
                {
                    return false;
                }

                Ride.Remove(ride);
                SaveChanges();
                return true;
            }

       
    }
    }
}











