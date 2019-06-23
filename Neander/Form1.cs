using Neander.Instrucoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public Form1()
        {
            InitializeComponent();
            montador = new Montador();
            Interpretador = new Interpretador();
        }

        private void PathSourceButton_Click(object sender, EventArgs e)
        {
            if (FileSource.ShowDialog() == DialogResult.OK) {
                PathText.Text = FileSource.FileName;
                montador.Diretorio = FileSource.FileName;
                montador.NomeDoArquivo = FileSource.SafeFileName;
                MontarStart.Enabled = true;
            }
        }

        private void MontarStart_Click(object sender, EventArgs e)
        {   
            montador.Leitura();
            montador.Montar();
            if (montador.ErrosDeMontagem.Count > 0)
            {
                MessageBox.Show("Erros na montagem");
            }
            else
            {
                MessageBox.Show("Sucesso!");
            }
        }

        private void SourceFileButtonInter_Click(object sender, EventArgs e)
        {
            if (FileSource.ShowDialog() == DialogResult.OK)
            {
                PathTextInterpretado.Text = FileSource.FileName;
                Interpretador.Diretorio = FileSource.FileName;
                InterpretaStart.Enabled = true;
            }
        }

        private void InterpretaStart_Click(object sender, EventArgs e)
        {
            Interpretador.LerInstrucoes();
            Maquina.instrucoes = Interpretador.Instrucoes;
            Atualizar();
        }
        private void Atualizar()
        {
            AcLabel.Text = Maquina.Acumulador.ToString();
            PcLabel.Text = Maquina.PC.ToString();
            AcessoLabel.Text = Maquina.Acessos.ToString();
            InstrucoesLabel.Text = Maquina.instrucoes.ToString();
            memoriaGrid.Rows.Clear();
            for (int x = 0; x < Maquina.instrucoes.Count;x++)
            {
                memoriaGrid.Rows.Add(x, Maquina.instrucoes[x].Mnemonico, Maquina.instrucoes[x].Dado);
            }
            memoriaGrid.Rows[Maquina.PC].Selected = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Maquina.instrucoes[Maquina.PC].Run(Maquina.PC);
            Atualizar();
        }
    }
}
