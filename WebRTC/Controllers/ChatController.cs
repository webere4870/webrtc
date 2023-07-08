using Microsoft.AspNetCore.Mvc;

namespace WebRTC.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Call()
        {
            return View();
        }

        public IActionResult Receive()
        {
            return View();
        }
    }
}
