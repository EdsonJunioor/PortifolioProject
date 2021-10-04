using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortifolioAPI.Models;

namespace PortifolioAPI.Data
{
    public interface IRepository
    {
        // CRUD GERAL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        // FIND USUARIO
        Task<Usuario[]> FindAllUsuarioAsync();
        Task<Usuario> FindUsuarioByIdAsync(int id);

        // FIND LOGIN
        Task<Login> FindLoginByEmail(string email);

        // FIND ESCOLARDADE
        Task<Escolaridade> FindEscolaridadeById(int id);

        // FIND EXPERIENCIA PROFISSIONAL
        Task<ExperienciaProfissional[]> FindAllExperiencia();
        Task<ExperienciaProfissional> FindExperienciaById(int id);

        // FIND QUALIFACAÇÕES
        Task<Qualificacao[]> FindAllQualificacao();
        Task<Qualificacao> FindQualificacaoById(int id);
    }
}
