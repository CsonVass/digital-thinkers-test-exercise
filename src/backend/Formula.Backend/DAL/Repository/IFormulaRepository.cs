using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL
{
    public interface IFormulaRepository
    {
        //Read
        public Task<IEnumerable<Driver>> GetDrivers();

        //Update
        public Task UpdatePalce(int driverId, int place);
    }
}
