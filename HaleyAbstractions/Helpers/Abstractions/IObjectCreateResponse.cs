namespace Haley.Abstractions {
    public interface IObjectCreateResponse : IFeedback {
        string SavedName { get; set; } //We are not going to show this anymore.. not required for user to know
        string RawName { get; set; }
        long Size { get; set; }
        bool ObjectExists { get; set; }
    }
}
