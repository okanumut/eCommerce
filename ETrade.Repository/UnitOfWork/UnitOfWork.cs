using ETrade.Entity;
using ETrade.Entity.Context.Mongo;
using ETrade.Repository.Interfaces;
using ETrade.Repository.Repositories.Mongo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.Repository.UnitOfWork
{
    public class UnitOfWork
    {
        private bool disposed = false;
        public ILoginUsers LoginUsers { get; } 
        private readonly IMongoContext _mongoContext;

        public UnitOfWork()
        {
            if (DatabaseSelection.DatabaseType == DbType.Mongo())
            {
                _mongoContext = new MongoContext();
                LoginUsers = new LoginUsersMongoRepository(_mongoContext); 
            }
            else
            {

            }
        }
        public void Dispose()
        {
            if (DatabaseSelection.DatabaseType == DbType.Mongo())
            {
                _mongoContext.Dispose();
            }
            else
            {
            }


        }
        public int Save()
        {
            if (DatabaseSelection.DatabaseType == DbType.Mongo())
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public object Entity<T>()
        {
            throw new NotImplementedException();
        }
    }
}
