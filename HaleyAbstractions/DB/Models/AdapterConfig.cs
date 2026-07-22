using Haley.Abstractions;
using Haley.Enums;

namespace Haley.Models {

    public class AdapterConfig : IAdapterConfig {

        public AdapterConfig() {
            DBType = TargetDB.unknown;
        }
        public string ConnectionString { get; set; }
        public string DBAString { get; set; }
        public string AdapterKey { get; set; }
        [OtherNames("key")]
        public string ConnectionKey { get; set; }
        [OtherNames("database")]
        public string DBName { get; set; }
        public TargetDB DBType { get; set; }
        public ConInfo ConnectionInfo { get; set; } = new ConInfo();
        [OtherNames("schema")]
        public string SchemaName { get; set; }
        [OtherNames("sha")]
        public string Sha { get; set; }

        public object Clone() {
            return new AdapterConfig() {
                AdapterKey = this.AdapterKey,
                ConnectionKey = this.ConnectionKey,
                ConnectionString = this.ConnectionString,
                DBName = this.DBName,
                DBType = this.DBType,
                ConnectionInfo = this.ConnectionInfo?.Clone() as ConInfo,
                SchemaName = this.SchemaName,  
                Sha = this.Sha
            };
        }

        public IAdapterConfig Update(IAdapterConfig entry) {
            //It is intentional not to update the ConnetionKey and AdapterKey.

            DBName = entry.DBName;
            ConnectionString = entry.ConnectionString;
            DBType = entry.DBType;
            ConnectionInfo = entry.ConnectionInfo?.Clone() as ConInfo;
            SchemaName = entry.SchemaName;  
            Sha = entry.Sha;
            return this;
        }
    }
}
