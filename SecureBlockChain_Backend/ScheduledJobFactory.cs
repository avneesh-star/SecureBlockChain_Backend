using Microsoft.Extensions.DependencyInjection;
using Quartz;
using Quartz.Spi;
using System;

namespace SecureBlockChain_Backend
{
    public class ScheduledJobFactory : IJobFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public ScheduledJobFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
        {
            // Create a scope to resolve scoped services
            var scope = _serviceProvider.CreateScope();

            // Get the job type from the bundle and resolve it from the scoped service provider
            return scope.ServiceProvider.GetRequiredService(bundle.JobDetail.JobType) as IJob;
        }

        public void ReturnJob(IJob job)
        {
            // Dispose the job if it is disposable
            if (job is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
    }
}
