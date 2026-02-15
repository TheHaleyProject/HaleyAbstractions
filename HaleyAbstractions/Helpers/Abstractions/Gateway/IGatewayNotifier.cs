using Haley.Models;
using System.Threading.Tasks;

namespace Haley.Abstractions {
    /// <summary>
    /// Implement this to send Email / WhatsApp / Push / Slack, etc.
    /// </summary>
    public interface IGatewayNotifier {
        Task NotifyAsync(GatewayNotifyRequest request);
    }
}
