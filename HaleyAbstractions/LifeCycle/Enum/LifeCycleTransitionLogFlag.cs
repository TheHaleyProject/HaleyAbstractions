using System;

namespace Haley.Enums {

    [Flags]
    public enum LifeCycleTransitionLogFlag {
        None = 0,
        IsSystem = 1 << 0, // 1  - transition executed internally
        IsManual = 1 << 1, // 2  - performed by user
        IsRetry = 1 << 2, // 4  - retried after failure
        IsRollback = 1 << 3, // 8  - rollback action
        IsError = 1 << 4  // 16 - transition resulted in error
    }
}
