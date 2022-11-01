using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApiAluno.Entities
{
    internal class Aluno
    {
        public int Id { get; set; }
        public string ?Nome { get; set; }
        public string ?Situacao { get; set; }
        public int Matricula { get; set; }

        public bool Verificacao = false;
    }
}
