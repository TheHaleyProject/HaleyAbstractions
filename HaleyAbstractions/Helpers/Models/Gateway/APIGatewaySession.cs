using System;
using Haley.Abstractions;

namespace Haley.Models {
    public sealed class APIGatewaySession : IAPIGatewaySession {
        public IAPIGatewayToken? Token { get; set; }
        public DateTime? ExpiresAtUtc { get; set; }
        public double RefreshMinutesBeforeExpiry { get; set; } = 10;

        public APIGatewaySession() { }

        public APIGatewaySession(IAPIGatewayToken? token, DateTime? expiresAtUtc, double refreshMinutesBeforeExpiry = 10) {
            Token = token;
            ExpiresAtUtc = expiresAtUtc;
            RefreshMinutesBeforeExpiry = refreshMinutesBeforeExpiry;
        }

        public bool HasToken() => Token != null;

        public bool IsExpiringSoon(DateTime utcNow)
            => !ExpiresAtUtc.HasValue
               || (ExpiresAtUtc.Value - utcNow).TotalMinutes <= RefreshMinutesBeforeExpiry;
    }
}