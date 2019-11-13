using MongoDB.Bson.Serialization.Attributes;

namespace DataApi.Dtos
{
    public class ProjectDto
    {
        [BsonId]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}