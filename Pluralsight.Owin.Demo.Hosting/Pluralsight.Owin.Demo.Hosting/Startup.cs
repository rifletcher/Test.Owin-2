using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Owin;

namespace Pluralsight.Owin.Demo.Hosting
{
    public class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            // view with http://localhost:12345/photo.jpg
            app.UseStaticFiles();

            app.Use(async (ctx, next) =>
            {
                await ctx.Response.WriteAsync("Hello World");
            });
        }
    }
}
