// RideService.cs

using EVS.Core.Models;
using EVS.Api.Helpers;
using System;
using System.Collections.Generic;

namespace EVS.Api.Services
{
    public class RideService : IRideService
    {

        public List<Ride> GetAllRides()
        {
            // Logique pour récupérer tous les Rides depuis la base de données, par exemple
            throw new NotImplementedException();
        }

        public Ride GetRideById(Guid rideId)
        {
            // Logique pour récupérer un trajet par son identifiant depuis la base de données
            // Par exemple, vous pouvez accéder à une source de données externe, telle qu'un service web ou une autre base de données
            // Ici, nous simulons simplement la récupération d'un trajet avec un identifiant donné
            var ride = new Ride
            {
                Id = rideId,
                StartCity = "CityA",
                EndCity = "CityB",
                StartLatitude = 52.00,
                StartLongitude = 32.00,
                EndLatitude = 65.00,
                EndLongitude = 79.00,
                //distancefunc = new GeoHelper(;
                //Distance = GeoHelper.GetDistanceAsTheCrowFlies(StartLatitude, StartLongitude, EndLatitude, EndLongitude),





                /*
               

        [Required, Column("distance")]
        public int Distance { get; set; }

        [Required, Column("departure")]
        public DateTime Departure { get; set; }

        [Required, Column("price")]
        public Double Price { get; set; }

        [Required, Range(1, 10), Column("seats")]
        public int Seats { get; set; }
                */




                // Autres propriétés
            };
            return ride;
        }
    }
}
 

    //    public void AddRide(Ride ride)
    //    {
    //        // Logique pour ajouter un nouveau trajet 
    //        throw new NotImplementedException();
    //    }

        

    //    public void DeleteRide(Guid rideId)
    //    {
    //        // Logique pour supprimer un utilisateur de la base de données, par exemple
    //        throw new NotImplementedException();
    //    }

       
    }
}


/*
 * // RideRepository.cs

using System;

namespace VotreNamespace
{
    public class RideRepository : IRideRepository
    {
        public Ride GetRideById(Guid rideId)
        {
            // Logique pour récupérer un trajet par son identifiant depuis la base de données
            // Par exemple, vous pouvez accéder à une source de données externe, telle qu'un service web ou une autre base de données
            // Ici, nous simulons simplement la récupération d'un trajet avec un identifiant donné
            var ride = new Ride
            {
                RideId = rideId,
                StartCity = "CityA",
                EndCity = "CityB",
                // Autres propriétés
            };
            return ride;
        }
    }
}

/*
 * Rides
GET
/rides/{startCity}/{endCity}/{departure}
✅
✅
✅
Liste des trajets disponibles correspondants aux critères
GET
/rides/{depart}/{date}
✅
✅
✅
Liste des trajets dispo correspondants aux critères
GET
/rides
❌
❌
❌
Liste de tous les trajets dispo
GET
/rides/{userId}
❌
✅
✅
Liste de tous les trajets d’un utilisateur
GET
/ride/{id}
✅
✅
✅


POST
/ride
❌
✅
❌
Création d’un trajet
DELETE
/ride/{id}
❌
✅
✅
Suppression d’un trajet, des réservations, des feedbacks
*/




