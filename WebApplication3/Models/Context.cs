using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Context : DbContext
    {
        public Context() : base("Server=LAPTOP-2GGF1CMS;Database=Persistence;User Id=terry;Password=123;") { }


        public DbSet<Persona> Persona { get; set; }
    }
}
