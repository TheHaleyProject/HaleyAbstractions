﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface IConfigHandler
    {
        void SaveConfig(ref IConfig config);
        void UpdateConfig(IConfig config);
        IConfig PrepareDefault();
    }
}