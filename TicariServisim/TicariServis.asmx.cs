using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TicariServisim
{
    /// <summary>
    /// TicariServis için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class TicariServis : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(string Ad, string Soyad, int yas)
        {
            return "Merhaba " + Ad + " " + Soyad + " " + yas;
        }
    }
}

