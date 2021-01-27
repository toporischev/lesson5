using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

WebHost.CreateDefaultBuilder().Configure(app =>
    {
        app.UseRouting();
        app.UseEndpoints(e => { e.MapGet("/health/", c => c.Response.WriteAsync("{'status': 'OK'}")); });
    })
    .Build().Run();
