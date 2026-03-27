using System;
using System.Threading;
using System.Threading.Tasks;

namespace Haley.Abstractions {
    /// <summary>
    /// Represents a one-shot receipt that completes when an event handler calls TryComplete,
    /// or is cancelled when the timeout elapses or Dispose is called.
    /// </summary>
    public interface IReceiptToken<T> : IDisposable {
        /// <summary>
        /// Awaits the result produced by the event handler.
        /// Throws OperationCanceledException if the timeout elapses before the handler fires.
        /// </summary>
        Task<T> WaitAsync(CancellationToken ct = default);

        /// <summary>
        /// True once the receipt has been completed (successfully or cancelled).
        /// </summary>
        bool IsCompleted { get; }
    }
}
