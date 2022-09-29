using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PessoaService
    {
        public bool Insert(Pessoa pessoa)
        {
            return new PessoaRepository().Insert(pessoa);
        }

    }
}
