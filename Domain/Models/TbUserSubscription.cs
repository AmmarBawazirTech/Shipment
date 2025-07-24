using DomainLayer.Models;
using System;
using System.Collections.Generic;

namespace DomainLayer.Models;

public partial class TbUserSubscription: BaseTable
{

    public Guid UserId { get; set; }

    public Guid PackageId { get; set; }

    public DateTime SubscriptionDate { get; set; }


}
