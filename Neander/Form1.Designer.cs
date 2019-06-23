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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.MensagemDoMontadoBox = new System.Windows.Forms.RichTextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.Ztext = new System.Windows.Forms.Label();
            this.Ntext = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RodaButton = new System.Windows.Forms.Button();
            this.memoriaGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterpretaStart = new System.Windows.Forms.Button();
            this.PathTextInterpretado = new System.Windows.Forms.TextBox();
            this.SourceFileButtonInter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.passoApassoButton = new System.Windows.Forms.Button();
            this.InstrucoesLabel = new System.Windows.Forms.Label();
            this.AcessoLabel = new System.Windows.Forms.Label();
            this.PcLabel = new System.Windows.Forms.Label();
            this.AcLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Comandos = new System.Windows.Forms.DataGridView();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mnemônico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileMemSource = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoriaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comandos)).BeginInit();
            this.SuspendLayout();
            // 
            // PathText
            // 
            this.PathText.Location = new System.Drawing.Point(92, 120);
            this.PathText.Name = "PathText";
            this.PathText.ReadOnly = true;
            this.PathText.Size = new System.Drawing.Size(321, 20);
            this.PathText.TabIndex = 0;
            // 
            // PathSourceButton
            // 
            this.PathSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PathSourceButton.Location = new System.Drawing.Point(11, 118);
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
            this.label1.Font = new System.Drawing.Font("Century", 20.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Montador";
            // 
            // MontarStart
            // 
            this.MontarStart.Enabled = false;
            this.MontarStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MontarStart.Location = new System.Drawing.Point(419, 118);
            this.MontarStart.Name = "MontarStart";
            this.MontarStart.Size = new System.Drawing.Size(75, 23);
            this.MontarStart.TabIndex = 3;
            this.MontarStart.Text = "montar";
            this.MontarStart.UseVisualStyleBackColor = true;
            this.MontarStart.Click += new System.EventHandler(this.MontarStart_Click);
            // 
            // FileSource
            // 
            this.FileSource.Filter = "Mnemônicos|*.mns";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1088, 633);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.MensagemDoMontadoBox);
            this.tabPage1.Controls.Add(this.richTextBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.MontarStart);
            this.tabPage1.Controls.Add(this.PathText);
            this.tabPage1.Controls.Add(this.PathSourceButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1080, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Montador";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(868, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "By: Fabricio Junior (UFC-Sobral)";
            // 
            // MensagemDoMontadoBox
            // 
            this.MensagemDoMontadoBox.Location = new System.Drawing.Point(680, 153);
            this.MensagemDoMontadoBox.Name = "MensagemDoMontadoBox";
            this.MensagemDoMontadoBox.Size = new System.Drawing.Size(370, 424);
            this.MensagemDoMontadoBox.TabIndex = 9;
            this.MensagemDoMontadoBox.Text = "";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(0, 153);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(611, 424);
            this.richTextBox.TabIndex = 8;
            this.richTextBox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 14.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(719, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "Mensagens do Montador";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 14.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(6, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Carrega Mnemônicos(.mnp)";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.ResetButton);
            this.tabPage2.Controls.Add(this.Ztext);
            this.tabPage2.Controls.Add(this.Ntext);
            this.tabPage2.Controls.Add(this.groupBox);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.RodaButton);
            this.tabPage2.Controls.Add(this.memoriaGrid);
            this.tabPage2.Controls.Add(this.InterpretaStart);
            this.tabPage2.Controls.Add(this.PathTextInterpretado);
            this.tabPage2.Controls.Add(this.SourceFileButtonInter);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.passoApassoButton);
            this.tabPage2.Controls.Add(this.InstrucoesLabel);
            this.tabPage2.Controls.Add(this.AcessoLabel);
            this.tabPage2.Controls.Add(this.PcLabel);
            this.tabPage2.Controls.Add(this.AcLabel);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.Comandos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1080, 607);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Simulador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(579, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 25);
            this.label14.TabIndex = 43;
            this.label14.Text = "Programa";
            // 
            // ResetButton
            // 
            this.ResetButton.Enabled = false;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.Location = new System.Drawing.Point(423, 167);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(143, 25);
            this.ResetButton.TabIndex = 42;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Ztext
            // 
            this.Ztext.AutoSize = true;
            this.Ztext.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Bold);
            this.Ztext.Location = new System.Drawing.Point(281, 148);
            this.Ztext.Name = "Ztext";
            this.Ztext.Size = new System.Drawing.Size(72, 21);
            this.Ztext.TabIndex = 41;
            this.Ztext.Text = "FALSE";
            // 
            // Ntext
            // 
            this.Ntext.AutoSize = true;
            this.Ntext.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Bold);
            this.Ntext.Location = new System.Drawing.Point(281, 107);
            this.Ntext.Name = "Ntext";
            this.Ntext.Size = new System.Drawing.Size(72, 21);
            this.Ntext.TabIndex = 40;
            this.Ntext.Text = "FALSE";
            // 
            // groupBox
            // 
            this.groupBox.Location = new System.Drawing.Point(13, 248);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(553, 351);
            this.groupBox.TabIndex = 39;
            this.groupBox.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(242, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 25);
            this.label12.TabIndex = 38;
            this.label12.Text = "Z:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(238, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 25);
            this.label11.TabIndex = 37;
            this.label11.Text = "N:";
            // 
            // RodaButton
            // 
            this.RodaButton.Enabled = false;
            this.RodaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RodaButton.Location = new System.Drawing.Point(423, 105);
            this.RodaButton.Name = "RodaButton";
            this.RodaButton.Size = new System.Drawing.Size(143, 25);
            this.RodaButton.TabIndex = 36;
            this.RodaButton.Text = "Rodar";
            this.RodaButton.UseVisualStyleBackColor = true;
            this.RodaButton.Click += new System.EventHandler(this.RodaButton_Click);
            // 
            // memoriaGrid
            // 
            this.memoriaGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.memoriaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memoriaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.memoriaGrid.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.memoriaGrid.Location = new System.Drawing.Point(869, 105);
            this.memoriaGrid.Name = "memoriaGrid";
            this.memoriaGrid.RowHeadersVisible = false;
            this.memoriaGrid.Size = new System.Drawing.Size(181, 492);
            this.memoriaGrid.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Dado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // InterpretaStart
            // 
            this.InterpretaStart.Enabled = false;
            this.InterpretaStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InterpretaStart.Location = new System.Drawing.Point(423, 52);
            this.InterpretaStart.Name = "InterpretaStart";
            this.InterpretaStart.Size = new System.Drawing.Size(136, 23);
            this.InterpretaStart.TabIndex = 32;
            this.InterpretaStart.Text = "Carrega Memoria";
            this.InterpretaStart.UseVisualStyleBackColor = true;
            this.InterpretaStart.Click += new System.EventHandler(this.InterpretaStart_Click);
            // 
            // PathTextInterpretado
            // 
            this.PathTextInterpretado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.PathTextInterpretado.Location = new System.Drawing.Point(98, 52);
            this.PathTextInterpretado.Name = "PathTextInterpretado";
            this.PathTextInterpretado.ReadOnly = true;
            this.PathTextInterpretado.Size = new System.Drawing.Size(319, 23);
            this.PathTextInterpretado.TabIndex = 30;
            // 
            // SourceFileButtonInter
            // 
            this.SourceFileButtonInter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SourceFileButtonInter.Location = new System.Drawing.Point(17, 52);
            this.SourceFileButtonInter.Name = "SourceFileButtonInter";
            this.SourceFileButtonInter.Size = new System.Drawing.Size(75, 23);
            this.SourceFileButtonInter.TabIndex = 31;
            this.SourceFileButtonInter.Text = "...";
            this.SourceFileButtonInter.UseVisualStyleBackColor = true;
            this.SourceFileButtonInter.Click += new System.EventHandler(this.SourceFileButtonInter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 20.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 33);
            this.label2.TabIndex = 33;
            this.label2.Text = "Memória";
            // 
            // passoApassoButton
            // 
            this.passoApassoButton.Enabled = false;
            this.passoApassoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.passoApassoButton.Location = new System.Drawing.Point(423, 136);
            this.passoApassoButton.Name = "passoApassoButton";
            this.passoApassoButton.Size = new System.Drawing.Size(143, 25);
            this.passoApassoButton.TabIndex = 27;
            this.passoApassoButton.Text = "Passo a passo";
            this.passoApassoButton.UseVisualStyleBackColor = true;
            this.passoApassoButton.Click += new System.EventHandler(this.PassoaPassoButton_Click);
            // 
            // InstrucoesLabel
            // 
            this.InstrucoesLabel.AutoSize = true;
            this.InstrucoesLabel.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstrucoesLabel.Location = new System.Drawing.Point(143, 144);
            this.InstrucoesLabel.Name = "InstrucoesLabel";
            this.InstrucoesLabel.Size = new System.Drawing.Size(25, 25);
            this.InstrucoesLabel.TabIndex = 26;
            this.InstrucoesLabel.Text = "0";
            // 
            // AcessoLabel
            // 
            this.AcessoLabel.AutoSize = true;
            this.AcessoLabel.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcessoLabel.Location = new System.Drawing.Point(143, 107);
            this.AcessoLabel.Name = "AcessoLabel";
            this.AcessoLabel.Size = new System.Drawing.Size(25, 25);
            this.AcessoLabel.TabIndex = 25;
            this.AcessoLabel.Text = "0";
            // 
            // PcLabel
            // 
            this.PcLabel.AutoSize = true;
            this.PcLabel.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PcLabel.Location = new System.Drawing.Point(143, 185);
            this.PcLabel.Name = "PcLabel";
            this.PcLabel.Size = new System.Drawing.Size(25, 25);
            this.PcLabel.TabIndex = 24;
            this.PcLabel.Text = "0";
            // 
            // AcLabel
            // 
            this.AcLabel.AutoSize = true;
            this.AcLabel.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcLabel.Location = new System.Drawing.Point(281, 185);
            this.AcLabel.Name = "AcLabel";
            this.AcLabel.Size = new System.Drawing.Size(25, 25);
            this.AcLabel.TabIndex = 23;
            this.AcLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mnemônico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Acessos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "PC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "AC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(864, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Dados";
            // 
            // Comandos
            // 
            this.Comandos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Comandos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Comandos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Endereço,
            this.Mnemônico,
            this.Dado});
            this.Comandos.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.Comandos.Location = new System.Drawing.Point(584, 105);
            this.Comandos.Name = "Comandos";
            this.Comandos.RowHeadersVisible = false;
            this.Comandos.Size = new System.Drawing.Size(279, 494);
            this.Comandos.TabIndex = 28;
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
            // FileMemSource
            // 
            this.FileMemSource.Filter = "Memoria|*.mem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1088, 633);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeanderC#";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoriaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comandos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Button PathSourceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MontarStart;
        private System.Windows.Forms.OpenFileDialog FileSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button InterpretaStart;
        private System.Windows.Forms.TextBox PathTextInterpretado;
        private System.Windows.Forms.Button SourceFileButtonInter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button passoApassoButton;
        private System.Windows.Forms.Label InstrucoesLabel;
        private System.Windows.Forms.Label AcessoLabel;
        private System.Windows.Forms.Label PcLabel;
        private System.Windows.Forms.Label AcLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView Comandos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mnemônico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.RichTextBox MensagemDoMontadoBox;
        private System.Windows.Forms.Button RodaButton;
        private System.Windows.Forms.DataGridView memoriaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label Ztext;
        private System.Windows.Forms.Label Ntext;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.OpenFileDialog FileMemSource;
        private System.Windows.Forms.Label label14;
    }
}

