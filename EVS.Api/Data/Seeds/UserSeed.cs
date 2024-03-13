using EVS.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EVS.Api.Data.Seeds
{
	public class UserSeed
	{
		public static List<User> Seed(ModelBuilder modelBuilder)
		{
			List<User> users = new List<User>()
			{
				new User()
				{
					Id = Guid.NewGuid(),
					IsAdmin = true,
					FirstName = "Admin",
					LastName = "Admin",
					Pseudo = "admin",
					Birthday = DateTime.Now,
					CarDescription = "",
					PhoneNumber = "0102030405",
					Photo = "https://this-person-does-not-exist.com/img/avatar-gen485cbb48758f0bbe06ed361e18f34d9c.jpg",
					Email = "admin@envoituresimone.com",
					Password = "admin"
                },
				new User()
				{
					Id = Guid.NewGuid(),
					IsAdmin = false,
					FirstName = "Ange",
					LastName = "Lefebvre",
					Pseudo = "angedu59",
					Birthday = DateTime.Parse("03/12/1998"),
					CarDescription = "Daewoo",
					PhoneNumber = "0337862430",
					Photo = "https://this-person-does-not-exist.com/img/avatar-gen1175da31458c1a38f5c53205c1d40c49.jpg",
					Email = "angedu59@gmail.com",
					Password = "df45dfh4",
                    AcceptFood = true,
					AcceptMusic = true,
					AcceptPet = false,
					AcceptSmallTalk = false,
					AcceptSmoker = false
				},
				new User()
				{
					Id = Guid.NewGuid(),
					IsAdmin = false,
					FirstName = "Nathanaël",
					LastName = "Leroy",
					Pseudo = "n@thleroy",
					Birthday = DateTime.Parse("30/08/1974"),
					CarDescription = "Lexus",
					PhoneNumber = "0322458382",
					Photo = "https://this-person-does-not-exist.com/img/avatar-genc4f3be92e510666c0f16aeee2435ed90.jpg",
					Email = "nath@gmail.com",
					Password = "456df456fg",
                    AcceptFood = false,
					AcceptMusic = true,
					AcceptPet = false,
					AcceptSmallTalk = true,
					AcceptSmoker = true
				},
				new User()
				{
					Id = Guid.NewGuid(),
					IsAdmin = false,
					FirstName = "Agathe",
					LastName = "Klein",
					Pseudo = "pokemonlover",
					Birthday = DateTime.Parse("09/05/1988"),
					CarDescription = "Jeep",
					PhoneNumber = "0903434966",
					Photo = "https://this-person-does-not-exist.com/img/avatar-gen7b7dfa2a253e45ffa4925acc349ffcdc.jpg",
					Email = "pokedex@gmail.com",
					Password = "fg456gf546",
                    AcceptFood = false,
					AcceptMusic = true,
					AcceptPet = true,
					AcceptSmallTalk = false,
					AcceptSmoker = false
				},
				new User()
				{
					Id = Guid.NewGuid(),
					IsAdmin = false,
					FirstName = "Chloé",
					LastName = "Laurent",
					Pseudo = "chloechloe",
					Birthday = DateTime.Parse("05/06/1984"),
					CarDescription = "Austin",
					PhoneNumber = "0162842195",
					Photo = "https://this-person-does-not-exist.com/img/avatar-gen1131946bc643d6ef1643496115dade90.jpg",
					Email = "chloechloe@gmail.com",
					Password = "456dffg456",
                    AcceptFood = true,
					AcceptMusic = true,
					AcceptPet = false,
					AcceptSmallTalk = false,
					AcceptSmoker = false
				},
				new User()
				{
					Id = Guid.NewGuid(),
					IsAdmin = false,
					FirstName = "Malo",
					LastName = "Guérin",
					Pseudo = "malolesbains",
					Birthday = DateTime.Parse("24/08/1997"),
					CarDescription = "BMW",
					PhoneNumber = "0494223557",
					Photo = "https://this-person-does-not-exist.com/img/avatar-gen376a50c7287a78e549d58d13a864d15f.jpg",
					Email = "malolesbains@plage.org",
					Password = "zer234efz42",
					AcceptFood = true,
					AcceptMusic = false,
					AcceptPet = false,
					AcceptSmallTalk = false,
					AcceptSmoker = false
				}
			};

			foreach (User user in users)
				modelBuilder.Entity<User>().HasData(user);

			return users;
		}
	}
}
