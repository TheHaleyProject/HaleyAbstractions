
using Haley.Enums;

namespace Haley.Models {
    public struct IOSSRoute {
        public string Key { get; }
        public string Path { get; private set; }
        public IOSSRoute SetPath(string path) {
            //This is a struct & thus a value type... Remember to replace where ever we use this method.
            //ALWAYS REMEMBER TO PUSH THE STRUCT BACK IN... 
            Path = path;
            return this;
        } //This 
       
        public bool CreateIfMissing { get; }
        public bool IsFile { get; set; }
        public IOSSRoute(string key, string path, bool isFile, bool createIfMissing) { Key = key; Path = path; CreateIfMissing = createIfMissing; IsFile = isFile;  }
    }
}
