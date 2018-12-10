using System.Threading.Tasks;

namespace Chatty.Hubs.Interfaces
{
    public interface IChatClient
    {
        Task ReceiveMessage(string user, string message);
        Task ReceiveMessage(string message);
    }
}
