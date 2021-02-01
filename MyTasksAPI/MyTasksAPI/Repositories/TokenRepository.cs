using MyTasksAPI.Database;
using MyTasksAPI.Models;
using MyTasksAPI.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTasksAPI.Repositories
{
    public class TokenRepository : ITokenRepository
    {
        private readonly MinhasTarefasContext _banco;

        public TokenRepository(MinhasTarefasContext banco)
        {
            _banco = banco;
        }

        public Token Obter(string refreshToken)
        {
           return _banco.Token.FirstOrDefault(a => a.RefreshToken == refreshToken && a.Utilizado == false);
        }

        public void Cadastrar(Token token)
        {
            _banco.Token.Add(token);
            _banco.SaveChanges();
        }

        public void Atualizar(Token token)
        {
            _banco.Token.Update(token);
            _banco.SaveChanges();
        }
    }
}
