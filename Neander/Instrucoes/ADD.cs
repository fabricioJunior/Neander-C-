﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neander.Instrucoes
{
    public class ADD : Instrucoes
    {
        public ADD()
        {
            @decimal = 48;
            end = true;
            mnemonico = "ADD";
            Dado = 48;
        }
        public override void Run(int Index)
        {
            Maquina.AcessosMemoria += 2;
          
            Maquina.Acumulador += Maquina.instrucoes[proximoByte(Index)].Dado;
            Maquina.ProximaInstrucao(Index);
           

        }
    }
}
