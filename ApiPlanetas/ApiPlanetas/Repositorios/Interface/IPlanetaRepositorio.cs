using ApiPlanetas.Models;

namespace ApiPlanetas.Repositorios.Interface
{
    public interface IPlanetaRepositorio
    {
        Task<List<PlanetaModel>> BuscarTodosPlanetas();

        Task<PlanetaModel> PlanetaPorId(int id);

        Task<PlanetaModel> Adicionar(PlanetaModel planeta);

        Task<PlanetaModel> Atualizar(PlanetaModel planeta, int id);

        Task<bool> Apagar(int id);
    }
}
