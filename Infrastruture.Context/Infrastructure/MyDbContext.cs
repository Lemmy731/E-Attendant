using E_Attendant.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastruture.Context.Infrastructure
{
    public class MyDbContext: DbContext
    {
        public DbSet <MyAttendee> Attendees  { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options ) : base( options )    
        {

        }
    }
}
