using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Haley.Models {
    //IMPORTANT: DONT' GIVE ANY FALL BACK VALUES.. WE ARE DEFINING THIS INSIDE THE PGEXPORT SERVICE.. IF WE DEFINE HERE, THEN IT WONT WORK IN OTHER PLACES.
    public sealed class PgToolOptions {
        [ConfigurationKeyName("pgdump")]
        public string PgDumpPath { get; set; } = "";

        [ConfigurationKeyName("psql")]
        public string PsqlPath { get; set; } = "";

        [ConfigurationKeyName("host")]
        public string Host { get; set; } = "";

        [ConfigurationKeyName("port")]
        public int Port { get; set; } = 0;

        [ConfigurationKeyName("database")]
        public string Database { get; set; } = "";

        [ConfigurationKeyName("user")]
        public string Username { get; set; } = "";

        [ConfigurationKeyName("password")]
        public string Password { get; set; } = "";

        [ConfigurationKeyName("schema")]
        public string DefaultSchema { get; set; } = "";

        [ConfigurationKeyName("timeout")]
        public int TimeoutSeconds { get; set; } = 120;

        // treat this as key, not raw connection string
        [ConfigurationKeyName("conn")]
        public string ConnectionKey { get; set; } = "";
    }
}
