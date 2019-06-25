using Neander.Instrucoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neander
{
    public partial class Form1 : Form
    {
        Montador montador;
        Interpretador Interpretador;
        ByteViewer bv = new ByteViewer();

        public Form1()
        {   

            InitializeComponent();
            montador = new Montador();
            Interpretador = new Interpretador();
            bv.Dock = DockStyle.Fill;
            groupBox.Controls.Add(bv);
        }

        private void PathSourceButton_Click(object sender, EventArgs e)
        {
            if (FileSource.ShowDialog() == DialogResult.OK)
            {
                PathText.Text = FileSource.FileName;
                montador.Diretorio = FileSource.FileName;
                montador.NomeDoArquivo = FileSource.SafeFileName;
                richTextBox.Lines = File.ReadAllLines(FileSource.FileName);
                MontarStart.Enabled = true;
                try
                {
                    string[] temp = File.ReadAllLines(PathText.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel abrir o arquivo:" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MontarStart_Click(object sender, EventArgs e)
        {
            if (montador.LeituraDosArquivos())
            {
                montador.Montar();
                if (montador.ErrosDeMontagem.Count > 0)
                {
                    MessageBox.Show("Erros na montagem");
                    MensagemDoMontadoBox.Lines = montador.ErrosDeMontagem.ToArray();
                }
                else
                {
                    if (MessageBox.Show("Sucesso! Deseja carrega o arquivo na memoria ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                       
                        PathTextInterpretado.Text = montador.Diretorio + ".mem";
                        Interpretador.Diretorio = montador.Diretorio + ".mem";
                        InterpretaStart.Enabled = true;
                        try
                        {
                           
                            bv.SetFile(montador.Diretorio + ".mem"); // or SetBytes

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possivel abrir o arquivo:" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        tabControl1.SelectedTab = tabPage2;
                        InterpretaStart_Click(null,null);
                    }
                }
            }
            else
            {
                MessageBox.Show("Não foi possivel realizar a leitura dos arquivos!");

            }
        }

        private void SourceFileButtonInter_Click(object sender, EventArgs e)
        {
            if (FileMemSource.ShowDialog() == DialogResult.OK)
            {
                PathTextInterpretado.Text = FileMemSource.FileName;
                Interpretador.Diretorio = FileMemSource.FileName;
                InterpretaStart.Enabled = true;
              
                try
                {
                 
                    bv.SetFile(FileMemSource.FileName); // or SetBytes
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel abrir o arquivo:" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InterpretaStart_Click(object sender, EventArgs e)
        {
            Interpretador.LerInstrucoes();
            Maquina.instrucoes = Interpretador.Instrucoes;
            Atualizar();
            passoApassoButton.Enabled = true;
            RodaButton.Enabled = true;
            ResetButton.Enabled = true;
        }
        private void Atualizar()
        {
            ///Atualiza as informções basicas 
            AcLabel.Text = Maquina.Acumulador.ToString();
            PcLabel.Text = Maquina.PC.ToString();
            AcessoLabel.Text = Maquina.AcessosMemoria.ToString();
            Ntext.Text = Convert.ToString(Maquina.Negativo);
            Ztext.Text = Convert.ToString(Maquina.Acumulador == 0);
            InstrucoesLabel.Text = Maquina.instrucoes[Maquina.PC].Mnemonico.ToString();
            ///Atualizar os grids 
            Comandos.Rows.Clear();
            memoriaGrid.Rows.Clear();
            for (int x = 0; x < Maquina.instrucoes.Count; x++)
            {
                Comandos.Rows.Add(x, Maquina.instrucoes[x].Mnemonico, Maquina.instrucoes[x].Dado);
                memoriaGrid.Rows.Add(x, Maquina.instrucoes[x].Dado);
            }
            Comandos.Rows[Maquina.PC].Selected = true;
            Comandos.FirstDisplayedScrollingRowIndex = Maquina.PC;
            if (Maquina.instrucoes[Maquina.PC].Endereco)
            {   
                int end = Maquina.instrucoes[Maquina.PC + 1].Dado;
                memoriaGrid.Rows[end].Selected = true;
                memoriaGrid.FirstDisplayedScrollingRowIndex = Maquina.instrucoes[Maquina.PC+1].Dado;
         
            }
         
        }
        
        private void PassoaPassoButton_Click(object sender, EventArgs e)
        {
            if (Maquina.PC == 255)
            {
                Maquina.PC = 0;
            }
            Maquina.PassoaPasso = true;
            Maquina.instrucoes[Maquina.PC].Run(Maquina.PC);
            Atualizar();
           
        }

      

        private void RodaButton_Click(object sender, EventArgs e)
        {
            Maquina.PassoaPasso = false;
            Maquina.instrucoes[0].Run(0);
            Maquina.PC = 255;
            Atualizar();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Maquina.Reset();
            Atualizar();
        }
    }
}
