namespace Haley.Enums {
    public enum OSSControlMode {
       None =0, //Not controlled
       Number = 1,
       Guid = 2, //It also depends on another property, IsForcedHash. If an item is forced hash, regardles of what value you provide, the system will try to create a hash (even if you give a guid).
       Both = 3 //Accepts both formats. Now, initially it will try to parse the input. If it doesn't match, it will then for hash, it will create. For numbers, throw error. 
       //Any = 4 //Should never use this. It will first try to parse as number and then as guid, and if nothing works saves as is.. But this should not be allowed.
    }
}
