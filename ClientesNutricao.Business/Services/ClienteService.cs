using ClientesNutricao.Business.Interfaces;
using ClientesNutricao.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientesNutricao.Business.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task Adicionar(Cliente cliente)
        {
            await _clienteRepository.Adicionar(cliente);
        }

        public async Task Atualizar(Cliente cliente)
        {
            await _clienteRepository.Atualizar(cliente);
        }

        public async Task<Cliente> ObterPorId(Guid id)
        {
            return await _clienteRepository.ObterPorId(id); 
        }

        public async Task<List<Cliente>> ObterTodos()
        {
            return await _clienteRepository.ObterTodos();   
        }

        public async Task Remover(Guid id)
        {
            await _clienteRepository.Remover(id);   
        }
    }
}
