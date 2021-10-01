﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Repository
{
    public interface TodoItemRepository
    {
        public Task<List<TodoItem>> Listar();
        public Task Salvar(TodoItem todo);

        public Task Atualizar(TodoItem todo);

        public Task Excluir(int id);
        public Task<TodoItem> GetById(int id);
    }
}
