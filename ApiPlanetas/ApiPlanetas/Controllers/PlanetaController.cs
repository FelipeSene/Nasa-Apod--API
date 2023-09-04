using ApiPlanetas.Models;
using ApiPlanetas.Repositorios;
using ApiPlanetas.Repositorios.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPlanetas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetaController : ControllerBase
    {
        private readonly IPlanetaRepositorio _planetaRepositorio;

        public PlanetaController(IPlanetaRepositorio planetaRepositorio)
        {
            _planetaRepositorio = planetaRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<PlanetaModel>>> BuscarTodosPlanetas()
        {
            List<PlanetaModel> planeta = await _planetaRepositorio.BuscarTodosPlanetas();
            return Ok(planeta);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<PlanetaModel>>> PlanetaPorId(int id)
        {
            PlanetaModel planeta = await _planetaRepositorio.PlanetaPorId(id);
            return Ok(planeta);
        }

        [HttpPost]
        public async Task<ActionResult<PlanetaModel>> Cadastrar([FromBody] PlanetaModel planetaModel)
        {
            PlanetaModel planeta = await _planetaRepositorio.Adicionar(planetaModel);
            return Ok(planeta);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PlanetaModel>> Atualizar([FromBody] PlanetaModel planetaModel, int id)
        {
            planetaModel.Id = id;
            PlanetaModel planeta = await _planetaRepositorio.Atualizar(planetaModel, id);
            return Ok(planeta);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PlanetaModel>> Apagar(int id)
        {
            bool apagado = await _planetaRepositorio.Apagar(id);
            return Ok(apagado);
        }

    }
}
