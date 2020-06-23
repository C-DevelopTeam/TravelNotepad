using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TravelClient.utils
{
    public class Client
    {
        private HttpClient CreateClient()
        {
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = delegate { return true; };
            HttpClient client = new HttpClient(handler);

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

            return client;
        }

        public async Task<HttpResponseMessage> Post(string url, string data)
        {
            HttpResponseMessage result = new HttpResponseMessage();
            using (HttpClient client = CreateClient())
            {
                try
                {
                    var request = new HttpRequestMessage(HttpMethod.Post, url);
                    request.Content = new StringContent(data, Encoding.Unicode, "application/xml");
                    result = await client.SendAsync(request);
                }
               catch(Exception e)
                {
                    throw new Exception("Unable to connect to the server", e);
                }
            }
            return result;
        }

        public async Task<HttpResponseMessage> Delete(string url)
        {
            HttpResponseMessage result = new HttpResponseMessage();
            using (HttpClient client = CreateClient())
            {
                try
                {
                    result = await client.DeleteAsync(url);
                }
                catch (Exception e)
                {
                    throw new Exception("Unable to connect to the server", e);
                }
            }
            return result;
        }

        public async Task<HttpResponseMessage> Get(string url)
        {
            HttpResponseMessage result = new HttpResponseMessage();
            using (HttpClient client = CreateClient())
            {
                try
                {
                    result = await client.GetAsync(url);
                }
                catch (Exception e)
                {
                    throw new Exception("Unable to connect to the server", e);
                }
            }
            return result;
        }

        public async Task<HttpResponseMessage> Put(string url, string data)
        {
            HttpResponseMessage result = new HttpResponseMessage();
            using (HttpClient client = CreateClient())
            {
                try
                {
                    var request = new HttpRequestMessage(HttpMethod.Put, url);
                    request.Content = new StringContent(data, Encoding.Unicode, "application/xml");
                    result = await client.SendAsync(request);
                }
                catch (Exception e)
                {
                    throw new Exception("Unable to connect to the server", e);
                }
            }
            return result;
        }
    }
}
