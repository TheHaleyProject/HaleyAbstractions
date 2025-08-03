namespace Haley.Enums {
    public enum OSSParseMode {
       Parse =0, //Only try to parse the input
       Generate = 1, //Ignore and directly try to force generate it regardless of the input
       ParseOrGenerate = 2// Try to parse, if it doesn't work, create it.
    }
}
