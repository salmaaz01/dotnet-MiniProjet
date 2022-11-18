using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class

    {

        private IGenericRepository<TEntity> _repository;
        private IUnitOfWork _unitOfWork;

        public Service( IUnitOfWork unitOfWork)
        {
            _repository = unitOfWork.Repository<TEntity>();
            _unitOfWork = unitOfWork;
        }
        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(System.Linq.Expressions.Expression<Func<TEntity, bool>> where)
        {
            return _repository.Delete(where);
        }

        public TEntity Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetMany(System.Linq.Expressions.Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
