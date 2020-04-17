using LoginService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginService.Repository
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetLoginUser(string email, string password);
    }
}
