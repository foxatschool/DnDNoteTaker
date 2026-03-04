using D_DNoteTaker.Data.Interfaces;
using MongoDB.Driver;

namespace D_DNoteTaker.Data
{
    public class MongoRepository<TDocument> : IMongoRepository<TDocument>
        where TDocument : IDocument
    {
        private readonly IMongoCollection<TDocument> _collection;

        public MongoRepository(IMongoDatabase database, string collectionName)
        {
            _collection = database.GetCollection<TDocument>(collectionName);
        }

        public async Task<List<TDocument>> GetAllAsync()
        {
            return await _collection.Find(Builders<TDocument>.Filter.Empty).ToListAsync();
        }

        public async Task<TDocument> GetByIdAsync(string id)
        {
            var filter = Builders<TDocument>.Filter.Eq(document => document.Id, id);
            return await _collection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task InsertOneAsync(TDocument document) => await _collection.InsertOneAsync(document);

        public async Task ReplaceOneAsync(TDocument document)
        {
            var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, document.Id);
            await _collection.ReplaceOneAsync(filter, document);
        }

        public async Task DeleteByIdAsync(string id)
        {
            var filter = Builders<TDocument>.Filter.Eq(document => document.Id, id);
            await _collection.DeleteOneAsync(filter);
        }


    }
}
