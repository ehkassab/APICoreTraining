using System;
using System.Collections.Generic;
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
        public Item CreateItem(Item item)
        {
            itemsCollection.InsertOne(item);
            return GetItem(item.Id);
        }

        public Item GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}