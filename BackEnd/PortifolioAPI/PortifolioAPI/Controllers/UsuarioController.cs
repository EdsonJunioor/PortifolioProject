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

        //[HttpGet]
        //public async Task<IActionResult> GetAllUsuario()
        //{
        //    var result = await this.usuarioRepository.GetAllUsuarioAsync();

        //    return Ok(result);
        //}

        //[HttpGet, Route("{id}")]
        //public async Task<IActionResult> UsuarioById(int id)
        //{
        //    try
        //    {
        //        var result = await this.usuarioRepository.GetUsuarioAsyncById(id);
        //        if (result != null)
        //        {
        //            return Ok(result);
        //        }
        //        else
        //        {
        //            return NotFound($"Erro: Usuario não encontrado.") ;
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        return BadRequest($"Erro:{ex.Message}");
        //    }
        //}

        //[HttpPost]
        //public async Task<IActionResult> Criar([FromBody]Usuario usuarioModel)
        //{
        //    try
        //    {
        //        this.usuarioRepository.Add(usuarioModel);

        //        if (await this.usuarioRepository.SaveChangesAsync())
        //        {
        //            return Ok(usuarioModel);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest($"Erro:{ex.Message}");
        //    }
        //    return BadRequest();
        //}
    }
}
