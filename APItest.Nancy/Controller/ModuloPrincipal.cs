using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace APItest.Nancy.Controller
{
    public class ModuloPrincipal : NancyModule
    {
        //Este constructor siempre lleva el mismo nombre que la clase
        public ModuloPrincipal()
        {
            Get("/v1/status", _ =>
            {

                return "200: OK";

            });

            Get("/v1/test", _ =>
            {

                return "Test Reponse";

            });

            Post("/v1/test", _ =>
            {


                return "";

            });
        }
    }
}
