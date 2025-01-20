using Npgsql;

namespace Fornecedores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        // função do botao de salvar
        private void btbCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") || !txtCPF.Text.Equals("") || !txtEmail.Text.Equals("") || !txtEndereco.Text.Equals(""))
                {
                    // chamando o método de cadastroFuncionarios
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Nome = txtNome.Text;
                    cadFuncionarios.Email = txtEmail.Text;
                    cadFuncionarios.Cpf = txtCPF.Text;
                    cadFuncionarios.Endereco = txtEndereco.Text;

                    if (cadFuncionarios.cadastrarFuncionarios())
                    {
                        MessageBox.Show($"Funcionário {cadFuncionarios.Nome} cadastrado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel cadastrar Funcionário!");
                    }
                }
                else
                {
                    MessageBox.Show("Preencher todos os campo corretamente!");
                    txtNome.Clear();
                    txtCPF.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    txtNome.Focus();
                }
            }
            catch (Exception err)
            {

                MessageBox.Show("Erro ao cadastrar funcionário: " + err.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCPF.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Cpf = txtCPF.Text;

                    NpgsqlDataReader reader = cadFuncionarios.localizarFuncionario();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            lblId.Text = reader["id"].ToString();
                            txtNome.Text = reader["nome"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtEndereco.Text = reader["endereco"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Funcionário não encontrado.");
                            txtNome.Clear();
                            txtCPF.Clear();
                            txtEmail.Clear();
                            txtEndereco.Clear();
                            txtNome.Focus();
                            lblId.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Funcionário não encontrado.");
                        txtNome.Clear();
                        txtCPF.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtCPF.Focus();
                        lblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Digte o CPF corretamente!");
                    txtNome.Clear();
                    txtCPF.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    txtCPF.Focus();
                    lblId.Text = "";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro ao buscar funcionário: " + err.Message);
                return;
            }
        }

        private void lblLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNome.Focus();
            lblId.Text = "";
        }

        private void lblAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCPF.Text.Equals("") && !txtEmail.Text.Equals("") && !txtEndereco.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Id = int.Parse(lblId.Text);
                    cadFuncionarios.Email = txtEmail.Text;
                    cadFuncionarios.Endereco = txtEndereco.Text;

                    if (cadFuncionarios.atualizarFuncionario())
                    {
                        MessageBox.Show("Dados dos funcionário atualizados");
                        txtNome.Clear();
                        txtCPF.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtCPF.Focus();
                        lblId.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar o funcionário");
                        txtNome.Clear();
                        txtCPF.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtCPF.Focus();
                        lblId.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Favor localizar funcionário que deseja realizar a atualização");
                    txtNome.Clear();
                    txtCPF.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    txtCPF.Focus();
                    lblId.Text = "";
                }
            }
            catch (Exception err)
            {

                MessageBox.Show("Erro ao atuaizar funcionário.");
            }
        }

        private void lblDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCPF.Text.Equals("") && !txtEmail.Text.Equals("") && !txtEndereco.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionario = new cadastroFuncionarios();
                    cadFuncionario.Id = int.Parse(lblId.Text);

                    if (cadFuncionario.deletarFuncionario())
                    {
                        MessageBox.Show("Funcionário excluído com sucesso");
                        txtNome.Clear();
                        txtCPF.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        lblId.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel excluir funcionário");
                        txtNome.Clear();
                        txtCPF.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        lblId.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Favor localizar funcionário que deseja realizar a exclusão");
                    txtNome.Clear();
                    txtCPF.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    txtCPF.Focus();
                    lblId.Text = "";
                }
            }
            catch (Exception err)
            {


                MessageBox.Show("Erro ao excluir funcionário" + err.Message);
            }

        }
    }
}
