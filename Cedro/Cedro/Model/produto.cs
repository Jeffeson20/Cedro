using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cedro.Model
{
    interface Operacao
    {
        List<Computadores> PegaProdutos();

        void AdicionaProduto(Computadores produto);

        void EditaProduto(Computadores produto);

        void ExcluiProduto(int id);

        void DetalhaProduto(int id);

        void CompraProduto(int id);

    }
}
