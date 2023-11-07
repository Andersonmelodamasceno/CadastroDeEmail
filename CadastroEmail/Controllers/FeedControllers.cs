using Microsoft.AspNetCore.Mvc;

namespace CadastroEmail.Controllers
{
    [Route("api/mails")]
    [ApiController]
    public class FeedControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
