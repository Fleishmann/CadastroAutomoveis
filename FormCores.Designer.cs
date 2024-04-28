namespace AutomoveisCadastro
{
    partial class FormCores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dtvCores = new DataGridView();
            panel1 = new Panel();
            cbBuscarPorStatus = new ComboBox();
            label2 = new Label();
            btnBuscarPorStatus = new Button();
            btnBuscarPorDescricao = new Button();
            btnLimpar = new Button();
            txtBuscarPorDescricao = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtBuscarPorId = new TextBox();
            btnBuscarPorId = new Button();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtvCores).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 21);
            label1.Name = "label1";
            label1.Size = new Size(221, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Cores";
            // 
            // dtvCores
            // 
            dtvCores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvCores.Location = new Point(17, 65);
            dtvCores.Name = "dtvCores";
            dtvCores.Size = new Size(771, 238);
            dtvCores.TabIndex = 1;
            dtvCores.KeyDown += dtvCores_KeyDown;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbBuscarPorStatus);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnBuscarPorStatus);
            panel1.Controls.Add(btnBuscarPorDescricao);
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(txtBuscarPorDescricao);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtBuscarPorId);
            panel1.Controls.Add(btnBuscarPorId);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 364);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 86);
            panel1.TabIndex = 4;
            // 
            // cbBuscarPorStatus
            // 
            cbBuscarPorStatus.FormattingEnabled = true;
            cbBuscarPorStatus.Items.AddRange(new object[] { "", "Ativo", "Inativo" });
            cbBuscarPorStatus.Location = new Point(221, 34);
            cbBuscarPorStatus.Name = "cbBuscarPorStatus";
            cbBuscarPorStatus.Size = new Size(77, 23);
            cbBuscarPorStatus.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 15);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 16;
            label2.Text = "Buscar por Status";
            // 
            // btnBuscarPorStatus
            // 
            btnBuscarPorStatus.Location = new Point(304, 34);
            btnBuscarPorStatus.Name = "btnBuscarPorStatus";
            btnBuscarPorStatus.Size = new Size(69, 23);
            btnBuscarPorStatus.TabIndex = 18;
            btnBuscarPorStatus.Text = "Buscar";
            btnBuscarPorStatus.UseVisualStyleBackColor = true;
            btnBuscarPorStatus.Click += btnBuscarPorStatus_Click;
            // 
            // btnBuscarPorDescricao
            // 
            btnBuscarPorDescricao.Location = new Point(592, 33);
            btnBuscarPorDescricao.Name = "btnBuscarPorDescricao";
            btnBuscarPorDescricao.Size = new Size(69, 23);
            btnBuscarPorDescricao.TabIndex = 15;
            btnBuscarPorDescricao.Text = "Buscar";
            btnBuscarPorDescricao.UseVisualStyleBackColor = true;
            btnBuscarPorDescricao.Click += btnBuscarPorDescricao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(701, 51);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 10;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtBuscarPorDescricao
            // 
            txtBuscarPorDescricao.Location = new Point(399, 32);
            txtBuscarPorDescricao.Name = "txtBuscarPorDescricao";
            txtBuscarPorDescricao.Size = new Size(187, 23);
            txtBuscarPorDescricao.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 14);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 13;
            label3.Text = "Buscar por Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 15);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 7;
            label4.Text = "Buscar por ID";
            // 
            // txtBuscarPorId
            // 
            txtBuscarPorId.Location = new Point(25, 33);
            txtBuscarPorId.Name = "txtBuscarPorId";
            txtBuscarPorId.Size = new Size(77, 23);
            txtBuscarPorId.TabIndex = 8;
            // 
            // btnBuscarPorId
            // 
            btnBuscarPorId.Location = new Point(108, 34);
            btnBuscarPorId.Name = "btnBuscarPorId";
            btnBuscarPorId.Size = new Size(69, 23);
            btnBuscarPorId.TabIndex = 11;
            btnBuscarPorId.Text = "Buscar";
            btnBuscarPorId.UseVisualStyleBackColor = true;
            btnBuscarPorId.Click += btnBuscarPorId_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(701, 309);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(69, 23);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(panel1);
            Controls.Add(dtvCores);
            Name = "FormCores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dtvCores).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtvCores;
        private Panel panel1;
        private TextBox txtBuscarPorId;
        private Label label4;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnBuscarPorId;
        private Button btnBuscarPorDescricao;
        private TextBox txtBuscarPorDescricao;
        private Label label3;
        private ComboBox cbBuscarPorStatus;
        private Label label2;
        private Button btnBuscarPorStatus;
    }
}