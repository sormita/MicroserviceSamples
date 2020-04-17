using LoginService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginService.Repository
{
    public class PersonRepository: IPersonRepository
    {
        private readonly AdventureWorks2017Context _context;

        public PersonRepository(AdventureWorks2017Context context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetLoginUser(string email, string password) => _context.Person
            .Where(x => x.Email == email)
            .Where(x => x.UsrPassword == password).ToList();
    }
}
