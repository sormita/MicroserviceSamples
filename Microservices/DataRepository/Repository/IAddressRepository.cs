using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataRepository.Repository
{
    public interface IAddressRepository
    {
        IEnumerable<Address> GetAll();
    }
}
