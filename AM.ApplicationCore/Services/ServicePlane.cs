using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServicePlane : IServicePlane
    {
        //IGenericRepository<Plane> genericRepository;

        IUnitOfWork _unitOfWork;
        public ServicePlane(IGenericRepository<Plane> genericRepository)
        {
            //this.genericRepository = genericRepository;
            _unitOfWork = _unitOfWork;

        }
        public void Add(Plane P)
        {
            //genericRepository.Add(P);
            _unitOfWork.Repository<Plane>().Add(P);
        }

        public void DeletePlanes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Plane> GetAll()
        {
            //return genericRepository.GetAll();
            return _unitOfWork.Repository<Plane>().GetAll();
        }

        public IEnumerable<Flight> GetFlights(int n)
        {
            throw new NotImplementedException();
        }

        public bool IsAvailablePlane(Flight flight, int n)
        {
            throw new NotImplementedException();
        }

        public void Remove(Plane P)
        {
            //genericRepository.Delete(P);
            _unitOfWork.Repository<Plane>().Delete(P); //hi

        }
    }
}
