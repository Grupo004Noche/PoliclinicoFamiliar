using ClientPoliclinicoLaFamilia.Models;
using Newtonsoft.Json;

namespace ClientPoliclinicoLaFamilia.Services
{
    public class MedicoService
    {
        string url = "https://localhost:7033";
        string endPoint = "";
        HttpClient client = new HttpClient();
        public async Task<List<Medico>> ListaIngredientes()
        {
            endPoint = "api/Medico";
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await client.GetAsync(endPoint);
            List<Medico> result = new List<Medico>();
            if (response.IsSuccessStatusCode)
            {
                string respuestaCuerpo = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<Medico>>(respuestaCuerpo);
            }
            return result;
        }
    }
}
