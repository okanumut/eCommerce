﻿using ETrade.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        object Entity<T>();

        ILoginUsers LoginUsers { get; } 
        IProducts Products { get; } 
        IBaskets Baskets { get; } 

        int Save();
    }
}
