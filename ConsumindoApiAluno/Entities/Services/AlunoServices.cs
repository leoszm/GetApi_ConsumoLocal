using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsumindoApiAluno.Entities.Services
{
    internal class AlunoServices
    {  
        //codigo abaixo é composto por async(aguardar retorno do aluno na lista de desejo(Aluno))
        //e o que será passado de informação que é id
        public async Task<Aluno> Integracao(int id)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://localhost:5296/aluno/{id}");
            var jsonString = await response.Content.ReadAsStringAsync();
            //                                             id da requisição(jsonString) vira id do <aluno>         
            var jsonObject = JsonConvert.DeserializeObject<Aluno>(jsonString);

            return jsonObject;

            if(jsonObject != null)
            {
                return jsonObject;
            }
            else
            {
                return new Aluno
                {
                    Verificacao = true
                };
            }


        }
    }
}
