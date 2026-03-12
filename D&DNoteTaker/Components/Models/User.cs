using AspNetCore.Identity.Mongo.Model;
using MongoDB.Bson.Serialization.Attributes;

namespace D_DNoteTaker.Components.Models
{
    [BsonIgnoreExtraElements]
    public class User : MongoUser
    {
        public List<string>? Campaigns { get; set; }
    }
}
