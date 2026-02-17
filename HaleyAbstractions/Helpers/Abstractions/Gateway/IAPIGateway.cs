using System.Threading.Tasks;

namespace Haley.Abstractions {
    public interface IAPIGateway {
        public IAPIGatewaySession? Session { get; set; }
        public Task<bool> HasValidSession();
    }
}