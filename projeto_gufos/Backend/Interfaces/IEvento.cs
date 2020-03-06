using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Domains;

namespace Backend.Interfaces
{
    public interface IEvento
    {
         Task<List<Evento>> Listar();

         Task<Evento> BuscarPorId(int id);
         
         Task<Evento> Salvar(Evento evento);

         Task<Evento> Alterar(Evento evento);

         Task<Evento> Excluir(Evento evento);
    }
}