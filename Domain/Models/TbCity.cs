using DomainLayer.Models;
using System;
using System.Collections.Generic;

namespace DomainLayer.Models;

public partial class TbCity:BaseTable
{

    public string? CityAname { get; set; }

    public string CityEname { get; set; } = null!;

    public Guid CountryId { get; set; }


}
