using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface IConfig
    {
        string Id { get; }
        string FileName { get; } //This name will be used for saving. // If null, we use the fully qualified name for this object.
    }
}
