using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRServer.Hubs
{
    public class CreateCubeHub : Hub
    {
        public void CreateCube()
        {
            Clients.All.create("Cube");
        }
    }
}