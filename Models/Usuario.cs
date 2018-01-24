using System;
using System.ComponentModel.DataAnnotations;

namespace ForumApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Display(Name="Nome do Usuário")]
        [Required(ErrorMessage="Esse campo é obrigatório")]
        [MinLength(2,ErrorMessage="Deve possuir mais de 2 caracteres")]
        [MaxLength(10,ErrorMessage="Maximo de 10 caracteres")]

        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}