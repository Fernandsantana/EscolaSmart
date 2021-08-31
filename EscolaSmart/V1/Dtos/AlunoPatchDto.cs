using EscolaSmart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaSmart.V1.Dtos
{
    public class AlunoPatchDto
    {
        public int Id { get; set; }        

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Telefone { get; set; }

        public bool Status { get; set; }
    }
}
