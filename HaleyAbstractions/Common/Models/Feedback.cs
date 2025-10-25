using Haley.Abstractions;

namespace Haley.Models {

    public class Feedback : Feedback<object>, IFeedback {
        public Feedback Clear() {
            Status = false;
            Result = null;
            Message = string.Empty;
            return this;
        }

        public new Feedback SetStatus(bool status) {
            base.SetStatus(status);
            return this;
        }

        public new Feedback SetMessage(string message) {
            base.SetMessage(message);
            return this;
        }

        public new Feedback SetResult(object result) {
            base.SetResult(result);
            return this;
        }

        public new Feedback Copy(IFeedback source) {
            base.Copy(source);
            return this;
        }

        public Feedback() { }
        public Feedback(bool status, string message, object result) :base(status,message,result) { }
        public Feedback(string message, object result) : base(message, result) { }
        public Feedback(bool status) : base(status, null,null) { }
        public Feedback(bool status, string message) : base(status, message, null) { }
    }

    public class Feedback<T> : IFeedback<T> {
        public bool Status { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
        public override string ToString() {
            return $@"{Status} : {Message} -- {Result}";
        }
        public Feedback() { }
        public Feedback(bool status, string message, T result) {
            Status = status;
            Message = message;
            Result = result;
        }

        public virtual Feedback<T> SetStatus(bool status) {
            Status = status;
            return this;
        }

        public virtual Feedback<T> SetMessage(string message) {
            Message = message;
            return this;
        }

        public virtual Feedback<T> Copy(IFeedback<T> source) {
            Status = source.Status;
            Message = source.Message;
            Result = source.Result;
            return this;
        }


        public virtual Feedback<T> SetResult(T result) {
            Result = result;
            return this;
        }
        public Feedback(bool status) : this(status, null) { }
        public Feedback(bool status, string message) : this(status, message, default) { }
        public Feedback(string message, T result)  {
            Message = message;
            Result = result;
        }
    }
}
