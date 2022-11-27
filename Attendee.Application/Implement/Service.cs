using Attendee.Application.Interface;
using E_Attendant.Domain.Entity;
using E_Attendant.Domain.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendee.Application.Implement
{
    public class Service : IService
    {
        private readonly IAttendeeRepo _attendeeRepo;

        public Service(IAttendeeRepo attendeeRepo)
        {
            _attendeeRepo = attendeeRepo;
        }
        public async Task<bool> CreateAttendee(AttendeeVM model)
        {
            var attend = new MyAttendee()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Gender = model.Gender,
                PhoneNumber = model.PhoneNumber,
                Stack = model.Stack,
                Arrival = model.Arrival,
                Departure = model.Departure

            };
            if (await _attendeeRepo.CreateAttendee(attend)) return true;
            return false;   
        }
    }
}
