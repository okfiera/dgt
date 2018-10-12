using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Application.MainBoundedContext.DTO.DgtModule.Vehicles;
using Application.MainBoundedContext.DTO.DgtModule.VehiclesDrivers;
using Newtonsoft.Json;

namespace Presentation.Windows.Seedwork.Api
{
    public class ApiManagerVehicles: ApiManagerBase
    {
        const string URL_KEY = "vehicles";
        public static async Task<List<VehicleDTO>> Search(string filter)
        {
            using (var client = GetHttpClient())
            {
                using (var response = await client.GetAsync(URL_KEY + "/search/" + filter))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        if (result == null || result == "null")
                            return new List<VehicleDTO>();
                        else
                        {
                            var items = JsonConvert.DeserializeObject<VehicleDTO[]>(result).ToList();
                            return items;
                        }
                    }
                    else
                        throw new Exception(GetHttpError(response));
                }
            }
        }

        public static async Task<List<VehicleDriverDTO>> ByDriverIdentifier(string identifier)
        {
            using (var client = GetHttpClient())
            {
                using (var response = await client.GetAsync(URL_KEY + "/driver/" + identifier))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        if (result == null || result == "null")
                            return new List<VehicleDriverDTO>();
                        else
                        {
                            var items = JsonConvert.DeserializeObject<VehicleDriverDTO[]>(result).ToList();
                            return items;
                        }
                    }
                    else
                        throw new Exception(GetHttpError(response));
                }
            }
        }



        public static async Task<VehicleDTO> GetByLicense(string license)
        {
            using (var client = GetHttpClient())
            {
                using (var response = await client.GetAsync(URL_KEY + "/license/" + license))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        if (result == null || result == "null")
                            return null;
                        else
                        {
                            var item = JsonConvert.DeserializeObject<VehicleDTO>(result);
                            return item;
                        }
                    }
                    else
                        throw new Exception(GetHttpError(response));
                }
            }
        }


        public static async Task<VehicleDTO> AddNew(VehicleDTO vehicle)
        {
            using (var client = GetHttpClient())
            {
                var serializeObject = JsonConvert.SerializeObject(vehicle);
                var content = new StringContent(serializeObject, Encoding.UTF8, "application/json");
                using (var response = await client.PostAsync(URL_KEY + "/save", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        if (response.Content != null)
                        {
                            var stringResult = await response.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject<VehicleDTO>(stringResult);
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

        public static async Task<VehicleDriverDTO> AttachDriver(string vehicleLicense, string driverIdentifier)
        {
            using (var client = GetHttpClient())
            {
                var url = String.Format("vehicles-drivers/{0}/{1}", vehicleLicense, driverIdentifier);
                using (var response = await client.PostAsync(url, null))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        if (response.Content != null)
                        {
                            var stringResult = await response.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject<VehicleDriverDTO>(stringResult);
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
    }
}
