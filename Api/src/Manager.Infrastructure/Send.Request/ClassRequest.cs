using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Manager.Infrastructure.Send.Request
{
    public class ClassRequest
    {
        private string msg;
        HttpClient client = new HttpClient();

        public async Task<string> GetDataAsync()
        {
            var data = await client.GetStringAsync("https://api.baselinker.com/connector.php");

            return msg = data;
           
        }
    }
}