using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Newtonsoft.Json;

namespace CodingCafeWebApplication
{
    /// <summary>
    /// Descrizione di riepilogo per WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        DataTable dtCountries = new DataTable();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Sum(int a,int b)
        {
            return a+b;
        }

        [WebMethod]
        public string Countries()
        {
            dtCountries.Columns.Add("Country Name");
            dtCountries.Columns.Add("Continent");

            dtCountries.Rows.Add("Italia","Europa");
            dtCountries.Rows.Add("Francia", "Europa");
            dtCountries.Rows.Add("Germania", "Europa");
            dtCountries.Rows.Add("Texas", "America");
            dtCountries.Rows.Add("Cina", "Asia");
            dtCountries.Rows.Add("Giappone", "Asia");

            return JsonConvert.SerializeObject(dtCountries);
        }
    }
}
