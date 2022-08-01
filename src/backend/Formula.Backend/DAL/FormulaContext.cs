using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DAL
{
    public class FormulaContext : DbContext, IFormulaContext
    {
        public FormulaContext(DbContextOptions<FormulaContext> options)
            : base(options) 
        {
            if (!Drivers.Any())
            {
                ReadData(this);
            }
        }

        public DbSet<Driver> Drivers { get; set; }


        /*
       * Helper methods
       */

        //Reading data from given folder
        private static void ReadData(FormulaContext ctx)
        {
            string dir = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "res\\formula1\\drivers.json");
            using (StreamReader r = new StreamReader(dir))
            {
                string json = r.ReadToEnd();
                List<Driver> drivers = JsonConvert.DeserializeObject<List<Driver>>(json);

                List<int> places = Enumerable.Range(1, drivers.Count).ToList();

                places = Shuffle(places);
                int i = 0;
                foreach (Driver d in drivers)
                {
                    d.Place = places[i++];
                    ctx.Drivers.Add(d);
                }
                ctx.SaveChanges();
            }
        }

        //helper method for shuffling the places
        private static Random rng = new Random();
        public static List<int> Shuffle(List<int> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }




    }
}
