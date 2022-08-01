using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class FormulaRepository : IFormulaRepository
    {
        public Task<IEnumerable<Driver>> GetDrivers()
        {
            throw new NotImplementedException();
        }

        public Task UpdatePalce(int driverId, int place)
        {
            throw new NotImplementedException();
        }
    }
}
