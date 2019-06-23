using Neander.Instrucoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neander
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Maquina.instrucoesConhecidas = new List<Instrucoes.IInstrucoes>();
            Maquina.instrucoesConhecidas.Add(new ADD());//1 OK
            Maquina.instrucoesConhecidas.Add(new AND());//2 OK
            Maquina.instrucoesConhecidas.Add(new HLT());//3 OK
            Maquina.instrucoesConhecidas.Add(new JMP());//4 OK
            Maquina.instrucoesConhecidas.Add(new JN());//5 OK
            Maquina.instrucoesConhecidas.Add(new JZ());//6 OK
            Maquina.instrucoesConhecidas.Add(new LDA());//7 OK
            Maquina.instrucoesConhecidas.Add(new NOP());//8 OK
            Maquina.instrucoesConhecidas.Add(new NOT());//9 OK
            Maquina.instrucoesConhecidas.Add(new OR());//10 OK
            Maquina.instrucoesConhecidas.Add(new STA());//11 OK

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
