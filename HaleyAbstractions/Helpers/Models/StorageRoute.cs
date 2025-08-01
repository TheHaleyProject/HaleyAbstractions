
using Haley.Enums;

namespace Haley.Models {
    public struct StorageRoute {
        public string Key { get; }
        public string Name { get; set; }
        public bool IsControlled { get; set; }
        public string Path { get; private set; }
        public StorageRoute SetPath(string path) {
            //This is a struct & thus a value type... Remember to replace where ever we use this method.
            //ALWAYS REMEMBER TO PUSH THE STRUCT BACK IN... 
            Path = path;
            return this;
        } //This 
        public StorageRoute SetType(StorageRouteType type) {
            Type = type;
            return this;
        }
        public StorageRoute SetIsControlled(bool iscontrolled) {
            IsControlled = iscontrolled;
            return this;
        } //This 
        public bool CreateIfMissing { get; }
        public StorageRouteType Type{ get; set; }
        public StorageRoute(string key, string path, StorageRouteType type, bool createIfMissing) { Key = key; Path = path; CreateIfMissing = createIfMissing; Type = type; Name = string.Empty; IsControlled = false; }
        public StorageRoute(string key,string name, bool iscontrolled, string path, StorageRouteType type, bool createIfMissing) { Key = key; Path = path; CreateIfMissing = createIfMissing; Type = type; Name = name; IsControlled = iscontrolled; }
    }
}
