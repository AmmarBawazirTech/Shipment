using DomainLayer.Models;
using System;
using System.Collections.Generic;

namespace DomainLayer.Models;

public partial class TbShippingType:BaseTable
{

    public string? ShippingTypeAname { get; set; }

    public string? ShippingTypeEname { get; set; }

    public double ShippingFactor { get; set; }

}
