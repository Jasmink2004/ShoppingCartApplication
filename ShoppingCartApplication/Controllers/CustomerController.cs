using Microsoft.AspNetCore.Mvc;
using ECommerceApp.Services;
namespace ECommerceApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IEmailService _emailService;
        public CustomerController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpPost("SendTestEmail")]
        public IActionResult SendTestEmail(string to, string subject, string body)
        {
            _emailService.SendEmail(to, subject, body);
            return Ok("Test email sent.");
        }
    }
}
