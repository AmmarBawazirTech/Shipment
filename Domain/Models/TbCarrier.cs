using System;
using System.Collections.Generic;

namespace Shipment.Models;

public partial class TbCarrier
{
    public Guid Id { get; set; }

    public string CarrierName { get; set; } = null!;

    public Guid? UpdatedBy { get; set; }

    public int CurrentState { get; set; }

    public DateTime CreatedDate { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
