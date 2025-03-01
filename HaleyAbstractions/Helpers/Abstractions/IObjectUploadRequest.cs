using Haley.Enums;
using System;
using System.IO;

namespace Haley.Abstractions {
    public interface IObjectUploadRequest : IObjectReadRequest, ICloneable {
        int BufferSize { get; set; }
        Stream FileStream { get; set; }
        string RawName { get; set; }
        string Id { get; set; }
        ObjectExistsResolveMode ResolveMode { get; set; }
    }
}
