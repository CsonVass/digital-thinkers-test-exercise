using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class FormulaRepository : IFormulaRepository
    {

        private readonly IFormulaContext ctx;

        public FormulaRepository(IFormulaContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task<IEnumerable<Driver>> GetDrivers()
        {
            return await ctx
                         .Drivers
                         .ToListAsync();
        }

        public async Task<Driver> GetDriverById(int id)
        {
            return await ctx
                         .Drivers
                         .Where(d => d.DriverId == id)
                         .FirstOrDefaultAsync();
        }

        public async Task<Driver> GetDriverByPlace(int place)
        {
            return await ctx
                         .Drivers
                         .Where(d => d.Place == place)
                         .FirstOrDefaultAsync();
        }


        public async Task<bool> UpdatePalce(int driverId, int place)
        {
            Driver driver = await GetDriverById(driverId);
            if(driver == null)
            {
                return false;
            }

            driver.Place = place;

            var updateInfo = ctx.Drivers.Update(driver).State;

            ((FormulaContext) ctx).SaveChanges();

            return updateInfo == EntityState.Modified;
        }



       
    }

}
