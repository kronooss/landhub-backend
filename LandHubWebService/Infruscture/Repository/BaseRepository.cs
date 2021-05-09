﻿using MongoDB.Bson;
using MongoDB.Driver;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Repository
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly IMongoLandHubDBContext _mongoContext;
        protected IMongoCollection<TEntity> _dbCollection;

        protected BaseRepository(IMongoLandHubDBContext context)
        {
            _mongoContext = context;
            _dbCollection = _mongoContext.GetCollection<TEntity>(typeof(TEntity).Name);
        }


        public async Task<TEntity> Get(string id)
        {
            //ex. 5dc1039a1521eaa36835e541

            var objectId = new ObjectId(id);

            FilterDefinition<TEntity> filter = Builders<TEntity>.Filter.Eq("_id", objectId);

            return await _dbCollection.FindAsync(filter).Result.FirstOrDefaultAsync();

        }


        public async Task<IEnumerable<TEntity>> Get()
        {
            var all = await _dbCollection.FindAsync(Builders<TEntity>.Filter.Empty);
            return await all.ToListAsync();
        }

        public async Task Create(TEntity obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(typeof(TEntity).Name + " object is null");
            }
            await _dbCollection.InsertOneAsync(obj);
        }

        public virtual void Update(TEntity obj)
        {
            _ = _dbCollection.ReplaceOneAsync(Builders<TEntity>.Filter.Eq("_id", obj.ToString()), obj);
        }

        public void Delete(string id)
        {
            //ex. 5dc1039a1521eaa36835e541

            var objectId = new ObjectId(id);
            _dbCollection.DeleteOneAsync(Builders<TEntity>.Filter.Eq("_id", objectId));

        }
    }
}