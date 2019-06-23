using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neander.Instrucoes
{
    public class HLT : Instrucoes
    {
        public HLT()
        {
            @decimal = 240;
            end = false;
            mnemonico = "HTL";
            Dado = 240;
        }
        public override void Run(int Index)
        {
            ///Basta não fazer nada 
        }
    }
}
