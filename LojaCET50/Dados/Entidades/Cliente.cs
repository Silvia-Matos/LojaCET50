using System;
using System.ComponentModel.DataAnnotations;

namespace LojaCET50.Dados.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }


        public string Nome { get; set; }


        public string Apelido { get; set; }


        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }


        public string Morada { get; set; }


        public string Email { get; set; }


        public string Telefone { get; set; }











    }
}

