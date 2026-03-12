using AspNetCore.Identity.Mongo.Mongo;
using D_DNoteTaker.Components.Models;
using D_DNoteTaker.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;
using MongoDB.Driver;

namespace D_DNoteTaker.Data
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<User> _user;

        public UserService(IMongoDatabase database, string collectionName)
        {
            _user = database.GetCollection<User>(collectionName);
        }

        public async Task AddUser(User user) => await _user.InsertOneAsync(user);

        public IEnumerable<User> GetAllUsers() => _user.Find(new BsonDocument()).ToList();

        public async Task<User> GetUserById(string id) => await _user.FirstOrDefaultAsync(usr => usr.Id.ToString() == id);

        public async Task RemoveUser(string id) => await _user.DeleteOneAsync(usr => usr.Id.ToString() == id);

        public async Task UpdateUserData(User user) => await _user.ReplaceOneAsync(usr => usr.Id == user.Id, user);
    }
}
