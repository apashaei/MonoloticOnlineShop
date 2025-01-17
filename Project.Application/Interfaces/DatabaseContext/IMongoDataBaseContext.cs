﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Interfaces.DatabaseContext
{
    public interface IMongoDataBaseContext<T>
    {
        public IMongoCollection<T> GetCollection();
    }
}
