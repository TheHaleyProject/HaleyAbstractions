using Haley.Abstractions;
using Haley.Enums;
using System;

namespace Haley.Models {
    public sealed class GatewayNotifyRequest {
        public string GatewayKey { get; set; } = "";
        public GatewayNotifyReason Reason { get; set; }
        public string? Message { get; set; }
        public DateTime UtcNow { get; set; }
        public IAPIGateway? Gateway { get; set; } // optional for richer context
    }
}