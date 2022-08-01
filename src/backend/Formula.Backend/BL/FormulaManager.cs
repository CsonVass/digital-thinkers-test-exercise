using AutoMapper;
using BL.DTO;
using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Transactions;

namespace BL
{
    public class FormulaManager
    {
        private readonly IFormulaRepository formulaRepository;

        public FormulaManager(IFormulaRepository formulaRepository)
        {
            this.formulaRepository = formulaRepository;
        }

        //List
        public async Task<IEnumerable<DriverDTO>> ListDrivers()
        {
            var driverList = await formulaRepository.GetDrivers();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Driver, DriverDTO>());
            var mapper = new Mapper(config);

            return mapper.Map<List<DriverDTO>>(driverList);
        }

        //Overtake
        public async Task<IEnumerable<DriverDTO>> Overtake(int driverId)
        {
            List<Driver> drivers = new List<Driver>();
            using (var tran = new TransactionScope(
                TransactionScopeOption.Required,
                new TransactionOptions() { IsolationLevel = IsolationLevel.RepeatableRead },
                TransactionScopeAsyncFlowOption.Enabled))
            {
                var driver = await formulaRepository.GetDriverById(driverId);
                if(driver == null)
                {
                    return null;
                }
                int driverPlace = driver.Place;
                if(driverPlace - 1 <= 0)
                {
                    return null;
                }

                var driverOvertaken = await formulaRepository.GetDriverByPlace(driverPlace - 1);
                int driverOvertakenPlace = driverOvertaken.Place;

                bool update1 = await formulaRepository.UpdatePalce(driverId, driverOvertakenPlace);
                bool update2 = await formulaRepository.UpdatePalce(driverOvertaken.Id, driverPlace);

                if(!update1 || !update2)
                {
                    return null;
                }

                drivers.Add(driver);
                drivers.Add(driverOvertaken);

            }
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Driver, DriverDTO>());
            var mapper = new Mapper(config);

            return mapper.Map<List<DriverDTO>>(drivers);
        }

        
    }
}
