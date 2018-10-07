using Microsoft.AspNetCore.Antiforgery;
using EV.Controllers;

namespace EV.Web.Host.Controllers
{
    public class AntiForgeryController : EVControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
