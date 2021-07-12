using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Pessoa : IPessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
    }
}
