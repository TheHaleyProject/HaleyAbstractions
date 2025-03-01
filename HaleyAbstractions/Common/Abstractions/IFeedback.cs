namespace Haley.Abstractions {
    public interface IFeedback {
        bool Status { get; set; }
        string Message { get; set; }
        object Result { get; set; }
    }
}
