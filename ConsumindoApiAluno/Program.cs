using ConsumindoApiAluno.Entities;
using ConsumindoApiAluno.Entities.Services;

namespace ConsumindoApiAluno
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Informe o id: ");
            int id = int.Parse(Console.ReadLine());

            AlunoServices alunoServices = new AlunoServices();

            Aluno alunoEncontrado = await alunoServices.Integracao(id);

            if (!alunoEncontrado.Verificacao)
            {
                Console.WriteLine("Aluno Encontrado");

                Console.WriteLine("Nome: " + alunoEncontrado.Nome);
                Console.WriteLine("Matricula: " + alunoEncontrado.Matricula);
                Console.WriteLine("Situacao: " + alunoEncontrado.Situacao);
            }
            else
            {
                Console.WriteLine("Aluno não encontrado");
            }
        }
    }
}