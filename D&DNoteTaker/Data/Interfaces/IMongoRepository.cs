namespace D_DNoteTaker.Data.Interfaces
{
    public interface IMongoRepository<TDocument> where TDocument : IDocument
    {
        Task<List<TDocument>> GetAllAsync();
        Task<TDocument> GetByIdAsync(string id);
        Task InsertOneAsync(TDocument document);
        Task ReplaceOneAsync(TDocument document);
        Task DeleteByIdAsync(string id);
    }
}
