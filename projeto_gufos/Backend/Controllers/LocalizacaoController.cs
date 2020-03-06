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
    public class LocalizacaoController : ControllerBase
    {
        // GufosContext _contexto = new GufosContext();

        LocalizacaoRepository _repositorio = new LocalizacaoRepository();

        // GET : api/Localizacao
        [HttpGet]
        public async Task<ActionResult<List<Localizacao>>> Get(){

            var localizacaos = await _repositorio.Listar();

            if(localizacaos == null){
                return NotFound();
            }

            return localizacaos;

        }

        // GET : api/Localizacao2
        [HttpGet("{id}")]
        public async Task<ActionResult<Localizacao>> Get(int id){

            // FindAsync = procura algo específico no banco
            var localizacao = await _repositorio.BuscarPorId(id);

            if(localizacao == null){
                return NotFound();
            }

            return localizacao;

        }

        // POST api/Localizacao
        [HttpPost]
        public async Task<ActionResult<Localizacao>> Post(Localizacao localizacao){

            try
            {
                await _repositorio.Salvar(localizacao);
            }
            catch (DbUpdateConcurrencyException)
            {
                
                throw;
            }

            return localizacao;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Localizacao localizacao){
            // Se o id do objeto não existir, ele retorna erro 400
            if(id != localizacao.LocalizacaoId){
                return BadRequest();
            }
            
            

            try
            {

                await _repositorio.Alterar(localizacao);
            }
            catch (DbUpdateConcurrencyException)
            {
                // Verificamos se o objeto inserido realmente existe no banco
                var localizacao_valido = await _repositorio.BuscarPorId(id);

                if(localizacao_valido == null){
                    return NotFound();
                }else{

                throw;
                }

                
            }
            // NoContent = retorna 204, sem nada
            return NoContent();
        }

        // DELETE api/localizacao/id
        [HttpDelete("{id}")]
        public async Task<ActionResult<Localizacao>> Delete(int id){
            var localizacao = await _repositorio.BuscarPorId(id);
            if(localizacao == null){
                return NotFound();
            }
            await _repositorio.Excluir(localizacao);
            
            return localizacao;
        }
    }
}