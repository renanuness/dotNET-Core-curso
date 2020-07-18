using KissLog.Apis.v1.Listeners;
using KissLog.AspNetCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreIdentity.Config
{
    public class LogConfig
    {
        public static void ConfigureKissLog(IOptionsBuilder options, IConfiguration configuration)
        {
            // register KissLog.net cloud listener
            options.Listeners.Add(new KissLogApiListener(new KissLog.Apis.v1.Auth.Application(
                configuration["KissLog.OrganizationId"],    //  "35c43b56-e2b6-4aae-a664-bca8872359b9"
                configuration["KissLog.ApplicationId"])     //  "b3952068-61e2-4c90-b976-9ccc1d72601a"
            )
            {
                ApiUrl = configuration["KissLog.ApiUrl"]    //  "https://api.kisslog.net"
            });

            // optional KissLog configuration
            options.Options
                .AppendExceptionDetails((Exception ex) =>
                {
                    StringBuilder sb = new StringBuilder();

                    if ( ex is System.NullReferenceException nullRefException )
                    {
                        sb.AppendLine("Important: check for null references");
                    }

                    return sb.ToString();
                });

            // KissLog internal logs
            options.InternalLog = (message) =>
            {
                Debug.WriteLine(message);
            };
        }
    }
}
