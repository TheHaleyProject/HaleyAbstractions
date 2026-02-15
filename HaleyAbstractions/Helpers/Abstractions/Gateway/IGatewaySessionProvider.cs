using Haley.Enums;
using Haley.Models;
using Haley.Services;
using System;
using System.Threading.Tasks;

namespace Haley.Abstractions {
    //May be we might have a central session provider, which can be used by all gateways. Or we can have individual session providers for each gateway. It depends on the use case and design preferences. For now, let's define an interface for a gateway session provider that can be implemented as needed. This is the reason why each method has the gateway as a parameter, so that the provider can decide how to handle sessions for different gateways if needed.
    public interface IGatewaySessionProvider {
        /// <summary>
        /// Pure read: try load current session from DB/cache (no side effects ideally).
        /// </summary>
        Task<IAPIGatewaySession?> TryLoadAsync(IAPIGateway gateway);

        /// <summary>
        /// Ensure a usable session.
        /// If it can refresh automatically, do it and return Refreshed.
        /// If it needs user action, return RequiresUserAction.
        /// </summary>
        Task<GatewaySessionResult> EnsureAsync(IAPIGateway gateway);

        /// <summary>
        /// Called for proactive reminders (can be no-op if not needed).
        /// </summary>
        Task NotifyAsync(IAPIGateway gateway,GatewayNotifyReason reason, string? message);
    }
}
