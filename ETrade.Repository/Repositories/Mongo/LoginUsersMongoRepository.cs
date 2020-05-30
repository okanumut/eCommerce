using ETrade.Entity.Concrete;
using ETrade.Entity.Context.Mongo;
using ETrade.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.Repository.Repositories.Mongo
{
    public class LoginUsersMongoRepository : MongoRepository<tbl_LoginUsers>, ILoginUsers
    {
        public LoginUsersMongoRepository(IMongoContext context) : base(context)
        {

        }
    }
}
