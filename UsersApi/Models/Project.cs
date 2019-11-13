using DataApi.Dtos;
using MongoDB.Bson.Serialization.Attributes;

namespace DataApi.Models
{
    public class Project
    {
        [BsonId]
        public string id { get; set; }
        public string Name { get; set; }
        public UserDto[] Members { get; set; }
    }
}
