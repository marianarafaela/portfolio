using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Domains;
using Backend.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    // Definimos nossa rota do controller e dizemos que é um controller de API
    [Route("api/[controller]")]
    [ApiController]
    public class PresencaController : ControllerBase
    {
        // GufosContext _contexto = new GufosContext();

        PresencaRepository _repositorio = new PresencaRepository();

        // GET : api/Presenca
        [HttpGet]
        public async Task<ActionResult<List<Presenca>>> Get(){

            var categorias = await _repositorio.Listar();

            if(categorias == null){
                return NotFound();
            }

            return categorias;

        }

        // GET : api/Presenca2
        [HttpGet("{id}")]
        public async Task<ActionResult<Presenca>> Get(int id){

            // FindAsync = procura algo específico no banco
            var categoria = await _repositorio.BuscarPorId(id);

            if(categoria == null){
                return NotFound();
            }

            return categoria;

        }

        // POST api/Presenca
        [HttpPost]
        public async Task<ActionResult<Presenca>> Post(Presenca categoria){

            try
            {
                await _repositorio.Salvar(categoria);
            }
            catch (DbUpdateConcurrencyException)
            {
                
                throw;
            }

            return categoria;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Presenca categoria){
            // Se o id do objeto não existir, ele retorna erro 400
            if(id != categoria.PresencaId){
                return BadRequest();
            }
            
            

            try
            {

                await _repositorio.Alterar(categoria);
            }
            catch (DbUpdateConcurrencyException)
            {
                // Verificamos se o objeto inserido realmente existe no banco
                var categoria_valido = await _repositorio.BuscarPorId(id);

                if(categoria_valido == null){
                    return NotFound();
                }else{

                throw;
                }

                
            }
            // NoContent = retorna 204, sem nada
            return NoContent();
        }

        // DELETE api/categoria/id
        [HttpDelete("{id}")]
        public async Task<ActionResult<Presenca>> Delete(int id){
            var categoria = await _repositorio.BuscarPorId(id);
            if(categoria == null){
                return NotFound();
            }
            await _repositorio.Excluir(categoria);
            
            return categoria;
        }
    }
}