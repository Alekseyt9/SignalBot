using Microsoft.AspNetCore.Mvc;
using SignalBot_NetCore.Services;

namespace SignalBot_NetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelegramController : ControllerBase
    {
        TelegramService _svc;

        public TelegramController(TelegramService svc)
        {
            _svc = svc;
        }

        [HttpGet(Name = "SendMessage")]
        public async Task<string> GetAsync(string msg)
        {
            await _svc.SendMessageAsync(msg);
            return $"Message sended: {msg}.";
        }

    }
}
