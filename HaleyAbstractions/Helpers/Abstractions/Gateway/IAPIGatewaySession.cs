using System;

namespace Haley.Abstractions {
    public interface IAPIGatewaySession {
        object? Token { get; set; }
        DateTime? ExpiresAtUtc { get; set; }
        double RefreshMinutesBeforeExpiry { get; set; }
        bool HasToken();
        bool IsExpiringSoon(DateTime utcNow);
    }
}
