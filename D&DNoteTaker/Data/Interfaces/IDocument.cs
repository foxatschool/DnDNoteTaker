using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace D_DNoteTaker.Data.Interfaces
{
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string Id { get; set; }
    }
}
