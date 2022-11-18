﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IUnitOfWork:IDisposable

    {
        int save();
        IGenericRepository<TEntity>Repository<TEntity>()where TEntity : class;
    }
}
