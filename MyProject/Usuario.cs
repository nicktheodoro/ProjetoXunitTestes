using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }

        private int MaiorIdade = 18;

        public Usuario()
        {
        }

        public Usuario(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public bool MaiorDeIdade()
        {
            if (Idade < MaiorIdade)
                return false;

            return true;
        }
    }
}