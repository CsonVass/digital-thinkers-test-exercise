using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FormulaContext : DbContext, IFormulaContext
    {
        public FormulaContext(DbContextOptions<FormulaContext> options)
            : base(options) { }

        public DbSet<Driver> Drivers { get; set ; }

    }
}
