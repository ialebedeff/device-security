using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceSecurity.Shared.Data
{
    public class Account : EntityBase
    {
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
