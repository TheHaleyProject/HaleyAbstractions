namespace Haley.Abstractions {
    public interface IObjectCreateResponse {
        bool Status { get; set; }
        string SavedName { get; set; } //We are not going to show this anymore.. not required for user to know
        string RawName { get; set; }
        string Message { get; set; }
        long Size { get; set; }
        bool ObjectExists { get; set; }
    }
}
