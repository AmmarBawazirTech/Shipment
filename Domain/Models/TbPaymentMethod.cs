using DomainLayer.Models;
using System;
using System.Collections.Generic;

namespace DomainLayer.Models;

public partial class TbPaymentMethod:BaseTable
{

    public string? MethdAname { get; set; }

    public string? MethodEname { get; set; }

    public double? Commission { get; set; }



}
