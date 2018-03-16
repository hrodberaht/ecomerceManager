using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Manager.Infrastructure.Send.Request
{
    public class ClassRequest
    {
        HttpClient client = new HttpClient();

        public async Task<object> GetDataAsync()
        {
            var data = await client.GetStreamAsync("https://dog.ceo/api/breeds/list/all");
            return data;
           
        }
    }
}