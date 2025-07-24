using System;
using System.Collections.Generic;

namespace Shipment.Models;

public partial class TbSubscriptionPackage
{
    public Guid Id { get; set; }

    public string PackageName { get; set; } = null!;

    public int ShippimentCount { get; set; }

    public double NumberOfKiloMeters { get; set; }

    public double TotalWeight { get; set; }

    public Guid? UpdatedBy { get; set; }

    public int CurrentState { get; set; }

    public DateTime CreatedDate { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
