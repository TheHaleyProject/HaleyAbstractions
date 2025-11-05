using Haley.Enums;
using Haley.Models;
using System;
using System.Data.SqlTypes;
using System.Net;

namespace Haley.Abstractions {
    public interface IFeedback : IFeedback<object> {
        new IFeedback SetStatus(bool status);
        new IFeedback SetMessage(string message);
        new IFeedback SetTrace(string trace);
        new IFeedback Copy(IFeedback source);
        new IFeedback SetResult(object result);
    }

    public interface IFeedback<T> : IFeedbackBase {
        T Result { get; set; }
        IFeedback<T> SetStatus(bool status);
        IFeedback<T> SetMessage(string message);
        IFeedback<T> SetTrace(string trace);
        IFeedback<T> Copy(IFeedback<T> source);
        IFeedback<T> Copy(IFeedback source);
        IFeedback<T> SetResult(T result);
    }

    public interface IFeedbackBase {
        bool Status { get; set; }
        string Trace { get; set; }
        string Message { get; set; }
    }

    public interface IWebFeedback : IFeedback<object> {
        HttpStatusCode StatusCode { get; set; }
    }
}
