using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoUsuarioController : ControllerBase
    {

        VallerContext _context = new VallerContext();

        [HttpGet]
        public async Task<ActionResult<List<TipoUsuario>>> Get() {

            var tipousuarios = await _context.TipoUsuario.ToListAsync();

            if(tipousuarios == null) {
                return NotFound();
            }
            return tipousuarios;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TipoUsuario>> Get(int id) {

            var tipousuario = await _context.TipoUsuario.FindAsync(id);

            if (tipousuario == null ) {
                return NotFound();
            }
            return tipousuario;
        }

        [HttpPost]
        public async Task<ActionResult<TipoUsuario>> Post(TipoUsuario tipousuario) {
            
            try {
                await _context.TipoUsuario.AddAsync(tipousuario);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                throw;
            }
            return tipousuario;
        }
        
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, TipoUsuario tipousuario){

            if(id != tipousuario.IdTipoUsuario) {
                return BadRequest();
            }

            _context.Entry(tipousuario).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                var tipousuario_valido = _context.TipoUsuario.FindAsync(id);
                if(tipousuario_valido == null) {
                    return NotFound();
                }
                else {
                    throw;
                }
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoUsuario>> Delete(int id){

            var tipousuario = await _context.TipoUsuario.FindAsync(id);
            
            if(tipousuario == null){
                return NotFound();
            }
            _context.TipoUsuario.remove(tipousuario);
            await _context.SaveChangesAsync();
            return tipousuario;
        }
    }
}