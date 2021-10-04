using Microsoft.AspNetCore.Mvc;
using PortifolioAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortifolioAPI.Models;

namespace PortifolioAPI.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : Controller
    {
        private readonly IRepository usuarioRepository;

        public UsuarioController(IRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsuario()
        {
            var result = await this.usuarioRepository.FindAllUsuarioAsync();

            return Ok(result);
        }

        [HttpGet, Route("{id}")]
        public async Task<IActionResult> UsuarioById(int id)
        {
            try
            {
                var result = await this.usuarioRepository.FindUsuarioByIdAsync(id);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound($"Erro: Usuario não encontrado.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro:{ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] Usuario usuarioModel)
        {
            try
            {
                this.usuarioRepository.Add(usuarioModel);

                if (await this.usuarioRepository.SaveChangesAsync())
                {
                    return Ok(usuarioModel);
                }
                else
                {
                    return BadRequest("Erro ao salvar um usuario");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro:{ex.Message}");
            }
        }

        [HttpPut, Route("editar/{id}")]
        public async Task<IActionResult> EditarUsuario(int id, [FromBody]Usuario usuario)
        {
            try
            {
                var retorno = await usuarioRepository.FindUsuarioByIdAsync(id);

                if(retorno != null)
                {
                    usuarioRepository.Update(usuario);
                    await usuarioRepository.SaveChangesAsync();
                    return Ok("Usuario editado");
                }
                else
                {
                    return BadRequest("Erro ao editar o usuario");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro:{ex.Message}");
            }
        }

    }
}
