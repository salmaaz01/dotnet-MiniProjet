using AM.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext _context;
        private Type _repositoryType;                //pour connaitre le type de ripo soit ripo plane ou bien ripo flight
        private bool disposedValue;

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }
        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class // va creer une instance d'un repository de type donne 

             {
            return (IGenericRepository<TEntity>)Activator
                  .CreateInstance(_repositoryType
                  .MakeGenericType(typeof(TEntity)), _context); ;
        }

        public int save()
        {
           return _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                    _context.Dispose();
                {
                    // TODO: supprimer l'état managé (objets managés)
                }

                // TODO: libérer les ressources non managées (objets non managés) et substituer le finaliseur
                // TODO: affecter aux grands champs une valeur null
                disposedValue = true;
            }
        }

        // // TODO: substituer le finaliseur uniquement si 'Dispose(bool disposing)' a du code pour libérer les ressources non managées
        // ~UnitOfWork()
        // {
        //     // Ne changez pas ce code. Placez le code de nettoyage dans la méthode 'Dispose(bool disposing)'
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Ne changez pas ce code. Placez le code de nettoyage dans la méthode 'Dispose(bool disposing)'
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }


}

