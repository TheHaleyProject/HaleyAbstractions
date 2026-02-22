namespace Haley.Enums {
    public enum GatewaySessionStatus {
        Valid,              // session exists and is not expiring soon
        ExpiringSoon,       // session still valid, but near expiry (caller may proceed)
        Refreshed,          // session was refreshed/acquired automatically
        Missing,            // no session available (DB/cache empty)
        RequiresUserAction, // cannot be acquired automatically; human action needed
        Failed,              // unexpected failure (network/db/etc.)
        NotInitiated
    }
}
