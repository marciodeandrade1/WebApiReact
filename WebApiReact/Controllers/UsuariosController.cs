using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiReact.Models;
using WebApiReact.Repository;

namespace WebApiReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            return Ok(await _usuarioRepository.GetUsuarios());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _usuarioRepository.GetUsuario(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> AddUsuario(Usuario usuario)
        {
            var createdUsuario = await _usuarioRepository.AddUsuario(usuario);
            return CreatedAtAction(nameof(GetUsuario), new { id = createdUsuario.Id }, createdUsuario);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Usuario>> UpdateUsario(int id, Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return BadRequest();
            }
            await _usuarioRepository.UpdateUsuario(usuario);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            await _usuarioRepository.DeleteUsuario(id);
            return NoContent();
        }
    }
}
