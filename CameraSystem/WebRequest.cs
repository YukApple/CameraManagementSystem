using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CameraSystem
{
    public class WebRequest
    {
        private string BASE_URL = "http://localhost:56501/api/";
        public Task<HttpResponseMessage> getmachine()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client.GetAsync("machine/getname");
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Task<HttpResponseMessage> getzone()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client.GetAsync("zone/getname");
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Task<HttpResponseMessage> getline()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client.GetAsync("line/getname");
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Task<HttpResponseMessage> getmodel()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client.GetAsync("model/getname");
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Task<HttpResponseMessage> getprocess()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client.GetAsync("process/getname");
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Task<HttpResponseMessage> getaccount()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client.GetAsync("account");
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
