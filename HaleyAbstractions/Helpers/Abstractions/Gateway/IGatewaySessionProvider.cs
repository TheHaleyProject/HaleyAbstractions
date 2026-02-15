using Haley.Enums;
using Haley.Models;
using Haley.Services;
using System;
using System.Threading.Tasks;

namespace Haley.Abstractions {
    public interface IGatewaySessionProvider {
        /// <summary>
        /// Pure read: try load current session from DB/cache (no side effects ideally).
        /// </summary>
        Task<IAPIGatewaySession?> TryLoadAsync(IAPIGateway gateway, DateTime utcNow);

        /// <summary>
        /// Ensure a usable session.
        /// If it can refresh automatically, do it and return Refreshed.
        /// If it needs user action, return RequiresUserAction.
        /// </summary>
        Task<GatewaySessionResult> EnsureAsync(IAPIGateway gateway, DateTime utcNow);

        /// <summary>
        /// Called for proactive reminders (can be no-op if not needed).
        /// </summary>
        Task NotifyAsync(IAPIGateway gateway, GatewayNotifyReason reason, string? message, DateTime utcNow);
    }
}
