using System;

namespace ClientesNutricao.Application.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public decimal Altura { get; set; }

        public decimal Peso { get; set; }

        public DateTime DataNascimento { get; set; }

        public int Idade { get; set; }

        public string Classificacao { get; set; }
    }
}
