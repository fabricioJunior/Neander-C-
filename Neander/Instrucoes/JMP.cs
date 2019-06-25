using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neander.Instrucoes
{
    public class JMP : Instrucoes
    {
        public JMP()
        {
            @decimal = 128;
            end = true;
            mnemonico = "JMP";
            Dado = 128;

        }
        public override void Run(int Index)
        {
           Maquina.AcessosMemoria++;
           Maquina.ProximaInstrucao(proximoByte(Index) - 2);
        }
    }
}
