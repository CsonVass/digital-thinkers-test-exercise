using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Driver
    {
        [Key]
        public int UniqueId { get; }
        public int DriverId { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Team { get; set; }
        public string ImgUrl { get; set; }
        public int Place { get; set; }

    }
}
