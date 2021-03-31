using APITacobellRegister.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITacobellRegister.Repository
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly tacobellContext _context;
        
        //public Registration(tacobellContext context)
        //{
        //    _context = context;
        //}

        // GET: api/Registrations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Registration>>> GetRegistrations()
        {
            return await _context.Registrations.ToListAsync();
        }

        // GET: api/Registrations/5
        
        private bool RegistrationExists(int id)
        {
            return _context.Registrations.Any(e => e.RegistrationId == id);
        }

        public IEnumerable<Registration> GetAllRegistrations()
        {
            throw new NotImplementedException();
        }

        public Task<Registration> PutRegistration(Registration item)
        {
            throw new NotImplementedException();
        }
      


        public Task<Registration> PostRegistration(Registration item)
        {
            throw new NotImplementedException();
        }
        public async Task<Registration> PostSpecification(Registration item)
        {
            Registration Sp = null;
            if (item == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                Sp = new Registration() { RegistrationId = item.RegistrationId };
                await _context.Registrations.AddAsync(Sp);
                await _context.SaveChangesAsync();
            }
            return Sp;
        }

        Task<Registration> IRegistrationRepository.RemoveRegistration(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<Registration> RemoveSpecification(string id)
        {
            Registration sp = await _context.Registrations.FindAsync(id);
            if (sp == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                _context.Registrations.Remove(sp);
                await _context.SaveChangesAsync();
            }
            return sp;
        }
    }
}


