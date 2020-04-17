using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataRepository.Repository
{
    public class AddressRepository: IAddressRepository
    {
        private readonly AdventureWorks2017Context _context;

        public AddressRepository(AdventureWorks2017Context context)
        {
            _context = context;
        }

        public IEnumerable<Address> GetAll() => _context.Address.ToList();
    }
}
