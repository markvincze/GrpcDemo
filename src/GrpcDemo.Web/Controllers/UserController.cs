using Microsoft.AspNetCore.Mvc;

namespace GrpcDemo.Web.Controllers
{
    [Route("users")]
    public class UserController : Controller
    {
        public IActionResult Get()
        {
            return Ok(
                new[]
                {
                    new
                    {
                        UserName = "jdoe",
                        Email = "jdoe@example.com"
                    },
                    new
                    {
                        UserName = "jsmith",
                        Email = "jsmith@example.com"
                    }
                });
        }
    }
}
