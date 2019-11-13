using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataApi.DbConn
{
    public class MongoCRUD
    {
        IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public async Task<List<T>> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            
            return (await collection.FindAsync(new BsonDocument())).ToList();

        }

        public T LoadRecord<T>(string table, string id)
        {
	        var collection = db.GetCollection<T>(table);
	        var filter = Builders<T>.Filter.Eq("Id", id);
	        return collection.Find(filter).First();
        }

		public void UpsertRecord<T>(string table, string id, T record)
        {
            var collection = db.GetCollection<T>(table);

            var result = collection.ReplaceOne(
                new BsonDocument("_id", id),
                record,
                new UpdateOptions { IsUpsert = true });
        }

        public void DeleteRecord<T>(string table, string id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
    }
}
