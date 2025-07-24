using System;
using System.Collections.Generic;

namespace DomainLayer.Models;

public partial class TbShippmentStatus:BaseTable
{

    public Guid? ShippmentId { get; set; }


    public string? Notes { get; set; }


}
