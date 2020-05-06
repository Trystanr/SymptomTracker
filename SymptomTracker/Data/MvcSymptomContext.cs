using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using SymptomTracker.Models;

namespace SymptomTracker.Data
{
    public class MvcSymptomContext : DbContext
    {

        public MvcSymptomContext (DbContextOptions<MvcSymptomContext> options) : base(options)
        {

        }

        public DbSet<Symptom> Symptom { get; set; }

    }
}
