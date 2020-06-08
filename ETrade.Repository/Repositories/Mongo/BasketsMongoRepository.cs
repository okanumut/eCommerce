using ETrade.Entity.Concrete;
using ETrade.Entity.Context.Mongo;
using ETrade.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.Repository.Repositories.Mongo
{
    public class BasketsMongoRepository: MongoRepository<tbl_Basket>, IBaskets
    {
        public BasketsMongoRepository(IMongoContext context) : base(context)
        {

        }
    }
}
 
