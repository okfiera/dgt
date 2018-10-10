using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Application.MainBoundedContext.DTO.DgtModule.Drivers;
using Newtonsoft.Json;

namespace Presentation.Windows.Seedwork.Api
{
    public class ApiManagerDrivers: ApiManagerBase
    {
        const string URL_KEY = "drivers";

        public static async Task<List<DriverDTO>> Search(string filter)
        {
            using (var client = GetHttpClient())
            {
                using (var response = await client.GetAsync(URL_KEY + "/search/" + filter))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        if (result == null || result == "null")
                            return new List<DriverDTO>();
                        else
                        {
                            var items = JsonConvert.DeserializeObject<DriverDTO[]>(result).ToList();
                            return items;
                        }
                    }
                    else
                        throw new Exception(GetHttpError(response));
                }
            }
        }

        public static async Task<DriverDTO> AddNew(DriverDTO driver)
        {
            using (var client = GetHttpClient())
            {
                var serializeObject = JsonConvert.SerializeObject(driver);
                var content = new StringContent(serializeObject, Encoding.UTF8, "application/json");
                using (var response = await client.PostAsync(URL_KEY + "/save", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        if (response.Content != null)
                        {
                            var stringResult = await response.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject<DriverDTO>(stringResult);
                            return result;
                        }
                        else
                            return null;
                    }
                    else
                    {
                        //Logger.Error("Error creando {0} '{1}'.", syncEntity.Singular(), obj.Name);
                        throw new Exception(await CastResultError(response));
                    }
                }
            }
        }
    }
}
