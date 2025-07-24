using DomainLayer.Models;
using System;
using System.Collections.Generic;

namespace Shipment.Models;

public partial class TbSetting:BaseTable
{

    public double? KiloMeterRate { get; set; }

    public double? KilooGramRate { get; set; }
}
