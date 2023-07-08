using Microsoft.AspNetCore.SignalR;

namespace WebRTC.Hubs
{
    public class SignalingServerHub : Hub
    {
        public async Task CallerRequest(object request)
        {
            await Clients.Others.SendAsync("CallerRequest", request);
        }

        public async Task CalleeAnswer(object answer)
        {
            await Clients.Others.SendAsync("CalleeAnswer", answer);
        }
    }
}
