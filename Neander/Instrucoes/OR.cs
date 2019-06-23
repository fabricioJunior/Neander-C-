using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neander.Instrucoes
{
    public class OR : Instrucoes
    {
        public OR()
        {
            @decimal = 64;
            end = true;
            mnemonico = "OR";
            Dado = @decimal;
        }
        public override void Run(int Index)
        {
            Maquina.Acumulador = Convert.ToByte(proximoByte(Index) | Maquina.Acumulador);
            Maquina.Acessos++;
            Maquina.ProximaInstrucao(Index);
            AtualizarInfos();
        }
    }
}
