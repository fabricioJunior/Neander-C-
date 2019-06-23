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
            groupBox.Controls.Add(bv);
        }

        private void PathSourceButton_Click(object sender, EventArgs e)
        {
            if (FileSource.ShowDialog() == DialogResult.OK)
            {
                PathText.Text = FileSource.FileName;
                montador.Diretorio = FileSource.FileName;
                montador.NomeDoArquivo = FileSource.SafeFileName;
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
            if (montador.Leitura())
            {
                montador.Montar();
                if (montador.ErrosDeMontagem.Count > 0)
                {
                    MessageBox.Show("Erros na montagem");
                    MensagemDoMontadoBox.Lines = montador.ErrosDeMontagem.ToArray();
                }
                else
                {
                    MessageBox.Show("Sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Não foi possivel realizar a leitura dos arquivos!");

            }
        }

        private void SourceFileButtonInter_Click(object sender, EventArgs e)
        {
            if (FileSource.ShowDialog() == DialogResult.OK)
            {
                PathTextInterpretado.Text = FileSource.FileName;
                Interpretador.Diretorio = FileSource.FileName;
                InterpretaStart.Enabled = true;
                try
                {
                 
                    bv.SetFile(FileSource.FileName); // or SetBytes
                   
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
            AcLabel.Text = Maquina.Acumulador.ToString();
            PcLabel.Text = Maquina.PC.ToString();
            AcessoLabel.Text = Maquina.Acessos.ToString();
            InstrucoesLabel.Text = Maquina.instrucoes[Maquina.PC].Mnemonico.ToString();
            Comandos.Rows.Clear();
            memoriaGrid.Rows.Clear();
            for (int x = 0; x < Maquina.instrucoes.Count; x++)
            {
                Comandos.Rows.Add(x, Maquina.instrucoes[x].Mnemonico, Maquina.instrucoes[x].Dado);
                memoriaGrid.Rows.Add(x, Maquina.instrucoes[x].Dado);
            }
            Ntext.Text = Convert.ToString(Maquina.Negativo);
            Ztext.Text = Convert.ToString(Maquina.Acumulador == 0);
            Comandos.Rows[Maquina.PC].Selected = true;
            Comandos.FirstDisplayedScrollingRowIndex = Maquina.PC;
            memoriaGrid.Rows[Maquina.PC].Selected = true;
            memoriaGrid.FirstDisplayedScrollingRowIndex = Maquina.PC;
        }
        
        private void PassoaPassoButton_Click(object sender, EventArgs e)
        {
            Maquina.instrucoes[Maquina.PC].Run(Maquina.PC);
            Atualizar();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

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
