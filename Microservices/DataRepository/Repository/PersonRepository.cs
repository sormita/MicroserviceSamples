using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataRepository.Repository
{
    public class PersonRepository:IPersonRepository
    {
        private readonly AdventureWorks2017Context _context;

        public PersonRepository(AdventureWorks2017Context context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetAll() => _context.Person.ToList();
    }
}
