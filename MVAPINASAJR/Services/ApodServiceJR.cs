using MVAPINASAJR.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVAPINASAJR.Services
{
    public class ApodServiceJR
    {
        public async Task<ApodJR> GetImage(DateTime dt)
        {
            ApodJR dto = null;
            HttpResponseMessage response;
            string requestUrl = $"https://api.nasa.gov/planetary/apod?date={dt.ToString("yyyy-MM-dd")}&api_key=br0RxuTQasuiSCdsXtJSFrPEsCiMWrabdZctBz2K";
            try
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
                HttpClient client = new HttpClient();
                response = await client.SendAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    dto = JsonConvert.DeserializeObject<ApodJR>(json);
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }
            return dto;
        }

    }
}
