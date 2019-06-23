using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neander.Instrucoes
{
    public class JZ : Instrucoes
    {
        public JZ()
        {
            @decimal = 160;
            end = true;
            mnemonico = "JZ";
            Dado = @decimal;
        }
        public override void Run(int Index)
        {
            if (Maquina.Acumulador == 00)
            {
                Maquina.ProximaInstrucao(proximoByte(Index) - 1);
            }
        }
    }
}
