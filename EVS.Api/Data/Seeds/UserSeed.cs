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
					Password = "admin" // TODO
                },
				new User()
				{
					Id = Guid.NewGuid(),
					IsAdmin = false,
					FirstName = "Amye",
					LastName = "Colchett",
					Pseudo = "acolchett0",
					Birthday = DateTime.Parse("03/12/1998"),
					CarDescription = "Daewoo",
					PhoneNumber = "0337862430",
					Photo = "https://this-person-does-not-exist.com/img/avatar-gen1175da31458c1a38f5c53205c1d40c49.jpg",
					Email = "naldren0@webeden.co.uk",
					Password = @"aB0.oB?iBy\", // TODO
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
					FirstName = "Nap",
					LastName = "Droogan",
					Pseudo = "ddroogan1",
					Birthday = DateTime.Parse("30/08/1974"),
					CarDescription = "Lexus",
					PhoneNumber = "0322458382",
					Photo = "https://this-person-does-not-exist.com/img/avatar-genc4f3be92e510666c0f16aeee2435ed90.jpg",
					Email = "ddroogan1@thetimes.co.uk",
					Password = @"tH0)I/Mt<xZwz2", // TODO
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
					FirstName = "Kordula",
					LastName = "Pedwell",
					Pseudo = "kpedwell2",
					Birthday = DateTime.Parse("09/05/1988"),
					CarDescription = "Jeep",
					PhoneNumber = "0903434966",
					Photo = "https://this-person-does-not-exist.com/img/avatar-gen7b7dfa2a253e45ffa4925acc349ffcdc.jpg",
					Email = "kpedwell2@icq.com",
					Password = @"pH3+&{WpvdT", // TODO
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
					FirstName = "Lindsey",
					LastName = "Hair",
					Pseudo = "lhair3",
					Birthday = DateTime.Parse("05/06/1984"),
					CarDescription = "Austin",
					PhoneNumber = "0162842195",
					Photo = "https://this-person-does-not-exist.com/img/avatar-gen1131946bc643d6ef1643496115dade90.jpg",
					Email = "lhair3@wikipedia.org",
					Password = @"eE0'6STA~9O#Suj{", // TODO
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
					FirstName = "Carlota",
					LastName = "Grigorkin",
					Pseudo = "cgrigorkin4",
					Birthday = DateTime.Parse("24/08/1997"),
					CarDescription = "BMW",
					PhoneNumber = "0494223557",
					Photo = "https://this-person-does-not-exist.com/img/avatar-gen376a50c7287a78e549d58d13a864d15f.jpg",
					Email = "cgrigorkin4@theatlantic.com",
					Password = @"tZ9\4s(DQvnvE", // TODO
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
