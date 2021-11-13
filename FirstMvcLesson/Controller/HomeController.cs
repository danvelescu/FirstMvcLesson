using FirstMvcLesson.Model;
using FirstMvcLesson.Repos;
using Microsoft.AspNetCore.Mvc;

namespace FirstMvcLesson.Controller
{
    [ApiController]
    [Route("api")]
    public class HomeController : ControllerBase
    {
        [HttpGet("phones")]
        public ActionResult<List<Phone>> getPhones()
        {
            var phones = PhoneRepository.PhoneRepositoryGetPhones();
            return phones;
        }
    }
}
