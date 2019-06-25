using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neander.Instrucoes
{
    public class NOT : Instrucoes
    {
        public NOT()
        {
            @decimal = 96;
            end = false;
            mnemonico = "NOT";
            Dado = @decimal;
        }
        public override void Run(int Index)
        {   
             
            Maquina.Acumulador = Convert.ToByte(255 -  Maquina.Acumulador);
            Maquina.Negativo = true;
            Maquina.ProximaInstrucao(Index,true);
            AtualizarInfos();
        }
       
    }
}
