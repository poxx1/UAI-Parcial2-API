using System;
using Microsoft.Owin.Hosting;

namespace APItest.Nancy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Servidor REST Nancy");

            var url = "http://+:27015";

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
