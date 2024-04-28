using System.Data;
using System.Data.SqlClient;

namespace AutomoveisCadastro
{
    public partial class index : Form
    {
        string connectionString = "";

        public index()
        {
            InitializeComponent();
            this.Load += FormInicial_Load;
        }

        private void CarregarTodosOsDados()
        {
            string query = "SELECT Placa, Renavam, Marca, Modelo, Combustivel_id, Cor_id, Ano_de_Fabricacao, Status FROM Veiculos";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dtvVeiculos.DataSource = dataTable;
            }
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            AtualizarTelas();
        }

        private void AtualizarTelas()
        {
            CarregarTodosOsDados();
            PreencherComboboxCombustivel();
            PreencherComboboxCor();
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtPlaca.Text = "";
            txtRenavam.Text = "";
            txtNumeroChassi.Text = "";
            txtNumeroMotor.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            cbCombustivel.SelectedIndex = -1;
            cbCor.SelectedIndex = -1;
            txtAnoFabricacao.Text = "";
            chkStatus.Checked = false;
        }

        private void PreencherComboboxCombustivel()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id, descricao FROM Combustivel";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    cbCombustivel.DataSource = dataTable;
                    cbCombustivel.DisplayMember = "descricao";
                    cbCombustivel.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao preencher o ComboBox de Combustível: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherComboboxCor()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id, descricao FROM Cores";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    cbCor.DataSource = dataTable;
                    cbCor.DisplayMember = "descricao";
                    cbCor.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao preencher o ComboBox de Cor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExcluirRegistro(string placa)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Veiculos WHERE placa = @placa";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@placa", placa);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Veiculo excluido com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o registro: " + ex.Message);
            }
        }


        private void btnCor_Click(object sender, EventArgs e)
        {
            FormCores novoForm = new FormCores();

            novoForm.ShowDialog();
        }

        private void btnCombustiveis_Click(object sender, EventArgs e)
        {
            FormCombustiveis novoForm = new FormCombustiveis();

            novoForm.ShowDialog();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text;
            string[] criterios = filtro.Split(',');

            string query = "SELECT Placa, Renavam, Marca, Modelo, Combustivel_id, Cor_id, Ano_de_Fabricacao, Status FROM Veiculos WHERE 1=1";

            foreach (string criterio in criterios)
            {
                string crit = criterio.Trim();
                if (!string.IsNullOrEmpty(crit))
                {
                    query += $" AND (Placa LIKE '%{crit}%' OR Marca LIKE '%{crit}%' OR Modelo LIKE '%{crit}%'";

                    if (crit.Equals("Ativo", StringComparison.OrdinalIgnoreCase) || crit.Equals("Inativo", StringComparison.OrdinalIgnoreCase))
                    {
                        bool status = crit.Equals("Ativo", StringComparison.OrdinalIgnoreCase);
                        query += $" OR Status = '{status}'";
                    }

                    query += ")";
                }
            }


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dtvVeiculos.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao filtrar os veículos: " + ex.Message);
            }
        }
        private void ConfigurarDataGridView()
        {
            dtvVeiculos.ReadOnly = true;

            dtvVeiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtvVeiculos.CellClick += async (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    try
                    {
                        string placa = dtvVeiculos.Rows[e.RowIndex].Cells["Placa"].Value?.ToString();

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            await connection.OpenAsync();

                            string query = "SELECT * FROM Veiculos WHERE Placa = @Placa";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@Placa", placa);

                            SqlDataReader reader = await command.ExecuteReaderAsync();

                            if (await reader.ReadAsync())
                            {
                                txtPlaca.Text = reader["Placa"].ToString();
                                txtRenavam.Text = reader["Renavam"].ToString();
                                txtNumeroChassi.Text = reader["Numero_do_Chassi"].ToString();
                                txtNumeroMotor.Text = reader["Numero_do_motor"].ToString();
                                txtMarca.Text = reader["Marca"].ToString();
                                txtModelo.Text = reader["Modelo"].ToString();
                                cbCombustivel.SelectedValue = reader["Combustivel_id"];
                                cbCor.SelectedValue = reader["Cor_id"];
                                txtAnoFabricacao.Text = reader["Ano_de_Fabricacao"].ToString();
                                chkStatus.Checked = Convert.ToBoolean(reader["Status"]);
                            }
                            else
                            {
                                LimparCampos();
                            }

                            reader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao buscar os detalhes do veículo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };

            foreach (DataGridViewColumn column in dtvVeiculos.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dtvVeiculos.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Insert)
                {
                    e.Handled = true;
                }
            };

            dtvVeiculos.KeyDown += dtvVeiculos_KeyDown;
        }

 

        private void dtvVeiculos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dtvVeiculos.SelectedRows.Count > 0)
                {
                    string placa = Convert.ToString(dtvVeiculos.SelectedRows[0].Cells["placa"].Value);

                    ExcluirRegistro(placa);

                    CarregarTodosOsDados();
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = "";
            LimparCampos();
            CarregarTodosOsDados();
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (CamposObrigatoriosPreenchidos())
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        await connection.OpenAsync();

                        string placa = txtPlaca.Text;
                        string renavam = txtRenavam.Text;
                        string numeroMotor = txtNumeroMotor.Text;
                        string numeroChassi = txtNumeroChassi.Text;

                        if (await PlacaExiste(connection, placa))
                        {
                            DialogResult result = MessageBox.Show("Já existe um veículo com a placa informada. Deseja atualizá-lo?", "Veículo Existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                await AtualizarVeiculo(connection, placa, null, null, null);
                                MessageBox.Show("Veículo atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            return;
                        }

                        if (await RenavamExiste(connection, renavam))
                        {
                            DialogResult result = MessageBox.Show("Já existe um veículo com o renavam informado. Deseja atualizá-lo?", "Veículo Existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                await AtualizarVeiculo(connection, null, renavam, null, null);
                                MessageBox.Show("Veículo atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            return;
                        }

                        if (await NumeroMotorExiste(connection, numeroMotor))
                        {
                            DialogResult result = MessageBox.Show("Já existe um veículo com o número do motor informado. Deseja atualizá-lo?", "Veículo Existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                await AtualizarVeiculo(connection, null, null, numeroMotor, null);
                                MessageBox.Show("Veículo atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            return;
                        }

                        if (await NumeroChassiExiste(connection, numeroChassi))
                        {
                            DialogResult result = MessageBox.Show("Já existe um veículo com o número do chassi informado. Deseja atualizá-lo?", "Veículo Existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                await AtualizarVeiculo(connection, null, null, null, numeroChassi);
                                MessageBox.Show("Veículo atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            return;
                        }

                        await InserirVeiculo(connection);

                        MessageBox.Show("Veículo cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AtualizarTelas();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro durante a operação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool CamposObrigatoriosPreenchidos()
        {
            return !string.IsNullOrWhiteSpace(txtPlaca.Text) &&
                   !string.IsNullOrWhiteSpace(txtRenavam.Text) &&
                   !string.IsNullOrWhiteSpace(txtNumeroMotor.Text) &&
                   !string.IsNullOrWhiteSpace(txtNumeroChassi.Text);
        }

        private async Task<bool> PlacaExiste(SqlConnection connection, string placa)
        {
            string query = "SELECT COUNT(*) FROM Veiculos WHERE Placa = @Placa";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Placa", placa);
            int count = (int)await command.ExecuteScalarAsync();
            return count > 0;
        }

        private async Task<bool> RenavamExiste(SqlConnection connection, string renavam)
        {
            string query = "SELECT COUNT(*) FROM Veiculos WHERE Renavam = @Renavam";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Renavam", renavam);
            int count = (int)await command.ExecuteScalarAsync();
            return count > 0;
        }


        private async Task<bool> NumeroMotorExiste(SqlConnection connection, string numeroMotor)
        {
            string query = "SELECT COUNT(*) FROM Veiculos WHERE Numero_do_motor = @NumeroMotor";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NumeroMotor", numeroMotor);
            int count = (int)await command.ExecuteScalarAsync();
            return count > 0;
        }

        private async Task<bool> NumeroChassiExiste(SqlConnection connection, string numeroChassi)
        {
            string query = "SELECT COUNT(*) FROM Veiculos WHERE Numero_do_Chassi  = @NumeroChassi";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NumeroChassi", numeroChassi);
            int count = (int)await command.ExecuteScalarAsync();
            return count > 0;
        }

        private async Task InserirVeiculo(SqlConnection connection)
        {
            string query = @"INSERT INTO Veiculos (Placa, Renavam, Numero_do_motor, Numero_do_Chassi, Marca, Modelo, Combustivel_id, Cor_id, Ano_de_Fabricacao, Status)
                     VALUES (@Placa, @Renavam, @NumeroMotor, @NumeroChassi, @Marca, @Modelo, @CombustivelId, @CorId, @AnoFabricacao, @Status)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Placa", txtPlaca.Text);
            command.Parameters.AddWithValue("@Renavam", txtRenavam.Text);
            command.Parameters.AddWithValue("@NumeroMotor", txtNumeroMotor.Text);
            command.Parameters.AddWithValue("@NumeroChassi", txtNumeroChassi.Text);
            command.Parameters.AddWithValue("@Marca", txtMarca.Text);
            command.Parameters.AddWithValue("@Modelo", txtModelo.Text);
            command.Parameters.AddWithValue("@CombustivelId", cbCombustivel.SelectedValue);
            command.Parameters.AddWithValue("@CorId", cbCor.SelectedValue);
            command.Parameters.AddWithValue("@AnoFabricacao", txtAnoFabricacao.Text);
            command.Parameters.AddWithValue("@Status", chkStatus.Checked);

            await command.ExecuteNonQueryAsync();
        }

        private async Task AtualizarVeiculo(SqlConnection connection, string placa, string renavam, string numeroChassi, string numeroMotor)
        {
            string query = @"UPDATE Veiculos 
                     SET Renavam = @Renavam, 
                         Numero_do_Chassi = @NumeroChassi, 
                         Numero_do_motor = @NumeroMotor, 
                         Marca = @Marca, 
                         Modelo = @Modelo, 
                         Combustivel_id = @CombustivelId, 
                         Cor_id = @CorId, 
                         Ano_de_Fabricacao = @AnoFabricacao, 
                         Status = @Status 
                     WHERE Placa = @Placa";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Placa", placa);
            command.Parameters.AddWithValue("@Renavam", txtRenavam.Text);
            command.Parameters.AddWithValue("@NumeroChassi", txtNumeroChassi.Text);
            command.Parameters.AddWithValue("@NumeroMotor", txtNumeroMotor.Text);
            command.Parameters.AddWithValue("@Marca", txtMarca.Text);
            command.Parameters.AddWithValue("@Modelo", txtModelo.Text);
            command.Parameters.AddWithValue("@CombustivelId", cbCombustivel.SelectedValue);
            command.Parameters.AddWithValue("@CorId", cbCor.SelectedValue);
            command.Parameters.AddWithValue("@AnoFabricacao", txtAnoFabricacao.Text);
            command.Parameters.AddWithValue("@Status", chkStatus.Checked);

            await command.ExecuteNonQueryAsync();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarTelas();
        }
    }
}
