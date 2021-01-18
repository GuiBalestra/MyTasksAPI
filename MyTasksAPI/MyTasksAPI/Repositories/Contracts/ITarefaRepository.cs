﻿using MyTasksAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTasksAPI.Repositories.Contracts
{
    public interface ITarefaRepository
    {
        List<Tarefa> Sincronizacao(List<Tarefa> tarefas);

        List<Tarefa> Restauracao(ApplicationUser usuario, DateTime dataUltimaSincronizacao);
    }
}
