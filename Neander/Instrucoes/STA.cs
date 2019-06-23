using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neander.Instrucoes
{
    public class STA : Instrucoes
    {
        public STA()
        {
            @decimal = 16;
            end = true;
            mnemonico = "STA";
            Dado = @decimal;
        }
        public override void Run(int Index)
        {
            AtualizarMemoria(proximoByte(Index));
            AtualizarInfos();
            Maquina.Acessos++;
            Maquina.ProximaInstrucao(Index);
            
        }
        /// <summary>
        /// Função para atualizar uma posição de memoria(valor) e verifica se  havera um novo comportamento em tal posição de memoria
        /// </summary>
        /// <param name="Valor"></param>
        private void AtualizarMemoria(byte Valor)
        {
            IInstrucoes source = Maquina.GetInstrucoes(Valor);
            if (Maquina.GetInstrucoes(Valor) is NOP)
            {
                Maquina.instrucoes[Valor] = new NOP() { Dado = Maquina.Acumulador };
            }
            else
            {
                Maquina.instrucoes[Valor] = source;
            }
        }
    }
}
