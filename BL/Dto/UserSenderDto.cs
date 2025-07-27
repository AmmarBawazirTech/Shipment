using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Dto
{
    public class UserSenderDto
    {
        public Guid UserId { get; set; }

        public string SenderName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public Guid CityId { get; set; }

        public string Address { get; set; } = null!;
    }
}
