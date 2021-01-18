using MyTasksAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTasksAPI.Repositories.Contracts
{
    public interface IUsuarioRepository
    {
        void Cadastrar(ApplicationUser usuario, string senha);

        ApplicationUser Obter(String email, string senha);
    }
}
