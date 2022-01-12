using LivrariaBoaLeitura.API.Context;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaBoaLeitura.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrariaController : ControllerBase
    {
        private readonly ToDoContext _context;

        public LivrariaController(ToDoContext context)
        {
            _context = context;
        }


    }
}
