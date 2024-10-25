```markdown
# GerenciadorDeTarefasAPI

GerenciadorDeTarefasAPI é uma API para gerenciar tarefas, permitindo criar, atualizar, deletar e consultar tarefas com base em diferentes critérios.

## Estrutura do Projeto

```

## Endpoints

### Criar uma Tarefa

- **URL:** `/Criar uma Tarefa`
- **Método:** `POST`
- **Descrição:** Cria uma nova tarefa.
- **Corpo da Requisição:**
  ```json
  {
    "titulo": "string",
    "descricao": "string",
    "data": "DateTime",
    "status": "StatusTarefa"
  }
  ```
- **Resposta de Sucesso:** `201 Created`

### Obter Tarefa por ID

- **URL:** `/{id}`
- **Método:** `GET`
- **Descrição:** Obtém uma tarefa pelo ID.
- **Resposta de Sucesso:** `200 OK`

### Obter Todas as Tarefas

- **URL:** `/ObterTodos`
- **Método:** `GET`
- **Descrição:** Obtém todas as tarefas.
- **Resposta de Sucesso:** `200 OK`

### Obter Tarefas por Título

- **URL:** `/ObterPorTitulo`
- **Método:** `GET`
- **Descrição:** Obtém tarefas pelo título.
- **Resposta de Sucesso:** `200 OK`

### Obter Tarefas por Data

- **URL:** `/ObterPorData`
- **Método:** `GET`
- **Descrição:** Obtém tarefas pela data.
- **Resposta de Sucesso:** `200 OK`

### Obter Tarefas por Status

- **URL:** `/ObterPorStatus`
- **Método:** `GET`
- **Descrição:** Obtém tarefas pelo status.
- **Resposta de Sucesso:** `200 OK`

### Atualizar Tarefa

- **URL:** `/{id}`
- **Método:** `PUT`
- **Descrição:** Atualiza uma tarefa existente.
- **Corpo da Requisição:**
  ```json
  {
    "titulo": "string",
    "descricao": "string",
    "data": "DateTime",
    "status": "StatusTarefa"
  }
  ```
- **Resposta de Sucesso:** `200 OK`

### Deletar Tarefa

- **URL:** `/{id}`
- **Método:** `DELETE`
- **Descrição:** Deleta uma tarefa pelo ID.
- **Resposta de Sucesso:** `204 No Content`

## Configuração

### Dependências

- .NET 8.0
- Entity Framework Core

### Configuração do Banco de Dados

Configure a string de conexão no arquivo `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "ConexaoPadrao": "Server = localhost\\[SeuServidorSQL]; Initial Catalog = [NomeDaSuaContext]; Integrated Security = True"
  }
}
```

### Executando Migrações

Para aplicar as migrações do Entity Framework Core, execute:

```sh
dotnet-ef database update
```

## Executando a API

Para executar a API, use o comando:

```sh
dotnet watch run
```

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests.
