using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neander.Instrucoes
{
    public class HLT : Instrucoes
    {
        public HLT()
        {
            @decimal = 240;
            end = false;
            mnemonico = "HLT";
            Dado = 240;
        }
        public override void Run(int Index)
        {
            MessageBox.Show("FIM DA EXECUÇÃO");
            Maquina.PC = 255;
        }
    }
}
