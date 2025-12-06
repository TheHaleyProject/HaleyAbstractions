using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IVaultUID  {
        long Id { get; set; }
        Guid Guid { get; set; } //Name with which it is identified
    }
}
