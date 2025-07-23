using System;
using System.Collections.Generic;

namespace Shipment.Models;

public partial class TbCity
{
    public Guid Id { get; set; }

    public string? CityAname { get; set; }

    public string CityEname { get; set; } = null!;

    public Guid CountryId { get; set; }

    public Guid? UpdatedBy { get; set; }

    public int CurrentState { get; set; }

    public DateTime CreatedDate { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
