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
            var result = await this.usuarioRepository.GetUsuarioAsyncById(id);

            return Ok(result);
        }
    }
}
