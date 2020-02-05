using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO.Classes
{
    abstract class AbsCrud
    {
        ///Para as Classes
        public abstract bool Cadastrar();
        public abstract DataSet Consultar();
        public abstract bool Excluir();
        public abstract bool Alterar();
    }
}
