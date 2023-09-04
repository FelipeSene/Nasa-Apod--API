using ApiPlanetas.Data;
using ApiPlanetas.Models;
using ApiPlanetas.Repositorios.Interface;
using Microsoft.EntityFrameworkCore;

namespace ApiPlanetas.Repositorios
{
    public class PlanetaRepositorio : IPlanetaRepositorio
    {
        private readonly SistemaDBContex _dbContex;
        public PlanetaRepositorio(SistemaDBContex sistemaDBContex)
        {
            _dbContex = sistemaDBContex;
        }
        public async Task<List<PlanetaModel>> BuscarTodosPlanetas()
        {
            return await _dbContex.Planetas.ToListAsync();
        }

        public async Task<PlanetaModel> PlanetaPorId(int id)
        {
            return await _dbContex.Planetas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<PlanetaModel> Adicionar(PlanetaModel planeta)
        {
            await _dbContex.Planetas.AddAsync(planeta);
            await _dbContex.SaveChangesAsync();

            return planeta;
        }

        public async Task<PlanetaModel> Atualizar(PlanetaModel planeta, int id)
        {
            PlanetaModel planetaPorId = await PlanetaPorId(id);

            if (planetaPorId == null)
            {
                throw new Exception($"Planeta para o ID; {id} não foi encontrado.");
            }

            planetaPorId.Name = planeta.Name;
            planetaPorId.Classification = planeta.Classification;

            _dbContex.Planetas.Update(planetaPorId);
            await _dbContex.SaveChangesAsync();

            return planetaPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            PlanetaModel planetaPorId = await PlanetaPorId(id);

            if (planetaPorId == null)
            {
                throw new Exception($"Planeta para o ID; {id} não foi encontrado.");
            }

            _dbContex.Planetas.Remove(planetaPorId);
            await _dbContex.SaveChangesAsync();

            return true;
        }
    }
}
