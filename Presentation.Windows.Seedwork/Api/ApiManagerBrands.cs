using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.MainBoundedContext.DTO.DgtModule.Brands;
using Newtonsoft.Json;

namespace Presentation.Windows.Seedwork.Api
{
    public class ApiManagerBrands: ApiManagerBase
    {
        public static async Task<List<BrandDTO>> GetAllBrands()
        {
            using (var client = GetHttpClient())
            {
                const string urlKey = "Brands";

                using (var response = await client.GetAsync(urlKey))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        if (result == null || result == "null")
                            return new List<BrandDTO>();
                        else
                        {
                            var items = JsonConvert.DeserializeObject<BrandDTO[]>(result).ToList();
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
