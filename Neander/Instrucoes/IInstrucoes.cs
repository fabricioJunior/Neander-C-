using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neander.Instrucoes
{
    //Contrato para todos os Mnemônicos 
    public interface IInstrucoes
    {
        //Valor em decimal do Mnemônico
        byte Decimal { get; set; }
        //Dado em uma certa posição de memoria
        byte Dado { get; set; }
        //Indice na memoria de execução
        byte IndiceNaMemoria { get; set; }
        //Executa as instruções
        void Run(int Index);
        //Armazena o nome do Mnemonico
        string Mnemonico { get; }
        //Indica se o Mnemonico acessa alguma endereço
        bool Endereco { get; }
        //Retorna um objeto clone do atual
        IInstrucoes Clone();
    }
}
