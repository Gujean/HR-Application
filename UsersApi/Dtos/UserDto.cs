using MongoDB.Bson.Serialization.Attributes;

namespace DataApi.Dtos
{
    public class UserDto
    {
        [BsonId]
        public string Id { get; set; }
        public string FirstName { get; set; }
		public string LastName { get; set; }

    }
}
