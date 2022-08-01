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
            ReadData((FormulaContext) ctx);
        }

        public Task<Driver> GetDriverById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Driver> GetDriverByPlace(int place)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Driver>> GetDrivers()
        {
            return await ctx
                         .Drivers
                         .ToListAsync();
        }

        public Task UpdatePalce(int driverId, int place)
        {
            throw new NotImplementedException();
        }

        //Reading data from given folder
        private static void ReadData(FormulaContext ctx)
        {
            string dir = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "res\\formula1\\drivers.json");
            using (StreamReader r = new StreamReader(dir))
            {
                string json = r.ReadToEnd();
                List<Driver> drivers = JsonConvert.DeserializeObject<List<Driver>>(json);
                foreach (Driver d in drivers)
                {
                    ctx.Drivers.Add(d);
                }
                ctx.SaveChanges();
            }
        }
    }

}
