using APITacobellRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITacobellRegister.Repository
{
    interface IRegistrationRepository
    {
        IEnumerable<Registration> GetAllRegistrations();
        Task<Registration> PutRegistration(Registration item);
        Task<Registration> PostRegistration(Registration item);
        //Registration GetRegistrationById(int id);
        
        Task<Registration> RemoveRegistration(int id);

    }
}
