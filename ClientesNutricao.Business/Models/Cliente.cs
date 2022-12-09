using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesNutricao.Business.Models
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }

        public decimal Altura { get; set; }

        public decimal Peso { get; set; }

        public DateTime DataNascimento { get; set; }

    }
}
