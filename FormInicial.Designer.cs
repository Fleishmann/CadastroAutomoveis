namespace AutomoveisCadastro
{
    partial class index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCor = new Button();
            btnCombustiveis = new Button();
            panel1 = new Panel();
            btnAtualizar = new Button();
            label1 = new Label();
            txtFiltro = new TextBox();
            label2 = new Label();
            BtnLimpar = new Button();
            btnFiltrar = new Button();
            txtPlaca = new TextBox();
            txtAnoFabricacao = new TextBox();
            txtModelo = new TextBox();
            txtRenavam = new TextBox();
            txtMarca = new TextBox();
            cbCor = new ComboBox();
            cbCombustivel = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dtvVeiculos = new DataGridView();
            btnCadastrar = new Button();
            panel2 = new Panel();
            label11 = new Label();
            txtNumeroChassi = new TextBox();
            label12 = new Label();
            txtNumeroMotor = new TextBox();
            chkStatus = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvVeiculos).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCor
            // 
            btnCor.Location = new Point(11, 10);
            btnCor.Name = "btnCor";
            btnCor.Size = new Size(75, 23);
            btnCor.TabIndex = 0;
            btnCor.Text = "Cores";
            btnCor.UseVisualStyleBackColor = true;
            btnCor.Click += btnCor_Click;
            // 
            // btnCombustiveis
            // 
            btnCombustiveis.Location = new Point(92, 10);
            btnCombustiveis.Name = "btnCombustiveis";
            btnCombustiveis.Size = new Size(98, 23);
            btnCombustiveis.TabIndex = 2;
            btnCombustiveis.Text = "Combustivels";
            btnCombustiveis.UseVisualStyleBackColor = true;
            btnCombustiveis.Click += btnCombustiveis_Click;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAtualizar);
            panel1.Controls.Add(btnCor);
            panel1.Controls.Add(btnCombustiveis);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(931, 44);
            panel1.TabIndex = 3;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(854, 3);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(64, 32);
            btnAtualizar.TabIndex = 33;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(380, 12);
            label1.Name = "label1";
            label1.Size = new Size(196, 21);
            label1.TabIndex = 4;
            label1.Text = "Cadastro de Automoveis";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(18, 32);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(297, 23);
            txtFiltro.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 14);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 6;
            label2.Text = "Buscar";
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(402, 27);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(75, 30);
            BtnLimpar.TabIndex = 7;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(321, 27);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 30);
            btnFiltrar.TabIndex = 8;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(66, 82);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(151, 23);
            txtPlaca.TabIndex = 9;
            // 
            // txtAnoFabricacao
            // 
            txtAnoFabricacao.Location = new Point(569, 149);
            txtAnoFabricacao.Name = "txtAnoFabricacao";
            txtAnoFabricacao.Size = new Size(190, 23);
            txtAnoFabricacao.TabIndex = 10;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(66, 149);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(137, 23);
            txtModelo.TabIndex = 11;
            // 
            // txtRenavam
            // 
            txtRenavam.Location = new Point(233, 82);
            txtRenavam.Name = "txtRenavam";
            txtRenavam.Size = new Size(123, 23);
            txtRenavam.TabIndex = 12;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(690, 82);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(190, 23);
            txtMarca.TabIndex = 13;
            // 
            // cbCor
            // 
            cbCor.FormattingEnabled = true;
            cbCor.Location = new Point(404, 149);
            cbCor.Name = "cbCor";
            cbCor.Size = new Size(141, 23);
            cbCor.TabIndex = 15;
            // 
            // cbCombustivel
            // 
            cbCombustivel.FormattingEnabled = true;
            cbCombustivel.Location = new Point(233, 149);
            cbCombustivel.Name = "cbCombustivel";
            cbCombustivel.Size = new Size(145, 23);
            cbCombustivel.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 64);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 17;
            label3.Text = "Placa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 64);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 18;
            label4.Text = "Renavam";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(690, 64);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 19;
            label5.Text = "Marca";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 131);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 20;
            label6.Text = "Modelo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(569, 131);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 22;
            label8.Text = "Ano Fabricação";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(404, 131);
            label9.Name = "label9";
            label9.Size = new Size(26, 15);
            label9.TabIndex = 23;
            label9.Text = "Cor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(233, 131);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 24;
            label10.Text = "Combustivel";
            // 
            // dtvVeiculos
            // 
            dtvVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvVeiculos.Location = new Point(12, 63);
            dtvVeiculos.Name = "dtvVeiculos";
            dtvVeiculos.Size = new Size(907, 152);
            dtvVeiculos.TabIndex = 25;
            dtvVeiculos.KeyDown += dtvVeiculos_KeyDown;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(844, 194);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 26;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dtvVeiculos);
            panel2.Controls.Add(btnFiltrar);
            panel2.Controls.Add(txtFiltro);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(BtnLimpar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 223);
            panel2.Name = "panel2";
            panel2.Size = new Size(931, 227);
            panel2.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(369, 64);
            label11.Name = "label11";
            label11.Size = new Size(105, 15);
            label11.TabIndex = 29;
            label11.Text = "Numero do Chassi";
            // 
            // txtNumeroChassi
            // 
            txtNumeroChassi.Location = new Point(369, 82);
            txtNumeroChassi.Name = "txtNumeroChassi";
            txtNumeroChassi.Size = new Size(123, 23);
            txtNumeroChassi.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(509, 64);
            label12.Name = "label12";
            label12.Size = new Size(104, 15);
            label12.TabIndex = 31;
            label12.Text = "Numero do Motor";
            // 
            // txtNumeroMotor
            // 
            txtNumeroMotor.Location = new Point(509, 82);
            txtNumeroMotor.Name = "txtNumeroMotor";
            txtNumeroMotor.Size = new Size(155, 23);
            txtNumeroMotor.TabIndex = 30;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(783, 153);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(58, 19);
            chkStatus.TabIndex = 32;
            chkStatus.Text = "Status";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(931, 450);
            Controls.Add(chkStatus);
            Controls.Add(label12);
            Controls.Add(txtNumeroMotor);
            Controls.Add(label11);
            Controls.Add(txtNumeroChassi);
            Controls.Add(panel2);
            Controls.Add(btnCadastrar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbCombustivel);
            Controls.Add(cbCor);
            Controls.Add(txtMarca);
            Controls.Add(txtRenavam);
            Controls.Add(txtModelo);
            Controls.Add(txtAnoFabricacao);
            Controls.Add(txtPlaca);
            Controls.Add(panel1);
            Name = "index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "index";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtvVeiculos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCor;
        private Button btnCombustiveis;
        private Panel panel1;
        private Label label1;
        private TextBox txtFiltro;
        private Label label2;
        private Button BtnLimpar;
        private Button btnFiltrar;
        private TextBox txtPlaca;
        private TextBox txtAnoFabricacao;
        private TextBox txtModelo;
        private TextBox txtRenavam;
        private TextBox txtMarca;
        private ComboBox cbCor;
        private ComboBox cbCombustivel;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridView dtvVeiculos;
        private Button btnCadastrar;
        private Panel panel2;
        private Label label11;
        private TextBox txtNumeroChassi;
        private Label label12;
        private TextBox txtNumeroMotor;
        private CheckBox chkStatus;
        private Button btnAtualizar;
    }
}
