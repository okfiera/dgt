using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.MainBoundedContext.DTO.DgtModule.Brands;
using Application.MainBoundedContext.DTO.DgtModule.Infractions;
using Newtonsoft.Json;

namespace Presentation.Windows.Seedwork.Api
{
    public class ApiManagerTotals: ApiManagerBase
    {
        public static async Task<ItemsCountsDTO> GetItemTotals()
        {
            using (var client = GetHttpClient())
            {
                const string urlKey = "totals";

                using (var response = await client.GetAsync(urlKey))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        if (result == null || result == "null")
                            return new ItemsCountsDTO();
                        else
                        {
                            var items = JsonConvert.DeserializeObject<ItemsCountsDTO>(result);
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
