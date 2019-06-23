using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neander.Instrucoes
{   
    /// <summary>
    /// Classe modelo para os Mnemonicos 
    /// </summary>
    public abstract class Instrucoes : IInstrucoes, IEquatable<Instrucoes>
    {  
        public byte Dado { get ; set ; }
        public byte IndiceNaMemoria { get ; set ; }
        /// <summary>
        /// Váriaveis de armazenamento e manipulação interna 
        /// </summary>
        protected byte @decimal { get; set; }
        protected bool end { get; set; }
        protected string mnemonico { get; set; }
       
        protected byte proximoByte(int index)
        {
            if (Maquina.instrucoes.Count > index+1)
            {
                Maquina.Acessos++;
                return Maquina.instrucoes[index + 1].Dado;
            }
            return 0;
        }
        /// <summary>
        /// Váriaveis e método do contrato com IInstruções 
        /// </summary>
        byte IInstrucoes.Decimal { get => @decimal; set => @decimal = value; }
        bool IInstrucoes.Endereco => end;
        string IInstrucoes.Mnemonico => mnemonico;
        public IInstrucoes Clone()
        {
            return (IInstrucoes)MemberwiseClone();
        }
        public virtual void Run(int Index)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Função que atualiza as váriaveis de informação da maquina 
        /// </summary>
        protected void AtualizarInfos()
        {
            Maquina.instrucoesCount += Convert.ToInt32((Dado == 0));
            Maquina.Acessos++;
        }
        /// <summary>
        /// Função auxiliares(Orientação a objetos)
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return Equals(obj as Instrucoes);
        }
        public bool Equals(Instrucoes other)
        {
            return other != null &&
                   mnemonico == other.mnemonico;
        }
        public override int GetHashCode()
        {
            return -1067604422 + EqualityComparer<string>.Default.GetHashCode(mnemonico);
        }
    }
}
