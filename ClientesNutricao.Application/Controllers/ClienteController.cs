using ClientesNutricao.Application.Models;
using ClientesNutricao.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientesNutricao.Application.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public async Task<IActionResult> Index()
        {
            var clientesBusiness = await _clienteService.ObterTodos();

            List<Cliente> clientes = new List<Cliente>();

            foreach (var clienteBusiness in clientesBusiness)
            {
                Cliente cliente = new Cliente
                {
                    Id = clienteBusiness.Id,
                    Nome = clienteBusiness.Nome,
                    Altura = clienteBusiness.Altura,
                    Peso = clienteBusiness.Peso,
                    DataNascimento = clienteBusiness.DataNascimento,
                    
                };

                var dataNascimento = DateTime.Parse(clienteBusiness.DataNascimento.ToShortDateString());

                var dataAtual = DateTime.Parse(DateTime.Now.ToShortDateString());

                cliente.Idade = dataAtual.Year - dataNascimento.Year;
                                
                var imc = (clienteBusiness.Peso / (clienteBusiness.Altura * clienteBusiness.Altura));

                if (imc < 18.5m)
                {
                    cliente.Classificacao = "Magreza";
                }

                else if((imc >= 18.5m) && (imc <= 24.5m) )
                {
                    cliente.Classificacao = "Normal";
                }

                else if ((imc >= 25.0m) && (imc <= 29.9m))
                {
                    cliente.Classificacao = "Sobrepeso";
                }

                else if((imc >= 30.0m) && (imc <= 39.9m))
                {
                    cliente.Classificacao = "Obesidade";
                }

                else if(imc > 40.0m)
                {
                    cliente.Classificacao = "Obesidade Grave";
                }

                clientes.Add(cliente);
            }
       
            return View(clientes);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View(new Cliente());
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(Cliente cliente)
        {
            var clienteBusiness = new Business.Models.Cliente
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Altura = cliente.Altura,
                Peso = cliente.Peso,
                DataNascimento = cliente.DataNascimento
            };

            await _clienteService.Adicionar(clienteBusiness);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Atualizar(Guid id)
        {
            var clienteBusiness = await _clienteService.ObterPorId(id);

            Cliente cliente = new Cliente
            {
                Id = clienteBusiness.Id,
                Nome = clienteBusiness.Nome,
                Altura = clienteBusiness.Altura,
                Peso = clienteBusiness.Peso,
                DataNascimento = clienteBusiness.DataNascimento
            };

            return View(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Atualizar(Cliente cliente)
        {
            var clienteBusiness = new Business.Models.Cliente
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Altura = cliente.Altura,
                Peso = cliente.Peso,
                DataNascimento = cliente.DataNascimento
            };

            await _clienteService.Atualizar(clienteBusiness);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Remover(Guid id)
        {
            await _clienteService.Remover(id);

            return RedirectToAction("Index");
        }

    }
}
