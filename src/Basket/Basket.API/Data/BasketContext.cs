﻿using System;
using Basket.API.Data.Interfaces;
using StackExchange.Redis;

namespace Basket.API.Data
{
    public class BasketContext : IBasketContext
    {
        private readonly ConnectionMultiplexer _redisConnection;

        public BasketContext(ConnectionMultiplexer redisConnection)
        {
            _redisConnection = redisConnection ?? throw new ArgumentNullException(nameof(redisConnection));
            Redis = redisConnection.GetDatabase();
        }

        public IDatabase Redis { get; }
    }
}
