using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

/*  Enunciado proposto pelo professor Marcos Lapa
Vamos agora praticar as habilidades de consumo de Web APIs, consumindo uma Web API de piadas (free).
Em anexo temos o link para a documentação da API.
Crie uma aplicação (com interface à sua escolha: Console, Web, Mobile...) para permitir a exibição de uma piada sorteada por vez e por categoria: Programming, Miscellaneous, Dark ou Pun
https://sv443.net/jokeapi/v2
 */

namespace ConsumindoWebAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a categoria da piada ou deixe-a em branco acaso queira buscar qualquer piada!");
            Console.WriteLine("Opções: Programming / Miscellaneous / Dark / Pun");
            string category = Console.ReadLine();
            if(category == "Programming" || category == "Miscellaneous" || category == "Dark" || category == "Pun" || category == "")
            {
                if(category == "")
                {
                    category = "Any";
                }
                GetJoke(category);
            }
            else
            {
                Console.WriteLine("Ta de brincation?");
            }
            Console.ReadKey();
        }

        public static async void GetJoke(string category)
        {
            HttpClient httpClient = new HttpClient();
            string url = $"https://sv443.net/jokeapi/v2/joke/{category}";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
            HttpResponseMessage response = await httpClient.SendAsync(request);
            string dados = await response.Content.ReadAsStringAsync();


            Joke p = JsonConvert.DeserializeObject<Joke>(dados);

            p.printJoke();

        }

    }
}
