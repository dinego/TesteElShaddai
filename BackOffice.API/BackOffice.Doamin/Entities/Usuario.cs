﻿using BackOffice.Doamin.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackOffice.Doamin.Entities
{
    [Table("Usuario")]
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public EPerfil Perfil { get; set; }
        public string SenhaHash { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
