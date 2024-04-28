using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomoveisCadastro
{
    public partial class FormCores : Form
    {
        string connectionString = "";

        public FormCores()
        {
            InitializeComponent();
            this.Load += FormCores_Load;
        }

        private void CarregarTodosOsDados()
        {
            string query = "SELECT * FROM cores";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dtvCores.DataSource = dataTable;
            }
        }

        private void ExcluirRegistro(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT COUNT(*) FROM Veiculos WHERE Cor_id = @id";
                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@id", id);
                        int veiculosVinculados = (int)selectCommand.ExecuteScalar();

                        if (veiculosVinculados > 0)
                        {
                            MessageBox.Show("Não é possível excluir este registro, pois há veículos vinculados a esta cor.", "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string deleteQuery = "DELETE FROM cores WHERE id = @id";
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@id", id);
                        deleteCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCores_Load(object sender, EventArgs e)
        {
            CarregarTodosOsDados();
            ConfigurarDataGridView();

        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscarPorId.Text) && int.TryParse(txtBuscarPorId.Text, out int id))
            {
                string query = "SELECT * FROM cores WHERE id = @id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dtvCores.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhuma cor encontrada com o ID fornecido.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite um ID válido.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBuscarPorId.Text = "";
            txtBuscarPorDescricao.Text = "";
            CarregarTodosOsDados();
        }

        private void btnBuscarPorDescricao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscarPorDescricao.Text))
            {
                string query = "SELECT * FROM cores WHERE descricao LIKE @descricao";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@descricao", "%" + txtBuscarPorDescricao.Text + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dtvCores.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhuma cor encontrada com a Descrição fornecida.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite uma Descrição válida.");
            }
        }

        private void btnBuscarPorStatus_Click(object sender, EventArgs e)
        {
            string statusSelecionado = cbBuscarPorStatus.SelectedItem.ToString();

            bool statusBooleano;
            if (statusSelecionado == "Ativo")
            {
                statusBooleano = true;
            }
            else if (statusSelecionado == "Inativo")
            {
                statusBooleano = false;
            }
            else
            {
                MessageBox.Show("Selecione um status válido.");
                return;
            }

            string query = "SELECT * FROM cores WHERE status = @status";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@status", statusBooleano);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dtvCores.DataSource = dataTable;

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhuma cor encontrada com o status fornecido.");
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM cores", connection);

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    DataTable dataTable = (DataTable)dtvCores.DataSource;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row["status"] == DBNull.Value || Convert.ToBoolean(row["status"]) == false)
                        {
                            row["status"] = false;
                        }
                        else
                        {
                            row["status"] = true;
                        }
                    }

                    adapter.Update(dataTable);

                    MessageBox.Show("Alterações salvas com sucesso.");
                    CarregarTodosOsDados();

                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show("A descrição já existe na tabela de cores. Por favor, insira uma descrição diferente.", "Erro de inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao salvar as alterações: " + ex.Message, "Erro de salvamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar as alterações: " + ex.Message);
            }
        }

        private void ConfigurarDataGridView()
        {
            dtvCores.Columns["id"].ReadOnly = true;

            foreach (DataGridViewColumn column in dtvCores.Columns)
            {
                if (column.Name != "id")
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.Beige;
            dtvCores.Columns["id"].DefaultCellStyle = style;

            dtvCores.KeyDown += dtvCores_KeyDown;
        }

        private void dtvCores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dtvCores.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dtvCores.SelectedRows[0].Cells["ID"].Value);

                    ExcluirRegistro(id);

                    CarregarTodosOsDados();
                }
            }
        }
    }
}
