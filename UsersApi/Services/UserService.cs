using DataApi.Models;

using DataApi.Settings;

using MongoDB.Driver;

namespace DataApi.Services
{
	public class UserService
	{
		private readonly IMongoCollection<User> _users;

		public UserService(IDataApiSettings settings)
		{
			var client = new MongoClient(settings.ConnectionString);
			var database = client.GetDatabase(settings.DatabaseName);
			//_users = database.GetCollection<User>(settings.UsersCollectionName);
		}
	}

}
