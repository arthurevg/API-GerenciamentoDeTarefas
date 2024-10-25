using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GerenciadorDeTarefasAPI.Context;
using GerenciadorDeTarefasAPI.Models;

namespace GerenciadorDeTarefasAPI.Controllers
{
    public class TarefaController : ControllerBase
    {
        private readonly OrganizadorContext _context;

        //CONSTRUTOR
        public TarefaController(OrganizadorContext context)
        {
            _context = context;
        }

        [HttpPost("Criar uma Tarefa")]
        public IActionResult Criar(Tarefa tarefa)
        {
            if(tarefa.Data == DateTime.MinValue)
            tarefa.Data = DateTime.Now;
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = tarefa.Id }, tarefa);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var tarefa = _context.Tarefas.Find(id);
            if (tarefa == null)
            {
                return NotFound();
            }
            return Ok(tarefa);
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos()
        {
            var tarefas = _context.Tarefas;
            return Ok(tarefas);
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo)
        {
            var tarefa = _context.Tarefas.Where(x => x.Titulo == titulo);
            return Ok(tarefa);
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var tarefa = _context.Tarefas.Where(x => x.Data.Date == data.Date);
            return Ok(tarefa);
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(StatusTarefa status)
        {
            var tarefas = _context.Tarefas.Where(x => x.Status == status);
            if (tarefas == null || !tarefas.Any())
            {
                return NotFound("Nenhuma tarefa encontrada com o status especificado.");
            }

            return Ok(tarefas);
        }



        [HttpPut("{id}")]
        public IActionResult Atualizar(int id,[FromBody] Tarefa tarefa)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null)
                return NotFound();
            tarefaBanco.Titulo = tarefa.Titulo;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.Data = tarefa.Data;
            tarefaBanco.Status = tarefa.Status;

            _context.Tarefas.Update(tarefaBanco);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null)
                return NotFound();

            _context.Tarefas.Remove(tarefaBanco);
            _context.SaveChanges();
            return NoContent();
        }

    }
}