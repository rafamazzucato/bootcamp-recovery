using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using TodoApi.Repository;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private readonly TodoItemRepository _repository;
        private readonly ITeste teste;

        public TodoItemController(TodoItemRepository repository,
              ITeste teste2)
        {
            _repository = repository;
            teste = teste2;
        }

        // GET: api/TodoItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GettodoItem()
        {
            return await _repository.Listar();
        }

        // GET: api/TodoItem/tarefasEmAberto
        [HttpGet("tarefasEmAberto")]
        public async Task<ActionResult<IEnumerable<TodoItem>>> OpenedTodos()
        {
            teste.Mensagem();
            return await _repository.Listar();
        }

        // GET: api/TodoItem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItem(int id)
        {
            var todoItem = await _repository.GetById(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        // PUT: api/TodoItem/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(int id, TodoItem todoItem)
        {
            if (id != todoItem.Id)
            {
                return BadRequest();
            }

            try
            {
                await _repository.Atualizar(todoItem);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TodoItem
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        {
            await _repository.Salvar(todoItem);

            return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
        }

        // DELETE: api/TodoItem/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(int id)
        {
            var todoItem = await _repository.GetById(id); //preciso do contexto aqui
            if (todoItem == null)
            {
                return NotFound();
            }

            await _repository.Excluir(id); //preciso do contexto aqui

            return NoContent();
        }

        private bool TodoItemExists(int id)
        {
            return _repository.GetById(id) != null;
        }
    }
}
