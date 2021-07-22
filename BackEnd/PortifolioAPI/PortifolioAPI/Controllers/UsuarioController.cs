using Microsoft.AspNetCore.Mvc;
using PortifolioAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortifolioAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsuario()
        {
            var result = await this.usuarioRepository.GetAllUsuarioAsync();

            return Ok(result);
        }

        [HttpGet("UsuarioById/{id}")]
        public async Task<IActionResult> UsuarioById(int id)
        {
            try
            {
                var result = await this.usuarioRepository.GetUsuarioAsyncById(id);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound($"Erro: Usuario não encontrado.") ;
                }
            }
            catch(Exception ex)
            {
                return BadRequest($"Erro:{ex.Message}");
            }
        }
    }
}
