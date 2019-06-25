using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neander.Instrucoes;
using System.Windows.Forms;
namespace Neander
{
    public static class Maquina
    {  
        /// <summary>
        /// Lista que armazena instruções que serão executadas 
        /// </summary>
        public static List<IInstrucoes> instrucoes;
        /// <summary>
        /// Lista que armazena instruções conhecidas pela maquina 
        /// </summary>
        public static List<IInstrucoes> instrucoesConhecidas;
        /// <summary>
        /// Ponteiros da maquina 
        /// </summary>
        public static byte Acumulador;
        public static bool Negativo;
        public static int instrucoesCount;
        public static int AcessosMemoria;//Acessos a memoria
        public static int PC;
        /// <summary>
        /// Método de controle de execução de comandos 
        /// </summary>
        /// <param name="index"></param>
        public static void ProximaInstrucao(int index, bool n = false) {

            PC = index + 1 + Convert.ToInt32(Maquina.instrucoes[PC].Endereco);
            if (!PassoaPasso)
            { 
                if (instrucoes.Count > PC)
                {
                    instrucoes[PC].Run(PC);
                }
                else
                {
                    MessageBox.Show("FIM DA EXECUÇÃO");
                }
            }
            if (!n)
            {
                Maquina.Negativo = false;
            }
        }
        /// <summary>
        /// Zera PC e o Acumulador 
        /// </summary>
        public static void Reset()
        {
            Acumulador = 0;
            Negativo = false;
         
            instrucoesCount = 0;
            AcessosMemoria = 0;
            PC = 0;
        }
        /// <summary>
        /// Retorna um mnemônico  a parti do seu código decimal 
        /// </summary>
        /// <param name="Decimal"></param>
        /// <returns></returns>
        public static IInstrucoes GetInstrucoes(byte Decimal)
        {
            IInstrucoes retorno;
            List<int> decimaisConhecidos = new List<int>();
            foreach (IInstrucoes instrucoes in Maquina.instrucoesConhecidas)
            {
                decimaisConhecidos.Add(instrucoes.Decimal);
            }
            if (Decimal == 0 || !decimaisConhecidos.Contains(Decimal))
            {
               retorno =  (new NOP() { Dado = Decimal });
            }
            else
            {
                var novoSource = from a in Maquina.instrucoesConhecidas where a.Decimal == Decimal select a;
                retorno = novoSource.ToList()[0].Clone();
            }
            return retorno;
        }
        /// <summary>
        /// Define o modo de execução 
        /// </summary>
        public static bool PassoaPasso = true;
    }
    /// <summary>
    /// Classe reposnável pela interpretação dos comandos
    /// </summary>
    public class Interpretador
    {
        public List<IInstrucoes> Instrucoes { get; private set; }
        public string Diretorio { get; set; }

        public void LerInstrucoes()
        {
            Instrucoes = new List<IInstrucoes>();
            if (Diretorio == null)
            {
                throw new ArgumentNullException("Informe o direitorio com o arquivo .mem");
            }
            List<int> decimaisConhecidos = new List<int>();
            foreach (IInstrucoes instrucoes in Maquina.instrucoesConhecidas)
            {
                decimaisConhecidos.Add(instrucoes.Decimal);
            }
            FileStream fileStream = new FileStream(Diretorio,FileMode.Open);
            byte[] memoria = ReadFully(fileStream,0);
            for (int x = 0, y = 0; x <= 255; x++, y++)
            {
                Instrucoes.Add(Maquina.GetInstrucoes(memoria[posicao(x)]));
   
            }
            fileStream.Close();
        }
        private int posicao(int xUser)
        {
            int viewer = 4 + (xUser * 2);
            return viewer;
        }
        /// <summary>
        /// Leitura dos bytes
        /// https://social.msdn.microsoft.com/Forums/en-US/ab831d92-14ad-437e-9b03-102d90f44d22/read-hex-data-from-binary-file?forum=csharpgeneral
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="initialLength"></param>
        /// <r
        /// eturns></returns>
        private byte[] ReadFully(Stream stream, int initialLength)
        {
            // If we've been passed an unhelpful initial length, just
            // use 32K.
            if (initialLength < 1)
            {
                initialLength = 32768;
            }

            byte[] buffer = new byte[initialLength];
            int read = 0;

            int chunk;
            while ((chunk = stream.Read(buffer, read, buffer.Length - read)) > 0)
            {
                read += chunk;

                // If we've reached the end of our buffer, check to see if there's
                // any more information
                if (read == buffer.Length)
                {
                    int nextByte = stream.ReadByte();

                    // End of stream? If so, we're done
                    if (nextByte == -1)
                    {
                        return buffer;
                    }

                    // Nope. Resize the buffer, put in the byte we've just
                    // read, and continue
                    byte[] newBuffer = new byte[buffer.Length * 2];
                    Array.Copy(buffer, newBuffer, buffer.Length);
                    newBuffer[read] = (byte)nextByte;
                    buffer = newBuffer;
                    read++;
                }
            }
            // Buffer is now too big. Shrink it.
            byte[] ret = new byte[read];
            Array.Copy(buffer, ret, read);
            return ret;
        }
    }
    /// <summary>
    /// Classe com métodos para fazer a montagem das instruções 
    /// </summary>
    public class Montador
    {
     
