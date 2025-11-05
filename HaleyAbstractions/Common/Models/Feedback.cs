using Haley.Abstractions;
using Haley.Enums;
using System.Diagnostics;

namespace Haley.Models {

    public class Feedback : Feedback<object>, IFeedback {
        public Feedback Clear() {
            Status = false;
            Result = null;
            Message = string.Empty;
            Trace = string.Empty;
            return this;
        }
        public new IFeedback SetStatus(bool status) {
            base.SetStatus(status);
            return this;
        }
        public new IFeedback SetMessage(string message) {
            base.SetMessage(message);
            return this;
        }
        public new IFeedback SetTrace(string trace) {
            base.SetTrace(trace);
            return this;
        }
        public new IFeedback SetResult(object result) {
            base.SetResult(result);
            return this;
        }
        public new IFeedback Copy(IFeedback source) {
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
        public string Trace { get; set; }
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
        public virtual IFeedback<T> SetStatus(bool status) {
            Status = status;
            return this;
        }
        public virtual IFeedback<T> SetMessage(string message) {
            Message = message;
            return this;
        }
        public virtual IFeedback<T> SetTrace(string trace) {
            this.Trace = trace;
            return this;
        }
        public virtual IFeedback<T> Copy(IFeedback<T> source) {
            Status = source.Status;
            Message = source.Message;
            Trace = source.Trace;
            Result = source.Result;
            return this;
        }
        public virtual IFeedback<T> Copy(IFeedback source) {
            Status = source.Status;
            Message = source.Message;
            Trace = source.Trace;
            return this;
        }
        public virtual IFeedback<T> SetResult(T result) {
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
