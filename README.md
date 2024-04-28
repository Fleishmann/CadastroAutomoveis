## Como Rodar o Aplicativo Cadastro de Automóveis

Este repositório contém um aplicativo de cadastro de automóveis desenvolvido em Windows Forms utilizando C#. Aqui estão as instruções para executar o aplicativo em seu ambiente local.

### Pré-requisitos

- Visual Studio (versão 2017 ou superior)
- SQL Server Management Studio (opcional para visualizar e interagir com o banco de dados)

### Passo a Passo

1. **Clonar o Repositório:**
   Clone este repositório para o seu ambiente local usando o seguinte comando:

   ```bash
   git clone https://github.com/Fleishmann/CadastroAutomoveis.git
   ``` 

2. **Abrir no Visual Studio:**
   Abra o projeto "CadastroAutomoveis.sln" no Visual Studio.

3. **Configurar a Connection String:**
   Abra os formulários de cada tela do aplicativo (`index.cs`, `FormCores.cs` e `FormCombustiveis.cs`). Dentro de cada classe, localize a variável `connectionString` e insira sua própria string de conexão ao banco de dados SQL Server.

   Exemplo:
   ```csharp
   string connectionString = "Server=DESKTOP-AP8T77F; Database=cadastroAutomoveis;User Id=seu-usuario;Password=sua-senha; TrustServerCertificate=True";
   ```

4. **Criar o Banco de Dados e Tabelas:**
   Abra o SQL Server Management Studio (SSMS) e conecte-se ao seu servidor SQL.

   Execute o script SQL fornecido no arquivo `script.sql` para criar o banco de dados e as tabelas necessárias.

5. **Executar o Aplicativo:**
   No Visual Studio, pressione F5 ou clique em "Iniciar" para compilar e executar o aplicativo.

6. **Explorar Funcionalidades:**
   Após iniciar o aplicativo, você poderá:
   - Cadastrar, atualizar e excluir veículos.
   - Visualizar e filtrar veículos por diferentes critérios.
   - Gerenciar cores e tipos de combustível usando as opções fornecidas na interface do usuário.
   - Utilizar a função de filtro por meio de uma lista separada por vírgula.

### Observações

- **Regras de Negócio:**
  - As alterações nas telas de cores e tipos de combustível são feitas por meio da grade de visualização (DataGridView) fornecida na interface do usuário.
  - O filtro de veículos funciona inserindo os critérios separados por vírgula na caixa de texto de filtro.

Agora você pode explorar e interagir com o aplicativo de cadastro de automóveis! Se tiver alguma dúvida ou encontrar algum problema, não hesite em me contatar. Divirta-se!
