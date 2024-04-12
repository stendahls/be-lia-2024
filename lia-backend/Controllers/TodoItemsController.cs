using Microsoft.AspNetCore.Mvc;

namespace lia_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoItemsController : Controller
    {
        public TodoItemsController()
        {
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return NotFound();
        }
    }
}
