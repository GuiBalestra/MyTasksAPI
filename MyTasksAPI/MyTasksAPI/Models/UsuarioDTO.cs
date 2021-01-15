﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTasksAPI.Models
{
    public class UsuarioDTO
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string EMail { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        [Compare("Senha")]
        public string ConfirmacaoSenha { get; set; }
    }
}
