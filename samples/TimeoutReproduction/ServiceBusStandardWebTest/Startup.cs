using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.ServiceBus.Management;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceBusStandardWebTest
{    
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private static List<QueueClient> _queueClients = new List<QueueClient>();
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        private static string GetQueueName(int i) => $"Queue{i}";

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {       
            var connectionString = "Endpoint=sb://netcore.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=3ZO9jeK2E8RjnacfoxtGPU+ltZZg3achA/gOGZoAww4=";
            var manager = new ManagementClient(connectionString);

            for (var i = 1; i <= 100; i++)
            {
                var queueName = GetQueueName(i);

                if (!manager.QueueExistsAsync(queueName).Result)
                {
                    var qd = new QueueDescription(queueName)
                    {
                        RequiresSession = true,
                        EnableDeadLetteringOnMessageExpiration = true,
                        RequiresDuplicateDetection = true
                    };
                    Debug.WriteLine($"Creating queue {queueName}");
                    manager.CreateQueueAsync(qd).Wait();
                }

                Debug.WriteLine($"Queue {queueName} already created");
            }
            
            for (var i = 1; i <= 100; i++)
            {
                var queueName = GetQueueName(i);
                var queueClient = new QueueClient(connectionString, queueName);
                _queueClients.Add(queueClient);
                Debug.WriteLine($"Registering session handler for {queueName}");
                queueClient.RegisterSessionHandler(async (message, token, b) => {}, async args => {});
            }

            app.UseMvcWithDefaultRoute();
        }        
    }
}
