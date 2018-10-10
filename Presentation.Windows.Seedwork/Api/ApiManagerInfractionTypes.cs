using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.MainBoundedContext.DTO.DgtModule.InfractionTypes;
using Newtonsoft.Json;
using System.Net.Http;

namespace Presentation.Windows.Seedwork.Api
{
   
    public class ApiManagerInfractionTypes: ApiManagerBase
    {
        const string URL_KEY = "infractiontypes";

        public static async Task<List<InfractionTypeDTO>> GetAllInfractionTypes()
        {
            using (var client = GetHttpClient())
            {
                using (var response = await client.GetAsync(URL_KEY))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        if (result == null || result == "null")
                            return new List<InfractionTypeDTO>();
                        else
                        {
                            var items = JsonConvert.DeserializeObject<InfractionTypeDTO[]>(result).ToList();
                            return items;
                        }
                    }
                    else
                        throw new Exception(GetHttpError(response));
                }
            }
        }

        public static async Task<InfractionTypeDTO> AddNew(InfractionTypeDTO infractionType)
        {
            using (var client = GetHttpClient())
            {
                var serializeObject = JsonConvert.SerializeObject(infractionType);
                var content = new StringContent(serializeObject, Encoding.UTF8, "application/json");
                using (var response = await client.PostAsync(URL_KEY, content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        if (response.Content != null)
                        {
                            var stringResult = await response.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject<InfractionTypeDTO>(stringResult);
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
