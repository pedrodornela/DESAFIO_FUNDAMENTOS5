using DESAFIO_FUNDAMENTOS5.Context;
using DESAFIO_FUNDAMENTOS5.Entities;
using DESAFIO_FUNDAMENTOS5.Enuns;
using Microsoft.AspNetCore.Mvc;

namespace DESAFIO_FUNDAMENTOS5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController :ControllerBase
    {
        private readonly AgendaContext _context;  
        public TarefaController(AgendaContext context) => _context = context;

        [HttpPost]
        public IActionResult CriaTarefa(Tarefa tarefa)
        {

            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new {Erro = "A data da tarefa não pode ser vazia!"});

            _context.Add(tarefa);
            _context.SaveChanges();

            return CreatedAtAction(nameof(BuscaPorId), new {id = tarefa.Id}, tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaTarefa(int id, Tarefa tarefa)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null) return NotFound();

            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new {Erro = "A data da tarefa não pode ser vazia!"});

            tarefaBanco.Titulo = tarefa.Titulo;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.Data = tarefa.Data;
            tarefaBanco.Status = tarefa.Status;

            _context.Tarefas.Update(tarefaBanco);
            _context.SaveChanges();

            return Ok(tarefa);

        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirTarefa(int id)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null) return NotFound();

            _context.Remove(tarefaBanco);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult BuscaPorId(int id)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null) return NotFound();

            return Ok(tarefaBanco);
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos()
        {
            var tarefaBanco = _context.Tarefas;

            if (tarefaBanco == null) return NotFound(new {Erro = "Não existem tarefas cadastradas!"});

            return Ok(tarefaBanco);
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo)
        {
            var tarefaBanco = _context.Tarefas.Where(x => x.Titulo.Contains(titulo));

            if (tarefaBanco == null) return NotFound();

            return Ok(tarefaBanco);
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var tarefaBanco = _context.Tarefas.Where(x => x.Data.Date == data.Date);

            if (tarefaBanco == null) return NotFound();

            return Ok(tarefaBanco);
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatus status)
        {
            var tarefaBanco = _context.Tarefas.Where(x => x.Status == status);

            if (tarefaBanco == null) return NotFound();

            return Ok(tarefaBanco);
        }

    }
}