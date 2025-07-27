using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Dto
{
    public class CityDto
    {
        public string? CityAname { get; set; }

        public string CityEname { get; set; } = null!;

        public Guid CountryId { get; set; }
    }
}
