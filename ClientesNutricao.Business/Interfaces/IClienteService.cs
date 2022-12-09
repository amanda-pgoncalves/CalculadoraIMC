using ClientesNutricao.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientesNutricao.Business.Interfaces
{
    public interface IClienteService
    {
        Task<List<Cliente>> ObterTodos();

        Task Atualizar(Cliente cliente);

        Task Remover(Guid id);

        Task Adicionar(Cliente cliente);

        Task<Cliente> ObterPorId(Guid id);
    }
}
