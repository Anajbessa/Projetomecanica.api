using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projetomecanica.api.Data;
using Projetomecanica.api.Models;

namespace Projetomecanica.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext _context;
        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }
        //login
        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            var user = _context.Usuarios.FirstOrDefault(u => u.usuario == usuario.usuario && u.Senha == usuario.Senha);
            if (user == null)
            {
                return Unauthorized("Usuario ou senha invalida");
            }
            return Ok(new {Nome = user.Nome});
        }
    }
}
