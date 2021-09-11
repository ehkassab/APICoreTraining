using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using APiCoreTraning.Entities;
using MongoDB.Driver;

namespace APiCoreTraning.Repositories
{
    public class MongoDbItemsRepo : IItemsRepo
    {

        private const string dbName  = "ApiTraining";
        private const string collectionName = "Items";
        private readonly IMongoCollection<Item> itemsCollection;
        
        public MongoDbItemsRepo(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(dbName);
            itemsCollection = database.GetCollection<Item>(collectionName);
        }
        public Task<Item> CreateItemAsync(Item item)
        {
            itemsCollection.InsertOneAsync(item);
            return GetItemAsync(item.Id);
        }

        public Task<Item> GetItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Item>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }
    }
}