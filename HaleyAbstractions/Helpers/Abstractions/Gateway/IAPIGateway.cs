using System.Threading.Tasks;

namespace Haley.Abstractions {
    public interface IAPIGateway<T> : IAPIGateway where T : IAPIGatewayInitArgs {
        new T Parameter { get; }
        Task UpdateParameter(T updated);
    }

    public interface IAPIGateway {
        public IAPIGatewaySession Session { get; set; }
        object Parameter { get; }
    }
}