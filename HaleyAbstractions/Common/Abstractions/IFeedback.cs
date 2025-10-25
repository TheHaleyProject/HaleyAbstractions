using System;
using System.Data.SqlTypes;
using System.Net;

namespace Haley.Abstractions {
    public interface IFeedback : IFeedback<object> {
       
    }

    public interface IFeedback<T>  {
        bool Status { get; set; }
        string Message { get; set; }
        T Result { get; set; }
    }

    public interface IWebFeedback : IFeedback<object> { 
        HttpStatusCode StatusCode { get; set; }
    }
}
