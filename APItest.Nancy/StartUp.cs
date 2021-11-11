using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owin;

namespace APItest.Nancy
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}
