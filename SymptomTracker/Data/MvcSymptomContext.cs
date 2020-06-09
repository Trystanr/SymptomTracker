using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SymptomTracker.Models;
using SymptomTracker.Models.Configuration;

namespace SymptomTracker.Data
{
    public class MvcSymptomContext : IdentityDbContext<User>
    {

        public MvcSymptomContext (DbContextOptions<MvcSymptomContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleConfiguration());
        }

        public DbSet<Symptom> Symptom { get; set; }

    }
}
