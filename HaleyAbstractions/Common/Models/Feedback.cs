using Haley.Abstractions;

namespace Haley.Models {
    public class Feedback : IFeedback {
        public bool Status { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }

        public Feedback SetStatus(bool status) {
            Status = status;
            return this;
        }

        public Feedback SetMessage(string message) {
            Message = message;
            return this;
        }

        public Feedback SetResult(object result) {
            Result = result;
            return this;
        }

        public Feedback Clear() {
            Status = false;
            Result = null;
            Message = string.Empty;
            return this;
        }

        public override string ToString() {
            return $@"{Status} : {Message} -- {Result}";
        }
        public Feedback() { }
        public Feedback(bool status, string message, object result) {
            Status = status;
            Message = message;
            Result = result;
        }
        public Feedback(bool status) : this(status, null, null) { }
        public Feedback(bool status, string message) : this(status, message, null) { }
    }
}
