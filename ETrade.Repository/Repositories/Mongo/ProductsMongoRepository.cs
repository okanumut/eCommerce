using ETrade.Entity.Concrete;
using ETrade.Entity.Context.Mongo;
using ETrade.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.Repository.Repositories.Mongo
{
    public class ProductsMongoRepository : MongoRepository<tbl_Products>, IProducts
    {
        public ProductsMongoRepository(IMongoContext context) : base(context)
        {

        }
    }
}
 
