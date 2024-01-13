using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitcoin_Valor_API.Dolar
{
    public class Dolar_Cotacao
    {
        public string api_response()
        {

            try
            {
                string valor = "https://api.hgbrasil.com/finance?fields=only_results,USD&key=29eda3df";

                HttpClient httpClient = new HttpClient();
                var response = httpClient.GetAsync(valor).Result;
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    Currencies bitcoin_Valor = JsonConvert.DeserializeObject<Currencies>(result);
                    

                    string ValorFinal = Math.Round(bitcoin_Valor.Currencie.ValorDoDolar, 2).ToString();
                    return ValorFinal;

                }

                else
                {
                    return "";
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "";
            }


        }

    }

    public class Currencies
    {
        
        [JsonProperty(PropertyName = "currencies")]
        public Dolar_Valor Currencie { get; set; }
    }
    public class Dolar_Valor
    {
       
        [JsonProperty(PropertyName = "buy")]
        public double ValorDoDolar { get; set; }
    }
}
