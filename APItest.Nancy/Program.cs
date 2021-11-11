using System;
using Microsoft.Owin.Hosting;

namespace APItest.Nancy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lastra Julian: API REST Nancy");

            //Configuro el puerto
            var url = "http://+:27015";

            //Inicializo el servicio
            using (WebApp.Start<StartUp>(url))
            {
                //Valido si existe el servicio/se inicializo
                Console.WriteLine("El servicio esta corriendo:");
                Console.WriteLine($"Port: {url}");
                Console.ReadLine(); //Espero 
            }
        }
    }
}
