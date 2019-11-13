using DataApi.Dtos;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

//using AspNetCoreVueStarter.DTOs;


namespace DataApi.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
		public string Address { get; set; }//Address can be a class aswell if needed
		public ProjectDto[] Projects { get; set; }
        public string Role { get; set; }
        public int Salary { get; set; }
		public int VacationDays { get; set; }
        public int SickDays { get; set; }
        public int OffDays { get; set; }
        public int WorkFromHomeDays { get; set; }
        public int SpecialDays { get; set; }// like when someone dies or  you get married
		

    }

}
