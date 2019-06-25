using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neander.Instrucoes
{
    public class AND : Instrucoes
    {
        public AND()
        {
            @decimal = 80;
            end = true;
            mnemonico = "AND";
            Dado = 80;
        }

        public override void Run(int Index)
        {
            Maquina.Acumulador = Convert.ToByte(proximoByte(Index) & Maquina.Acumulador);
            Maquina.AcessosMemoria++;
            Maquina.ProximaInstrucao(Index);
            AtualizarInfos();
        }
    }
}
