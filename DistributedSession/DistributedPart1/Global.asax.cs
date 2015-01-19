using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Harbour.RedisSessionStateStore;
using ServiceStack.Redis;

namespace DistributedPart1
{
    public class Global : System.Web.HttpApplication
    {
        private IRedisClientsManager clientManager;

        protected void Application_Start(object sender, EventArgs e)
        {
            var redisServer = ConfigurationManager.AppSettings["sessionRedisBase"];

            this.clientManager = new PooledRedisClientManager(redisServer);
            RedisSessionStateStoreProvider.SetClientManager(this.clientManager);

            // Configure options on the provider.
            RedisSessionStateStoreProvider.SetOptions(new RedisSessionStateStoreOptions()
            {
                KeySeparator = ":",
                OnDistributedLockNotAcquired = sessionId =>
                {
                    Console.WriteLine("Session \"{0}\" could not establish distributed lock. " +
                                      "This most likely means you have to increase the " +
                                      "DistributedLockAcquireSeconds/DistributedLockTimeoutSeconds.", sessionId);
                }
            });
        }

        protected void Application_End()
        {
            this.clientManager.Dispose();
        }
    }
}