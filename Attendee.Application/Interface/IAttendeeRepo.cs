using E_Attendant.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendee.Application.Interface
{
    public interface IAttendeeRepo
    {
        Task<bool> CreateAttendee(MyAttendee attendee);
        Task<bool> UpdateAttendee(MyAttendee attendee);
        Task DeleteAttendee(MyAttendee id);
        Task<MyAttendee> GetAttendeeById(int id);
        Task<List<MyAttendee>> GetAllAttendees();
        Task<List<MyAttendee>> GetAttendeesByEmail(string email);
        Task<List<MyAttendee>> GetAttendeesByDateTime(string DateTime);
    }
}
