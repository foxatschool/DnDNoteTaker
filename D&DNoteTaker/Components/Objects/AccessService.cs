using MongoDB.Bson;
using MongoDB.Driver;

namespace D_DNoteTaker.Components.Objects
{
    public class AccessService
    {
        private readonly IMongoCollection<Testing> _tester;

        //public static List<Testing> databaseCopy { get; set; }

        public AccessService()
        {
            var client = new MongoClient(Environment.GetEnvironmentVariable("MONGODB_URI"));
            var database = client.GetDatabase("Testing");
            _tester = database.GetCollection<Testing>("Testing");
        }

        public List<Testing> GetDatabase()
        {
            return _tester.Find(new BsonDocument()).ToList();
        }

        public async Task InsertAccessService(Testing tester)
        {
            await _tester.InsertOneAsync(tester);
        }
    }
}
