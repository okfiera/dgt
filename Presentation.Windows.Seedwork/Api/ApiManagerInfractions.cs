using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Application.MainBoundedContext.DTO.DgtModule.Infractions;
using Newtonsoft.Json;

namespace Presentation.Windows.Seedwork.Api
{
    public class ApiManagerInfractions: ApiManagerBase
    {
        const string URL_KEY = "infractions";
        public static async Task<List<InfractionDTO>> Search(string vehicleLicense, string driverIdentifier, string infractionTypeId, DateTime? from, DateTime? to)
        {
            var url = URL_KEY + "/search/?";

            if (!String.IsNullOrEmpty(vehicleLicense))
                url += "vehicleLicense=" + vehicleLicense + "&";

            if (!String.IsNullOrEmpty(driverIdentifier))
                url += "driverIdentifier=" + driverIdentifier + "&";

            if (!String.IsNullOrEmpty(infractionTypeId))
                url += "infractionTypeId=" + infractionTypeId;

            if (from != null)
                url += "from=" + from.Value.ToString("yyyy-MM-dd") + "&";

            if (to != null)
                url += "to=" + to.Value.ToString("yyyy-MM-dd") + "&";

            if (url.EndsWith("&"))
                url = url.Substring(0, url.Length - 1);


            using (var client = GetHttpClient())
            {
                using (var response = await client.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        if (result == null || result == "null")
                            return new List<InfractionDTO>();
                        else
                        {
                            var items = JsonConvert.DeserializeObject<InfractionDTO[]>(result).ToList();
                            return items;
                        }
                    }
                    else
                        throw new Exception(GetHttpError(response));
                }
            }
        }

        public static async Task<InfractionDTO> AddNew(InfractionDTO infraction)
        {
            using (var client = GetHttpClient())
            {
                var serializeObject = JsonConvert.SerializeObject(infraction);
                var content = new StringContent(serializeObject, Encoding.UTF8, "application/json");
                using (var response = await client.PostAsync(URL_KEY + "/save", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        if (response.Content != null)
                        {
                            var stringResult = await response.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject<InfractionDTO>(stringResult);
                            return result;
                        }
                        else
                            return null;
                    }
                    else
                    {
                        throw new Exception(await CastResultError(response));
                    }
                }
            }
        }

        public static async Task<List<InfractionDTO>> ByDriverIdentifier(string identifier)
        {
            using (var client = GetHttpClient())
            {
                using (var response = await client.GetAsync(URL_KEY + "/driver/" + identifier))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        if (result == null || result == "null")
                            return new List<InfractionDTO>();
                        else
                        {
                            var items = JsonConvert.DeserializeObject<InfractionDTO[]>(result).ToList();
                            return items;
                        }
                    }
                    else
                        throw new Exception(GetHttpError(response));
                }
            }
        }

        public static async Task<List<InfractionDTO>> ByVehicleLicense(string license)
        {
            using (var client = GetHttpClient())
            {
                using (var response = await client.GetAsync(URL_KEY + "/vehicle/" + license))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        if (result == null || result == "null")
                            return new List<InfractionDTO>();
                        else
                        {
                            var items = JsonConvert.DeserializeObject<InfractionDTO[]>(result).ToList();
                            return items;
                        }
                    }
                    else
                        throw new Exception(GetHttpError(response));
                }
            }
        }

    }
}
