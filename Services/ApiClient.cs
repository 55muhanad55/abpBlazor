using Newtonsoft.Json;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;

namespace Web.Blazor.Services
{
    public class ApiClient
    {
        private readonly LocalStorage _localStorage;
        private int? TenantId = null;
        private string Token = null;
        private string Localization = null;

        public ApiClient(LocalStorage localStorage)
        {
            _localStorage = localStorage;
            TenantId = _localStorage.GetItem<int?>("Abp.TenantId");
            Token = _localStorage.GetItem("Abp.AuthToken");
            Localization = _localStorage.GetItem("Abp.Localization.CultureName");
        }

       

        public async Task<T> PostAsync<T>(string methodUrl, object model)
        {
            HttpClient client = new HttpClient();
           
            // Now serialzize the object to json 
            string jsonData = JsonConvert.SerializeObject(model);

            // Create a content 
            HttpContent content = new StringContent(jsonData);

            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            await AddHeader(client);

            // Make a request 
            var response = await client.PostAsync(methodUrl, content);
            var responseAsString = await response.Content.ReadAsStringAsync();

            // Deserialize the coming object into a T object 
            T obj = JsonConvert.DeserializeObject<T>(responseAsString);

            return obj;
        }

        public async Task<T> GetAsync<T>(string methodUrl)
        {
            HttpClient client = new HttpClient();

            await AddHeader(client);
            
            // Send a request and get the response 

            var response = await client.GetAsync(methodUrl);

            // Read the data 
            var jsonData = await response.Content.ReadAsStringAsync();

            T obj = JsonConvert.DeserializeObject<T>(jsonData);

            return obj;
        }

        public async Task<T> PutAsync<T>(string methodUrl, object model)
        {
            HttpClient client = new HttpClient();

            // Serialize the object
            string jsonData = JsonConvert.SerializeObject(model);

            HttpContent content = new StringContent(jsonData);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            await AddHeader(client);


            var response = await client.PutAsync(methodUrl, content);

            var responseAsString = await response.Content.ReadAsStringAsync();

            // Deserialize the coming object into a T object 
            T obj = JsonConvert.DeserializeObject<T>(responseAsString);

            return obj;
        }

        public async Task<T> DeleteAsync<T>(string methodUrl, int id)
        {
            HttpClient client = new HttpClient();

            await AddHeader(client);


            var response = await client.DeleteAsync(methodUrl + "?id=" + id);
            var jsonData = await response.Content.ReadAsStringAsync();
            
            T obj = JsonConvert.DeserializeObject<T>(jsonData);

            return obj;
        }

        public async Task AddHeader(HttpClient client)
        {
            if (!string.IsNullOrEmpty(TenantId.ToString())) { client.DefaultRequestHeaders.Add("Abp.TenantId", TenantId.ToString()); }
            if (!string.IsNullOrEmpty(Token)) { client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Token); }
            if (!string.IsNullOrEmpty(Localization)) { client.DefaultRequestHeaders.Add(".AspNetCore.Culture", Localization); }
            await Task.FromResult(client.DefaultRequestHeaders);
        }

    }
}
