using System;

namespace Haley.Enums {

    [Flags]
    public enum LifeCycleInstanceFlag {
        None = 0,
        IsActive = 1 << 0, // 1   - currently active instance
        IsSuspended = 1 << 1, // 2   - temporarily paused
        IsCompleted = 1 << 2, // 4   - fully completed
        IsFailed = 1 << 3, // 8   - ended in failure state
        IsArchived = 1 << 4  // 16  - archived for audit
    }
}