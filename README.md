# DIO - Trilha .NET - Fundamentos 
## Desafio de Projeto: Construindo um Sistema de Agendamento de Tarefas com Entity Framework

## Contexto
Precisei contruir um sistema gerenciador de tarefas, onde é possível cadastrar uma lista de tarefas que permitirá organizar melhor a rotina. Essa lista de tarefas possui um CRUD, ou seja permite criar, listar, atualizar e deletar os registros/tarefas.

### A classe principal, a classe da Tarefa, foi contruída da seguinte maneira:


![Classe Principal](/imgs/Classe_Principal.png)

## Métodos:
### Swagger:

![Métodos](/imgs/Metodos.png)


### Endpoints:


| Verbo  |         Endpoint       | Parâmetro |     Body       |
| ------ | :--------------------: | :-------: | :------------: |
| POST   | /Tarefa                |    N/A    | Schema Tarefa  |   
| PUT    | /Tarefa/{id}           |    id     | Schema Tarefa  |
| DELETE | /Tarefa/{id}           |    id     |      N/A       |     
| GET    | /Tarefa/{id}           |    id     |      N/A       |
| GET    | /Tarefa/ObterTodos     |    N/A    |      N/A       |
| GET    | /Tarefa/ObterPorTitulo |  titulo   |      N/A       |
| GET    | /Tarefa/ObterPorData   |   data    |      N/A       |
| GET    | /Tarefa/ObterPorStatus |  status   |      N/A       |


### Esse é o schema (model) de Tarefa, utilizado para passar os métodos:

```json
{
  "id": 0,
  "titulo": "string",
  "descricao": "string",
  "data": "2022-06-08T01:31:07.056Z",
  "status": "Pendente"
}
```




(Fontes(imagens, contexto do desafio) disponibilizadas pela equipe DIO => [DESAFIO DIO](https://github.com/digitalinnovationone/trilha-net-api-desafio))