using System;
using Haley.Abstractions;

namespace Haley.Models {
    public sealed class APIGatewaySession : IAPIGatewaySession {
        public object? Token { get; set; }
        public DateTime? ExpiresAtUtc { get; set; }
        public double RefreshMinutesBeforeExpiry { get; set; } = 10;

        public APIGatewaySession() { }

        public APIGatewaySession(object? token, DateTime? expiresAtUtc, double refreshMinutesBeforeExpiry = 10) {
            Token = token;
            ExpiresAtUtc = expiresAtUtc;
            RefreshMinutesBeforeExpiry = refreshMinutesBeforeExpiry;
        }

        public bool HasToken() => Token != null;

        public bool IsExpiringSoon(DateTime utcNow) {
            //what if the sessoin is oAuth and it doesn't have expiry at all.. For instance, for a session to be active, it needs  may be only the key/pwd.. and then it will always be active.
            if (!ExpiresAtUtc.HasValue) return false; //Meaning, we dont have an expiry set, so, we give the benefit of doubt and say this doesn't expire.
            if (RefreshMinutesBeforeExpiry < 1) RefreshMinutesBeforeExpiry = 10;
           return (ExpiresAtUtc.Value - utcNow).TotalMinutes <= RefreshMinutesBeforeExpiry; //If it has an expiry then we 
        }
    }
}