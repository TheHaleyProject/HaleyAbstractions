using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IOSSClient : IOSSDirectory {
        string SigningKey { get; set; }
        string EncryptKey { get; set; }
        string PasswordHash { get; set; }
       
    }
}
