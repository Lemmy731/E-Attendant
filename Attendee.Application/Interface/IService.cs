using E_Attendant.Domain.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendee.Application.Interface
{
    public interface IService
    {
        Task<bool> CreateAttendee(AttendeeVM model);
    }
}
