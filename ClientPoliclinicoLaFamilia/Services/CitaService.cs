using ClientPoliclinicoLaFamilia.Models;
using Newtonsoft.Json;

namespace ClientPoliclinicoLaFamilia.Services
{
    public class CitaService
    {
        string url = "https://localhost:7033";
        string endPoint = "";
        HttpClient client = new HttpClient();
        public async Task<List<Cita>> ListaIngredientes()
        {
            endPoint = "api/Medico";
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await client.GetAsync(endPoint);
            List<Cita> result = new List<Cita>();
            if (response.IsSuccessStatusCode)
            {
                string respuestaCuerpo = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<Cita>>(respuestaCuerpo);
            }
            return result;
        }
    }
}
