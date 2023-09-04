using ApiPlanetas.Data;
using ApiPlanetas.Models;
using ApiPlanetas.Repositorios.Interface;
using Microsoft.EntityFrameworkCore;

namespace ApiPlanetas.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaDBContex _dbContex;
        public UsuarioRepositorio(SistemaDBContex sistemaDBContex) 
        {
            _dbContex = sistemaDBContex;
        }
        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContex.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> BuscarPorId(int id)
        {
            return await _dbContex.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbContex.Usuarios.AddAsync(usuario);
            await _dbContex.SaveChangesAsync();

            return usuario;
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário para o ID; {id} não foi encontrado.");
            }

            usuarioPorId.Name = usuario.Name;
            usuarioPorId.Email = usuario.Email;

            _dbContex.Usuarios.Update(usuarioPorId);
            await _dbContex.SaveChangesAsync();

            return usuarioPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário para o ID; {id} não foi encontrado.");
            }

            _dbContex.Usuarios.Remove(usuarioPorId);
            await _dbContex.SaveChangesAsync();

            return true;
        }
    }
}
