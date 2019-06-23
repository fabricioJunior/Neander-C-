namespace Neander
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PathText = new System.Windows.Forms.TextBox();
            this.PathSourceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MontarStart = new System.Windows.Forms.Button();
            this.FileSource = new System.Windows.Forms.OpenFileDialog();
            this.InterpretaStart = new System.Windows.Forms.Button();
            this.SourceFileButtonInter = new System.Windows.Forms.Button();
            this.PathTextInterpretado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AcLabel = new System.Windows.Forms.Label();
            this.PcLabel = new System.Windows.Forms.Label();
            this.AcessoLabel = new System.Windows.Forms.Label();
            this.InstrucoesLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.memoriaGrid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mnemônico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.memoriaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PathText
            // 
            this.PathText.Location = new System.Drawing.Point(111, 67);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(360, 20);
            this.PathText.TabIndex = 0;
            // 
            // PathSourceButton
            // 
            this.PathSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PathSourceButton.Location = new System.Drawing.Point(30, 65);
            this.PathSourceButton.Name = "PathSourceButton";
            this.PathSourceButton.Size = new System.Drawing.Size(75, 23);
            this.PathSourceButton.TabIndex = 1;
            this.PathSourceButton.Text = "...";
            this.PathSourceButton.UseVisualStyleBackColor = true;
            this.PathSourceButton.Click += new System.EventHandler(this.PathSourceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Montador";
            // 
            // MontarStart
            // 
            this.MontarStart.Enabled = false;
            this.MontarStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MontarStart.Location = new System.Drawing.Point(477, 65);
            this.MontarStart.Name = "MontarStart";
            this.MontarStart.Size = new System.Drawing.Size(75, 23);
            this.MontarStart.TabIndex = 3;
            this.MontarStart.Text = "montar";
            this.MontarStart.UseVisualStyleBackColor = true;
            this.MontarStart.Click += new System.EventHandler(this.MontarStart_Click);
            // 
            // InterpretaStart
            // 
            this.InterpretaStart.Enabled = false;
            this.InterpretaStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InterpretaStart.Location = new System.Drawing.Point(477, 147);
            this.InterpretaStart.Name = "InterpretaStart";
            this.InterpretaStart.Size = new System.Drawing.Size(136, 23);
            this.InterpretaStart.TabIndex = 6;
            this.InterpretaStart.Text = "Carrega Memoria";
            this.InterpretaStart.UseVisualStyleBackColor = true;
            this.InterpretaStart.Click += new System.EventHandler(this.InterpretaStart_Click);
            // 
            // SourceFileButtonInter
            // 
            this.SourceFileButtonInter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SourceFileButtonInter.Location = new System.Drawing.Point(30, 147);
            this.SourceFileButtonInter.Name = "SourceFileButtonInter";
            this.SourceFileButtonInter.Size = new System.Drawing.Size(75, 23);
            this.SourceFileButtonInter.TabIndex = 5;
            this.SourceFileButtonInter.Text = "...";
            this.SourceFileButtonInter.UseVisualStyleBackColor = true;
            this.SourceFileButtonInter.Click += new System.EventHandler(this.SourceFileButtonInter_Click);
            // 
            // PathTextInterpretado
            // 
            this.PathTextInterpretado.Location = new System.Drawing.Point(111, 149);
            this.PathTextInterpretado.Name = "PathTextInterpretado";
            this.PathTextInterpretado.Size = new System.Drawing.Size(360, 20);
            this.PathTextInterpretado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Memoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "AC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "PC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Instruções:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Acesso:";
            // 
            // AcLabel
            // 
            this.AcLabel.AutoSize = true;
            this.AcLabel.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcLabel.Location = new System.Drawing.Point(150, 212);
            this.AcLabel.Name = "AcLabel";
            this.AcLabel.Size = new System.Drawing.Size(25, 25);
            this.AcLabel.TabIndex = 12;
            this.AcLabel.Text = "0";
            // 
            // PcLabel
            // 
            this.PcLabel.AutoSize = true;
            this.PcLabel.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PcLabel.Location = new System.Drawing.Point(150, 253);
            this.PcLabel.Name = "PcLabel";
            this.PcLabel.Size = new System.Drawing.Size(25, 25);
            this.PcLabel.TabIndex = 13;
            this.PcLabel.Text = "0";
            // 
            // AcessoLabel
            // 
            this.AcessoLabel.AutoSize = true;
            this.AcessoLabel.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcessoLabel.Location = new System.Drawing.Point(150, 295);
            this.AcessoLabel.Name = "AcessoLabel";
            this.AcessoLabel.Size = new System.Drawing.Size(25, 25);
            this.AcessoLabel.TabIndex = 14;
            this.AcessoLabel.Text = "0";
            // 
            // InstrucoesLabel
            // 
            this.InstrucoesLabel.AutoSize = true;
            this.InstrucoesLabel.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstrucoesLabel.Location = new System.Drawing.Point(150, 336);
            this.InstrucoesLabel.Name = "InstrucoesLabel";
            this.InstrucoesLabel.Size = new System.Drawing.Size(25, 25);
            this.InstrucoesLabel.TabIndex = 15;
            this.InstrucoesLabel.Text = "0";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(17, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Passo a passo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // memoriaGrid
            // 
            this.memoriaGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.memoriaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memoriaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Endereço,
            this.Mnemônico,
            this.Dado});
            this.memoriaGrid.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.memoriaGrid.Location = new System.Drawing.Point(719, 33);
            this.memoriaGrid.Name = "memoriaGrid";
            this.memoriaGrid.RowHeadersVisible = false;
            this.memoriaGrid.Size = new System.Drawing.Size(253, 378);
            this.memoriaGrid.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(788, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Memoria";
            // 
            // Endereço
            // 
            this.Endereço.HeaderText = "Endereço";
            this.Endereço.Name = "Endereço";
            this.Endereço.Width = 75;
            // 
            // Mnemônico
            // 
            this.Mnemônico.HeaderText = "Mnemônico";
            this.Mnemônico.Name = "Mnemônico";
            // 
            // Dado
            // 
            this.Dado.HeaderText = "Dado";
            this.Dado.Name = "Dado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 433);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.memoriaGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InstrucoesLabel);
            this.Controls.Add(this.AcessoLabel);
            this.Controls.Add(this.PcLabel);
            this.Controls.Add(this.AcLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InterpretaStart);
            this.Controls.Add(this.SourceFileButtonInter);
            this.Controls.Add(this.PathTextInterpretado);
            this.Controls.Add(this.MontarStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathSourceButton);
            this.Controls.Add(this.PathText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.memoriaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Button PathSourceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MontarStart;
        private System.Windows.Forms.OpenFileDialog FileSource;
        private System.Windows.Forms.Button InterpretaStart;
        private System.Windows.Forms.Button SourceFileButtonInter;
        private System.Windows.Forms.TextBox PathTextInterpretado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AcLabel;
        private System.Windows.Forms.Label PcLabel;
        private System.Windows.Forms.Label AcessoLabel;
        private System.Windows.Forms.Label InstrucoesLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView memoriaGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mnemônico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dado;
    }
}

