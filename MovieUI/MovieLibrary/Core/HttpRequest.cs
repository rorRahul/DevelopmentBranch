using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;

namespace MovieLibrary.Core
{
    public class HttpRequest: HttpRequestMessage
    {
        private readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">the type of content expected in the return result</typeparam>
        /// <returns></returns>
        public async Task<T> SendAsyn<T>() where T : class
        {
            var response = await _httpClient.SendAsync(this).ConfigureAwait(false);
            return await ConvertResponse<T>(response).ConfigureAwait(false);
        }

        private Task<T> ConvertResponse<T>(HttpResponseMessage responseMessage) where T : class
        {
            if (responseMessage.IsSuccessStatusCode)
            {
                return Task.Run(async () =>
                {
                    var json = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var response = JsonConvert.DeserializeObject<T>(json);
                    return response;
                });
            }
            throw new Exception();
        }
    }
}
