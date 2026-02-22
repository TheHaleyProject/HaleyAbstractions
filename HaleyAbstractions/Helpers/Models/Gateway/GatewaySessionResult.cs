using Haley.Abstractions;
using Haley.Enums;
using System;

namespace Haley.Services {
    public sealed class GatewaySessionResult {
        public GatewaySessionStatus Status { get; set; }
        public IAPIGatewaySession? Session { get; set; }
        public string? Message { get; set; }

        public static GatewaySessionResult Valid(IAPIGatewaySession s)
            => new GatewaySessionResult { Status = GatewaySessionStatus.Valid, Session = s };

        public static GatewaySessionResult ExpiringSoon(IAPIGatewaySession s, string? msg = null)
            => new GatewaySessionResult { Status = GatewaySessionStatus.ExpiringSoon, Session = s, Message = msg };

        public static GatewaySessionResult Refreshed(IAPIGatewaySession s, string? msg = null)
            => new GatewaySessionResult { Status = GatewaySessionStatus.Refreshed, Session = s, Message = msg };

        public static GatewaySessionResult RequiresUser(string? msg = null)
            => new GatewaySessionResult { Status = GatewaySessionStatus.RequiresUserAction, Message = msg };

        public static GatewaySessionResult Missing(string? msg = null)
            => new GatewaySessionResult { Status = GatewaySessionStatus.Missing, Message = msg };

        public static GatewaySessionResult Failed(string? msg = null)
            => new GatewaySessionResult { Status = GatewaySessionStatus.Failed, Message = msg };
        public static GatewaySessionResult NotInitiated(string? msg = null)
            => new GatewaySessionResult { Status = GatewaySessionStatus.NotInitiated, Message = msg };
    }
}