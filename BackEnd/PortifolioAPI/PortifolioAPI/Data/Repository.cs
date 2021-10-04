using Microsoft.EntityFrameworkCore;
using PortifolioAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortifolioAPI.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
        // USUARIO
        public async Task<Usuario[]> FindAllUsuarioAsync()
        {
            IQueryable<Usuario> query = _context.Usuario;


            query = query.AsNoTracking()
                         .OrderBy(c => c.UsuarioId);

            return await query.ToArrayAsync();
        }
        public async Task<Usuario> FindUsuarioByIdAsync(int usuarioId)
        {
            IQueryable<Usuario> query = _context.Usuario;

            query = query.AsNoTracking()
                         .OrderBy(usuario => usuario.UsuarioId)
                         .Where(usuario => usuario.UsuarioId == usuarioId);

            return await query.FirstOrDefaultAsync();
        }
        // LOGIN
        public async Task<Login> FindLoginByEmail(string email)
        {
            IQueryable<Login> query = _context.Login;

            query = query.AsNoTracking()
                         .OrderBy(login => login.Email)
                         .Where(login => login.Email == email);

            return await query.FirstOrDefaultAsync();
        } 
        // ESCOLARIDADE
        public async Task<Escolaridade> FindEscolaridadeById(int id)
        {
            IQueryable<Escolaridade> query = _context.Escolaridade;

            query = query.AsNoTracking()
                         .OrderBy(escolaridade => escolaridade.UsuarioId)
                         .Where(escolaridade => escolaridade.UsuarioId == id);

            return await query.FirstOrDefaultAsync();
        }
        // EXPERIENCIA PROFISSIONAL
        public async Task<ExperienciaProfissional[]> FindAllExperiencia()
        {
            IQueryable<ExperienciaProfissional> query = _context.ExperienciaProfissional;


            query = query.AsNoTracking()
                         .OrderBy(e => e.UsuarioId);

            return await query.ToArrayAsync();
        }
        public async Task<ExperienciaProfissional> FindExperienciaById(int id)
        {
            IQueryable<ExperienciaProfissional> query = _context.ExperienciaProfissional;

            query = query.AsNoTracking()
                         .OrderBy(e => e.UsuarioId)
                         .Where(e => e.UsuarioId == id);

            return await query.FirstOrDefaultAsync();
        }
        // QUALIFICAÇÃO
        public async Task<Qualificacao[]> FindAllQualificacao()
        {
            IQueryable<Qualificacao> query = _context.Qualificacao;


            query = query.AsNoTracking()
                         .OrderBy(q => q.UsuarioId);

            return await query.ToArrayAsync();
        }
        public async Task<Qualificacao> FindQualificacaoById(int id)
        {
            IQueryable<Qualificacao> query = _context.Qualificacao;

            query = query.AsNoTracking()
                         .OrderBy(q => q.UsuarioId)
                         .Where(q => q.UsuarioId == id);

            return await query.FirstOrDefaultAsync();
        }
    }
}
