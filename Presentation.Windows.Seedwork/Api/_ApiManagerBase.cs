using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Presentation.Windows.Seedwork.Api
{
    #region Protected methods

    public abstract class ApiManagerBase
    {
        protected static HttpClient GetHttpClient()
        {
            var apiUrl = ConfigurationManager.AppSettings["ApiUrl"];
            var client = new HttpClient() { BaseAddress = new Uri(apiUrl) };

            return client;
        }

        protected static async Task<string> CastResultError(HttpResponseMessage response)
        {

            var stringErrorResult = await response.Content.ReadAsStringAsync();
            if (String.IsNullOrEmpty(stringErrorResult))
                return GetHttpError(response);
            else
            {
                var errorMessage = "";
                var result = JsonConvert.DeserializeObject<ApiResultError>(stringErrorResult);
                if (!string.IsNullOrEmpty(result.message))
                    errorMessage = result.message + Environment.NewLine;

                if (result.errors != null && result.errors.Any())
                {
                    foreach (var error in result.errors.Where(e => !String.IsNullOrEmpty(e.message)))
                        errorMessage += error.message + Environment.NewLine;
                }

                return errorMessage;
            }
        }

        protected static string GetHttpError(HttpResponseMessage msg)
        {
            var message = "";
            switch (msg.StatusCode)
            {
                case HttpStatusCode.NotFound:
                    message = String.Format("La dirección '{0}' no es correcta", msg.RequestMessage.RequestUri);
                    break;
                case HttpStatusCode.InternalServerError:
                    message = String.Format("La solicitud a la dirección '{0}' ha generado el siguiente error:" + Environment.NewLine + msg.ReasonPhrase, msg.RequestMessage.RequestUri);
                    break;
                case HttpStatusCode.Redirect:
                    message = String.Format("La dirección '{0}' ha sido movida", msg.RequestMessage.RequestUri);
                    break;
                case HttpStatusCode.Forbidden:
                    message = String.Format("No tiene acceso a la url solicitada ({0}).", msg.RequestMessage.RequestUri);
                    break;
                case HttpStatusCode.Unauthorized:
                    message = String.Format("No tiene autorización para solicitar la url ({0}).", msg.RequestMessage.RequestUri);
                    break;

            }

            if (String.IsNullOrEmpty(message))
            {
                if (!String.IsNullOrEmpty(msg.ReasonPhrase))
                    message = String.Format("Ha ocurrido el siguiente error solicitando la dirección '{0}'" + Environment.NewLine + "{1}", msg.RequestMessage.RequestUri, msg.ReasonPhrase);
                else
                    message = String.Format("Ha ocurrido un error solicitando la dirección '{0}'", msg.RequestMessage.RequestUri);
            }

            return message;
        }
    }

    #endregion

}
