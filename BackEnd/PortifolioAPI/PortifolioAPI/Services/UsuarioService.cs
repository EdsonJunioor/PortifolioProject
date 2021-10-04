using Microsoft.AspNetCore.Mvc;
using PortifolioAPI.Data;
using PortifolioAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortifolioAPI.Services
{
    public class UsuarioService
    {
        private readonly IRepository usuarioRepository;

        //public async Task<Usuario> UsuarioById(int id)
        //{
        //    try
        //    {
        //        var result = await this.usuarioRepository.FindUsuarioByIdAsync(id);
        //        if (result != null)
        //        {
        //            return result;
        //        }
        //        else
        //        {
        //            throw new Exception("Usuário não encontrado");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Exception($"Usuário não encontrado: {ex}");
        //    }
        //}
    }
}
