using ClientesNutricao.Business.Interfaces;
using ClientesNutricao.Business.Models;
using ClientesNutricao.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesNutricao.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(MyDbContext context) : base(context) { }
    }
}
