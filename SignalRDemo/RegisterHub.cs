using Microsoft.AspNet.SignalR;
using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(SignalRDemo.RegisterHub))]

namespace SignalRDemo
{
    public class RegisterHub
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
            app.MapSignalR();
            //app.MapSignalR<DemoPersistentConnection>("/Connections/DemoPersistentConnection");
            //app.MapSignalR<AuthorizationPersistentConnection>("/Connections/AuthorizationPersistentConnection");

            app.Map("/EnableDetailedErrors", map =>
            {
                var hubConfiguration = new HubConfiguration
                {
                    EnableDetailedErrors = true
                };

                map.MapSignalR(hubConfiguration);
            });
            // Any connection or hub wire up and configuration should go here
            //app.MapSignalR();
        }

    }
}
