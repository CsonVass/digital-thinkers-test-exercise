using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Driver
    {
        [Key]
        [Column("Id")]
        public int UniqueId { get; set; }
        [Column("DriverId")]
        public int Id { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Team { get; set; }
        public string ImgUrl { get; set; }
        public int Place { get; set; }

    }
}
