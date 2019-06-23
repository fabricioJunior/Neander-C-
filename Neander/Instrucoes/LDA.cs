using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neander.Instrucoes
{
    public class LDA : Instrucoes
    {
        public LDA()
        {
            @decimal = 32;
            end = true;
            mnemonico = "LDA";
            Dado = @decimal;
        }
        public override void Run(int Index)
        {
            Maquina.Acumulador = Maquina.instrucoes[proximoByte(Index)].Dado;
            Maquina.ProximaInstrucao(Index);
        }
    }
}
