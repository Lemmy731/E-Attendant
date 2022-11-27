using Attendee.Application.Interface;
using E_Attendant.Domain.Entity;
using Infrastruture.Context.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastruture.Context.Repository
{
    public class AttandeeRepo : IAttendeeRepo
    {
        private readonly MyDbContext _myDbContext;
        

        public AttandeeRepo(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
            

        }

        public async Task<bool> CreateAttendee(MyAttendee attendee)
        {
            var attendees = _myDbContext.Attendees.Add(attendee);
            if (await _myDbContext.SaveChangesAsync() > 0) return true;
            return false;
        }

        public async Task DeleteAttendee(MyAttendee id)
        {
            var attendee = _myDbContext.Attendees.Attach(id);
            _myDbContext.Attendees.Remove(id);
            await _myDbContext.SaveChangesAsync();
            
        }

        public async Task<List<MyAttendee>> GetAllAttendees()
        {
            var attendee =await _myDbContext.Attendees.ToListAsync();
            return attendee;
        }

        public async Task<MyAttendee> GetAttendeeById(int id)
        {
            var attendee = await _myDbContext.Attendees.FindAsync(id);
            return attendee;
        }

        public async Task<List<MyAttendee>> GetAttendeesByDateTime(string DateTime)
        {
            var attendee =  await _myDbContext.Attendees.Where(x => x.Arrival.Equals(DateTime)).ToListAsync();
            return attendee;

        }

        public async Task<List<MyAttendee>> GetAttendeesByEmail(string email)
        {
          var attendee =   _myDbContext.Attendees.Where(attendee => attendee.Email == email).ToList();
            return attendee;
        }

        public async Task<bool> UpdateAttendee(MyAttendee attendee)
        {
            var attendees =  _myDbContext.Attendees.Add(attendee); 
            _myDbContext.SaveChanges();
            return true;
        }
    }
}
