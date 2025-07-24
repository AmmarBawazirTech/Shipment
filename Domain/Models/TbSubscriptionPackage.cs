using DomainLayer.Models;
using System;
using System.Collections.Generic;

namespace DomainLayer.Models;

public partial class TbSubscriptionPackage:BaseTable
{

    public string PackageName { get; set; } = null!;

    public int ShippimentCount { get; set; }

    public double NumberOfKiloMeters { get; set; }

    public double TotalWeight { get; set; }


}
