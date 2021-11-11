using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Post("/v1/calc", x =>
            {
                var product = new Product();
                var rawRequest = Context.Request.Body.AsString();

                //product.Name = "Papa";
                //product.Price = 4;

                //string output = JsonConvert.SerializeObject(product);

                Product dProduct = JsonConvert.DeserializeObject<Product>(rawRequest);

                dProduct.Price = dProduct.Price + 1;

                string output = JsonConvert.SerializeObject(dProduct);

                return output;
            });

            #endregion

        }
    }
}
