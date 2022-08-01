using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTO
{
    public class DriverDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Country { get; set; }
        public string Team { get; set; }
        public string ImgUrl { get; set; }
        public int Place { get; set; }

    }
}
