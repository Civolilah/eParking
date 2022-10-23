using eParking.Data.ViewModels;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MobileApps
{
    public class APIService
    {
        private string _route;
        public static string Username { get; set; }
        public static string Password { get; set; }
        public APIService(string route)
        {
            _route = route;
        }
#if DEBUG
        private string _apiUrl = "http://localhost:23138";
#endif
#if RELEASE
        private string _apiUrl = "https://myapp.com";
#endif
        public async Task<T> GetGradove<T>()
        {
            var url = $"{_apiUrl}/{_route}" + "/GetGradove";

            var result = await url.GetJsonAsync<T>();

            return result;
        }
        public async Task<T> GetParkingeByGrad<T>(object input)
        {
            var url = $"{_apiUrl}/{_route}" + "/GetParkingeByGrad";

            if (input != null)
            {
                var keyValueContent = input.ToKeyValue();
                var keys = keyValueContent.Keys.ToList();
                var values = keyValueContent.Values.ToList();
                url += "?";
                int brojac = 0;
                foreach (var item in keys)
                {
                    if (brojac == keys.Count - 1)
                    {
                        url += item.ToString() + "=" + values[brojac].ToString();
                    }
                    else
                    {
                        url += item.ToString() + "=" + values[brojac].ToString() + "&";
                    }
                    brojac++;
                }
            }

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }
        public async Task<T> GetPreporuku<T>(object input)
        {
            var url = $"{_apiUrl}/{_route}" + "/GetParkingPreporuku";

            if (input != null)
            {
                var keyValueContent = input.ToKeyValue();
                var keys = keyValueContent.Keys.ToList();
                var values = keyValueContent.Values.ToList();
                url += "?";
                int brojac = 0;
                foreach (var item in keys)
                {
                    if (brojac == keys.Count - 1)
                    {
                        url += item.ToString() + "=" + values[brojac].ToString();
                    }
                    else
                    {
                        url += item.ToString() + "=" + values[brojac].ToString() + "&";
                    }
                    brojac++;
                }
            }

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }
        public async Task<T> GetDetaljeParkinga<T>(object input)
        {
            var url = $"{_apiUrl}/{_route}" + "/GetParking";

            if (input != null)
            {
                var keyValueContent = input.ToKeyValue();
                var keys = keyValueContent.Keys.ToList();
                var values = keyValueContent.Values.ToList();
                url += "?";
                int brojac = 0;
                foreach (var item in keys)
                {
                    if (brojac == keys.Count - 1)
                    {
                        url += item.ToString() + "=" + values[brojac].ToString();
                    }
                    else
                    {
                        url += item.ToString() + "=" + values[brojac].ToString() + "&";
                    }
                    brojac++;
                }
            }

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }
        public async Task<T> GetSveLokacijeParkinga<T>()
        {
            var url = $"{_apiUrl}/{_route}" + "/GetSveLokacijeParkinga";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }
    }
}
