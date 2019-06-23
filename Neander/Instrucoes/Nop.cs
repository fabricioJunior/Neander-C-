using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neander.Instrucoes
{
    public class NOP : Instrucoes
    {
        public NOP()
        {
            @decimal = 0;
            end = false;
            mnemonico = "NOP";
        }
        public override void Run(int Index)
        {
            AtualizarInfos();
            Maquina.ProximaInstrucao(Index);
        }
    }
}
