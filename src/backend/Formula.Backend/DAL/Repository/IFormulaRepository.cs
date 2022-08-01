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
        public Task<Driver> GetDriverById(int id);
        public Task<Driver> GetDriverByPlace(int place);

             
        //Update
        public Task<bool> UpdatePalce(int driverId, int place);
    }
}
