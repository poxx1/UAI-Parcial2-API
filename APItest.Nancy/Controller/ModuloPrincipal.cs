using Nancy;
using Nancy.Extensions;
using Newtonsoft.Json;
using Properties;

namespace APItest.Nancy.Controller
{
    public class ModuloPrincipal : NancyModule
    {
        //Este constructor siempre lleva el mismo nombre que la clase
        public ModuloPrincipal()
        {
            #region Tests + Status 

            Get("/v1/status", _ =>
            {
                return "GET 200: OK";
            });

            Get("/v1/test", _ =>
            {
                return "GET Test Reponse";
            });

            Post("/v1/test", _ =>
            {
                return "POST Test Reponse";
            });

            #endregion

            #region Calculator

            Post("/v1/Price", x =>
            {
                //Objeto a modificar con el POST
                var product = new Product();
                //Obtengo el raw
                var rawRequest = Context.Request.Body.AsString();
                //Lo paso a la clase
                product = JsonConvert.DeserializeObject<Product>(rawRequest);

                //Modifico las propiedades
                product.Price = product.Price + 1;

                //Lo serializo como Json para entregar como respuesta
                string output = JsonConvert.SerializeObject(product);
                return output;
            });

            #endregion
        }
    }
}