        private string[] Dados; 
        public string[] Mnemonicos { get; private set; }
        public string Diretorio { get; set; }
        public string NomeDoArquivo { get; set; }
        public List<string> ErrosDeMontagem { get; set; }
    
        public Montador()
        {
            ErrosDeMontagem = new List<string>();
        }
        public bool LeituraDosArquivos()
        {
            if (Diretorio == null || NomeDoArquivo == null)
            {
                throw new ArgumentNullException("Informe diretorio!");
            }
            try
            {
                int limite;
                int x = 0;
                while (NomeDoArquivo[x] != '.')
                {
                    x++;
                }
                limite = x;
                string dadosSource = NomeDoArquivo.Substring(0, x) + ".dados";
                string diretorio = Diretorio.Replace(NomeDoArquivo, "");
                if (!File.Exists(diretorio + dadosSource))
                {
                    return false;
                }
                Mnemonicos = File.ReadAllLines(Diretorio);
                Dados = File.ReadAllLines(diretorio + dadosSource);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        public void Montar() {
            List<IInstrucoes> instrucoes =  LerInstrucoes();
            List<Dados> dados =  LerDados();
            List<int> posicoesDeDados = new List<int>();
            ///Inicializando array de byes no padrão neander
            byte[] data = new byte[516];
            data[0] = 3;
            data[1] = 78;
            data[2] = 68;
            data[3] = 82;
            ///adicionando mnemônicos ao array
            foreach (IInstrucoes novas in instrucoes)
            {
                data[posicao(novas.IndiceNaMemoria)] = novas.Decimal;
                if (novas.Endereco)
                {
                    data[posicao(novas.IndiceNaMemoria) + 2] = novas.Dado;
                }
            }
            ///adicionando os dados ao array 
            foreach (Dados da in dados)
            {
                data[posicao(da.Posicao)] = da.Valor; 
            }
            //Criando e abrindo na classe para gração de bytes 
            BinaryWriter BWriter = new BinaryWriter(File.OpenWrite(Diretorio + ".mem"));
            //Grava os dados no arquivo 
            BWriter.Write(data);
            //Fecha o arquivo e salva o estado do arquivo 
            BWriter.Close();
        }
        private int posicao(int xUser)
        {   
            int viewer = 4 + (xUser * 2);
            return viewer;
        }
        /// <summary>
        /// Ler as intruções presentes no arquivo fornecido e retorna em uma lista de instruções
        /// </summary>
        /// <returns></returns>
        private List<IInstrucoes> LerInstrucoes()
        {
            ErrosDeMontagem.Clear();
            List<IInstrucoes> retorno = new List<IInstrucoes>();
            List<string> mnemonicosConhecidos = new List<string>();
            ///Carega Mnemônicos conhecidos no formato de string
            foreach (IInstrucoes mnn  in Maquina.instrucoesConhecidas)
            {
                mnemonicosConhecidos.Add(mnn.Mnemonico);
            }
            ///Corre todas as linhas do arquivo 
            for (int x = 0; x < Mnemonicos.Length; x++ )
            {
                string atual = Mnemonicos[x].Trim();
                ///Verifica linha em branco ou comentário 
                if (atual != "" && atual[0] != ';')
                {
                    try
                    {

                        string[] temp = atual.Split(',');
                        ///Verifica se o que foi digitado é um mnemônico
                        // posição, mnemônico
                        if (@byte(temp[0]) && mnemonicosConhecidos.Contains(temp[1]))
                        {
                            var novaInstrucao = (from a in Maquina.instrucoesConhecidas where a.Mnemonico == temp[1] select a).ToList()[0];
                            if (novaInstrucao.Endereco)
                            {
                                try
                                {
                                    ///Verifica se existe um byte a ser modificado na proxíma linha
                                    if (@byte(Mnemonicos[x + 1]))
                                    {
                                        novaInstrucao.Dado = Convert.ToByte(Mnemonicos[x + 1]);
                                        novaInstrucao.IndiceNaMemoria = Convert.ToByte(temp[0]);
                                        retorno.Add(novaInstrucao.Clone());
                                        x++;
                                    }
                                    else
                                    {
                                        ///Adiciona a lista de erros de montagem 
                                        ErrosDeMontagem.Add("Linha " + (x + 1) + ":end esperado ->" + Mnemonicos[x + 1]);
                                    }
                                }
                                catch (Exception)
                                {
                                    ErrosDeMontagem.Add("Linha " + x + ":Mnemônico desconhecido ->" + Mnemonicos[x]);
                                }
                            }
                            else
                            {
                                novaInstrucao.IndiceNaMemoria = Convert.ToByte(temp[0]);
                                retorno.Add(novaInstrucao.Clone());
                            }
                        }
                        else
                        {
                            ///Adiciona a lista de erros de montagem
                            ErrosDeMontagem.Add("Linha " + x + ":Mnemônico desconhecido ->" + Mnemonicos[x]);
                        }
                    }
                    catch (Exception)
                    {
                        ErrosDeMontagem.Add("Linha " + x + ":Mnemônico desconhecido ->" + Mnemonicos[x]);
                    }
                }
            }
            return retorno;
        }
        /// <summary>
        /// Ler os dados presentes no arquivo fornecido e retorna em uma lista de dados
        /// </summary>
        /// <returns></returns>
        private List<Dados> LerDados()
        {
            List<Dados> retorno = new List<Dados>();
            for (int x = 0; x < Dados.Length; x++)
            {
                try
                {
                    string atual = Dados[x].Trim();
                    if (atual != "" && atual[0] != ';')
                    {
                        string[] temp = atual.Split(',');
                        if (temp.Length == 2)
                        {
                            //// (posição na memoria),(byte)
                            if (@byte(temp[0]) && @byte(temp[1]))
                            {
                                Dados novo = new Dados();
                                novo.Posicao = Convert.ToInt32(temp[0]);
                                novo.Valor = Convert.ToByte(temp[1]);
                                retorno.Add(novo);
                            }
                            else
                            {
                                ErrosDeMontagem.Add("Dados -> Linha " + (x) + ": Byte não localizado ->" + Dados[x]);
                            }
                        }
                        else
                        {
                            ErrosDeMontagem.Add("Dados -> Linha " + (x) + ": Sintaxe incorreta ->" + Dados[x]);
                        }
                    }
                }
                catch (Exception)
                {

                    ErrosDeMontagem.Add("Dados -> Linha " + (x) + ": Sintaxe incorreta ->" + Dados[x]);
                }
            }

            return retorno;
        }
        /// <summary>
        /// Verifica se o próximo valor é um byte
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool @byte(string str)
        {
            try
            {
                int d = Convert.ToByte(str);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
    /// <summary>
    /// Classe auxiliar para controle de Dados
    /// </summary>
    public class Dados : IEquatable<Dados>
    {
       public int Posicao { get; set; }
       public byte Valor { get; set; }
       public bool Equals(Dados other)
       {
            return other != null &&
                   Posicao == other.Posicao;
       }
    }
}
