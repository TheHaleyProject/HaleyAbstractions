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
        Task<IAPIGatewaySession?> TryLoadAsync();

        /// <summary>
        /// Ensure a usable session.
        /// If it can refresh automatically, do it and return Refreshed.
        /// If it needs user action, return RequiresUserAction.
        /// </summary>
        Task<GatewaySessionResult> EnsureAsync();

        /// <summary>
        /// Called for proactive reminders (can be no-op if not needed).
        /// </summary>
        Task NotifyAsync(GatewayNotifyReason reason, string? message);
    }
}
